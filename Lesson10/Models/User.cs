using System.ComponentModel.DataAnnotations;

namespace Lesson10.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string Fullname { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }


    }
}