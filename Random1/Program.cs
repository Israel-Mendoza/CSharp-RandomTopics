using System;

namespace Random1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("Israel", "Mendoza");
            Console.WriteLine($"typeof(Person) = {typeof(Person)}");
            Console.WriteLine($"p1.GetType() = {p1.GetType()}");
            Console.WriteLine($"p1 is Person = {p1 is Person}");
            Console.WriteLine($"p1 is object = {p1 is object}");
            // Console.WriteLine($"p1.Age is int = {p1.Age is float}");
        }
    }
}
