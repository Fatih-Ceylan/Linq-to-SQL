using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.UI.WebControls;
namespace SingleTableInheritance
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        #region This method display all rows of Employee
        private DataTable ConvertEmployeesForDisplay(List<Employee> employees)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("AnuualSalary");
            dt.Columns.Add("HourlyPay");
            dt.Columns.Add("HoursWorked");
            dt.Columns.Add("Type");
            foreach (Employee employee in employees)
            {
                DataRow dr = dt.NewRow();
                dr["ID"] = employee.ID;
                dr["Name"] = employee.Name;
                dr["Gender"] = employee.Gender;
                if (employee is PermanentEmployee)
                {
                    dr["AnuualSalary"] = ((PermanentEmployee)employee).AnnualSalary;
                    dr["Type"] = "Permanent";
                }
                else
                {
                    dr["HourlyPay"] = ((ContractEmployee)employee).HourlyPay;
                    dr["HoursWorked"] = ((ContractEmployee)employee).HoursWorked;
                    dr["Type"] = "Contract";
                }
                dt.Rows.Add(dr);
            }
            return dt;
        }
        #endregion
        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sample2DataContext dbContext = new Sample2DataContext();
            dbContext.Log = Response.Output;
            switch (RadioButtonList1.SelectedValue)
            {
                case "Permanent":
                    GridView1.DataSource = dbContext.Employees.OfType<PermanentEmployee>().ToList();
                    GridView1.DataBind();
                    break;
                case "Contract":
                    GridView1.DataSource = dbContext.Employees.OfType<ContractEmployee>().ToList();
                    GridView1.DataBind();
                    break;
                default:
                    GridView1.DataSource = ConvertEmployeesForDisplay(dbContext.Employees.ToList());
                    GridView1.DataBind();
                    break;
            }
        }
    }
}