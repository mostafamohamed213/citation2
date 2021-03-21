using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Citations.Models;
using Microsoft.AspNetCore.Mvc;

namespace Citations.Controllers
{
    public class RemoteValidationController : Controller
    {
        private readonly CitationContext _context;

        public RemoteValidationController(CitationContext context)
        {
            _context = context;
        }

        public IActionResult AutheremailExistsremote(string Email, int Authorid)
        {
            if (Email == null)
            {
                return Json(data: "الرجاء ادخال ايميل صحيح");
            }
            if (Authorid == 0)
            {
                if (_context.Authors.Any(e => e.Email.ToLower().Trim() == Email.ToLower().Trim()))
                    return Json(data: " الايميل موجود بالفعل");
            }
            if (Authorid != 0)
            {
                if (_context.Authors.Any(e => e.Email.ToLower().Trim() == Email.ToLower().Trim() && e.Authorid != Authorid))
                    return Json(data: " الايميل موجود بالفعل");
            }


            return Json(data: true);
        }


        public IActionResult AutherMobileExistsremote(string Mobile, int Authorid)
        {

            if (Mobile == null)
            {
                return Json(data: "الرجاء ادخال اسم صحيح");
            }
            if (Authorid == 0)
            {
                if (_context.Authors.Any(e => e.Mobile.ToLower().Trim() == Mobile.ToLower().Trim()))
                    return Json(data: " الاسم موجود بالفعل");

            }
            if (Authorid != 0)
            {

                if (_context.Authors.Any(e => e.Mobile.ToLower().Trim() == Mobile.ToLower().Trim() && e.Authorid != Authorid))
                    return Json(data: " الاسم موجود بالفعل");
            }


            return Json(data: true);
        }



        public IActionResult FacultyExistsremote(string Name,int Facultyid)
        {
            if (Name == null)
            {
                return Json(data: "الرجاء ادخال اسم صحيح");
            }
            if (Facultyid==0) {
                if (_context.Faculties.Any(e => e.Name.ToLower().Trim() == Name.ToLower().Trim()))
                    return Json(data: " الاسم موجود بالفعل");
            }
            if (Facultyid != 0)
            {
                if (_context.Faculties.Any(e => e.Name.ToLower().Trim() == Name.ToLower().Trim()&&e.Facultyid!=Facultyid))
                    return Json(data: " الاسم موجود بالفعل");
            }


            return Json(data: true);
        }



        public IActionResult DepartmentExistsremote(string Name, int Departmentid)
        {
            if (Name == null)
            {
                return Json(data: "الرجاء ادخال اسم صحيح");
            }
            if (Departmentid == 0)
            {
                if (_context.Departments.Any(e => e.Name.ToLower().Trim() == Name.ToLower().Trim()))
                    return Json(data: " الاسم موجود بالفعل");
            }
            if (Departmentid != 0)
            {
                if (_context.Departments.Any(e => e.Name.ToLower().Trim() == Name.ToLower().Trim() && e.Departmentid != Departmentid))
                    return Json(data: " الاسم موجود بالفعل");
            }


            return Json(data: true);
        }



        public IActionResult TypeNameExistsremote(string TypeName, int TypePublisherid)
        {

            if (TypeName == null)
            {
                return Json(data: "الرجاء ادخال اسم صحيح");
            }
            if (TypePublisherid==0)
            {
                if (_context.TypeOfPublishers.Any(e => e.TypeName.ToLower().Trim() == TypeName.ToLower().Trim()))
                    return Json(data: " الاسم موجود بالفعل");

            }
            if (TypePublisherid != 0)
            {

                if (_context.TypeOfPublishers.Any(e => e.TypeName.ToLower().Trim() == TypeName.ToLower().Trim()&&e.TypePublisherid!=TypePublisherid))
                    return Json(data: " الاسم موجود بالفعل");
            }


            return Json(data: true);
        }
        public IActionResult positionjobExistsremote(string PositionJob1,int PositionJobid)
        {
           
            if (PositionJob1 == null)
            {
                return Json(data: "الرجاء ادخال اسم صحيح");
            }
            if (PositionJobid == 0)
            {
                if (_context.PositionJobs.Any(e => e.PositionJob1.ToLower().Trim() == PositionJob1.ToLower().Trim()))
                    return Json(data: " الاسم موجود بالفعل");
            }
            if (PositionJobid != 0) {
                if (_context.PositionJobs.Any(e => e.PositionJob1.ToLower().Trim() == PositionJob1.ToLower().Trim() &&e.PositionJobid!=PositionJobid))
                    return Json(data: " الاسم موجود بالفعل");
            }

           

            return Json(data: true);
        }
        public IActionResult typepublisherExistsremote(string TypeName, int TypePublisherid)
        {
            
              if (TypeName == null) {
                return Json(data: "الرجاء ادخال اسم صحيح");
            }
            if (TypePublisherid == 0)
            {
                if (_context.TypeOfPublishers.Any(e => e.TypeName.ToLower().Trim() == TypeName.ToLower().Trim()))
                    return Json(data: " الاسم موجود بالفعل");

            }
            if (TypePublisherid != 0)
                if (_context.TypeOfPublishers.Any(e => e.TypeName.ToLower().Trim() == TypeName.ToLower().Trim()&&e.TypePublisherid!= TypePublisherid))
                return Json(data: " الاسم موجود بالفعل");
            

            return Json(data: true);
        }   
        
        
        public IActionResult publisherExistsremote(string Name,int Publisherid)
        {
            
              if (Name==null) {
                return Json(data: "الرجاء ادخال اسم صحيح");
            }
            if (Publisherid==0)
            {
                if (_context.Publishers.Any(e => e.Name.ToLower().Trim() == Name.ToLower().Trim()))
                    return Json(data: " الاسم موجود بالفعل");

            }
            if (Publisherid != 0)
                if (_context.Publishers.Any(e => e.Name.ToLower().Trim() == Name.ToLower().Trim()&&e.Publisherid!=Publisherid))
                return Json(data: " الاسم موجود بالفعل");
            

            return Json(data: true);
        }
        public IActionResult Index()
        {
            return View();
        }
    }








}
