using System.ComponentModel.DataAnnotations;

namespace mini_finance.Models
{
    public class ProfileViewModel
    {
        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; } = string.Empty;

        [Display(Name = "Address")]
        public string Address { get; set; } = string.Empty;

        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Profile Image")]
        public string ProfileImage { get; set; } = string.Empty;

        [Display(Name = "Member Since")]
        public DateTime MemberSince { get; set; }
    }
} 