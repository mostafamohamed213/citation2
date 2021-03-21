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
    public class DepartmentsController : Controller
    {
        private readonly CitationContext _context;

        public DepartmentsController(CitationContext context)
        {
            _context = context;
        }

        // GET: Departments
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

            IQueryable<Department> departments = _context.Departments;
            if (!String.IsNullOrEmpty(searchstring))
            {
                departments = departments.Where(f => f.Name.ToLower().Contains(searchstring.ToLower()));
                //    .Count() == 0 ? departments :
                //departments.Where(f => f.Name.ToLower().Contains(searchstring.ToLower()))
                //;
                ViewData["CurrentFilter"] = searchstring;
            }
            return View(await PaginatedList<Department>.CreateAsync(departments.AsNoTracking(), pageNumber ?? 1, 5));

            return View(await _context.Authors.Where(a => a.Active == true || a.Active == false).ToListAsync());
        }

        // GET: Departments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Departments.Include(f=>f.FacultyInstitutionDepartments)
                .ThenInclude(fid=>fid.FacultyInstitution.Institution)
                .Include(f=>f.FacultyInstitutionDepartments)
                .ThenInclude(f=>f.FacultyInstitution.Faculty)
                .FirstOrDefaultAsync(m => m.Departmentid == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // GET: Departments/Create
        public IActionResult Create()
        {
 
            ViewData["Institutionid"] = new SelectList(_context.Institutions.Where(a=>a.Active==true), "Institutionid", "Name");
            return View();
        }

        // POST: Departments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Departmentid,Name,Active")] Department department,string[] institutions, string[] Faculty)
        {
            if (ModelState.IsValid)
            {

              var existeddep=  _context.Departments.FirstOrDefault(d=>d.Name.ToLower()==department.Name.ToLower());
                if (existeddep != null)
                {
                    ViewData["Institutionid"] = new SelectList(_context.Institutions.Where(a => a.Active == true), "Institutionid", "Name");
                    ViewBag.exist = "Department Already Exists";
                    return View(department);

                }
                _context.Add(department);

                 _context.SaveChanges();
                int depid=department.Departmentid;
                for (int i = 0; i < institutions.Length; i++)
                {

                    var instid = int.Parse(institutions[i]);
                    var facid = int.Parse(Faculty[i]);
                
                    
                    if (instid == 0)
                    {
                        continue;
                    }
                    int facinstid = _context.FacultyInstitutions.FirstOrDefault(fi => fi.Institutionid == instid && fi.Facultyid == facid).FacultyInstitutionid;
                    
                    _context.FacultyInstitutionDepartments.Add(new FacultyInstitutionDepartment() { FacultyInstitutionid = facinstid ,Departmentid=department.Departmentid}) ;
                }
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(department);
        }

        // GET: Departments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            ViewData["Institutionid"] = new SelectList(_context.Institutions.Where(a => a.Active == true), "Institutionid", "Name");
            var department = await _context.Departments.Include(f => f.FacultyInstitutionDepartments)
                .ThenInclude(fid => fid.FacultyInstitution.Institution)
                .Include(f => f.FacultyInstitutionDepartments)
                .ThenInclude(f => f.FacultyInstitution.Faculty)
                .FirstOrDefaultAsync(m => m.Departmentid == id);
            if (department == null)
            {
                return NotFound();
            }
            return View(department);
        }

        // POST: Departments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Departmentid,Name,Active")] Department department, string[] institutions, string[] Faculty)
        {
            if (id != department.Departmentid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    for (int i = 0; i < institutions.Length; i++)
                    {

                        var instid = int.Parse(institutions[i]);
                        var facid = int.Parse(Faculty[i]);


                        if (instid == 0)
                        {
                            continue;
                        }
                        int facinstid = _context.FacultyInstitutions.FirstOrDefault(fi => fi.Institutionid == instid && fi.Facultyid == facid).FacultyInstitutionid;

                        _context.FacultyInstitutionDepartments.Add(new FacultyInstitutionDepartment() { FacultyInstitutionid = facinstid, Departmentid = department.Departmentid });
                    }
                    _context.Update(department);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DepartmentExists(department.Departmentid))
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
            return View(department);
        }

        // GET: Departments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var department = await _context.Departments
                .FirstOrDefaultAsync(m => m.Departmentid == id);
            if (department == null)
            {
                return NotFound();
            }

            return View(department);
        }

        // POST: Departments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            _context.Departments.Remove(department);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DepartmentExists(int id)
        {
            return _context.Departments.Any(e => e.Departmentid == id);
        }
    }
}
