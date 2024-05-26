using BusinessLayer.Concrete;
using CRM.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Serilog;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Controllers
{
	public class DefaultController : Controller
	{

        SaleManager saleManager = new SaleManager(new EfSaleDal());
        ProductManager productManager= new ProductManager(new EfProductDal());
        private readonly UserManager<AppUser> _userManager;

        public DefaultController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);
                ViewBag.user = user.Name;

                var sales = saleManager.TGetList();
                var products = productManager.TGetList();

                // Satışları ve ürünleri birleştir
                var combinedData = from sale in sales
                                   join product in products on sale.ProductId equals product.ProductId
                                   select new { Sale = sale, ProductName = product.ProductName, ProductPrice = product.ProductPrice };

                //*****COLUMN CHART*****
                
                var productSalesCounts = combinedData // Her bir ürünün satış sayısını hesapla
                    .GroupBy(cd => cd.ProductName)
                    .Select(g => new { ProductName = g.Key, SaleCount = g.Count() })
                    .ToList(); 

                List<string> xValue = new List<string>();
                List<int> yValue = new List<int>();

                foreach (var item in productSalesCounts)
                {
                    xValue.Add(item.ProductName);
                    yValue.Add(item.SaleCount);
                }

                ViewBag.xValue = xValue;
                ViewBag.yValue = yValue;


                //*****LOG SCALE CHART*****
                var monthlySales = combinedData
                 .GroupBy(cd => new { cd.Sale.SaleDate.Year, cd.Sale.SaleDate.Month }) // Yıl ve ay bazında gruplama
                 .Select(g => new
                 {
                     Month = new DateTime(g.Key.Year, g.Key.Month, 1), // Ayın ilk günü olarak temsil ediyoruz
                     TotalPrice = g.Sum(s => s.ProductPrice * g.Count()) // Aylık toplam fiyat hesaplaması (ürün fiyatı * satış adedi)
                 })
                 .OrderBy(g => g.Month) // Ay bazında sıralama
                 .ToList();

                List<DateTime> xScaleValue = new List<DateTime>();
                List<double> yScaleValue = new List<double>();

                foreach (var item in monthlySales)
                {
                    xScaleValue.Add(item.Month);
                    yScaleValue.Add(item.TotalPrice);
                }

                ViewBag.xScaleValue = xScaleValue;
                ViewBag.yScaleValue = yScaleValue;


                return View();
            }
            catch (Exception ex)
            {
                // Hata mesajını loglama
                Log.Error(ex, "Bir hata oluştu: {ErrorMessage}", ex.Message);

                // Kullanıcıya hata mesajını gösterme
                //ViewBag.ErrorMessage = "Bir hata oluştu. Lütfen daha sonra tekrar deneyin.";

                // Hata sayfasına yönlendirme
                return RedirectToAction("Error", "Home");
            }
        }
    }
}










