//using Domain.Entities;
//using Infrastructure;
//using Microsoft.AspNetCore.Authentication;
//using Microsoft.AspNetCore.Mvc;
//using System.Security.Claims;
//using WebApp.Models;

//namespace WebApp.Controllers
//{
//    public class AccountController : Controller
//    {
//        private readonly BlogDbContext _context;

//        public AccountController(BlogDbContext context)
//        {
//            _context = context;
//        }

//        public ActionResult Register()
//        {
//            return View();
//        }

//        [HttpPost]
//        public IActionResult Register(UserViewModel userVm)
//        {
//            if (ModelState.IsValid)
//            {
//                var user = new User
//                {
//                    UserName = userVm.UserName,
//                    Password = userVm.Password,
//                    // Add other properties as needed
//                };

//                // Save user to the database
//                _context.Users.Add(user);
//                _context.SaveChanges();

//                return RedirectToAction("Login");
//            }

//            return View(userVm);
//        }

//        public ActionResult Login()
//        {
//            return View();
//        }


//        [HttpPost]
//        public IActionResult Login(UserViewModel userModel)
//        {
//            // Check if the user exists in the database
//            var dbUser = _context.Users.FirstOrDefault(u => u.UserName == userModel.UserName && u.Password == userModel.Password);

//            if (dbUser != null)
//            {
//                // Sign in the user
//                var claims = new List<Claim>
//                {
//                    new Claim(ClaimTypes.Name, userModel.UserName),

//                };

//                var identity = new ClaimsIdentity(claims, "cookie");
//                var principal = new ClaimsPrincipal(identity);

//                HttpContext.SignInAsync(principal);

//                // Redirect to the home page
//                return RedirectToAction("Index", "Home");
//            }

//            ModelState.AddModelError("", "Invalid login attempt");
//            return View(userModel);
//        }


//        public IActionResult Logout()
//        {
//            HttpContext.SignOutAsync();
//            return RedirectToAction("Index", "Home");
//        }
//    }
//}
