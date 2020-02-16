using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace TestApp.Controllers
{
    public class AccountController : Controller
    {
        private readonly DogsBarberShopContext _context;


        public AccountController(DogsBarberShopContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

       

        [HttpPost]
        public async Task<ActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Users.SingleOrDefaultAsync(m => m.Email == model.Email && m.Password == model.Password);
                if (user == null)
                {
                    ModelState.AddModelError("Password", "Invalid login attempt.");
                    return View();
                }

                HttpContext.Session.SetString("userId", user.Id.ToString());
                user.LastLogin = DateTime.Now;
                _context.Update(user);
                await _context.SaveChangesAsync();

                

            }
            else
            {
                return View("Login");
            }
            
            return RedirectToAction("Index", "Home");
        }

        
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegistrationViewModel model)
        {

            if (ModelState.IsValid)
            {
                Users user = new Users
                {
                    DisplayName = model.DisplayName,
                    Email = model.Email,
                    Password = model.Password,
                    Mobile = model.Mobile,
                    LastLogin = DateTime.Now

                };
                List<Users> email=_context.Users.FromSql($"SP_GetUser {user.Email}").ToList();
                //var email = _context.Users.FirstOrDefault(u => u.Email == user.Email);
                if (email == null || email.Count()==0)
                {
                    _context.Add(user);
                    await _context.SaveChangesAsync();
                    HttpContext.Session.SetString("userId", user.Id.ToString());
                }
                else
                {
                    ViewBag.EmailErrorMsg = "User with this Email Already Exist";
                    return View();
                }

            }
            else
            {               
                return View("Register");
            }

            //HttpContext.Session.SetString("userId", user.Id.ToString());
            return RedirectToAction("Index", "Home");
        }
        // registration Page load
        

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }
        public void ValidationMessage(string key, string alert, string value)
        {
            try
            {
                TempData.Remove(key);
                TempData.Add(key, value);
                TempData.Add("alertType", alert);
            }
            catch
            {
                Debug.WriteLine("TempDataMessage Error");
            }

        }
    }
}