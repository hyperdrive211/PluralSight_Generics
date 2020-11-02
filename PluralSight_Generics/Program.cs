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

            Console.WriteLine("Results for hashsets");

            HashSet<Employee> set = new HashSet<Employee>();
            var emp = new Employee("Scott");
            set.Add(emp);
            set.Add(emp);


            //When looping this structure the expectation will be that only one record will be returned. 
            //this is because the hashSet only allows unique values to be added; 
            foreach (var item in set) {
                Console.WriteLine(item.Name); 
            }

            //Code for Dictionaries
            Dictionary <string, Employee> employeeByName = new Dictionary<string, Employee>();
            employeeByName.Add("Scott", new Employee("Scott"));
            employeeByName.Add("Alan", new Employee("Alan"));
            employeeByName.Add("Joy", new Employee("Joy"));


            Employee scott = employeeByName["Scott"];

            foreach (var item in employeeByName) {
                Console.WriteLine("{0}:{1}", item.Key, item.Value.Name); 

            }

            //Inserting a list into a dictionary

            Dictionary<string, List<Employee>> staff = new Dictionary<string, List<Employee>>();
            staff.Add("Sales Team", new List<Employee> { new Employee("Steven"),
                                                                new Employee("Travis"),
                                                                new Employee("Shane")});

            staff.Add("Engineering Team", new List<Employee> { new Employee("Shaun"),
                                                               new Employee("James"),
                                                                new Employee("Richard")}); 



        }
    }
}
