using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;
using System;
using Microsoft.AspNetCore.Http;
using CRM.Models;
using Serilog;

namespace CRM.Controllers
{
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            try
            {
                //Yapay hata oluştur
                //throw new Exception("Deneme Hatası");
                var values = await _userManager.FindByNameAsync(User.Identity.Name);
                UserEditViewModel userEditViewModel = new UserEditViewModel();
                userEditViewModel.Name = values.Name;
                userEditViewModel.Surname = values.Surname;
                userEditViewModel.UserName = values.UserName;
                userEditViewModel.PhoneNumber = values.PhoneNumber;
                userEditViewModel.Mail = values.Email;
                return View(userEditViewModel);
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
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            try
            {
                //İsme göre kullanıcıyı bul
                var user = await _userManager.FindByNameAsync(User.Identity.Name);


                user.Name = p.Name;
                user.Surname = p.Surname;
                user.UserName = p.UserName;
                if (p.Password != null)
                {
                    user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
                }
                user.PhoneNumber = p.PhoneNumber;
                user.Email = p.Mail;
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Default");
                }
                return View();
            }
            catch (Exception ex)
            {
                // Hata mesajını loglama
                Log.Error(ex, "Bir hata oluştu: {ErrorMessage}", ex.Message);

                // Hata sayfasına yönlendirme
                return RedirectToAction("Error", "Home");
            }

        }
    }
}


