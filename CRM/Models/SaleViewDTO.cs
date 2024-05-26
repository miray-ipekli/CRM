using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRM.Models
{
    public class SaleViewDTO
    {
        public Sale Sale { get; set; }
        public string Product { get; set; }
        public string Customer { get; set; }
    }
}
