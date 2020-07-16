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
            var compiledStudentQuery = CompiledQuery.Compile(
                (StudentConsoleDemoDataContext dataContext, int studentId) =>
                (from s in  dataContext.Students 
                 where s.ID == studentId 
                 select s).Single());


            using (StudentConsoleDemoDataContext dbContext = new StudentConsoleDemoDataContext())
            {
                /// To compile and shorten load time for this query look above
                //Student student = (from s in dbContext.Students where s.ID == 1 select s).Single();

                Student student = compiledStudentQuery(dbContext, 1);

                Console.WriteLine(student.FirstName + " " + student.LastName);
                Console.ReadKey();
            }
        }
    }
}
