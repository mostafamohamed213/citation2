using System;
using System.Collections.Generic;

#nullable disable

namespace Citations.Models
{
    public partial class Faculty
    {
        public Faculty()
        {
            FacultyInstitutions = new HashSet<FacultyInstitution>();
        }

        public int Facultyid { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<FacultyInstitution> FacultyInstitutions { get; set; }
    }
}
