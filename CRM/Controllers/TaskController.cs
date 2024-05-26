using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CRM.Models;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFreamework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.Results;
using ValidationResult = FluentValidation.Results.ValidationResult;
using X.PagedList;
using Microsoft.AspNetCore.Authorization;
using System.Data;

namespace CRM.Controllers
{
    public class TaskController : Controller
    {
        EmployeeTaskManager employeeTaskManager = new EmployeeTaskManager(new EfEmployeeTaskDal());
        AppUserManager appUserManager = new AppUserManager(new EfAppUserDal());

        private readonly UserManager<AppUser> _userManager;

        public TaskController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        //Listele
        public async Task<IActionResult> Index(int page =1)
        {
            try
            {
                using (var context = new Context())
                {
                    var values = await _userManager.FindByNameAsync(User.Identity.Name);
                    ViewBag.user = values.Id;
                    // Sale tablosundan satışları alırken, ilişkili appuser nesnelerini Include() ile yükleyelim.
                    var tasks = context.EmployeeTasks
                        .Include(s => s.AppUser)
                        .ToList();

                    return View(tasks.ToPagedList(page, 5));
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
        public IActionResult AddTask()
        {                
            //DropDown List içini customer isimleri ile doldurduk.
            List<SelectListItem> value = (from x in appUserManager.TGetList()
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Name,
                                                      Value = x.Id.ToString()
                                                  }).ToList();
            ViewBag.users = value;
            return View();
        }

        [HttpPost]
        public IActionResult AddTask(EmployeeTask employeeTask)
        {
            try
            {

                    EmployeeTask taskForm = new EmployeeTask();
                    Context context = new Context();
                    taskForm.AppUserId = employeeTask.AppUser.Id;
                    taskForm.TaskStatus = "Yeni Görev";
                    taskForm.CompletionDate = DateTime.Now;
                    taskForm.Task = employeeTask.Task;
                    taskForm.TaskDescription = employeeTask.TaskDescription;
                    employeeTaskManager.TAdd(taskForm);
                    return RedirectToAction("Index", "Task");
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
        public IActionResult UpdateTask(int id, string status)
        {
            try
            {
                var value = employeeTaskManager.TGetById(id);

                if (status == "Göreve Başlandı")
                {
                    value.TaskStatus = "Devam Ediyor";
                }
                else if (status == "Tamamlandı")
                {
                    value.TaskStatus = "Görev Tamamlandı";
                    value.CompletionDate = DateTime.Now;
                }


                employeeTaskManager.TUpdate(value);
                return RedirectToAction("Index", "Task");
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