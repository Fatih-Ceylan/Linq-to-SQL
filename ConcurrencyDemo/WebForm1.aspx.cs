﻿using System;
using System.Data.Linq;
using System.Linq;

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
                try
                {
                    Account account = db.Accounts.FirstOrDefault(x => x.AccountNumber == 1);

                    account.AccountBalance = account.AccountBalance + 500;
                    db.SubmitChanges();

                    GetAccountsData();
                }
                catch (ChangeConflictException)
                {

                    db.ChangeConflicts.ResolveAll(RefreshMode.KeepCurrentValues);
                }
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