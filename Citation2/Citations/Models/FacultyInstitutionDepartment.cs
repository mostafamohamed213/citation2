using System;
using System.Collections.Generic;

#nullable disable

namespace Citations.Models
{
    public partial class FacultyInstitutionDepartment
    {
        public FacultyInstitutionDepartment()
        {
            AuthorsPositionInstitutions = new HashSet<AuthorsPositionInstitution>();
        }

        public int FacultyInstitutionDepartmentid { get; set; }
        public int FacultyInstitutionid { get; set; }
        public int Departmentid { get; set; }

        public virtual Department Department { get; set; }
        public virtual FacultyInstitution FacultyInstitution { get; set; }
        public virtual ICollection<AuthorsPositionInstitution> AuthorsPositionInstitutions { get; set; }
    }
}
