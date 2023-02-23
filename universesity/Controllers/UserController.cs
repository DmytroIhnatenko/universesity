using Fluent.Infrastructure.FluentModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;
namespace universesity.Controllers
{
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == username && u.Password == password);

            if (user == null)
            {
                ModelState.AddModelError("", "Invalid username or password");
                return View();
            }

            HttpContext.Session.SetString("Username", user.Username);
            HttpContext.Session.SetString("Role", user.Role);

            if (user.Role == "Student")
            {
                return RedirectToAction("ViewSchedule");
            }
            else if (user.Role == "Administrator")
            {
                return RedirectToAction("ManageClasses");
            }
            else
            {
                ModelState.AddModelError("", "Invalid user role");
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }

        [Authorize(Roles = "Student")]
        public IActionResult ViewSchedule()
        {
            // TODO: Implement view schedule functionality for students
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult ManageClasses()
        {
            // TODO: Implement manage classes functionality for administrators
            return View();
        }
    }

}
