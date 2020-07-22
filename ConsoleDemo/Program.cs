using System;
namespace LazyLoadConsoleDemo

{
    class Program
    {
        static void Main(string[] args)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                #region Eager Loading
                dbContext.Log = Console.Out;
                //dbContext.Log = Console.Out;
                //// Load related Employee entities along with the Department entity
                //DataLoadOptions loadOptions = new DataLoadOptions();
                //loadOptions.LoadWith<Department>(d => d.Employees);
                //dbContext.LoadOptions = loadOptions;

                #endregion

                #region Lazy Loading

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
                #endregion
            }
        }
    }
}
