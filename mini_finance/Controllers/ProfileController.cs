using Microsoft.AspNetCore.Mvc;
using mini_finance.Models;

namespace mini_finance.Controllers
{
    public class ProfileController : Controller
    {
        private readonly ILogger<ProfileController> _logger;

        public ProfileController(ILogger<ProfileController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var profileData = new ProfileViewModel
            {
                FullName = "Thomas Edison",
                Email = "thomas@site.com",
                Phone = "(60) 12 345 6789",
                Address = "123 Finance Street, Money City, FC 12345",
                DateOfBirth = new DateTime(1990, 5, 15),
                ProfileImage = "~/images/medium-shot-happy-man-smiling.jpg",
                MemberSince = new DateTime(2020, 1, 1)
            };

            return View(profileData);
        }

        [HttpPost]
        public IActionResult UpdateProfile(ProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                // Simulate saving profile data
                TempData["SuccessMessage"] = "Profile updated successfully!";
                return RedirectToAction("Index");
            }

            return View("Index", model);
        }
    }
} 