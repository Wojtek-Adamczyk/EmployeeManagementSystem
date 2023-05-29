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
            Console.Write("Provide new employee's surname: ");
            string inputSurname = Console.ReadLine();
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

            employeesList.Add(new User(inputName, inputSurname, inputDepartment, inputDepartmentLong, inputSalary, inputDate));
        }

        public static bool DeleteEmployee(List<User> employeesList)
        {
            employeesList.ForEach(employee => employee.Show());

            Console.Write("Provide the ID of the employee to be dismissed: ");
            var inputId = int.Parse(Console.ReadLine());

            var employeeToRemove = employeesList.FirstOrDefault(e => e.id == inputId);
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

        public static bool ChangeSalary(List<User> employeesList)
        {
            employeesList.ForEach(employee => employee.Show());

            Console.Write("Provide the ID of the employee to change the pay: ");
            var inputId = int.Parse(Console.ReadLine());

            var employeeToSalaryChange = employeesList.FirstOrDefault(e => e.id == inputId);
            if (employeeToSalaryChange != null)
            {
                Console.Write("Provide new salary: ");
                var newSalary = double.Parse(Console.ReadLine());
                if (newSalary <= 0)
                    Console.WriteLine("Salary cannot be negative");
                else
                {
                    employeeToSalaryChange.Salary = newSalary;
                    Console.WriteLine("Salary changed successfully.");
                }
                return true;
            }
            else
            {
                Console.WriteLine("Employee not found.");
                return false;
            }
        }

        public static bool ChangeDepartment(List<User> employeesList)
        {
            employeesList.ForEach(employee => employee.Show());

            Console.Write("Provide the ID of the employee to change the department: ");
            var inputId = int.Parse(Console.ReadLine());

            var employeeToDepartmentChange = employeesList.FirstOrDefault(e => e.id == inputId);
            if (employeeToDepartmentChange != null)
            {
                Console.Write("Provide new department (short): ");
                var newDepartment = Console.ReadLine();

                employeeToDepartmentChange.DepartamentShort = newDepartment;

                string newDepartmentLong = newDepartment switch
                {
                    "gm" => "General Management",
                    "sld" => "Sales Department",
                    "hr" => "Human Resources",
                    "opd" => "Operations Department",
                    _ => "UNKNOWN DEPARTMENT"
                };

                employeeToDepartmentChange.DepartamentLong = newDepartmentLong;
                Console.WriteLine("Department changed successfully.");
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
        private string Surname { get; set; }
        private string DepartamentShort { get; set; }
        private string DepartamentLong { get; set; }
        private double Salary { get; set; }
        private DateTime WhenHired { get; set; }

        public User(string name, string surname, string departmentShort, string departamentLong, double salary, DateTime whenhired)
        {
            id = nextId; 
            nextId++;
            Name = name;
            Surname = surname;
            DepartamentShort = departmentShort;
            DepartamentLong = departamentLong;
            Salary = salary;
            WhenHired = whenhired;
        }

        public int GetId() {return id;}
        public string GetName() { return Name; }
        public string GetSurname() { return Surname; }
        public double GetSalary() { return Salary; }
        public string GetDepartamentShort() { return DepartamentShort; }
        public string GetDepartamentLong() { return DepartamentLong; }
        public DateTime GetWhenHired() { return WhenHired; }

        public void Show()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"{Name} {Surname}, {DepartamentLong}, salary (PLN): {Salary}, hired: {WhenHired}");
        }

        public override string ToString()
        {
            return $"ID: {id} \n{Name} {Surname}, {DepartamentLong}, salary (PLN): {Salary}, hired: {WhenHired}";
        }
    }
}
