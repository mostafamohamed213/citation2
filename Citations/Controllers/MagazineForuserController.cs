using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Citations.Controllers
{
    public class MagazineForuserController : Controller
    {
        private readonly CitationContext _context;

        public MagazineForuserController(CitationContext context)
        {
            _context = context;
        }

        //public IActionResult Index(int? pageNumber)
        //{
        //    return ViewComponent("article", new {pageNumber=pageNumber ?? 1 });
        //}
        public async Task<IActionResult> Details(int? id, int? pageNumber)
        {
            if (id == null)
            {
                return NotFound();
            }

            ViewBag.pageNumber = pageNumber;

            //var articles = from a in _context.Articles
            //               join isofis in _context.IssueOfIssues
            //               on a.ArticleIssue equals isofis.IssueOfIssueid
            //               join mis in _context.MagazineIssues
            //               on isofis.MagazineIssueId equals mis.Issueid
            //               join m in _context.Magazines
            //               on mis.Magazineid equals m.Magazineid
            //               join ins in _context.Institutions
            //               on m.Institutionid equals ins.Institutionid
            //               where ins.Institutionid == id
            //               select a;

      

            var ci1 = (from arf in _context.ArticleReferences
                          join arcit in _context.Articles
                          on arf.Articlerefid equals arcit.Articleid
                          join arref in _context.Articles
                          on arf.Articleid equals arref.Articleid
                          join isofis in _context.IssueOfIssues
                          on arcit.ArticleIssue equals isofis.IssueOfIssueid
                          join isofisref in _context.IssueOfIssues
                           on arref.ArticleIssue equals isofisref.IssueOfIssueid
                          join mis in _context.MagazineIssues
                          on isofis.MagazineIssueId equals mis.Issueid
                          join m in _context.Magazines
                          on mis.Magazineid equals m.Magazineid
                          where m.Magazineid == id
                          && isofisref.DateOfPublication.Year == DateTime.Now.Year - 5


                          select arf) .Count();

            var ci2 = (from arf in _context.ArticleReferences
                          join arcit in _context.Articles
                          on arf.Articlerefid equals arcit.Articleid
                          join arref in _context.Articles
                          on arf.Articleid equals arref.Articleid
                          join isofis in _context.IssueOfIssues
                          on arcit.ArticleIssue equals isofis.IssueOfIssueid
                          join isofisref in _context.IssueOfIssues
                           on arref.ArticleIssue equals isofisref.IssueOfIssueid
                          join mis in _context.MagazineIssues
                          on isofis.MagazineIssueId equals mis.Issueid
                          join m in _context.Magazines
                          on mis.Magazineid equals m.Magazineid
                          where m.Magazineid == id
                          && isofisref.DateOfPublication.Year == DateTime.Now.Year - 4


                          select arf).Count();


            var ci3= (from arf in _context.ArticleReferences
                          join arcit in _context.Articles
                          on arf.Articlerefid equals arcit.Articleid
                          join arref in _context.Articles
                          on arf.Articleid equals arref.Articleid
                          join isofis in _context.IssueOfIssues
                          on arcit.ArticleIssue equals isofis.IssueOfIssueid
                          join isofisref in _context.IssueOfIssues
                           on arref.ArticleIssue equals isofisref.IssueOfIssueid
                          join mis in _context.MagazineIssues
                          on isofis.MagazineIssueId equals mis.Issueid
                          join m in _context.Magazines
                          on mis.Magazineid equals m.Magazineid
                          where m.Magazineid == id
                          && isofisref.DateOfPublication.Year == DateTime.Now.Year - 3


                          select arf).Count();

            var ci4 = (from arf in _context.ArticleReferences
                          join arcit in _context.Articles
                          on arf.Articlerefid equals arcit.Articleid
                          join arref in _context.Articles
                          on arf.Articleid equals arref.Articleid
                          join isofis in _context.IssueOfIssues
                          on arcit.ArticleIssue equals isofis.IssueOfIssueid
                          join isofisref in _context.IssueOfIssues
                           on arref.ArticleIssue equals isofisref.IssueOfIssueid
                          join mis in _context.MagazineIssues
                          on isofis.MagazineIssueId equals mis.Issueid
                          join m in _context.Magazines
                          on mis.Magazineid equals m.Magazineid
                          where m.Magazineid == id
                          && isofisref.DateOfPublication.Year == DateTime.Now.Year - 2


                          select arf).Count();

            var ci5 = (from arf in _context.ArticleReferences
                          join arcit in _context.Articles
                          on arf.Articlerefid equals arcit.Articleid
                          join arref in _context.Articles
                          on arf.Articleid equals arref.Articleid
                          join isofis in _context.IssueOfIssues
                          on arcit.ArticleIssue equals isofis.IssueOfIssueid
                          join isofisref in _context.IssueOfIssues
                           on arref.ArticleIssue equals isofisref.IssueOfIssueid
                          join mis in _context.MagazineIssues
                          on isofis.MagazineIssueId equals mis.Issueid
                          join m in _context.Magazines
                          on mis.Magazineid equals m.Magazineid
                          where m.Magazineid == id
                          && isofisref.DateOfPublication.Year == DateTime.Now.Year - 1


                          select arf).Count();

            ViewBag.ci1 = ci1;
            ViewBag.ciname1 = DateTime.Now.Year - 5;
            ViewBag.ci2 = ci2;
            ViewBag.ciname2 = DateTime.Now.Year - 4;
            ViewBag.ci3 = ci3;
            ViewBag.ciname3 = DateTime.Now.Year - 3;
            ViewBag.ci4 = ci4;
            ViewBag.ciname4 = DateTime.Now.Year - 2;
            ViewBag.ci5 = ci5;
            ViewBag.ciname5= DateTime.Now.Year - 1;


            ///

            // second condation must be just <  mn 3'er ysaoy + mngbsh t7t elarba3a 
            //lazem elle best5dmo ka reference ybka gwa el arb3 sneen w de feh moshkela


            //var issoissue = _context.IssueOfIssues.Where(value => value.MagazineIssue.Magazine.Magazineid == id && value.DateOfPublication.Year >= DateTime.Now.Year - 4 && value.DateOfPublication.Year <= DateTime.Now.Year).Include(a => a.Articles);

            //var allarticals = issoissue.Select(a => a.Articles.Select(s => s.Articleid));
            //List<int> allids = new List<int>();
            //foreach (var item in allarticals)
            //{
            //    allids.AddRange(item);
            //}

            ////var xarticals = articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => institutionids.Contains(value.MagazineIssue.Magazine.Institution.Institutionid)));

            //IQueryable<ArticleReference> artref = _context.ArticleReferences;

            //artref = artref.Where(a => a.Articleref.ArticleIssueNavigation.DateOfPublication.Year >= DateTime.Now.Year - 4 
            //&& a.Articleref.ArticleIssueNavigation.DateOfPublication.Year < DateTime.Now.Year 
            //&& a.Article.ArticleIssueNavigation.DateOfPublication.Year >= DateTime.Now.Year - 4
            //&& a.Article.ArticleIssueNavigation.DateOfPublication.Year < DateTime.Now.Year);
            //double numberof_ref_for_articals = artref.Where(a => allids.Contains(a.Articleref.Articleid)).Count();
            //double numberof_articls = artref.Where(a => allids.Contains(a.Articleref.Articleid)).Select(a => a.Article).Distinct().Count();

            //double sum = issoissue.Sum(a => a.Articles.Count());


            //var impactfactor = numberof_ref_for_articals / sum;

            //ViewBag.معامل_التأثير = impactfactor;

            var impactfactor = MagazineImpactFactor(DateTime.Now.Year, id);


            double impactfactorsum = 0;
            for (int year = DateTime.Now.Year - 4; year <= DateTime.Now.Year; year++)
            {
                impactfactorsum += MagazineImpactFactor(year, id);
            }
            double impactfactorrange = impactfactorsum / 5;
            


            string arabicimpactfactor;
            if (double.IsNaN(impactfactor))
            {
                arabicimpactfactor = "0";
            }
            else
            {
                arabicimpactfactor = String.Format("{0:0.00}", impactfactor);
            }


            string arabicirangempactfactor;
            if (double.IsNaN(impactfactorrange))
            {
                arabicirangempactfactor = "0";
            }
            else
            {
                arabicirangempactfactor = String.Format("{0:0.00}", impactfactorrange);
            }

            ViewBag.impactfactorrange = arabicirangempactfactor;


            ViewBag.ImpactFactor = arabicimpactfactor;

            var magazine = await _context.Magazines
                .Include(m => m.Institution)
                .Include(m => m.Publisher)
                .ThenInclude(m => m.Institution)
                .FirstOrDefaultAsync(m => m.Magazineid == id);

            IEnumerable<int> Fields = await _context.MagazineResearchFields.Where(a => a.Magazineid == id).Select(a => a.Field.Fieldid).ToListAsync();
            //ViewBag.ResearchFields = Fields;
            //magazine.ResearchFields = Fields.ToArray();
            //var rFields = _context.ResearchFields.Where(a => a.Active == true).Select(s => new
            //{
            //    Fieldid = s.Fieldid,
            //    Name = string.Format("{0} - {1}", s.Name, s.NameEn)
            //}).ToList();
            //ViewBag.Fieldid = new MultiSelectList(rFields, "Fieldid", "Name");

            //var publisher = _context.Publishers.Include(a => a.Institution).Where(a => a.Active == true && a.Institutionid != null).Select(s => new
            //{
            //    Publisherid = s.Publisherid,
            //    Name = s.Institution.Name
            //}).ToList();
            //publisher.AddRange(_context.Publishers.Include(a => a.Institution).Where(a => a.Active == true && a.Institutionid == null).Select(s => new
            //{
            //    Publisherid = s.Publisherid,
            //    Name = s.Name
            //}).ToList());
            //ViewData["Publisherid"] = new SelectList(publisher, "Publisherid", "Name");

            if (magazine == null)
            {
                return NotFound();
            }

            return View(magazine);
        }

        double MagazineImpactFactor(int year, int? id)
        {



            var issoissue = _context.IssueOfIssues.Where(value => value.MagazineIssue.Magazine.Magazineid == id && value.DateOfPublication.Year >= DateTime.Now.Year - 4 && value.DateOfPublication.Year <= DateTime.Now.Year).Include(a => a.Articles);

            var allarticals = issoissue.Select(a => a.Articles.Select(s => s.Articleid));
            List<int> allids = new List<int>();
            foreach (var item in allarticals)
            {
                allids.AddRange(item);
            }

            //var xarticals = articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => institutionids.Contains(value.MagazineIssue.Magazine.Institution.Institutionid)));



            IQueryable<ArticleReference> artref = _context.ArticleReferences;
            artref = artref.Where(a => a.Articleref.ArticleIssueNavigation.DateOfPublication.Year >= year - 4
            && a.Articleref.ArticleIssueNavigation.DateOfPublication.Year <= year
            && a.Article.ArticleIssueNavigation.DateOfPublication.Year >= year - 4
            && a.Article.ArticleIssueNavigation.DateOfPublication.Year < year);

            double numberof_ref_for_articals = artref.Where(a => allids.Contains(a.Articleref.Articleid)).Count();
            double numberof_articls = artref.Where(a => allids.Contains(a.Articleref.Articleid)).Select(a => a.Article).Distinct().Count();



            double sum = issoissue.Sum(a => a.Articles.Count());


            var impactfactor = numberof_ref_for_articals / sum;

            return impactfactor;
        }

    }
}
