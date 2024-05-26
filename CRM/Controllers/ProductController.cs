using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace CRM.Controllers
{
    public class ProductController : Controller
    {
        ProductManager productManager = new ProductManager(new EfProductDal());
        ProductValidator productValidator = new ProductValidator();
        //Listele
        public IActionResult Index(int page=1)
        {
            try
            {
                var values = productManager.TGetList();
                return View(values.ToPagedList(page, 5));
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
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            try
            {

                ValidationResult results = productValidator.Validate(product);
                if (results.IsValid) {
                    product.ProductStatus = 0;
                    productManager.TAdd(product);
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                     foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
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

        //Sil
        [HttpGet]
        public IActionResult DeleteProduct(int id)
        {
            try
            {
                productManager.TDelete(productManager.TGetById(id));
                return RedirectToAction("Index", "Product");
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

        //Id Güncelle
        public IActionResult UpdateProductId(int id, int status)
        {
            try
            {
                var value = productManager.TGetById(id);
                value.ProductStatus = (ProductStatus)Enum.Parse(typeof(ProductStatus), status.ToString());
                productManager.TUpdate(value);
                return RedirectToAction("Index", "Product");
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


        //Güncelle
        [HttpGet]
        public IActionResult UpdateProduct(int id)
        {
            try
            {
                var values = productManager.TGetById(id);
                return View(values);
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
        public IActionResult UpdateProduct(Product product)
        {
            try
            {
                ValidationResult results = productValidator.Validate(product);
                if (results.IsValid)
                {
                    var value = productManager.TGetById(product.ProductId);
                    value.ProductName = product.ProductName;
                    value.ProductPrice = product.ProductPrice;
                    productManager.TUpdate(value);
                    return RedirectToAction("Index");
                }
                else
                {
                    foreach (var item in results.Errors)
                    {
                        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                    }
                }
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
