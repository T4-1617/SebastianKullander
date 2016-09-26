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
        private System.Collections.ArrayList Transactions;



        public Form1()
        {
            InitializeComponent();

            _customers = new System.Collections.ArrayList();
            Transactions = new System.Collections.ArrayList();
            //hård kodade customers o accounts
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
            DisplayAccounts(c);//anropar metoden nedan
        }
        //metod som som clearar listboxen, visar kontots namn och lägger in varje konto i listan
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
            //om textboxen inte är tom och om listboxen är iklickad gör det nedan 
            if (txbDepositMoney.Text != string.Empty)
            {
                if (lbxAccount.SelectedItem != null)
                {
                    Account a = (Account)lbxAccount.SelectedItem;//håller koll vilka man klickat på
                    Customer c = (Customer)lbxCustomer.SelectedItem;
                    a.Deposit(decimal.Parse(txbDepositMoney.Text));//lägger in pengarna
                    lblAccountBalance.Text = string.Format("{0}", a.Balance);//ändrar labeln i saldo
                    Transactions.Add(new Transaction() { CustomerName = c.FirstName, AccountName = a.AccountName,
                    TransactionAmount = decimal.Parse(txbDepositMoney.Text), TransactionType = "satt in", TransactionWord = "i" });//lägger till nu transaction och skriver ut det i listboxen
                    TogglePanels(false, false, false, false, true, false);//togglar panels till saldo
                    ClearTextBoxes();//metod
                }

            }

            else
            {
                MessageBox.Show("Var vänlig och ange ett värde!");//om inte allt är uppfyllt visa medellande
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //beroende på vad man väljer i comboboxen så toggla panels
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
        //metod som väljer vilka knappar som ska funka
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
        //metod för att toggla panels
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
        //metod för att lägga in kunder i listboxen
        private void DisplayCustomer()
        {
            lbxCustomer.Items.Clear();
            foreach (Customer item in _customers)
            {
                lbxCustomer.Items.Add(item);
            }

        }
        //metod för att cleara textboxar
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
            //togglar ny kund panelen
            TogglePanels(true, false, false, false, false, false);
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            //togglar öppna konto panelen
            TogglePanels(false, true, false, false, false, false);
        }

        private void btnDepositMoney_Click(object sender, EventArgs e)
        {
            //togglar sätt in panelen
            TogglePanels(false, false, true, false, false, false);
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            //togglar ta ut panelen
            TogglePanels(false, false, false, true, false, false);
        }

        private void btnAccountBlanace_Click(object sender, EventArgs e)
        {
            //togglar saldo panelen
            TogglePanels(false, false, false, false, true, false);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            //togglar transactions panelen
            TogglePanels(false, false, false, false, false, true);
            lbxTransactions.Items.Clear();//clearar listan och lägger in i listboxen
            foreach (Transaction item in Transactions)
            {
                lbxTransactions.Items.Add(item);
            }

        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            //om alla textboxar är ifyllda så gör det nedan
            if (txbCustomerFirstName.Text != string.Empty || txbCustomerLastName.Text != string.Empty || txbCustomerID.Text != string.Empty)
            {
                //tar emot värdena och sparar dem
                _customers.Add(new Customer() { FirstName = txbCustomerFirstName.Text, LastName = txbCustomerLastName.Text, Id = long.Parse(txbCustomerID.Text) });
                DisplayCustomer();//anropar metod som lägger in customers i listboxen
                ClearTextBoxes();//clearar textboxarna
            }

            else
            {
                //om någon textbox är tom visa medellande
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
            //om båda textboxarna är ifyllda
            if (txbAccountName.Text != string.Empty || txbFirstDeposit.Text != string.Empty)
            {
                Customer c = (Customer)lbxCustomer.SelectedItem;
                if (lbxCustomer.SelectedItem != null)//om item ilistboxen är iklickad gör nedan
                {
                    c.CreateAccount(decimal.Parse(txbFirstDeposit.Text), txbAccountName.Text);
                    ClearTextBoxes();
                    DisplayAccounts(c);
                }
            }
            //annars visa medellande
            else
            {
                MessageBox.Show("fyll i formuläret!");
            }
        }

        private void btnWithdrawAdd_Click(object sender, EventArgs e)
        {
            
            if (txbWithdrawMoney.Text != string.Empty)
            {
                Account a = (Account)lbxAccount.SelectedItem;
                Customer c = (Customer)lbxCustomer.SelectedItem;
                if (lbxAccount.SelectedItem != null)
                {
                    a.Withdraw(decimal.Parse(txbWithdrawMoney.Text));
                    lblAccountBalance.Text = string.Format("{0}", a.Balance);
                    ClearTextBoxes();
                    TogglePanels(false, false, false, false, true, false);

                    Transactions.Add(new Transaction() { CustomerName = c.FirstName, AccountName = a.AccountName,
                    TransactionAmount = decimal.Parse(txbWithdrawMoney.Text), TransactionType = "tagit ur", TransactionWord = "ur" });
                }
            }
        }

        private void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, false, false);
        }

        private void btnAccountCancel_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, false, false);
        }
    }
}
