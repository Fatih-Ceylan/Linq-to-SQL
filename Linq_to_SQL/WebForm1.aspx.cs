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
            SampleDataContext dbContext = new SampleDataContext();
            GridView1.DataSource = from Employee in  dbContext.Employees
                                   where Employee.Gender =="Male"
                                   orderby Employee.Salary descending
                                   select Employee;
            GridView1.DataBind();
        }
    }
}