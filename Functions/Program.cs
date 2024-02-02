using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Employee> cashiers = new Employee[]
            {
                new Employee { Id = 1, FirstName = "Adam", LastName = "Nowak"},
                new Employee { Id = 1, FirstName = "Michal", LastName = "Kowal"},
                new Employee { Id = 1, FirstName = "Marcin", LastName = "Tak"},
                new Employee { Id = 1, FirstName = "Jan", LastName = "Krzak"}
            };
            IEnumerable<Employee> managers = new Employee[]
            {
                new Employee { Id = 1, FirstName = "Ola", LastName = "Nowak"},
                new Employee { Id = 1, FirstName = "Ada", LastName = "Kowal"},
                new Employee { Id = 1, FirstName = "Maja", LastName = "Kwas"}
            };

            //named method
            foreach (var person in cashiers.Where(StartsWithM))
            {
                Console.WriteLine(person.FirstName);
            }

            //annonymous method
            foreach (var person in cashiers.Where(delegate(Employee employee) {
                    return employee.FirstName.StartsWith("M");
                    }
                ))
            {
                Console.WriteLine(person.FirstName);
            }

            //lambda
            foreach (var person in cashiers.Where(p => p.FirstName.StartsWith("M")))
            {
                Console.WriteLine(person.FirstName);
            }

            Func<int, int> pot = x => x * x;
            Console.WriteLine(pot(2));

            Func<int, int, int> add = (x, y) => x + y;
            Func<int, int, int> add2 = (x, y) =>
            {
                var result = x + y;
                return result;
            };
            Console.WriteLine(add(2, 3));


            //return void
            Action<int> write = x => Console.WriteLine(x);
        }

        private static bool StartsWithM(Employee employee)
        {
            return employee.FirstName.StartsWith("M");
        }
    }
}
