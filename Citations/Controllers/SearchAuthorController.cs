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
    public class SearchController : Controller
    {

        private readonly CitationContext _context;

        public SearchController(CitationContext context)
        {
            _context = context;

        }
        //[HttpGet]
        //public async Task<IActionResult> SearchArticle()
        //{
        //    return View(await PaginatedList<Article>.CreateAsync(_context.Articles.AsNoTracking(), 1 , 15));

        //}
        //[HttpPost]
        public class data
        {

        }


        public async Task<IActionResult> Searchmagazine(string magazinename, string CurrentFilter, List<int> resfields, string navresfields, List<int> institutionids, string navinstitutionids,  int? pageNumber, int pagesize)


        {





            if (navresfields != null)
            {
                if (resfields.Count() == 0 && navresfields.Split(",").Length > 0)
                {
                    resfields = navresfields.Split(",").Select(int.Parse).ToList();
                }

            }

            if (navinstitutionids != null)
            {
                if (institutionids.Count() == 0 && navinstitutionids.Split(",").Length > 0)
                {
                    institutionids = navinstitutionids.Split(",").Select(int.Parse).ToList();
                }

            }
  

            ViewData["institutionids"] = institutionids;
            ViewData["resfields"] = resfields;
       


            ViewData["CurrentFilter"] = magazinename;

            ViewData["pagesize"] = pagesize;


            //foreach (var item in magazinids)
            //{
            //    articals = articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid == item);
            //}

            //foreach (var item in magazinids)
            //{
            //    var articles = from a in _context.Articles
            //                   join isofis in _context.IssueOfIssues
            //                   on a.ArticleIssue equals isofis.IssueOfIssueid
            //                   join mis in _context.MagazineIssues
            //                   on isofis.MagazineIssueId equals mis.Issueid
            //                   join m in _context.Magazines
            //                   on mis.Magazineid equals m.Magazineid
            //                   where m.Magazineid ==item
            //                   select a;
            //}



            //    articals = articals.TakeWhile(value =>value.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid magazinids.Contains(value.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid));


            IQueryable<Magazine> pagedindex = _context.Magazines;

            if (magazinename != null)
            {
                pageNumber = 1;
            }
            else
            {
                magazinename = CurrentFilter;
            }
            if (pageNumber <= 0)
            {
                pageNumber = 1;
            }



            if (!string.IsNullOrEmpty(magazinename))
            {
                pagedindex = pagedindex.Where(a => a.Name.Trim().Contains(magazinename.Trim()));

            }
            //articals = articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())).Count()>0 ? 
            //    articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())): articals;

            if (resfields.Count() > 0)
                pagedindex = pagedindex.Where(ar => ar.MagazineResearchFields.Any(value => resfields.Contains(value.Field.Fieldid)));


            // pagedindex = pagedindex.Where(ar => ar.AuthorResearchFields.Any(value => resfields.Contains(value.Field.Fieldid))).Any(value => resfields.Contains(value.Field.Fieldid)));



            // pagedindex = pagedindex.Where(ar => ar.ArticleAuthores. ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => magazinids.Contains(value.MagazineIssue.Magazineid)));


            if (institutionids.Count() > 0)
                pagedindex = pagedindex.Where(ar => institutionids.Contains(ar.Institutionid));

                //.Any(value => institutionids
                //.Contains(value.Institutionid)));



            //pagedindex = pagedindex.Where(ar => ar.AuthorsPositionInstitutions
            //.Any(value => institutionids
            //.Contains(value.FacultyInstitutionDepartment.FacultyInstitution.Institution.)));

    //        if (magazinids.Count() > 0)


    //            pagedindex = pagedindex.Where(ar => ar.ArticleAuthores
    //.Any(value => magazinids
    //.Contains(value.Article.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid)));


            // pagedindex = pagedindex.Include(ar => ar.ArticleAuthores).ThenInclude(ar => ar.Article).ThenInclude(a => a.ArticleAuthores);




            var researchfields = _context.ResearchFields.Where(a => a.Active == true).Select(s => new
            {
                fieldid = s.Fieldid,
                field = string.Format("{0} - {1}", s.Name, s.NameEn)
            }).ToList();
            ViewData["allresfields"] = new MultiSelectList(researchfields, "fieldid", "field", resfields);


            //ViewData["KeyWords"] = new MultiSelectList(_context.KeyWords, "KeyWordid", "KeyWord1",keyWords);
            //ViewData["magazins"] = new MultiSelectList(_context.Magazines, "Magazineid", "Name", magazinids);

            ViewData["institutions"] = new MultiSelectList(_context.Institutions.Where(a => a.Active == true), "Institutionid", "Name", institutionids);




            return View(await PaginatedList<Magazine>.CreateAsync(pagedindex.Where(a=>a.Active==true).AsNoTracking().Include(p=>p.Institution), pageNumber ?? 1, 5));

        }






        public async Task<IActionResult> SearchAuthers(string authername, string CurrentFilter, List<int> resfields, string navresfields, List<int> institutionids, string navinstitutionids, List<int> magazinids, string navmagazinids, int? pageNumber, int pagesize)


        {





            if (navresfields != null)
            {
                if (resfields.Count() == 0 && navresfields.Split(",").Length > 0)
                {
                    resfields = navresfields.Split(",").Select(int.Parse).ToList();
                }

            }

            if (navinstitutionids != null)
            {
                if (institutionids.Count() == 0 && navinstitutionids.Split(",").Length > 0)
                {
                    institutionids = navinstitutionids.Split(",").Select(int.Parse).ToList();
                }

            }
            if (navmagazinids != null)
            {
                if (magazinids.Count() == 0 && navmagazinids.Split(",", StringSplitOptions.RemoveEmptyEntries).Length > 0)
                {
                    magazinids = navmagazinids.Split(",").Select(int.Parse).ToList();
                }

            }

            ViewData["institutionids"] = institutionids;
            ViewData["resfields"] = resfields;
            ViewBag.magazinids = magazinids;


            ViewData["CurrentFilter"] = authername;
        
            ViewData["pagesize"] = pagesize;


            //foreach (var item in magazinids)
            //{
            //    articals = articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid == item);
            //}

            //foreach (var item in magazinids)
            //{
            //    var articles = from a in _context.Articles
            //                   join isofis in _context.IssueOfIssues
            //                   on a.ArticleIssue equals isofis.IssueOfIssueid
            //                   join mis in _context.MagazineIssues
            //                   on isofis.MagazineIssueId equals mis.Issueid
            //                   join m in _context.Magazines
            //                   on mis.Magazineid equals m.Magazineid
            //                   where m.Magazineid ==item
            //                   select a;
            //}



            //    articals = articals.TakeWhile(value =>value.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid magazinids.Contains(value.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid));


            IQueryable<Author> pagedindex = _context.Authors;

            if (authername != null)
            {
                pageNumber = 1;
            }
            else
            {
                authername = CurrentFilter;
            }
            if (pageNumber <= 0)
            {
                pageNumber = 1;
            }



            if (!string.IsNullOrEmpty(authername))
            {
                pagedindex = pagedindex.Where(a => a.Name.Trim().Contains(authername.Trim()))    ;

            }
            //articals = articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())).Count()>0 ? 
            //    articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())): articals;

            if(resfields.Count()>0)
            pagedindex = pagedindex.Where(ar => ar.AuthorResearchFields.Any(value => resfields.Contains(value.Field.Fieldid)));


           // pagedindex = pagedindex.Where(ar => ar.AuthorResearchFields.Any(value => resfields.Contains(value.Field.Fieldid))).Any(value => resfields.Contains(value.Field.Fieldid)));



           // pagedindex = pagedindex.Where(ar => ar.ArticleAuthores. ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => magazinids.Contains(value.MagazineIssue.Magazineid)));


            if(institutionids.Count()>0)
            pagedindex = pagedindex.Where(ar => ar.AuthorsPositionInstitutions
            .Any(value => institutionids
            .Contains(value.FacultyInstitutionDepartment.FacultyInstitution.Institution.Institutionid)));



            //pagedindex = pagedindex.Where(ar => ar.AuthorsPositionInstitutions
            //.Any(value => institutionids
            //.Contains(value.FacultyInstitutionDepartment.FacultyInstitution.Institution.)));

            if(magazinids.Count()>0)


                            pagedindex = pagedindex.Where(ar => ar.ArticleAuthores
                .Any(value => magazinids
                .Contains(value.Article.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid)));


           // pagedindex = pagedindex.Include(ar => ar.ArticleAuthores).ThenInclude(ar => ar.Article).ThenInclude(a => a.ArticleAuthores);




            var researchfields = _context.ResearchFields.Where(a => a.Active == true).Select(s => new
            {
                fieldid = s.Fieldid,
                field = string.Format("{0} - {1}", s.Name, s.NameEn)
            }).ToList();
            ViewData["allresfields"] = new MultiSelectList(researchfields, "fieldid", "field", resfields);


            //ViewData["KeyWords"] = new MultiSelectList(_context.KeyWords, "KeyWordid", "KeyWord1",keyWords);
            ViewData["magazins"] = new MultiSelectList(_context.Magazines.Where(a => a.Active == true), "Magazineid", "Name", magazinids);

            ViewData["institutions"] = new MultiSelectList(_context.Institutions.Where(a => a.Active == true), "Institutionid", "Name", institutionids);




            return View(await PaginatedList<Author>.CreateAsync(pagedindex.Where(a => a.Active == true).AsNoTracking(), pageNumber ?? 1, 6));

        }



        public async Task<IActionResult> Searchajax(data d)
            

        {
        
            IQueryable<Article> articals = _context.Articles;


            string CurrentFilter = Request.Query.ContainsKey("CurrentFilter") ? Request.Query["CurrentFilter"].ToString() : null;
            int pagesize  = Request.Query.ContainsKey("pagesize") ? int.Parse(Request.Query["pagesize"].ToString()) : 0;
            int? pageNumber = Request.Query.ContainsKey("PageIndex") ? int.Parse(Request.Query["PageIndex"].ToString()) : 0;
            string Articletittle = Request.Query.ContainsKey("Articletittle") ? Request.Query["Articletittle"].ToString() : null;
            List<int> institutionids = Request.Query.ContainsKey("institutionids") ?Request.Query["institutionids"].ToString().Split(',').Select(int.Parse).ToList() : new List<int> {  };
            List<int> magazinids = Request.Query.ContainsKey("magazinids") ?Request.Query["magazinids"].ToString().Split(',').Select(int.Parse).ToList() :new List<int> {  };
            List<int> keyWords = Request.Query.ContainsKey("keyWords") ?Request.Query["keyWords"].ToString().Split(',').Select(int.Parse).ToList() :new List<int> {  };


            //for (int i = 0; i < 10; i++)
            //{
            //    magazinids.Add(i);
            //}





            if (Articletittle != null)
            {
                pageNumber = 1;
            }
            else
            {
                Articletittle = CurrentFilter;
            }
            if (pageNumber <= 0)
            {
                pageNumber = 1;
            }



            if (!string.IsNullOrEmpty(Articletittle))
            {
                articals = articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())).Count() > 0 ?
               articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())) : articals;

            }
            //articals = articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())).Count()>0 ? 
            //    articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())): articals;

            articals = articals.Where(ar => ar.ArticlesKeywords.Any(value => keyWords.Contains(value.KeyWord.KeyWordid))).Count() == 0 ?
                articals :
                articals.Where(ar => ar.ArticlesKeywords.Any(value => keyWords.Contains(value.KeyWord.KeyWordid)));



            articals = articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => magazinids.Contains(value.MagazineIssue.Magazineid))).Count() == 0 ?
        articals :
        articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => magazinids.Contains(value.MagazineIssue.Magazineid)));



            articals = articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => institutionids.Contains(value.MagazineIssue.Magazine.Institution.Institutionid))).Count() == 0 ?
      articals :
      articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => institutionids.Contains(value.MagazineIssue.Magazine.Institution.Institutionid)));


            articals = articals.Include(ar => ar.ArticleIssueNavigation).ThenInclude(ar => ar.MagazineIssue).ThenInclude(a => a.Magazine);



            return PartialView("view", await PaginatedList<Article>.CreateAsync(articals.AsNoTracking(), pageNumber ?? 1, pagesize == 0 ? 10 : pagesize));

            
        }
        public async Task<IActionResult> SearchArticle(string Articletittle, string CurrentFilter, List<int> keyWords, string navkeyWords, List<int> institutionids, string navinstitutionids, List<int> magazinids, string navmagazinids, int? pageNumber, int pagesize)


        {





            if (navkeyWords != null)
            {
                if (keyWords.Count() == 0 && navkeyWords.Split(",").Length > 0)
                {
                    keyWords = navkeyWords.Split(",").Select(int.Parse).ToList();
                }

            }
            if (navinstitutionids != null)
            {
                if (institutionids.Count() == 0 && navinstitutionids.Split(",").Length > 0)
                {
                    institutionids = navinstitutionids.Split(",").Select(int.Parse).ToList();
                }

            }
            if (navmagazinids != null)
            {
                if (magazinids.Count() == 0 && navmagazinids.Split(",", StringSplitOptions.RemoveEmptyEntries).Length > 0)
                {
                    magazinids = navmagazinids.Split(",").Select(int.Parse).ToList();
                }

            }

            ViewData["institutionids"] = institutionids;
            ViewData["KeyWordid"] = keyWords;
            ViewBag.magazinids = magazinids;


            ViewData["CurrentFilter"] = Articletittle;
            ViewData["CurrentFilter"] = Articletittle;
            ViewData["pagesize"] = pagesize;


            //foreach (var item in magazinids)
            //{
            //    articals = articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid == item);
            //}

            //foreach (var item in magazinids)
            //{
            //    var articles = from a in _context.Articles
            //                   join isofis in _context.IssueOfIssues
            //                   on a.ArticleIssue equals isofis.IssueOfIssueid
            //                   join mis in _context.MagazineIssues
            //                   on isofis.MagazineIssueId equals mis.Issueid
            //                   join m in _context.Magazines
            //                   on mis.Magazineid equals m.Magazineid
            //                   where m.Magazineid ==item
            //                   select a;
            //}



            //    articals = articals.TakeWhile(value =>value.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid magazinids.Contains(value.ArticleIssueNavigation.MagazineIssue.Magazine.Magazineid));


            IQueryable<Article> articals = _context.Articles;

            if (Articletittle != null)
            {
                pageNumber = 1;
            }
            else
            {
                Articletittle = CurrentFilter;
            }
            if (pageNumber <= 0)
            {
                pageNumber = 1;
            }



            if (!string.IsNullOrEmpty(Articletittle))
            {
                articals = articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim()));
               //     .Count() > 0 ?
               //articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())) : articals;

            }
            //articals = articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())).Count()>0 ? 
            //    articals.Where(a => a.Articletittle.Trim().Contains(Articletittle.Trim())): articals;

            if (keyWords.Count() > 0) {
                articals = articals.Where(ar => ar.ArticlesKeywords.Any(value => keyWords.Contains(value.KeyWord.KeyWordid)));
            }

            if (magazinids.Count() > 0) {
                articals = articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => magazinids.Contains(value.MagazineIssue.Magazineid)));

            }
            if (institutionids.Count()>0)
            {

            
            articals = articals.Where(ar => ar.ArticleIssueNavigation.MagazineIssue.IssueOfIssues.Any(value => institutionids.Contains(value.MagazineIssue.Magazine.Institution.Institutionid)));
        }


            articals = articals.Include(ar => ar.ArticleIssueNavigation).ThenInclude(ar => ar.MagazineIssue).ThenInclude(a => a.Magazine);




            var Keywords = _context.KeyWords.Where(a => a.Active == true).Select(s => new
            {
                KeyWordid = s.KeyWordid,
                KeyWord = string.Format("{0} - {1}", s.KeyWord1, s.KeyWordEn)
            }).ToList();
            ViewData["KeyWords"] = new MultiSelectList(Keywords, "KeyWordid", "KeyWord",keyWords);


            //ViewData["KeyWords"] = new MultiSelectList(_context.KeyWords, "KeyWordid", "KeyWord1",keyWords);
            ViewData["magazins"] = new MultiSelectList(_context.Magazines.Where(a => a.Active == true), "Magazineid", "Name",magazinids);

            ViewData["institutions"] = new MultiSelectList(_context.Institutions.Where(a => a.Active == true), "Institutionid", "Name",institutionids);

    


            return View( await PaginatedList<Article>.CreateAsync(articals.Where(a => a.Active == true).AsNoTracking(), pageNumber ?? 1, pagesize==0?10:pagesize));

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
