using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                dbContext.Log = Console.Out;
                foreach (Department department in dbContext.Departments)
                {
                    Console.WriteLine(department.Name);
                    foreach (Employee employee in department.Employees)
                    {
                        Console.WriteLine("\t" + employee.FirstName + " " + employee.LastName);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}
