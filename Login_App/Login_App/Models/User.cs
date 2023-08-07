using Microsoft.VisualBasic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Login_App.Models
{
    public class User
        
    {
        
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName ("Full Name")]
        public string FullName { get; set; }
        [Required]
        public DateTime DateofBirth { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string ConfirmPassword { get; set; }
        [Required]
        public int Age { get; set; }
        [Phone]
        public string Phone { get; set; }
        [EmailAddress]
        public string Email { get; set; }
    }
}
