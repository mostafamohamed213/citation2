using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Citations.Models;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace Citations.Controllers
{
    public class ArticlesController : Controller
    {
        private readonly CitationContext _context;
        public static List<articleauthors1> asd;
        public ArticlesController(CitationContext context)
        {
            _context = context;
        }

        // GET: Articles
        public async Task<IActionResult> Index()
        {
            var citationContext = _context.Articles.Include(a => a.ArticleIssueNavigation);
            return View(await citationContext.ToListAsync());
        }

        public IActionResult checkname(String Articletittle, int? Articleid)
        {
            if (Articleid == null)
            {
                var Articletittle1 = Articletittle.Trim();
                if (_context.Articles.FirstOrDefault(i => i.Articletittle == Articletittle1) == null)
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }
            }
            else
            {
                var Articletittle1 = Articletittle.Trim();
                if (_context.Articles.FirstOrDefault(i => i.Articleid != Articleid && i.Articletittle == Articletittle1) == null)
                {
                    return Json(true);
                }
                else
                {
                    return Json(false);
                }

            }
        }

        // GET: Articles/Details/5
        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = _context.Articles.Include(p => p.ArticleAuthores).ThenInclude(p=>p.Author).Include(p => p.ArticlesKeywords).Include(p => p.ArticleIssueNavigation).ThenInclude(p => p.MagazineIssue).ThenInclude(p => p.Magazine).Where(a => a.Articleid == id).Single();

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

        // GET: Articles/Create
        public IActionResult Create()
        {
            ViewData["ArticleIssue"] = new SelectList(_context.IssueOfIssues, "IssueOfIssueid", "IssuenumberOfIssue");
            ViewData["Authors"] = new SelectList(_context.Authors, "Authorid", "Name");
            ViewData["institution"] = new SelectList(_context.Institutions, "Institutionid", "Name");
            var Keywords = _context.KeyWords.Where(a => a.Active == true).Select(s => new
            {
                KeyWordid = s.KeyWordid,
                KeyWord = string.Format("{0} - {1}", s.KeyWord1, s.KeyWordEn)
            }).ToList();
            ViewData["key"] = new MultiSelectList(Keywords, "KeyWordid", "KeyWord");

            

            return View();
        }

        [HttpPost]
        public IActionResult save([FromBody] articleauthors data)
        {

            asd = data.articleauthors1;

            return Json(new
            {
                success = true
            });
        }

        [HttpPost]
        public IActionResult SaveArticle(string keyw,[Bind("Articleid,Articletittle,ArticletittleEn,ScannedArticlePdf,BriefQuote,BriefQuoteEn,NumberOfCitations,NumberOfReferences,ArticleIssue,Active")] Article article, IFormFile afiles)
        {
            if (ModelState.IsValid)
            {
                if (afiles != null)
                {
                    try
                    {
                        var date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                        date = date.Replace("/", "-").Replace(":", "-");

                        var fileName = date + Path.GetFileName(afiles.FileName);
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");
                        string filepath = Path.Combine(path, fileName);
                        //  file.CopyTo(new FileStream(filepath, FileMode.Create));


                        //string path = ""; // From appsettings.json
                        //string filePath = path + $"\\Attachment {i}-" + attachment.FileName;
                        System.IO.StreamWriter files = new System.IO.StreamWriter(filepath);
                        afiles.OpenReadStream().CopyTo(files.BaseStream);
                        files.Flush();
                        files.Close();

                        article.ScannedArticlePdf = fileName;
                    }
                    catch(Exception ex)
                    {
                        throw ex;
                    }
                }
                _context.Add(article);
                _context.SaveChanges();

                if (keyw != null)
                {
                    string[] str_arr = keyw.Split(',').ToArray();
                    int[] int_arr = Array.ConvertAll(str_arr, Int32.Parse);

                    article.ArticlesKeywords = new List<ArticlesKeyword>();
                    foreach (var risk in int_arr)
                    {
                        var risktoadd = _context.KeyWords.Find(risk);
                        _context.ArticlesKeywords.Add(new ArticlesKeyword { KeyWordid = risktoadd.KeyWordid, Articleid = article.Articleid });
                        _context.SaveChanges();
                    }
                }



                foreach (var item in asd)
                {
                    ArticleAuthore articleAuthore = new ArticleAuthore();
                    articleAuthore.Articleid = article.Articleid;
                    articleAuthore.Authorid = item.author;
                    articleAuthore.MainAuthor = item.main;
                    _context.Add(articleAuthore);
                    _context.SaveChanges();
                }
                return Json(new
                {
                    success = true
                });


            }
            else
            {
                return Json(new
                {
                    success = false
                });
            }

        }


        public JsonResult getmagazine(int Institutionid)
        {
            List<Magazine> data = new List<Magazine>();

            data = _context.Magazines.Where(a => a.Institutionid.Equals(Institutionid)).OrderBy(a => a.Name).ToList();

            return Json(data);
        }

        public JsonResult getissue(int Magazineid)
        {
            List<MagazineIssue> data = new List<MagazineIssue>();

            data = _context.MagazineIssues.Where(a => a.Magazineid.Equals(Magazineid)).OrderBy(a => a.Issuenumber).ToList();

            return Json(data);
        }

        public JsonResult getissueversion(int magazineissueid)
        {
            List<IssueOfIssue> data = new List<IssueOfIssue>();

            data = _context.IssueOfIssues.Where(a => a.MagazineIssueId.Equals(magazineissueid)).OrderBy(a => a.IssuenumberOfIssue).ToList();

            return Json(data);
        }


       
      public IActionResult SaveResourceNewArticle(int articleid,[Bind("Articletittle,ArticletittleEn,ScannedArticlePdf,BriefQuote,BriefQuoteEn,NumberOfCitations,NumberOfReferences,ArticleIssue,Active")] Article article,string page)
        {
          
           
            if (TryValidateModel(article))
            {
                article.NumberOfCitations = 1;
                _context.Add(article);
                _context.SaveChanges();

                foreach (var item in asd)
                {
                    ArticleAuthore articleAuthore = new ArticleAuthore();
                    articleAuthore.Articleid = article.Articleid;
                    articleAuthore.Authorid = item.author;
                    articleAuthore.MainAuthor = item.main;
                    _context.Add(articleAuthore);
                    _context.SaveChanges();
                }

                ArticleReference articleReference = new ArticleReference();
                articleReference.Articleid = articleid;
                articleReference.Articlerefid = article.Articleid;
                articleReference.Page = page;
                articleReference.TypeSourceid = 1;

                _context.Add(articleReference);
                _context.SaveChanges();

                Article article1 = _context.Articles.Find(articleid);
                article1.NumberOfReferences = ++article1.NumberOfReferences;
                _context.Update(article1);
                _context.SaveChanges();

                return Json(new
                {
                    success = true
                });
            }
            else
            {
                return Json(new
                {
                    success = false,
                    responseText = "there is an invalid input!.",
                    type = "error"

                });

            }


        }

        public IActionResult SaveResourceExistArticle(int articleid,int articlerefid,string page)
        {
            ArticleReference articleReference = new ArticleReference();
            articleReference.Articleid = articleid;
            articleReference.Articlerefid = articlerefid;
            articleReference.Page = page;
            articleReference.TypeSourceid = 1;

            _context.Add(articleReference);
            _context.SaveChanges();

            Article article1 = _context.Articles.Find(articleid);
            article1.NumberOfReferences = ++article1.NumberOfReferences;
            _context.Update(article1);
            _context.SaveChanges();

            Article articleref = _context.Articles.Find(articlerefid);
            articleref.NumberOfCitations = ++articleref.NumberOfCitations;
            _context.Update(articleref);
            _context.SaveChanges();

            return Json(new
            {
                success = true
            });



        }


        public IActionResult SaveResourceNewBook(int articleid, [Bind("Bookid,Booktittle,Year,Country,Publisherid,Active")] Book book, string page)
        {


            if (TryValidateModel(book))
            {
                _context.Add(book);
                _context.SaveChanges();


                foreach (var item in asd)
                {
                    BookAuthore bookAuthore = new BookAuthore();
                    bookAuthore.Bookid = book.Bookid;
                    bookAuthore.Authorid = item.author;
                    bookAuthore.MainAuthor= item.main;
                    _context.Add(bookAuthore);
                    _context.SaveChanges();
                }


                ArticleReference articleReference = new ArticleReference();
                articleReference.Articleid = articleid;
                articleReference.Bookid=book.Bookid;
                articleReference.Page = page;
                articleReference.TypeSourceid = 2;

                _context.Add(articleReference);
                _context.SaveChanges();

                Article article1 = _context.Articles.Find(articleid);
                article1.NumberOfReferences = ++article1.NumberOfReferences;
                _context.Update(article1);
                _context.SaveChanges();

                return Json(new
                {
                    success = true
                });
            }
            else
            {
                return Json(new
                {
                    success = false,
                    responseText = "there is an invalid input!.",
                    type = "error"

                });

            }


        }

        public IActionResult SaveResourceExistBook(int articleid, int bookrefid, string page)
        {
            ArticleReference articleReference = new ArticleReference();
            articleReference.Articleid = articleid;
            articleReference.Bookid = bookrefid;
            articleReference.Page = page;
            articleReference.TypeSourceid = 2;

            _context.Add(articleReference);
            _context.SaveChanges();

            Article article1 = _context.Articles.Find(articleid);
            article1.NumberOfReferences = ++article1.NumberOfReferences;
            _context.Update(article1);
            _context.SaveChanges();

            return Json(new
            {
                success = true
            });



        }

        public IActionResult SaveResourceNewConference(int articleid, [Bind("Conferenceid,Conferencetittle,Year,ConferencePublicationName,Country,Publisherid,Active")] ConferenceProceeding conferenceProceeding, string page)
        {


            if (TryValidateModel(conferenceProceeding))
            {
                _context.Add(conferenceProceeding);
                _context.SaveChanges();


                foreach (var item in asd)
                {
                    ConferenceProceedingsAuthor conferenceProceedingsAuthor = new ConferenceProceedingsAuthor();
                    conferenceProceedingsAuthor.Conferenceid = conferenceProceeding.Conferenceid;
                    conferenceProceedingsAuthor.Authorid= item.author;
                    conferenceProceedingsAuthor.MainAuthor= item.main;
                
                    _context.Add(conferenceProceedingsAuthor);
                    _context.SaveChanges();
                }


                ArticleReference articleReference = new ArticleReference();
                articleReference.Articleid = articleid;
                articleReference.Conferenceid = conferenceProceeding.Conferenceid;
                articleReference.Page = page;
                articleReference.TypeSourceid = 3;

                _context.Add(articleReference);
                _context.SaveChanges();

                Article article1 = _context.Articles.Find(articleid);
                article1.NumberOfReferences = ++article1.NumberOfReferences;
                _context.Update(article1);
                _context.SaveChanges();

                return Json(new
                {
                    success = true
                });
            }
            else
            {
                return Json(new
                {
                    success = false,
                    responseText = "there is an invalid input!.",
                    type = "error"

                });

            }


        }

        public IActionResult SaveResourceExistConference(int articleid, int conferencerefid, string page)
        {
            ArticleReference articleReference = new ArticleReference();
            articleReference.Articleid = articleid;
            articleReference.Conferenceid= conferencerefid;
            articleReference.Page = page;
            articleReference.TypeSourceid = 3;

            _context.Add(articleReference);
            _context.SaveChanges();

            Article article1 = _context.Articles.Find(articleid);
            article1.NumberOfReferences = ++article1.NumberOfReferences;
            _context.Update(article1);
            _context.SaveChanges();

            return Json(new
            {
                success = true
            });



        }
        // POST: Articles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Articleid,Articletittle,ArticletittleEn,ScannedArticlePdf,BriefQuote,BriefQuoteEn,NumberOfCitations,NumberOfReferences,ArticleIssue,Active")] Article article)
        {
            if (ModelState.IsValid)
            {
                _context.Add(article);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArticleIssue"] = new SelectList(_context.IssueOfIssues, "IssueOfIssueid", "IssuenumberOfIssue", article.ArticleIssue);
            return View(article);
        }

        // GET: Articles/Edit/5
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article =  _context.Articles.Include(p => p.ArticleAuthores).Include(p => p.ArticlesKeywords).Include(p => p.ArticleIssueNavigation).ThenInclude(p => p.MagazineIssue).ThenInclude(p => p.Magazine).Where(a => a.Articleid == id).Single();
            
            if (article == null)
            {
                return NotFound();
            }

            ViewData["Authors"] = new SelectList(_context.Authors, "Authorid", "Name");
            ViewData["institution"] = new SelectList(_context.Institutions, "Institutionid", "Name");
            IEnumerable<int> keywords =  _context.ArticlesKeywords.Where(a => a.Articleid == id).Select(a => a.KeyWord.KeyWordid).ToList();
       
            article.KeyWords = keywords.ToArray();

               var Keywords = _context.KeyWords.Where(a => a.Active == true).Select(s => new
            {
                KeyWordid = s.KeyWordid,
                KeyWord = string.Format("{0} - {1}", s.KeyWord1, s.KeyWordEn)
            }).ToList();
            ViewData["key"] = new MultiSelectList(Keywords, "KeyWordid", "KeyWord");

            return View(article);
        }

        // POST: Articles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
     
        public async Task<IActionResult> Edit(int id, string keyw, [Bind("Articleid,Articletittle,ArticletittleEn,ScannedArticlePdf,BriefQuote,BriefQuoteEn,NumberOfCitations,NumberOfReferences,ArticleIssue,Active")] Article article, IFormFile afiles)
        {
            if (id != article.Articleid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    if (afiles != null)
                    {
                        try
                        {
                            var date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                            date = date.Replace("/", "-").Replace(":", "-");

                            var fileName = date + Path.GetFileName(afiles.FileName);
                            var path = Path.Combine(Directory.GetCurrentDirectory(), "UploadedFiles");
                            string filepath = Path.Combine(path, fileName);
                            //  file.CopyTo(new FileStream(filepath, FileMode.Create));


                            //string path = ""; // From appsettings.json
                            //string filePath = path + $"\\Attachment {i}-" + attachment.FileName;
                            System.IO.StreamWriter files = new System.IO.StreamWriter(filepath);
                            afiles.OpenReadStream().CopyTo(files.BaseStream);
                            files.Flush();
                            files.Close();
                            if (article.ScannedArticlePdf != null)
                            {
                                System.IO.File.Delete(Path.Combine(path, article.ScannedArticlePdf));
                            }
                            article.ScannedArticlePdf = fileName;
                        }
                        catch (Exception ex)
                        {
                            throw ex;
                        }
                    }
                    _context.Update(article);
                    await _context.SaveChangesAsync();

                    var articlekeywords = _context.ArticlesKeywords.Where(a => a.Articleid == article.Articleid);
                    _context.ArticlesKeywords.RemoveRange(articlekeywords);
                    _context.SaveChanges();
                    if (keyw != null)
                    {
                        string[] str_arr = keyw.Split(',').ToArray();
                        int[] int_arr = Array.ConvertAll(str_arr, Int32.Parse);

                        article.ArticlesKeywords = new List<ArticlesKeyword>();
                        foreach (var risk in int_arr)
                        {
                            var risktoadd = _context.KeyWords.Find(risk);
                            _context.ArticlesKeywords.Add(new ArticlesKeyword { KeyWordid = risktoadd.KeyWordid, Articleid = article.Articleid });
                            _context.SaveChanges();
                        }
                    }

                    var articleauthor = _context.ArticleAuthores.Where(a => a.Articleid == article.Articleid);
                    _context.ArticleAuthores.RemoveRange(articleauthor);
                    _context.SaveChanges();
                    foreach (var item in asd)
                    {
                        ArticleAuthore articleAuthore = new ArticleAuthore();
                        articleAuthore.Articleid = article.Articleid;
                        articleAuthore.Authorid = item.author;
                        articleAuthore.MainAuthor = item.main;
                        _context.Add(articleAuthore);
                        _context.SaveChanges();
                    }

                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ArticleExists(article.Articleid))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ArticleIssue"] = new SelectList(_context.IssueOfIssues, "IssueOfIssueid", "IssuenumberOfIssue", article.ArticleIssue);
            return View(article);
        }

        // GET: Articles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var article = await _context.Articles
                .Include(a => a.ArticleIssueNavigation)
                .FirstOrDefaultAsync(m => m.Articleid == id);
            if (article == null)
            {
                return NotFound();
            }

            return View(article);
        }

        // POST: Articles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var article = await _context.Articles.FindAsync(id);
            _context.Articles.Remove(article);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ArticleExists(int id)
        {
            return _context.Articles.Any(e => e.Articleid == id);
        }
    }
}
