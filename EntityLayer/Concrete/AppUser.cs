using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Status Status { get; set; }

        public List<EmployeeTask> EmployeeTasks { get; set; }
    }
    public enum Status
    {
        Aktif,
        Pasif
    }
}
