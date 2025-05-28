using Microsoft.AspNetCore.Mvc;
using mini_finance.Models;

namespace mini_finance.Controllers
{
    public class WalletController : Controller
    {
        private readonly ILogger<WalletController> _logger;

        public WalletController(ILogger<WalletController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var walletData = new WalletViewModel
            {
                Balance = 254800.00m,
                AccountNumber = "2560",
                CardHolderName = "Thomas Edison",
                ExpiryDate = "12/2028",
                RecentTransactions = GetRecentTransactions()
            };

            return View(walletData);
        }

        private List<TransactionViewModel> GetRecentTransactions()
        {
            return new List<TransactionViewModel>
            {
                new TransactionViewModel
                {
                    Id = 1,
                    PersonName = "Daniel Jones",
                    Description = "Sent you money",
                    Amount = 100.00m,
                    Time = "12:30 PM",
                    ProfileImage = "~/images/profile/senior-man-white-sweater-eyeglasses.jpg",
                    IsIncoming = true
                },
                new TransactionViewModel
                {
                    Id = 2,
                    PersonName = "Sarah Smith", 
                    Description = "Dinner payment",
                    Amount = -50.00m,
                    Time = "11:15 AM",
                    ProfileImage = "~/images/profile/portrait-beautiful-young-woman-standing-grey-wall.jpg",
                    IsIncoming = false
                },
                new TransactionViewModel
                {
                    Id = 3,
                    PersonName = "Emma Wilson",
                    Description = "Grocery shopping",
                    Amount = -75.00m,
                    Time = "10:00 AM",
                    ProfileImage = "~/images/profile/young-beautiful-woman-pink-warm-sweater-natural-look-smiling-portrait-isolated-long-hair.jpg",
                    IsIncoming = false
                }
            };
        }
    }
} 