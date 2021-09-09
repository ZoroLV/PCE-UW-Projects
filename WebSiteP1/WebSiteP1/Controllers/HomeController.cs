using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebSiteP1.Models;
using Microsoft.EntityFrameworkCore;
using WebSiteP1.Data;
using Microsoft.AspNetCore.Identity;
using WebSiteP1.Areas.Identity.Data;
using System.Security.Claims;
using System.Data.SqlClient;
using System.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Filters;

namespace WebSiteP1.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DataContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeController(ILogger<HomeController> logger, DataContext context, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        public IActionResult Enroll()
        {
            ViewData["ClassId"] = new SelectList(_context.ClassList, "ClassName", "ClassName");
            ViewBag.ClassList = _context.ClassList.ToList();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            SelectList list = new SelectList(userId);
            ViewBag.Users = list;
            ViewBag.hdnFlag = userId;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [PreventDuplicateRequest]
        public async Task<IActionResult> Enroll([Bind("ClassId,UserId")] UserClasses userClasses)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userClasses);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(StudentClasses));
            }
            ViewData["ClassId"] = new SelectList(_context.ClassList, "ClassName", "ClassName", userClasses.ClassId);
            ViewBag.ClassList = _context.ClassList.ToList();
            return View(userClasses);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ClassList()
        {
            var data = _context.ClassList.ToList();
            var data2 = _context.ClassList;
            ViewBag.ClassList = data;
            ViewBag.ClassListing = data2;
            Classes ClassModel = new Classes();
            return View(ClassModel);
        }

        public IActionResult EnrollInClass()
        {
            return View();
        }

        public IActionResult StudentClasses()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var classIds = _context.UserClassList.Where(x => x.UserId == userId).Select(x => x.ClassId).ToList();
            ViewBag.Classes = classIds;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
        public class PreventDuplicateRequestAttribute : ActionFilterAttribute
        {
            public override void OnActionExecuting(ActionExecutingContext context)
            {
                if (context.HttpContext.Request.HasFormContentType && context.HttpContext.Request.Form.ContainsKey("__RequestVerificationToken"))
                {
                    var currentToken = context.HttpContext.Request.Form["__RequestVerificationToken"].ToString();
                    var lastToken = context.HttpContext.Session.GetString("LastProcessedToken");

                    if (lastToken == currentToken)
                    {
                        context.ModelState.AddModelError(string.Empty, "Looks like you accidentally submitted the same form twice.");
                    }
                    else
                    {
                        context.HttpContext.Session.SetString("LastProcessedToken", currentToken);
                    }
                }
            }
        }
    }
}
