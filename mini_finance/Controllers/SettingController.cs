using Microsoft.AspNetCore.Mvc;
using mini_finance.Models;

namespace mini_finance.Controllers
{
    public class SettingController : Controller
    {
        private readonly ILogger<SettingController> _logger;

        public SettingController(ILogger<SettingController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var settings = new SettingViewModel
            {
                NotificationEnabled = true,
                EmailNotifications = true,
                TwoFactorEnabled = false,
                Currency = "USD",
                Language = "English",
                Theme = "Light"
            };

            return View(settings);
        }

        [HttpPost]
        public IActionResult UpdateSettings(SettingViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Simulate saving settings
                TempData["SuccessMessage"] = "Settings updated successfully!";
                return RedirectToAction("Index");
            }

            return View("Index", model);
        }
    }
} 