using CRM.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Threading.Tasks;

namespace CRM.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
 
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel p)
        {
            try
            {
                if (ModelState.IsValid)
                {
                   
                        var result = await _signInManager.PasswordSignInAsync(p.UserName, p.Password, false, true);
                        if (result.Succeeded)
                        {
                            var user = await _signInManager.UserManager.FindByNameAsync(p.UserName);
                            if (user.Status == 0)
                            {
                                return RedirectToAction("Index", "Default");
                            }
                            else
                            {
                                ModelState.AddModelError(string.Empty, "Hesabınız aktif değil.");
                            }
                        }
                        else
                        {
                            // Kullanıcı adı veya şifre hatalı ise uyarı mesajını ekleyelim.
                            ModelState.AddModelError(string.Empty, "Kullanıcı adı veya şifre hatalı");
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

        [HttpGet]
        public async Task<IActionResult> LogOut()
        {
            try
            {
                await _signInManager.SignOutAsync();
                return RedirectToAction("SignIn", "Login");
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
