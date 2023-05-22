using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkryptoweProjekt
{
    class User
    {
        static public void AddNewEmployee(List<User> employeesList)
        {
            Console.Write("Provide new employee's name: ");
            string inputName = Console.ReadLine();
            Console.Write("Provide department short name: ");
            string inputDepartment = Console.ReadLine();
            Console.Write("Provide new salary: ");
            var inputSalary = double.Parse(Console.ReadLine());
            Console.Write("When was the employee hired?: ");
            var inputDate = DateTime.Parse(Console.ReadLine());

            string inputDepartmentLong = inputDepartment switch
            {
                "gm" => "General Management",
                "sld" => "Sales Department",
                "hr" => "Human Resources",
                "opd" => "Operations Department",
                _ => "UNKNOWN DEPARTMENT"
            };

            employeesList.Add(new User(inputName, inputDepartment, inputDepartmentLong, inputSalary, inputDate));
        }

        public static bool DeleteEmployee(List<User> employeesList)
        {
            employeesList.ForEach(employee => employee.Show());

            Console.Write("Provide the ID of the employee to be dismissed: ");
            var inputId = int.Parse(Console.ReadLine());

            var employeeToRemove = employeesList.FirstOrDefault(employee => employee.id == inputId);
            if (employeeToRemove != null)
            {
                employeesList.Remove(employeeToRemove);
                Console.WriteLine("Employee fired successfully.");
                return true;              
            }
            else
            {
                Console.WriteLine("Employee not found.");
                return false;
            }
        }

        private static int nextId = 1;

        private int id;
        private string Name { get; set; }       
        private string DepartamentShort { get; set; }
        private string DepartamentLong { get; set; }
        private double Salary { get; set; }
        private DateTime WhenHired { get; set; }

        public User(string name, string departmentShort, string departamentLong, double salary, DateTime whenhired)
        {
            id = nextId; 
            nextId++;
            Name = name;            
            DepartamentShort = departmentShort;
            DepartamentLong = departamentLong;
            Salary = salary;
            WhenHired = whenhired;
        }

        public int GetId() {return id;}
        public string GetName() { return Name; }
        public double GetSalary() { return Salary; }
        public string GetDepartamentShort() { return DepartamentShort; }
        public DateTime GetWhenHired() { return WhenHired; }

        public void Show()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"{Name}, {DepartamentLong}, salary (PLN): {Salary}, hired: {WhenHired}");
        }       
    }
}
