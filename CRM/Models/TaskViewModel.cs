using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class TaskViewModel
    {
        public List<EmployeeTask> EmployeeTasks { get; set; }
        public List<AppUser> AppUsers { get; set; }
    }
}
