using System.Text.RegularExpressions;

namespace SkryptoweProjekt
{

    internal class Program
    {
        static List<User> GetEmployeesList()
        {
            List<User> employeeList = new List<User>()
            {
                new User("Wojciech", "Adamczyk", "gm", "General Management", 11034.56, new DateTime(2020,03,20)),
                new User("Max", "Kolonko", "hr", "Human Resources", 4204.20, new DateTime(2014,04,26)),
                new User("Victoria", "Secret", "sld", "Sales Departament", 3141.34, new DateTime(2004,01,12)),
                new User("James", "Hetfield", "opd", "Operations Departament", 42.20, new DateTime(1983,10,23)),
                new User("Sam", "Smith", "sld", "Sales Departament", 5178.99, new DateTime(2008,12,24)),
                new User("John", "Wick", "hr", "Human Resources", 3101.87, new DateTime(2014,03,06)),
                new User("Chris", "Pine", "hr", "Human Resources", 4601.60, new DateTime(2012,08,13)),
                new User("Amerigo", "Vespucci", "hr", "Human Resources", 5200.71, new DateTime(2001,01,05)),
                new User("Jan", "Paweł", "opd", "Operations Departament", 2137.05, new DateTime(2005,04,20)),
                new User("Karl", "Marx", "opd", "Operations Departament", 1920.17, new DateTime(2017,10,17)),
                new User("Marcin", "Dubiel", "opd", "Operations Departament", 3410.10, new DateTime(2019,02,09)),
                new User("Wojciech", "Adamski", "opd", "Operations Departament", 1000.00, new DateTime(2023,05,21))
            };

            return employeeList;
        }

        static void Main(string[] args)
        {
            var employeesList = GetEmployeesList();
            

            if (Login.LogIn())
            {
                while (true)
                {
                    var input = int.Parse(Console.ReadLine());

                    if (input == 1)
                    {
                        employeesList.ForEach(employee => employee.Show());
                        Menu.CallMenu();
                    }
                    else if (input == 2)
                    {
                        EmployeeSearch.SearchEmployee(employeesList);
                        Menu.CallMenu();
                    }
                    else if (input == 3)
                    {
                        User.AddNewEmployee(employeesList);
                        Menu.CallMenu();
                    }
                    else if (input == 4)
                    {
                        User.DeleteEmployee(employeesList);
                        Menu.CallMenu();
                    }
                    else if (input == 5)
                    {
                        User.ChangeSalary(employeesList);
                        Menu.CallMenu();
                    }
                    else if (input == 6)
                    {
                        User.ChangeDepartment(employeesList);
                        Menu.CallMenu();
                    }
                    else if (input == 7)
                        Login.LogIn();
                }
            }
        }     
    }
}