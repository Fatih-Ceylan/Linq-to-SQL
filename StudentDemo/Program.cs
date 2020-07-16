using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StudentDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Compiled Queries
            //var compiledStudentQuery = CompiledQuery.Compile(
            //       (StudentConsoleDemoDataContext dataContext, int studentId) =>
            //       (from s in dataContext.Students
            //        where s.ID == studentId
            //        select s).Single());
            //using (StudentConsoleDemoDataContext dbContext = new StudentConsoleDemoDataContext())
            //{
            //    /// To compile and shorten load time for this query look above
            //    //Student student = (from s in dbContext.Students where s.ID == 1 select s).Single();
            //    Student student = compiledStudentQuery(dbContext, 1);
            //    Console.WriteLine(student.FirstName + " " + student.LastName);
            //    Console.ReadKey();
            //}
            #endregion

            #region Identity Cache

            using (StudentConsoleDemoDataContext dbContext1 = new StudentConsoleDemoDataContext())
            using (StudentConsoleDemoDataContext dbContext2 = new StudentConsoleDemoDataContext())
            {
                dbContext1.Log = Console.Out;
                dbContext2.Log = Console.Out;

                Student S1 = dbContext1.Students.FirstOrDefault(x => x.ID == 1);
                Student S2 = dbContext2.Students.FirstOrDefault(x => x.ID == 1);

                Console.WriteLine("S1.FirstName= {0}", S1.FirstName);
                Console.WriteLine("S2.FirstName= {0}", S2.FirstName);

                // Student1's name is updated but student2 is not
                S1.FirstName = "Updated...";
                dbContext1.SubmitChanges();

                // after submitting changes query reloaded but there is no select query because dbcontex1 and dbcontex2 is already cached
                S2 = dbContext2.Students.FirstOrDefault(x => x.ID == 1);

                Console.WriteLine("S1.FirstName= {0}", S1.FirstName);
                Console.WriteLine("S2.FirstName= {0}", S2.FirstName);

                // that's why linq query needed refresh method
                dbContext2.Refresh(RefreshMode.OverwriteCurrentValues, S2);
                Console.WriteLine("S1.FirstName= {0}", S1.FirstName);
                Console.WriteLine("S2.FirstName= {0}", S2.FirstName);

            }

            #endregion
        }
    }
}
