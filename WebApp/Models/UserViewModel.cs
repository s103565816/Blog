using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    public class UserViewModel
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        public string UserName { get; set; }  = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
    }
}
