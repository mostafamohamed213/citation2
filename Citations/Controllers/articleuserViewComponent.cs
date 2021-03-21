using Citations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citations.Controllers
{
    public class articleuserViewComponent:ViewComponent
    {
        private readonly CitationContext _context;
        public articleuserViewComponent(CitationContext context)
        {
            _context = context;
        }


        public async Task<IViewComponentResult> InvokeAsync(int id,

            int? pageNumber)
        {
            ViewBag.authorid = id;

      
            var articles = from ar in _context.Articles
                           join aa in _context.ArticleAuthores
                           on ar.Articleid equals aa.Articleid
                           where aa.Authorid == id
                           select ar;

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
