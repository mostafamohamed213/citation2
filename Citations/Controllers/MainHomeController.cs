using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citations.Models;
using Microsoft.AspNetCore.Mvc;

namespace Citations.Controllers
{
    public class MainHomeController : Controller
    {
        private readonly CitationContext _context;

        public MainHomeController(CitationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.articles = _context.Articles.Count();
            ViewBag.authors = _context.Authors.Count();
            ViewBag.magazines = _context.Magazines.Count();
            ViewBag.institutions = _context.Institutions.Count();
            return View();
        }
    }
}
