using Citations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citations.Controllers
{
    public class articleViewComponent : ViewComponent
    {
        private readonly CitationContext _context;
        public articleViewComponent(CitationContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync(int id,
        
            int? pageNumber)
        {
            ViewBag.magazineid = id;

            var articles = from a in _context.Articles
                           join isofis in _context.IssueOfIssues
                           on a.ArticleIssue equals isofis.IssueOfIssueid
                           join mis in _context.MagazineIssues
                           on isofis.MagazineIssueId equals mis.Issueid
                           join m in _context.Magazines
                           on mis.Magazineid equals m.Magazineid
                           where m.Magazineid == id
                           select a;


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
            return View(await PaginatedList<Article>.CreateAsync(articles.Where(a => a.Active == true).AsNoTracking(), pageNumber ?? 1, pageSize));
        }
    
    }
   
}
