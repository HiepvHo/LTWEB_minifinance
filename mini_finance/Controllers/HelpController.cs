using Microsoft.AspNetCore.Mvc;
using mini_finance.Models;

namespace mini_finance.Controllers
{
    public class HelpController : Controller
    {
        private readonly ILogger<HelpController> _logger;

        public HelpController(ILogger<HelpController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var faqList = GetFAQList();
            return View(faqList);
        }

        private List<FAQViewModel> GetFAQList()
        {
            return new List<FAQViewModel>
            {
                new FAQViewModel
                {
                    Question = "How do I add money to my wallet?",
                    Answer = "You can add money to your wallet by clicking the 'Top up' button on the dashboard and following the instructions. We support various payment methods including credit cards, bank transfers, and online banking."
                },
                new FAQViewModel
                {
                    Question = "How do I send money to someone?",
                    Answer = "To send money, go to your wallet, click 'Send' and enter the recipient's details along with the amount. You can send money using their email address or phone number."
                },
                new FAQViewModel
                {
                    Question = "What are the transaction fees?",
                    Answer = "Standard transactions within our network are free. For external transfers, we charge a small fee of $1-3 depending on the transfer method and destination."
                },
                new FAQViewModel
                {
                    Question = "How do I view my transaction history?",
                    Answer = "You can view your complete transaction history by navigating to the 'My Wallet' section or by clicking on any transaction in the recent transactions list on your dashboard."
                },
                new FAQViewModel
                {
                    Question = "Is my money secure?",
                    Answer = "Yes, we use bank-level security measures including 256-bit SSL encryption, two-factor authentication, and regular security audits to ensure your money and personal information are protected."
                },
                new FAQViewModel
                {
                    Question = "How do I contact customer support?",
                    Answer = "You can contact our customer support team 24/7 through the contact form below, by email at support@minifinance.com, or by calling our hotline at +1-800-FINANCE."
                }
            };
        }
    }
} 