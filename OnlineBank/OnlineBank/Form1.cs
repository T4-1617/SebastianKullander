using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBank
{
    public partial class Form1 : Form
    {
        private System.Collections.ArrayList _customers;
        

        public Form1()
        {
            InitializeComponent();

            _customers = new System.Collections.ArrayList();

            Customer c = new Customer() { Name = "Kalle" };
            c.CreateAccount(1200);
            _customers.Add(c);

            c = new Customer() { Name = "stevon" };
            c.CreateAccount(5000);
            c.CreateAccount(3200100);
            _customers.Add(c);

            lbxCustomer.DisplayMember = "Name";
            foreach (Customer item in _customers)
            {
                lbxCustomer.Items.Add(item);
            }
        }

        private void lbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = (Customer)lbxCustomer.SelectedItem;
            DisplayAccounts(c);
        }

        private void DisplayAccounts(Customer c)
        {
            lbxAccount.Items.Clear();
            lbxAccount.DisplayMember = "AccountInfo";
            foreach (Account item in c.GetAccounts())
            {
                lbxAccount.Items.Add(item);
            }
        }


    }
}
