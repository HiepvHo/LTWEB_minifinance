using System.ComponentModel.DataAnnotations;

namespace mini_finance.Models
{
    public class SettingViewModel
    {
        [Display(Name = "Enable Notifications")]
        public bool NotificationEnabled { get; set; }

        [Display(Name = "Email Notifications")]
        public bool EmailNotifications { get; set; }

        [Display(Name = "Two-Factor Authentication")]
        public bool TwoFactorEnabled { get; set; }

        [Display(Name = "Currency")]
        public string Currency { get; set; } = "USD";

        [Display(Name = "Language")]
        public string Language { get; set; } = "English";

        [Display(Name = "Theme")]
        public string Theme { get; set; } = "Light";
    }
} 