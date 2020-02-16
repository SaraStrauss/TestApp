using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestApp.Models;

namespace TestApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly DogsBarberShopContext _context;
        public HomeController(DogsBarberShopContext context)
        {
            _context = context;
        }

      
        public async Task<IActionResult> Index(string sortOrder, string searchString,DateTime searchDate)
        {
           
            ViewData["NameSortParm"] = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewData["DateSortParm"] = sortOrder == "Date" ? "date_desc" : "Date";
            ViewData["CurrentFilter"] = searchString;
            if (searchDate != DateTime.MinValue)
            { ViewData["currentFilter2"] = searchDate.ToString("yyyy-MM-dd"); }
            else
            {
                ViewData["currentFilter2"] = null;
            }

            string userId = HttpContext.Session.GetString("userId");
            var queue = from q in _context.Queue
                        join u in _context.Users on q.UserId equals u.Id
                        where q.QueueDate >= DateTime.Now
                        select new Queue { Id = q.Id, UserId = q.UserId, QueueDate = q.QueueDate, InsertDate = q.InsertDate, user = u, IsMine = u.Id.ToString() == userId };
            //var queue = _context.Queue.FromSql($"SP_GetQueue {DateTime.Now}");
            
            if (!String.IsNullOrEmpty(searchString))
            {
                queue = queue.Where(s => s.user.DisplayName.Contains(searchString));
            }
            if (searchDate!=null && searchDate!=DateTime.MinValue)
            {
                queue = queue.Where(s => s.QueueDate.Date== searchDate.Date);
            }

            switch (sortOrder)
            {
                case "name_desc":
                    queue = queue.OrderByDescending(s => s.user.DisplayName);
                    break;
                case "Date":
                    queue = queue.OrderBy(s => s.QueueDate);
                    break;
                case "date_desc":
                    queue = queue.OrderByDescending(s => s.QueueDate);
                    break;
                default:
                    queue = queue.OrderBy(s => s.user.DisplayName);
                    break;
            }

            return View(await queue.AsNoTracking().ToListAsync());
        }


        public ActionResult Edit(int Id)
        {           
            var q = _context.Queue.Where(s => s.Id == Id).FirstOrDefault();
            if (q == null)
            {
                string userId = HttpContext.Session.GetString("userId");
                q = new Queue() { UserId = int.Parse(userId) };
            }
            q.user = _context.Users.Where(u => u.Id == q.UserId).FirstOrDefault();

            return View(q);
        }

       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Queue q)
        {            
            if (!ModelState.IsValid)
            {                
                q.user = _context.Users.Where(u => u.Id == q.UserId).FirstOrDefault();
                return View(q);
            }
           
            if (q.InsertDate == DateTime.MinValue)
            {
                q.InsertDate = DateTime.Now;
                _context.Add(q);
            }
            else
            {
                q.InsertDate = DateTime.Now;
                _context.Update(q);
            }

            _context.SaveChanges();
            return RedirectToAction("Index");
        }




        public ActionResult Delete(Queue q)
        {
            _context.Remove(q);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        public IActionResult VerifyQueueDate(DateTime qdate)
        {
            if (qdate < DateTime.Now)
            {
                return Json(data: false);
            }

            return Json(data: true);
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyEmail(string email)
        {

            return Json($"Email {email} is already in use.");


            return Json(true);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(
             [Bind("Id")] Queue queue)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(queue);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (DbUpdateException /* ex */)
            {
                //Log the error (uncomment ex variable name and write a log.
                ModelState.AddModelError("", "Unable to save changes. " +
                    "Try again, and if the problem persists " +
                    "see your system administrator.");
            }
            return View(queue);
        }


        public ActionResult Details(Queue queue)
        {
            queue.user = _context.Users.FirstOrDefault(w => w.Id == queue.UserId);
            return PartialView("_Details", queue);

        }



        [HttpPost]
        public ActionResult CreateTeacherAndStudent(Queue queue)
        {
            try
            {
                //_context context = new MyDbContext();
                //_context.Teachers.AddRange(teacherAndStudent.Teachers);
                //context.Students.AddRange(teacherAndStudent.Students);
                //context.SaveChanges();
                return Content("save ok");
            }
            catch (Exception)
            {

                return View("ShowTS", queue);
            }

        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy(Queue q)
        {
            return View(q);
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return View("Login");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
