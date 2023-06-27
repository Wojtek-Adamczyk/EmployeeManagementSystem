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
            bool isLogged = false;

            while (!isLogged)
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();
                string pattern = @"^\w+(?:\.\w+)*@\w+\.(?:com|pl)$";
                bool isEmailValid = Regex.IsMatch(email, pattern);

                if (isEmailValid)
                {
                    Console.WriteLine("password = 'admin'");
                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();

                    if (password == "admin")
                    {
                        Menu.CallMenu();
                        isLogged = true;
                    }
                }

                if (!isLogged)
                {
                    Console.WriteLine("Wrong email or password. Please try again.");
                }
            }

            return true;
        }
    }
}