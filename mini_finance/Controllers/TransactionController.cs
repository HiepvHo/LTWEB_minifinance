using Microsoft.AspNetCore.Mvc;
using mini_finance.Models;

namespace mini_finance.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ILogger<TransactionController> _logger;

        public TransactionController(ILogger<TransactionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var transactions = GetAllTransactions();
            return View(transactions);
        }

        public IActionResult Detail(int id)
        {
            var transaction = GetTransactionById(id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        private List<TransactionViewModel> GetAllTransactions()
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
                    Date = DateTime.Today,
                    ProfileImage = "~/images/profile/senior-man-white-sweater-eyeglasses.jpg",
                    IsIncoming = true,
                    TransactionId = "TXN001",
                    Status = "Completed"
                },
                new TransactionViewModel
                {
                    Id = 2,
                    PersonName = "Sarah Smith",
                    Description = "Dinner payment",
                    Amount = -50.00m,
                    Time = "11:15 AM",
                    Date = DateTime.Today,
                    ProfileImage = "~/images/profile/portrait-beautiful-young-woman-standing-grey-wall.jpg",
                    IsIncoming = false,
                    TransactionId = "TXN002",
                    Status = "Completed"
                },
                new TransactionViewModel
                {
                    Id = 3,
                    PersonName = "Emma Wilson",
                    Description = "Grocery shopping",
                    Amount = -75.00m,
                    Time = "10:00 AM",
                    Date = DateTime.Today,
                    ProfileImage = "~/images/profile/young-beautiful-woman-pink-warm-sweater-natural-look-smiling-portrait-isolated-long-hair.jpg",
                    IsIncoming = false,
                    TransactionId = "TXN003",
                    Status = "Completed"
                },
                new TransactionViewModel
                {
                    Id = 4,
                    PersonName = "Michael Brown",
                    Description = "Monthly rent",
                    Amount = -1200.00m,
                    Time = "09:00 AM",
                    Date = DateTime.Today.AddDays(-1),
                    ProfileImage = "~/images/profile/senior-man-white-sweater-eyeglasses.jpg",
                    IsIncoming = false,
                    TransactionId = "TXN004",
                    Status = "Completed"
                },
                new TransactionViewModel
                {
                    Id = 5,
                    PersonName = "Lisa Johnson",
                    Description = "Freelance payment",
                    Amount = 500.00m,
                    Time = "03:30 PM",
                    Date = DateTime.Today.AddDays(-2),
                    ProfileImage = "~/images/profile/portrait-beautiful-young-woman-standing-grey-wall.jpg",
                    IsIncoming = true,
                    TransactionId = "TXN005",
                    Status = "Completed"
                }
            };
        }

        private TransactionDetailViewModel? GetTransactionById(int id)
        {
            var transaction = GetAllTransactions().FirstOrDefault(t => t.Id == id);
            if (transaction == null) return null;

            return new TransactionDetailViewModel
            {
                Id = transaction.Id,
                TransactionId = transaction.TransactionId,
                PersonName = transaction.PersonName,
                Description = transaction.Description,
                Amount = transaction.Amount,
                Date = transaction.Date,
                Time = transaction.Time,
                Status = transaction.Status,
                ProfileImage = transaction.ProfileImage,
                IsIncoming = transaction.IsIncoming,
                PaymentMethod = "Credit Card",
                Category = transaction.IsIncoming ? "Income" : "Expense",
                Notes = "Transaction completed successfully"
            };
        }
    }
} 