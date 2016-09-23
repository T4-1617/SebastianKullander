using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineBanking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Kund":
                    DisplayPanels(true, true, true, true, false);
                    ToggleButtons(true, true, true, true, false);
                    break;

                case "Anställd":
                    DisplayPanels(true, false, false, false, true);
                    ToggleButtons(true, false, false, false, true);
                    break;
            }

        }

        private void DisplayPanels(bool pnlOpenAccountBool, bool pnlDepositMoneyBool, bool pnlWithdrawMoneyBool, bool pnlAccountBalanceBool, bool pnlTransactionsBool)
        {
            pnlOpenAccount.Visible = pnlOpenAccountBool;
            pnlDepositMoney.Visible = pnlDepositMoneyBool;
            pnlWithdrawMoney.Visible = pnlWithdrawMoneyBool;
            pnlAccountBalance.Visible = pnlAccountBalanceBool;
            pnlTransactions.Visible = pnlTransactionsBool;

        }

        private void ToggleButtons(bool btnOpenAccountBool, bool btnDepositMoneyBool, bool btnWithdrawMoneyBool, bool btnAccountBalanceBool, bool btnTransactionsBool)
        {
            btnOpenAccount.Enabled = btnOpenAccountBool;
            btnDepositMoney.Enabled = btnDepositMoneyBool;
            btnWithdrawMoney.Enabled = btnWithdrawMoneyBool;
            btnAccountBalance.Enabled = btnAccountBalanceBool;
            btnTransactions.Enabled = btnTransactionsBool;
        }
    }
}
