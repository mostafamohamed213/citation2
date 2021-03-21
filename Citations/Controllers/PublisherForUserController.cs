using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citations.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Citations.Controllers
{
    public class PublisherForUserController : Controller
    {
        private readonly CitationContext _context;
     
        public PublisherForUserController(CitationContext context)
        {
            _context = context;
     
        }


        public async Task<IActionResult> Index(int? pageNumber, string searchstring, string CurrentFilter)
        {
            if (searchstring != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchstring = CurrentFilter;
            }
            if (pageNumber <= 0)
            {
                pageNumber = 1;
            }
            ViewData["CurrentFilter"] = searchstring;

            IQueryable<Publisher> publishers = _context.Publishers;
            if (!String.IsNullOrEmpty(searchstring))
            {
                publishers = publishers.Where(f => f.Name.ToLower().Contains(searchstring.ToLower()));
                //    .Count() == 0 ? publishers :
                //publishers.Where(f => f.Name.ToLower().Contains(searchstring.ToLower()))
                //;
                ViewData["CurrentFilter"] = searchstring;
            }
            return View(await PaginatedList<Publisher>.CreateAsync(publishers.Where(a => a.Active == true).Include(p=>p.TypeOfPublisherNavigation).Include(p => p.CountryNavigation).Include(p => p.Institution).AsNoTracking(), pageNumber ?? 1, 5));


        }

    }
}
