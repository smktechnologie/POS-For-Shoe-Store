using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pos
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen=false;
            foreach (Form f in Application.OpenForms)
            {
                if(f.Text == "Products")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if(!IsOpen)
            {
                Product f2 = new Product();
                f2.MdiParent = this;
                f2.Show();

            }
        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Expense")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                Expense f2 = new Expense();
                f2.MdiParent = this;
                f2.Show();

            }
        }

        private void inventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Purchase")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                Purchase f2 = new Purchase();
                f2.MdiParent = this;
                f2.Show();

            }
        }

        private void sellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Order")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                Order f2 = new Order();
                f2.MdiParent = this;
                f2.Show();

            }
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "User")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                User f2 = new User();
                f2.MdiParent = this;
                f2.Show();

            }
        }


        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "AccountTransaction")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                AccountTransaction f2 = new AccountTransaction();
                f2.MdiParent = this;
                f2.Show();

            }

        }

        private void manageAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Accounts")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                Accounts f2 = new Accounts();
                f2.MdiParent = this;
                f2.Show();

            }
        }

        private void viewTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "View Transations")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                ViewTransations f2 = new ViewTransations();
                f2.MdiParent = this;
                f2.Show();

            }
        }

        private void payrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Payroll")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                Payroll f2 = new Payroll();
                f2.MdiParent = this;
                f2.Show();

            }
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Report Purchase")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                ReportPurchase f2 = new ReportPurchase();
                f2.MdiParent = this;
                f2.Show();

            }
        }

        private void sellToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Report Sell")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                ReportSell f2 = new ReportSell();
                f2.MdiParent = this;
                f2.Show();

            }
        }

        private void expenseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Report Expense")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                ReportExpense f2 = new ReportExpense();
                f2.MdiParent = this;
                f2.Show();

            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if (f.Text == "Dashboard")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                Dashboard f2 = new Dashboard();
                f2.MdiParent = this;
                f2.Show();

            }
        }
    }
}
