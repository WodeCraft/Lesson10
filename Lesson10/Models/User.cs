using Lesson10.Infrastructure;
using System.ComponentModel.DataAnnotations;

namespace Lesson10.Models
{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string Fullname { get; set; }

        [Required]
        //[Remote("UniqueUserName", "RemoteValidation")]
        [UsernameIsUnique()]
        public string Username { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }

        [Required]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Range(1, 120)]
        public int Age { get; set; }


    }
}