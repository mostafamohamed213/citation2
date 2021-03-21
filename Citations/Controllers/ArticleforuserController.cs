using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Citations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Citations.Controllers
{
    public class ArticleforuserController : Controller
    {
        private readonly CitationContext _context;

        public ArticleforuserController(CitationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DownloadAttachment(long id)
        {
            try
            {
                Article attachment = _context.Articles.Where(r => r.Articleid == id).FirstOrDefault();
                if (attachment == null) return null;

                var path = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");

                byte[] fileBytes = System.IO.File.ReadAllBytes(Path.Combine(path, attachment.ScannedArticlePdf));
                return File(fileBytes, "application/force-download", Path.Combine(path, attachment.ScannedArticlePdf).Substring(Path.Combine(path, attachment.ScannedArticlePdf).LastIndexOf('\\') + 1));
            }
            catch (Exception)
            {
                return RedirectToAction("Details", new { id = id });
            }
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = _context.Articles.Include(p => p.ArticleReferenceArticles).ThenInclude(p => p.Articleref).Include(p => p.ArticleReferenceArticles).ThenInclude(p => p.Book).Include(p => p.ArticleReferenceArticles).ThenInclude(p => p.Conference).Include(p => p.ArticleAuthores).ThenInclude(p => p.Author).Include(p => p.ArticlesKeywords).Include(p => p.ArticleIssueNavigation).ThenInclude(p => p.MagazineIssue).ThenInclude(p => p.Magazine).ThenInclude(p=>p.Institution).Where(a => a.Articleid == id).Single();

            if (article == null)
            {
                return NotFound();
            }

            ViewData["Authors"] = new SelectList(_context.Authors, "Authorid", "Name");
            ViewData["institution"] = new SelectList(_context.Institutions, "Institutionid", "Name");
            ViewData["sources"] = new SelectList(_context.TypeOfSources, "TypeSourceid", "TypeName");
            ViewData["country"] = new SelectList(_context.Countries, "Countryid", "Name");
            ViewData["publisher"] = new SelectList(_context.Publishers, "Publisherid", "Name");
            ViewData["Article"] = new SelectList(_context.Articles, "Articleid", "Articletittle");
            ViewData["Book"] = new SelectList(_context.Books, "Bookid", "Booktittle");
            ViewData["Conference"] = new SelectList(_context.ConferenceProceedings, "Conferenceid", "Conferencetittle");
            IEnumerable<int> keywords = _context.ArticlesKeywords.Where(a => a.Articleid == id).Select(a => a.KeyWord.KeyWordid).ToList();

            article.KeyWords = keywords.ToArray();

            var Keywords = _context.KeyWords.Where(a => a.Active == true).Select(s => new
            {
                KeyWordid = s.KeyWordid,
                KeyWord = string.Format("{0} - {1}", s.KeyWord1, s.KeyWordEn)
            }).ToList();
            ViewData["key"] = new MultiSelectList(Keywords, "KeyWordid", "KeyWord");


            return View(article);
        }


    }
}
