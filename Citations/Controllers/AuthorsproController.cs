using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Citations.Models;

namespace Citations.Controllers
{
    public class AuthorsproController : Controller
    {
        private readonly CitationContext _context;

        public AuthorsproController(CitationContext context)
        {
            _context = context;
        }

        // GET: Authorspro
        public async Task<IActionResult> Index()
        {
            return View(await _context.Authors.ToListAsync());
        }


        // GET: Authorspro/Details/5

        public async Task<IActionResult> Details(int? id,int? pageNumber)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewBag.pageNumber = pageNumber;
            var author = _context.Authors.Include(p=>p.NationalityNavigation).Where(a => a.Authorid == id).Single();
            if (author == null)
            {
                return NotFound();
            }

            var Articleauthor = _context.ArticleAuthores.Where(m => m.Authorid == id).Select(s => s.Article);

            var artauth = (from a in _context.ArticleAuthores
                           join b in Articleauthor
                           on a.Articleid equals b.Articleid
                           select a);
            var coauth = (from a in _context.Authors
                          join b in artauth
                          on a.Authorid equals b.Authorid
                          where a.Authorid != id
                          select a
                           ).Distinct();


            ViewBag.co = coauth;


              var ci1 = (from arf in _context.ArticleReferences
                          join arauth in _context.ArticleAuthores
                          on arf.Articlerefid equals arauth.Articleid
                          join arref in _context.Articles
                          on arf.Articleid equals arref.Articleid
                          join isofisref in _context.IssueOfIssues
                           on arref.ArticleIssue equals isofisref.IssueOfIssueid
                          where arauth.Authorid == id
                          && isofisref.DateOfPublication.Year == DateTime.Now.Year - 5


                          select arf) .Count();

            var ci2 = (from arf in _context.ArticleReferences
                       join arauth in _context.ArticleAuthores
                       on arf.Articlerefid equals arauth.Articleid
                       join arref in _context.Articles
                       on arf.Articleid equals arref.Articleid
                       join isofisref in _context.IssueOfIssues
                        on arref.ArticleIssue equals isofisref.IssueOfIssueid
                       where arauth.Authorid == id
                       && isofisref.DateOfPublication.Year == DateTime.Now.Year - 4


                          select arf).Count();


            var ci3= (from arf in _context.ArticleReferences
                      join arauth in _context.ArticleAuthores
                      on arf.Articlerefid equals arauth.Articleid
                      join arref in _context.Articles
                      on arf.Articleid equals arref.Articleid
                      join isofisref in _context.IssueOfIssues
                       on arref.ArticleIssue equals isofisref.IssueOfIssueid
                      where arauth.Authorid == id
                      && isofisref.DateOfPublication.Year == DateTime.Now.Year - 3


                          select arf).Count();

            var ci4 = (from arf in _context.ArticleReferences
                       join arauth in _context.ArticleAuthores
                       on arf.Articlerefid equals arauth.Articleid
                       join arref in _context.Articles
                       on arf.Articleid equals arref.Articleid
                       join isofisref in _context.IssueOfIssues
                        on arref.ArticleIssue equals isofisref.IssueOfIssueid
                       where arauth.Authorid == id
                       && isofisref.DateOfPublication.Year == DateTime.Now.Year - 2


                          select arf).Count();

