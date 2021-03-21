using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Citations.Models
{
    public class UserRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }

        public string Address { get; set; }

        public string FullName { get; set; }
        public bool IsSelected { get; set; }
    }
}
