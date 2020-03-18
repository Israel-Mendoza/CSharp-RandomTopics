using System;
using System.Collections.Generic;

namespace Delegates2
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Employee("Israel Mendoza", 23000, 4);
            var emp2 = new Employee("Roberto Cedillo", 12000, 6);
            var emp3 = new Employee("Angel Arevalo", 18000, 5);
            var emp4 = new Employee("Allin Rubio", 12000, 6);
            var emp5 = new Employee("Fernando Gomez", 12000, 3);
            var emp6 = new Employee("Luis Tellez", 26_000, 7);

            var myEmployees = new List<Employee>() { emp1, emp2, emp3, emp4, emp5, emp6 };
            
            Employee.DisplayEmployeesToBePromoted(myEmployees, x => x.ExperianceInYears >= 5);
            Console.WriteLine();
            Employee.DisplayEmployeesToBePromoted(myEmployees, x => x.Salary >= 15000);
        }
    }
}
