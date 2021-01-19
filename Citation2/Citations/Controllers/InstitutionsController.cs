using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Citations.Models;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;

namespace Citations.Controllers
{
    public class InstitutionsController : Controller
    {
        private readonly CitationContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;
        public InstitutionsController(CitationContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }


        // GET: Institutions
        public async Task<IActionResult> Index()
        {
            var citationContext = _context.Institutions.Include(i => i.CountryNavigation).Include(i => i.TypeOfInstitutionNavigation);
            return View(await citationContext.ToListAsync());
        }

        // GET: Institutions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institution = await _context.Institutions
                .Include(i => i.CountryNavigation)
                .Include(i => i.TypeOfInstitutionNavigation)
                .FirstOrDefaultAsync(m => m.Institutionid == id);
            if (institution == null)
            {
                return NotFound();
            }

            return View(institution);
        }

        // GET: Institutions/Create
        public IActionResult Create()
        {
            ViewData["Country"] = new SelectList(_context.Countries, "Countryid", "Name");
            ViewData["TypeOfInstitution"] = new SelectList(_context.TypeOfInstitutions, "TypeInstitutionid", "TypeName");
            return View();
        }

        // POST: Institutions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Institutionid,Name,Country,TypeOfInstitution,ImpactFactor,PointerH,NumberOfCitations,Active")] Institution institution, IFormFile cover, IFormFile logo)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    if (cover != null)
                    {
                        var date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                        date = date.Replace("/", "-").Replace(":", "-");

                        var fileName = date + Path.GetFileName(cover.FileName);
                        var path = Path.Combine(webHostEnvironment.WebRootPath, "images");
                        string filepath = Path.Combine(path, fileName);
                        //  file.CopyTo(new FileStream(filepath, FileMode.Create));


                        //string path = ""; // From appsettings.json
                        //string filePath = path + $"\\Attachment {i}-" + attachment.FileName;
                        System.IO.StreamWriter files = new System.IO.StreamWriter(filepath);
                        cover.OpenReadStream().CopyTo(files.BaseStream);
                        files.Flush();
                        files.Close();

                        institution.ScannedCoverImage = fileName;

                    }


                }
                catch (Exception ex)
                {
                    throw ex;
                }

                try
                {
                    if (logo != null)
                    {
                        var date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
                        date = date.Replace("/", "-").Replace(":", "-");

                        var fileName = date + Path.GetFileName(logo.FileName);
                        var path = Path.Combine(webHostEnvironment.WebRootPath, "images");
                        string filepath = Path.Combine(path, fileName);
                        //  file.CopyTo(new FileStream(filepath, FileMode.Create));


                        //string path = ""; // From appsettings.json
                        //string filePath = path + $"\\Attachment {i}-" + attachment.FileName;
                        System.IO.StreamWriter files = new System.IO.StreamWriter(filepath);
                        logo.OpenReadStream().CopyTo(files.BaseStream);
                        files.Flush();
                        files.Close();

                        institution.ScannedLogoImage = fileName;

                    }


                }
                catch (Exception ex)
                {
                    throw ex;
                }
                _context.Add(institution);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Country"] = new SelectList(_context.Countries, "Countryid", "Name", institution.Country);
            ViewData["TypeOfInstitution"] = new SelectList(_context.TypeOfInstitutions, "TypeInstitutionid", "TypeName", institution.TypeOfInstitution);
            return View(institution);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Institutionid,Name,Country,TypeOfInstitution,ScannedCoverImage,ScannedLogoImage,ImpactFactor,PointerH,NumberOfCitations,Active")] Institution institution)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(institution);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    ViewData["Country"] = new SelectList(_context.Countries, "Countryid", "Name", institution.Country);
        //    ViewData["TypeOfInstitution"] = new SelectList(_context.TypeOfInstitutions, "TypeInstitutionid", "TypeName", institution.TypeOfInstitution);
        //    return View(institution);
        //}

        // GET: Institutions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institution = await _context.Institutions.FindAsync(id);
            if (institution == null)
            {
                return NotFound();
            }
            ViewData["Country"] = new SelectList(_context.Countries, "Countryid", "Name", institution.Country);
            ViewData["TypeOfInstitution"] = new SelectList(_context.TypeOfInstitutions, "TypeInstitutionid", "TypeName", institution.TypeOfInstitution);
            return View(institution);
        }

        // POST: Institutions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Institutionid,Name,Country,TypeOfInstitution,ScannedCoverImage,ScannedLogoImage,ImpactFactor,PointerH,NumberOfCitations,Active")] Institution institution)
        {
            if (id != institution.Institutionid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(institution);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstitutionExists(institution.Institutionid))
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
            ViewData["Country"] = new SelectList(_context.Countries, "Countryid", "Name", institution.Country);
            ViewData["TypeOfInstitution"] = new SelectList(_context.TypeOfInstitutions, "TypeInstitutionid", "TypeName", institution.TypeOfInstitution);
            return View(institution);
        }

        // GET: Institutions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institution = await _context.Institutions
                .Include(i => i.CountryNavigation)
                .Include(i => i.TypeOfInstitutionNavigation)
                .FirstOrDefaultAsync(m => m.Institutionid == id);
            if (institution == null)
            {
                return NotFound();
            }

            return View(institution);
        }

        // POST: Institutions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var institution = await _context.Institutions.FindAsync(id);
            _context.Institutions.Remove(institution);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstitutionExists(int id)
        {
            return _context.Institutions.Any(e => e.Institutionid == id);
        }
    }
}