            var ci5 = (from arf in _context.ArticleReferences
                       join arauth in _context.ArticleAuthores
                       on arf.Articlerefid equals arauth.Articleid
                       join arref in _context.Articles
                       on arf.Articleid equals arref.Articleid
                       join isofisref in _context.IssueOfIssues
                        on arref.ArticleIssue equals isofisref.IssueOfIssueid
                       where arauth.Authorid == id
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


            var numberofciations = Articleauthor.Sum(a => a.NumberOfCitations);
            var numberofarticles = Articleauthor.Count();
            ViewBag.numberofciations= numberofciations;
            ViewBag.numberofarticles = numberofarticles;
            var thisauther = _context.Authors.Include(a => a.ArticleAuthores).ThenInclude(a => a.Article).FirstOrDefault(a => a.Authorid == id);
            var allarticalsmorethan0 = thisauther.ArticleAuthores.Where(a => a.Article.NumberOfCitations > 0).Select(a => a.Article);

            int pointerh = getpointerh(allarticalsmorethan0.ToList(), id);

            ViewBag.pointerH= pointerh;


            var authresfields = _context.AuthorResearchFields.Where(authfild => authfild.Authorid == id);

            List<int> fieldid = authresfields.Select(arf => arf.Fieldid).ToList<int>();

            var autherposinst = _context.AuthorsPositionInstitutions.Where(authfild => authfild.Authorid == id);
            List<int> positions = autherposinst.Select(arf => arf.PositionJobid).ToList<int>();
            ViewData["Institutions"] = _context.Institutions;
            ViewData["Institutionid"] = new SelectList(_context.Institutions, "Institutionid", "Name", positions);
            ViewData["PositionJobid"] = new SelectList(_context.PositionJobs, "PositionJobid", "PositionJob1");
            ViewData["autherposithininstitute"] = _context.AuthorsPositionInstitutions.Where(m => m.Authorid == id)
                .Include(api => api.FacultyInstitutionDepartment)
                .ThenInclude(fid => fid.FacultyInstitution.Institution)
                .Include(fi => fi.FacultyInstitutionDepartment.Department)
                .Include(fi => fi.FacultyInstitutionDepartment.FacultyInstitution.Faculty)

                .Include(a => a.PositionJob).Include(a => a.Author)
                .ThenInclude(a => a.AuthorResearchFields)
                .ThenInclude(arf => arf.Field)
              ; ;

            //ViewData["Fieldid"] = new SelectList(_context.ResearchFields, "Fieldid", "Name");

            ViewData["Fieldid"] = new MultiSelectList(_context.ResearchFields, "Fieldid", "Name", fieldid);
            return View(author);
        }
        //public async Task<IActionResult> Details2(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var Articleauthor =  _context.ArticleAuthores.Where(m => m.Authorid == id).Select(s => s.Article);

        //    var artauth = (from a in _context.ArticleAuthores
        //                    join b in Articleauthor
        //                    on a.Articleid equals b.Articleid
        //                    select a);
        //    var coauth = (from a in _context.Authors
        //                   join b in artauth
        //                   on a.Authorid equals b.Authorid
        //                   where a.Authorid != id 
        //                  select a
        //                   ).Distinct();
           

        //    ViewBag.co = coauth;
        //    var author = await _context.Authors.Include(p=>p.ArticleAuthores).ThenInclude(p=>p.Author).Include(p=>p.ArticleAuthores).ThenInclude(p=>p.Article)
        //        .FirstOrDefaultAsync(m => m.Authorid == id);
        //    if (author == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(author);
        //}

        // GET: Authorspro/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Authorspro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Authorid,Name,ScannedAuthorimage,AuthorBio,PointerH,Active")] Author author)
        {
            if (ModelState.IsValid)
            {
                _context.Add(author);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(author);
        }

        // GET: Authorspro/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var author = await _context.Authors.FindAsync(id);
        //    if (author == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(author);
        //}

        // POST: Authorspro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Authorid,Name,ScannedAuthorimage,AuthorBio,PointerH,Active")] Author author)
        {
            if (id != author.Authorid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(author);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AuthorExists(author.Authorid))
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
            return View(author);
        }

        // GET: Authorspro/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var author = await _context.Authors
                .FirstOrDefaultAsync(m => m.Authorid == id);
            if (author == null)
            {
                return NotFound();
            }

            return View(author);
        }

        // POST: Authorspro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var author = await _context.Authors.FindAsync(id);
            _context.Authors.Remove(author);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        static public int getpointerh(List<Article> articles, int? id)
        {


            //  var thisauther = _context.Authors.Find(id);
            var allarticalsmorethan0 = articles;

            // int? pointerh = allarticalsmorethan0.Max(aa=>aa.NumberOfCitations);
            int pointerh = 0;
            int count = allarticalsmorethan0.Count();


            var temp = allarticalsmorethan0.Where(all => all.NumberOfCitations >= count);
            if (allarticalsmorethan0.All(all => all.NumberOfCitations >= count))
            {

                pointerh = allarticalsmorethan0.Count();
                return pointerh;
            }
            else
            {
                var newarticals = allarticalsmorethan0.Except(allarticalsmorethan0.Where(a => a.NumberOfCitations == allarticalsmorethan0.Min(aa => aa.NumberOfCitations)).Take(1));
                return getpointerh(newarticals.ToList(), id);
            }
            //foreach (var item in allarticalsmorethan0)
            //{
            //    if (item.NumberOfCitations >= pointerh)
            //    {

            //    }

            //}




        }
        private bool AuthorExists(int id)
        {
            return _context.Authors.Any(e => e.Authorid == id);
        }
    }
}
