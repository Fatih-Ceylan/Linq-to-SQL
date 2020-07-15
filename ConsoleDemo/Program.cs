using System;

namespace LazyLoadConsoleDemo
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
