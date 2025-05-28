using System.ComponentModel.DataAnnotations;

namespace mini_finance.Models
{
    public class TransactionViewModel
    {
        public int Id { get; set; }
        public string TransactionId { get; set; } = string.Empty;
        public string PersonName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Amount { get; set; }
        public string Time { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string ProfileImage { get; set; } = string.Empty;
        public bool IsIncoming { get; set; }
        public string Status { get; set; } = string.Empty;
    }

    public class TransactionDetailViewModel : TransactionViewModel
    {
        public string PaymentMethod { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string Notes { get; set; } = string.Empty;
    }
} 