using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Linq_to_SQL
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //GridView1.DataSource = from Employee in  dbContext.Employees
            //                       where Employee.Gender =="Male"
            //                       orderby Employee.Salary descending
            //                       select Employee;
            GridView1.DataBind();
        }

        private void GetData()
        {
            SampleDataContext dbContext = new SampleDataContext();
            GridView1.DataSource = dbContext.Employees;
            GridView1.DataBind();
        }

        protected void btnGetData_Click(object sender, EventArgs e)
        {
            GetData();
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                Employee newEmployee = new Employee
                {
                    FirstName = "Tim",
                    LastName = "Jonathan",
                    Gender = "Male",
                    Salary = 5500,
                    DepartmentId = 1
                };

                dbContext.Employees.InsertOnSubmit(newEmployee);
                dbContext.SubmitChanges();
            }

            GetData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                // insert any id exist on database
                Employee employee = dbContext.Employees.SingleOrDefault(x => x.ID == 1002);
                employee.Salary = 6999;
                dbContext.SubmitChanges();
            }

            GetData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                // insert any desired ID exist on database
                Employee employee = dbContext.Employees.SingleOrDefault(x => x.ID == 1004);
                dbContext.Employees.DeleteOnSubmit(employee);
                dbContext.SubmitChanges();
            }

            GetData();
        }
    }
}