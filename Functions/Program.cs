using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            foreach (var person in cashiers.Where(StartsWithM))
            {
                Console.WriteLine(person.FirstName);
            }
        }

        private static bool StartsWithM(Employee employee)
        {
            return employee.FirstName.StartsWith("M");
        }
    }
}
