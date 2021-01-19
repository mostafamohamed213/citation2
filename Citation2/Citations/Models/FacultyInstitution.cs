using System;
using System.Collections.Generic;

#nullable disable

namespace Citations.Models
{
    public partial class FacultyInstitution
    {
        public FacultyInstitution()
        {
            FacultyInstitutionDepartments = new HashSet<FacultyInstitutionDepartment>();
        }

        public int FacultyInstitutionid { get; set; }
        public int Institutionid { get; set; }
        public int Facultyid { get; set; }

        public virtual Faculty Faculty { get; set; }
        public virtual Institution Institution { get; set; }
        public virtual ICollection<FacultyInstitutionDepartment> FacultyInstitutionDepartments { get; set; }
    }
}
