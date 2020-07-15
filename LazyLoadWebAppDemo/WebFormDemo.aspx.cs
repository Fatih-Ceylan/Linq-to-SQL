using System;

namespace LazyLoadWebAppDemo
{
    public partial class WebFormDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            using (WebAppSampleDataContext dbContext = new WebAppSampleDataContext())
            {
                // Log the sql query
                dbContext.Log = Response.Output;

                GridView1.DataSource = dbContext.Departments;
                GridView1.DataBind();
            }
        }
    }
}