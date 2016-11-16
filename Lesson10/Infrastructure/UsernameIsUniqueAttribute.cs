using System.ComponentModel.DataAnnotations;

namespace Lesson10.Infrastructure
{
    public class UsernameIsUniqueAttribute : ValidationAttribute
    {

        public UsernameIsUniqueAttribute()
        {
            ErrorMessage = "The username needs to be unique.";
            ErrorMessageResourceName = "";
        }

        public override bool IsValid(object value)
        {
            bool isUnique = UserRepository.UsernameIsUnique((string)value);
            ErrorMessage = string.Format("The username '{0}' is already taken.", (string)value);

            return isUnique;
        }

    }
}