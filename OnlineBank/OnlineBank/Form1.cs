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

            Customer c = new Customer() { FirstName = "kalle", LastName = "anka", Id = 1};
            c.CreateAccount(1200, "kontot");
            _customers.Add(c);

            c = new Customer() { FirstName = "stevon", LastName = "MountainBranch", Id = 2 };
            c.CreateAccount(5000, "kontot");
            c.CreateAccount(3200100, "kontot");
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
            lbxAccount.DisplayMember = "AccountName";
            foreach (Account item in c.GetAccounts())
            {
                lbxAccount.Items.Add(item);
            }
        }

        private void btnDepositAdd_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    EnableButtons(true, true, true, true, true, false);
                    lbxCustomer.Enabled = true;
                    break;

                case 1:
                    EnableButtons(true, true, false, false, false, true);
                    lbxCustomer.Enabled = true;
                    break;

                default:
                    EnableButtons(false, false, false, false, false, false);
                    lbxCustomer.Enabled = false;
                    break;
            }
        }

        private void EnableButtons(bool EnableButtonNewCustomer, bool EnableButtonOpenAccount, bool EnableButtonDepositMoney, 
        bool EnableButtonWithdrawMoney, bool EnableButtonAccountBalance, bool EnableButtonTransactions)
        {
            btnNewCustomer.Enabled = EnableButtonNewCustomer;
            btnOpenAccount.Enabled = EnableButtonOpenAccount;
            btnDepositMoney.Enabled = EnableButtonDepositMoney;
            btnWithdrawMoney.Enabled = EnableButtonWithdrawMoney;
            btnAccountBlanace.Enabled = EnableButtonAccountBalance;
            btnTransactions.Enabled = EnableButtonTransactions;
            
        }

        private void TogglePanels(bool pnlToggleNewCustomer, bool pnlToggleOpenAccount, bool pnlToggleDepositMoney,
        bool pnlToggleWithdrawMoney, bool pnlToggleAccountBlance, bool pnlToggleTransactions)
        {
            pnlNewCustomer.Visible = pnlToggleNewCustomer;
            pnlOpenAccount.Visible = pnlToggleOpenAccount;
            pnlDepositMoney.Visible = pnlToggleDepositMoney;
            pnlWithdrawMoney.Visible = pnlToggleWithdrawMoney;
            pnlAccountBalance.Visible = pnlToggleAccountBlance;
            pnlTransactions.Visible = pnlToggleTransactions;
        }

        private void DisplayCustomer()
        {
            lbxCustomer.Items.Clear();
            foreach (Customer item in _customers)
            {
                lbxCustomer.Items.Add(item);
            }

        }

        private void ClearTextBoxes()
        {
            txbCustomerFirstName.Clear();
            txbCustomerLastName.Clear();
            txbCustomerID.Clear();
            txbFirstDeposit.Clear();
            txbAccountName.Clear();
            txbDepositMoney.Clear();
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            TogglePanels(true, false, false, false, false, false);
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            TogglePanels(false, true, false, false, false, false);
        }

        private void btnDepositMoney_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, true, false, false, false);
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, true, false, false);
        }

        private void btnAccountBlanace_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, true, false);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, false, true);
           
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (txbCustomerFirstName.Text != string.Empty || txbCustomerLastName.Text != string.Empty || txbCustomerID.Text != string.Empty)
            {
                _customers.Add(new Customer() { FirstName = txbCustomerFirstName.Text, LastName = txbCustomerLastName.Text, Id = long.Parse(txbCustomerID.Text) });
                DisplayCustomer();
                ClearTextBoxes();
            }

            else
            {
                MessageBox.Show("Var vänlig och fyll i formuläret!");
            }

        }

        private void lbxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAccount.SelectedItem != null)
            {
                Account a = (Account)lbxAccount.SelectedItem;
                lblAccountBalance.Text = string.Format("{0}", a.Balance);
            }

        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            if (txbAccountName.Text != string.Empty || txbFirstDeposit.Text != string.Empty)
            {
                Customer c = (Customer)lbxCustomer.SelectedItem;
                if (lbxCustomer.SelectedItem != null)
                {
                    c.CreateAccount(decimal.Parse(txbFirstDeposit.Text), txbAccountName.Text);
                    ClearTextBoxes();
                    DisplayAccounts(c);
                }

                else
                {
                    MessageBox.Show("Välj en kund!");
                }

                if (lbxCustomer.SelectedItem != null && c.Error == true)
                {
                    MessageBox.Show("Sätt in 1000 kronor minst för att skapa ett konto!");
                }
            }

            else
            {
                MessageBox.Show("fyll i formuläret!");
            }
        }
    }
}
