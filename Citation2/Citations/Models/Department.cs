using System;
using System.Collections.Generic;

#nullable disable

namespace Citations.Models
{
    public partial class Department
    {
        public Department()
        {
            FacultyInstitutionDepartments = new HashSet<FacultyInstitutionDepartment>();
        }

        public int Departmentid { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<FacultyInstitutionDepartment> FacultyInstitutionDepartments { get; set; }
    }
}
