using System;

namespace PluralSight_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employess = new Employee[] {
                new Employee("Scott"),
                new Employee("Alex")
            };

            foreach (var employee in employess) {
                Console.WriteLine(employee.Name); 
            }
        }
    }
}
