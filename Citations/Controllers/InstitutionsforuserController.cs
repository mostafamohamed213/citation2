using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citations.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Citations.Controllers
{
    public class InstitutionsforuserController : Controller
    {
        private readonly CitationContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public InstitutionsforuserController(CitationContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }


        public async Task<IActionResult> Index(
          string sortOrder,
          string currentFilter,
          string searchString,
          int? pageNumber)
        {
            ViewData["CurrentSort"] = sortOrder;
            //  ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            //ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var students = from s in _context.Institutions
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                students = students.Where(s => s.Name.Contains(searchString));
            }
            //switch (sortOrder)
            //{
            //    //3kstha 
            //    case "name_desc":
            //        students = students.OrderBy(s => s.NumberOfCitations);
            //        break;
            //    //case "Date":
            //    //    students = students.OrderBy(s => s.EnrollmentDate);
            //    //    break;
            //    //case "date_desc":
            //    //    students = students.OrderByDescending(s => s.EnrollmentDate);
            //    //    break;
            //    default:
            //        students = students.OrderByDescending(s => s.NumberOfCitations);
            //        break;
            //}

            int pageSize = 5;
            return View(await PaginatedList<Institution>.CreateAsync(students.Where(a => a.Active == true).AsNoTracking().Include(i => i.CountryNavigation).Include(i => i.TypeOfInstitutionNavigation), pageNumber ?? 1, pageSize));
        }

        public async Task<IActionResult> Details(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            var issoissue = _context.IssueOfIssues.Where(value => value.MagazineIssue.Magazine.Institution.Institutionid == id && value.DateOfPublication.Year >= DateTime.Now.Year - 4 && value.DateOfPublication.Year <= DateTime.Now.Year).Include(a => a.Articles);

            var allarticals = issoissue.Select(a => a.Articles.Select(s => s.Articleid));
            List<int> allids = new List<int>();
            foreach (var item in allarticals)
            {
                allids.AddRange(item);
            }

            //var xarticals = articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => institutionids.Contains(value.MagazineIssue.Magazine.Institution.Institutionid)));

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
            var ImpactFactor = InstitutionImpactFactor(DateTime.Now.Year, id);


            double impactfactorsum = 0;
            for (int year = DateTime.Now.Year - 4; year <= DateTime.Now.Year; year++)
            {
                impactfactorsum += InstitutionImpactFactor(year, id);
            }
            double impactfactorrange = impactfactorsum / 5;
           

            string arabicimpactfactor;
            if (double.IsNaN(ImpactFactor))
            {
                arabicimpactfactor = "0";
            }
            else
            {
                arabicimpactfactor = String.Format("{0:0.00}", ImpactFactor);
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
                       join ins in _context.Institutions
                       on m.Institutionid equals ins.Institutionid
                       where ins.Institutionid == id
                       && isofisref.DateOfPublication.Year == DateTime.Now.Year - 5


                       select arf).Count();

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
                       join ins in _context.Institutions
                       on m.Institutionid equals ins.Institutionid
                       where ins.Institutionid == id
                       && isofisref.DateOfPublication.Year == DateTime.Now.Year - 4


                       select arf).Count();


            var ci3 = (from arf in _context.ArticleReferences
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
                       join ins in _context.Institutions
                      on m.Institutionid equals ins.Institutionid
                       where ins.Institutionid == id
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
                       join ins in _context.Institutions
                       on m.Institutionid equals ins.Institutionid
                       where ins.Institutionid == id
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
                       join ins in _context.Institutions
                      on m.Institutionid equals ins.Institutionid
                       where ins.Institutionid == id
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
            ViewBag.ciname5 = DateTime.Now.Year - 1;


            var articals = _context.Articles.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => value.MagazineIssue.Magazine.Institution.Institutionid == id));



            int pointerh = getpointerh(articals.ToList(), id);




            ViewBag.PointerH = pointerh;


            var numberofcitations = (from a in _context.Articles
                            join isofis in _context.IssueOfIssues
                            on a.ArticleIssue equals isofis.IssueOfIssueid
                            join mis in _context.MagazineIssues
                            on isofis.MagazineIssueId equals mis.Issueid
                            join m in _context.Magazines
                            on mis.Magazineid equals m.Magazineid
                            join ins in _context.Institutions
                            on m.Institutionid equals ins.Institutionid
                            where ins.Institutionid == id
                            select a.NumberOfCitations).Sum();

            ViewBag.numberofcitations = numberofcitations;

            var institution = await _context.Institutions
                .Include(i => i.CountryNavigation)
                .Include(i => i.TypeOfInstitutionNavigation)
                .Include(i=>i.Magazines)
                .FirstOrDefaultAsync(m => m.Institutionid == id);

            var x = (from author in _context.Authors
                     join ap in _context.AuthorsPositionInstitutions
                     on author.Authorid equals ap.Authorid
                     join ins in _context.FacultyInstitutionDepartments
                     on ap.FacultyInstitutionDepartmentid equals ins.FacultyInstitutionDepartmentid
                     join fs in _context.FacultyInstitutions
                     on ins.FacultyInstitutionid equals fs.FacultyInstitutionid
                     join inst in _context.Institutions
                     on fs.Institutionid equals inst.Institutionid
                     where inst.Institutionid == id
                     select author).Distinct().Count();
            //var x = (from ap in _context.AuthorsPositionInstitutions
            //         join ins in _context.FacultyInstitutionDepartments
            //         on ap.FacultyInstitutionDepartmentid equals ins.FacultyInstitutionDepartmentid
            //         join fs in _context.FacultyInstitutions
            //         on ins.FacultyInstitutionid equals fs.Institutionid
            //         where fs.Institutionid == id
            //         select ap).Count();
            ViewBag.numberofauthor = x;

            var articles = (from a in _context.Articles
                           join isofis in _context.IssueOfIssues
                           on a.ArticleIssue equals isofis.IssueOfIssueid
                           join mis in _context.MagazineIssues
                           on isofis.MagazineIssueId equals mis.Issueid
                           join m in _context.Magazines
                           on mis.Magazineid equals m.Magazineid
                           join ins in _context.Institutions
                           on m.Institutionid equals ins.Institutionid
                           where ins.Institutionid == id
                           select a).Count();

            ViewBag.numberofarticles = articles;

            if (institution == null)
            {
                return NotFound();
            }

            return View(institution);
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

        double InstitutionImpactFactor(int year, int? id)
        {



            var issoissue = _context.IssueOfIssues.Where(value => value.MagazineIssue.Magazine.Institution.Institutionid == id && value.DateOfPublication.Year >= DateTime.Now.Year - 4 && value.DateOfPublication.Year <= DateTime.Now.Year).Include(a => a.Articles);

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
