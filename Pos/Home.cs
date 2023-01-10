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
                if (f.Text == "Inventory")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }

            if (!IsOpen)
            {
                Inventory f2 = new Inventory();
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

        private void accountsToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}
