using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CRM.Models;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Windows.Markup;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using X.PagedList;
using OpenAI_API.Moderation;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace CRM.Controllers
{
    public class CustomerController : Controller
    {
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        CustomerValidator customerValidator = new CustomerValidator();

        //Listele
        public IActionResult Index(int page = 1)
        {
            try
            {
                var values = customerManager.TGetList();
                return View(values.ToPagedList(page,5));
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
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(Customer customer)
        {
            try
            {
                ValidationResult results = customerValidator.Validate(customer);
                if (results.IsValid)
                {
                    customer.CustomerStatus = 0;
                    customerManager.TAdd(customer);
                    return RedirectToAction("Index", "Customer");
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
        public IActionResult DeleteCustomer(int id)
        {
            try
            {
                customerManager.TDelete(customerManager.TGetById(id));
                return RedirectToAction("Index", "Customer");
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
        public IActionResult UpdateCustomerId(int id, string status)
        {
            try
            {
                var value = customerManager.TGetById(id);
                value.CustomerStatus = (CustomerStatus)Enum.Parse(typeof(CustomerStatus), status.ToString()); ;
                customerManager.TUpdate(value);
                return RedirectToAction("Index", "Customer");
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
        public IActionResult UpdateCustomer(int id)
        {
            try
            {
                var values = customerManager.TGetById(id);
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
        public IActionResult UpdateCustomer(Customer customer)
        {
            try
            {
                ValidationResult results = customerValidator.Validate(customer);
                if (results.IsValid)
                {
                    var value = customerManager.TGetById(customer.CustomerId);
                    value.CustomerName = customer.CustomerName;
                    value.CustomerSurname = customer.CustomerSurname;
                    value.CustomerEmail = customer.CustomerEmail;
                    value.CustomerPhone = customer.CustomerPhone;
                    value.CustomerAdress = customer.CustomerAdress;
                    customerManager.TUpdate(value);
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
