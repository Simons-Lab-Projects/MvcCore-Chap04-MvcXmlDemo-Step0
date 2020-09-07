using Microsoft.AspNetCore.Mvc;
using MvcXmlDemo.Models;

namespace MvcXmlDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home
        public IActionResult Index()
        {
            return View();
        }

        // POST: /Home/Index
        [HttpPost]
        public IActionResult Index(Category cat)
        {
            return View("Save", cat);
        }
    }
}
