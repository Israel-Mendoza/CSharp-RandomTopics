using System;
using System.Collections.Generic;
using System.Text;

namespace Delegates2
{

    public delegate bool IsPromotable(Employee empObj);
    
    public class Employee
    {
        // Static members
        public static int NumberOfEmployees = 0;
        public static int GetNextIDNumber() => ++NumberOfEmployees;

        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int ExperianceInYears { get; set; }

        public Employee(string name, int salary, int experienceInYears)
        {
            this.Name = name;
            this.Salary = salary;
            this.ExperianceInYears = experienceInYears;
            this.ID = GetNextIDNumber();
        }

        // Method
        public static void DisplayEmployeesToBePromoted(List<Employee> anEmployeeList, IsPromotable IsEligibleToPromotion)
        {            
            foreach(var e in anEmployeeList)
            {
                if (IsEligibleToPromotion(e))
                    Console.WriteLine($"{e.Name} is to be promoted...");
            }
        }
    }
}
