using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ConcurrencyDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAccountsData();
            }
        }

        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            using (ConcurrencyDataContext db = new ConcurrencyDataContext())
            {
                Account account = db.Accounts.FirstOrDefault(x => x.AccountNumber == 1);

                account.AccountBalance = account.AccountBalance + 500;
                db.SubmitChanges();
            }

        }

        private void GetAccountsData()
        {
            using (ConcurrencyDataContext db = new ConcurrencyDataContext())
            {
                Account account = db.Accounts.FirstOrDefault(x => x.AccountNumber == 1);

                lblAccountNumber.Text = account.AccountNumber.ToString();
                lblAccountName.Text = account.AccountNumber.ToString();
                lblAccountBalance.Text = account.AccountBalance.ToString();
            }
        }
    }
}