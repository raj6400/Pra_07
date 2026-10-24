using FeedbackManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace FeedbackManagement.Controllers
{
    public class FeedbackController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            Feedback feedback = new Feedback
            {
                Date = DateTime.Today
            };

            return View(feedback);
        }

        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Submitted = true;
            }

            return View(feedback);
        }
    }
}