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
    public class FacultiesController : Controller
    {
        private readonly CitationContext _context;

        public FacultiesController(CitationContext context)
        {
            _context = context;
        }

        // GET: Faculties
        public async Task<IActionResult> Index(int? pageNumber, string searchstring,string CurrentFilter)
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
            IQueryable<Faculty> faculties = _context.Faculties;
            if (!String.IsNullOrEmpty(searchstring))
            {
                faculties = faculties.Where(f => f.Name.ToLower().Contains(searchstring.ToLower()));
                //    .Count() == 0 ? faculties :
                //faculties.Where(f => f.Name.ToLower().Contains(searchstring.ToLower()))
                //;
                ViewData["CurrentFilter"] = searchstring;
            }
            return View(await PaginatedList<Faculty> .CreateAsync( faculties.AsNoTracking() , pageNumber ?? 1, 5));
        }
        public async Task<IActionResult> departments(int instid, int facid)
        {
            var institus = _context.FacultyInstitutions.FirstOrDefault(fi => fi.Institutionid == instid&&fi.Facultyid==facid);
            _context.FacultyInstitutionDepartments.Where(a => a.FacultyInstitutionid == institus.FacultyInstitutionid);
            return View(await _context.Faculties.ToListAsync());
        }

        // GET: Faculties/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faculty =  _context.Faculties.Include(c=>c.FacultyInstitutions).ThenInclude(f=>f.Institution)
                .FirstOrDefault(m => m.Facultyid == id);
            ViewData["institutions"] = faculty.FacultyInstitutions.Select(fi => fi.Institution.Name);
            if (faculty == null)
            {
                return NotFound();
            }

            return View(faculty);
        }

        // GET: Faculties/Create
        public IActionResult Create()
        {
            ViewData["institutions"] = new SelectList(_context.Institutions.Where(a=>a.Active==true), "Institutionid", "Name");
            return View();
        }

        // POST: Faculties/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Facultyid,Name,Active")] Faculty faculty,string[] institutions)
        {
            if (ModelState.IsValid)
            {
                _context.Add(faculty);
                
                _context.SaveChanges();
                foreach (var item in institutions)
                {
                    _context.FacultyInstitutions.Add(new FacultyInstitution() { Facultyid = faculty.Facultyid, Institutionid = int.Parse(item) });
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(faculty);
        }

        
        // GET: Faculties/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            
  
            var faculty = await _context.Faculties.Include(c => c.FacultyInstitutions).ThenInclude(f => f.Institution).FirstOrDefaultAsync(f=>f.Facultyid==id);
            if (faculty == null)
            {
                return NotFound();
            }
         var instexist=   _context.FacultyInstitutions.Where(ins => ins.Facultyid == id).Select(fi => fi.Institution);

            ViewBag.institutions =new MultiSelectList( _context.Institutions.Where(a=>a.Active==true).Except(instexist), "Institutionid", "Name");
            return View(faculty);
        }

        // POST: Faculties/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Facultyid,Name,Active")] Faculty faculty ,List<int> institutions)
        {
            if (id != faculty.Facultyid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    foreach (var item in institutions)
                    {
                        _context.FacultyInstitutions.Add(new FacultyInstitution() { 
                        Facultyid=id,
                        Institutionid=item
                        }
                        );
                    }
                    _context.Update(faculty);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FacultyExists(faculty.Facultyid))
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
            return View(faculty);
        }

        // GET: Faculties/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var faculty = await _context.Faculties
                .FirstOrDefaultAsync(m => m.Facultyid == id);
            if (faculty == null)
            {
                return NotFound();
            }

            return View(faculty);
        }

        // POST: Faculties/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var faculty = await _context.Faculties.FindAsync(id);
            _context.Faculties.Remove(faculty);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
       
        private bool FacultyExists(int id)
        {
            return _context.Faculties.Any(e => e.Facultyid == id);
        }
    }
}
