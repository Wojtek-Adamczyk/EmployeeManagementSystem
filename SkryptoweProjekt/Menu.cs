using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkryptoweProjekt
{
    internal class Menu
    {
        static public void CallMenu()
        {
            var menu = File.ReadAllText(@"C:\Users\wojte\source\repos\SkryptoweProjekt\SkryptoweProjekt\MenuText.txt");
            Console.WriteLine(menu);
        }

        public static void CallSearchMenu()
        {
            var menu = File.ReadAllText(@"C:\Users\wojte\source\repos\SkryptoweProjekt\SkryptoweProjekt\MenuSearchText.txt");
            Console.WriteLine(menu);
        }

       

    }
}
