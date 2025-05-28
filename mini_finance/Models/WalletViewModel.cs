using System.ComponentModel.DataAnnotations;

namespace mini_finance.Models
{
    public class WalletViewModel
    {
        public decimal Balance { get; set; }
        public string AccountNumber { get; set; } = string.Empty;
        public string CardHolderName { get; set; } = string.Empty;
        public string ExpiryDate { get; set; } = string.Empty;
        public List<TransactionViewModel> RecentTransactions { get; set; } = new List<TransactionViewModel>();
    }
} 