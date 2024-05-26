using BusinessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CRM.Models;
using Serilog;
using System;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using BusinessLayer.ValidationRules;
using X.PagedList;

namespace CRM.Controllers
{
	public class EmployeeController : Controller
	{
		AppUserManager appUserManager= new AppUserManager(new EfAppUserDal());

        //Kayıt Ol
        private readonly UserManager<AppUser> _userManager;
        public EmployeeController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index(int page=1)
		{
            try
            {
                var values = appUserManager.TGetList();
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

        [Authorize(Roles = "Yönetici")]
        [HttpGet]
		public IActionResult AddEmployee()
		{
			return View();
		}

        [HttpPost]
		public async Task<IActionResult> AddEmployee(UserRegisterViewModel p)
		{
            try
            {
                //ValidationResult results = emplooyeValidator.Validate(p);
                //if (results.IsValid)
                //{
                    var uName = p.Name + p.Surname;
                    uName = uName.ToLower();
                    uName = uName.Replace('ö', 'o');
                    uName = uName.Replace('ü', 'u');
                    uName = uName.Replace('ı', 'i');
                    uName = uName.Replace('ğ', 'g');
                    uName = uName.Replace('ş', 's');
                    uName = uName.Replace('ç', 'c');
                    uName = uName.Replace(' ', '_');
                    AppUser appUser = new AppUser()
                    {
                        Name = p.Name,
                        Surname = p.Surname,
                        UserName = uName,
                        Email = p.Mail,
                        PhoneNumber = p.PhoneNumber,
                        Status = 0
                    };
                    if (p.Password == p.ConfirmPassword)
                    {
                        var result = await _userManager.CreateAsync(appUser, p.Password);

                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            foreach (var item in result.Errors)
                            {
                                ModelState.AddModelError("", item.Description);
                            }
                        }
                    }
                    return View(p);
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
        public async Task<IActionResult> UpdateEmployee(int id, string status)
        {
            try
            {
                var value = appUserManager.TGetById(id);

                value.Status = (Status)Enum.Parse(typeof(Status), status.ToString());
                appUserManager.TUpdate(value);
                return RedirectToAction("Index", "Employee");
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
