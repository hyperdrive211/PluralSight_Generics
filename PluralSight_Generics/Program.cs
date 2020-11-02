using System;
using System.Collections.Generic;

namespace PluralSight_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee> {
                new Employee("Scott"), new Employee("Alex")
            };

            employees.Add(new Employee("Johnny"));

            Console.WriteLine("Foreach loop"); 

            foreach (var employee in employees) {
                Console.WriteLine(employee.Name); 
            }

            Console.WriteLine("For loop");
            for (int i = 0; i < employees.Count; i++) {
                Console.WriteLine(employees[i].Name); 
            }


            //Code for Generic Data Structure Queue

            Queue<Employee> line = new Queue<Employee>();
            line.Enqueue(new Employee("Steven"));
            line.Enqueue(new Employee("Jmaes"));
            line.Enqueue(new Employee("Mathew"));

            while (line.Count > 0) {
                var employee = line.Dequeue();
                Console.WriteLine("Employee removed from the queue " + employee.Name);
            }

            Console.WriteLine("Stack implementation");
            Stack<Employee> stack = new Stack<Employee>();
            stack.Push(new Employee("Robert"));
            stack.Push(new Employee("Charles"));
            stack.Push(new Employee("Louis"));

            
            while (stack.Count > 0) {
                var peeked = stack.Pop();
                Console.WriteLine(peeked.Name);
            }


        }
    }
}
