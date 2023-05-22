using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SkryptoweProjekt
{
    class Login
    {
        public static bool LogIn()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();
            string pattern = @"^\w+(?:\.\w+)*@\w+\.(?:com|pl)$";
            bool isCorrect = Regex.IsMatch(email, pattern);
            if (isCorrect)
            {
                Console.WriteLine("password = 'admin'");
                Console.Write("Enter password: ");
                string password = Console.ReadLine();
                if (password == "admin")
                {
                    Menu.CallMenu();
                    return true;
                }
            }

            throw new Exception("Wrong email or password");
        }
    }
}
