using BusinessLayer.Concrete;
using CRM.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using X.PagedList;

namespace CRM.Controllers
{
    public class SaleController : Controller
    {
        SaleManager saleManager=new SaleManager(new EfSaleDal());
        ProductManager productManager=new ProductManager(new EfProductDal());
        CustomerManager customerManager=new CustomerManager(new EfCustomerDal());
        //Listele
        public IActionResult Index(int page=1)
        {
            try
            {
                using (var context = new Context())
                {
                    // Sale tablosundan satışları alırken, ilişkili Product ve Customer nesnelerini Include() ile yükleyelim.
                    var sales = context.Sales
                        .Include(s => s.Product)
                        .Include(s => s.Customer)
                        .ToList();

                    return View(sales.ToPagedList(page, 5));
                }

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

        //Ekle
        [Authorize(Roles = "Yönetici")]
        [HttpGet]
        public IActionResult AddSale()
        {
            try
            {
                SaleViewModel saleViewModel = new SaleViewModel();
                //DropDown List içini product isimleri ile doldurduk.
                List<SelectListItem> valueProduct = (from x in productManager.TGetList()
                                                     select new SelectListItem
                                                     {
                                                         Text = x.ProductName,
                                                         Value = x.ProductId.ToString()
                                                     }).ToList();
                ViewBag.productList = valueProduct;
                saleViewModel.Products = valueProduct;

                //DropDown List içini customer isimleri ile doldurduk.
                List<SelectListItem> valueCustomer = (from x in customerManager.TGetList()
                                                      select new SelectListItem
                                                      {
                                                          Text = x.CustomerName,
                                                          Value = x.CustomerId.ToString()
                                                      }).ToList();
                ViewBag.costumerList = valueCustomer;
                saleViewModel.Customers = valueCustomer;
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

        [HttpPost]
        public IActionResult AddSale(Sale sale)
        {
            try
            {

                Sale saleForm = new Sale(); 
                Context context = new Context();
                saleForm.ProductId = sale.Product.ProductId;
                saleForm.CustomerId = sale.Customer.CustomerId;
                saleForm.SaleDate = sale.SaleDate;





                saleManager.TAdd(saleForm);
                return RedirectToAction("Index", "Sale");
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


        //Sil
        [HttpGet]
        public IActionResult DeleteSale(int id)
        {
            try
            {
                saleManager.TDelete(saleManager.TGetById(id));
                return RedirectToAction("Index", "Sale");
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
