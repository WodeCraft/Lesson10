using Lesson10.Models;
using System.Collections.Generic;
using System.Linq;

namespace Lesson10.Infrastructure
{
    public class UserRepository
    {
        static List<User> users = new List<User>()
        {
            new User { Fullname = "Peter Nielsen", Username = "peter", Password = "ptr3nls", Age = 24 },
            new User { Fullname = "Thomas Larsen", Username = "tmlar", Password = "thm14lar", Age = 32 },
            new User { Fullname = "Vibeke Hansen", Username = "vibe", Password = "vibe2hanse", Age = 22 },
            new User { Fullname = "Susan Olsen", Username = "suol", Password = "susanol", Age = 34 }
        };


        public static IEnumerable<User> GetUsers()
        {
            return users;
        }

        public static bool UsernameIsUnique(string userName)
        {
            bool userNameExists = users.Where(u => u.Username == userName).Any();

            return !userNameExists;
        }
    }
}