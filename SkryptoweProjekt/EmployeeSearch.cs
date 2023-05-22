using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkryptoweProjekt
{
    class EmployeeSearch
    {
        public static void SearchEmployee(List<User> employeesList)
        {
            Menu.SearchEmployee();
            var inputSearch = int.Parse(Console.ReadLine());

            switch (inputSearch)
            {
                case 1:
                    SearchByName(employeesList);
                    break;
                case 2:
                    SearchByDepartment(employeesList);
                    break;
                case 3:
                    SearchBySalary(employeesList);
                    break;
                case 4:
                    SearchByDateHired(employeesList);
                    break;
            }
        }

        private static void SearchByName(List<User> employeesList)
        {
            Console.Write("Type name: ");
            string searchByName = Console.ReadLine();
            List<User> searchedEmployees = employeesList.Where(e => e.GetName() == searchByName).ToList();
            searchedEmployees.ForEach(searchedEmployees => searchedEmployees.Show());
        }

        private static void SearchByDepartment(List<User> employeesList)
        {
            Console.Write("Department (short): ");
            string searchByDepartment = Console.ReadLine();
            List<User> searchedEmployees = employeesList.Where(e => e.GetDepartamentShort() == searchByDepartment).ToList();
            searchedEmployees.ForEach(searchedEmployees => searchedEmployees.Show());
        }

        private static void SearchBySalary(List<User> employeesList)
        {
            Console.Write("Search by the salary (e.g., >X, <X, =X): ");
            string searchBySalary = Console.ReadLine();

            string inputOperator = searchBySalary.Substring(0, 1);
            int inputValue = int.Parse(searchBySalary.Substring(1));

            List<User> searchedEmployees = new List<User>();

            switch (inputOperator)
            {
                case ">":
                    searchedEmployees = employeesList.Where(e => e.GetSalary() > inputValue).ToList();
                    break;
                case "<":
                    searchedEmployees = employeesList.Where(e => e.GetSalary() < inputValue).ToList();
                    break;
                case "=":
                    searchedEmployees = employeesList.Where(e => e.GetSalary() == inputValue).ToList();
                    break;
                default:
                    Console.WriteLine("Invalid criteria operator. Please try again.");
                    break;
            }

            searchedEmployees.ForEach(employee => employee.Show());
        }

        private static void SearchByDateHired(List<User> employeesList)
        {
            Console.Write("Search by the date hired (e.g., >X, <X, =X): ");
            string searchByDateHired = Console.ReadLine();

            string inputOperator = searchByDateHired.Substring(0, 1);
            DateTime inputValue = DateTime.Parse(searchByDateHired.Substring(1));

            List<User> searchedEmployees = new List<User>();

            switch (inputOperator)
            {
                case ">":
                    searchedEmployees = employeesList.Where(e => e.GetWhenHired() > inputValue).ToList();
                    break;
                case "<":
                    searchedEmployees = employeesList.Where(e => e.GetWhenHired() < inputValue).ToList();
                    break;
                case "=":
                    searchedEmployees = employeesList.Where(e => e.GetWhenHired() == inputValue).ToList();
                    break;
                default:
                    Console.WriteLine("Invalid criteria operator. Please try again.");
                    break;
            }

            searchedEmployees.ForEach(employee => employee.Show());
        }
    }
}
