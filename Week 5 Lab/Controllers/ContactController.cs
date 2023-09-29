
using Microsoft.AspNetCore.Mvc;
using VioletsLoops.Models;
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(ContactModel model)
        {
        
            return View(model);
        }
    }
