using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class SaleViewModel
    {
        public Sale Sale { get; set; }
        public List<SelectListItem> Products { get; set; }
        public List<SelectListItem> Customers { get; set; }
    }
}
