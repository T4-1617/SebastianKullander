namespace OnlineBanking
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnWithdrawMoney = new System.Windows.Forms.Button();
            this.btnAccountBalance = new System.Windows.Forms.Button();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.btnDepositMoney = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlOpenAccount = new System.Windows.Forms.Panel();
            this.txbAccountName = new System.Windows.Forms.TextBox();
            this.pnlWithdrawMoney = new System.Windows.Forms.Panel();
            this.txbWithdrawMoney = new System.Windows.Forms.TextBox();
            this.pnlDepositMoney = new System.Windows.Forms.Panel();
            this.txbDepositMoney = new System.Windows.Forms.TextBox();
            this.pnlAccountBalance = new System.Windows.Forms.Panel();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.pnlNewCustomer = new System.Windows.Forms.Panel();
            this.txPersonalID = new System.Windows.Forms.TextBox();
            this.txbPersonalID = new System.Windows.Forms.Label();
            this.txbLastName = new System.Windows.Forms.TextBox();
            this.txbFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.txbFirstDeposit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbxTransactions = new System.Windows.Forms.ListBox();
            this.pnlOpenAccount.SuspendLayout();
            this.pnlWithdrawMoney.SuspendLayout();
            this.pnlDepositMoney.SuspendLayout();
            this.pnlAccountBalance.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlNewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Välj användarroll:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kund",
            "Anställd"});
            this.comboBox1.Location = new System.Drawing.Point(193, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnWithdrawMoney
            // 
            this.btnWithdrawMoney.Enabled = false;
            this.btnWithdrawMoney.Location = new System.Drawing.Point(12, 282);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(89, 69);
            this.btnWithdrawMoney.TabIndex = 2;
            this.btnWithdrawMoney.Text = "Ta ut $";
            this.btnWithdrawMoney.UseVisualStyleBackColor = true;
            // 
            // btnAccountBalance
            // 
            this.btnAccountBalance.Enabled = false;
            this.btnAccountBalance.Location = new System.Drawing.Point(12, 357);
            this.btnAccountBalance.Name = "btnAccountBalance";
            this.btnAccountBalance.Size = new System.Drawing.Size(89, 69);
            this.btnAccountBalance.TabIndex = 3;
            this.btnAccountBalance.Text = "Saldo";
            this.btnAccountBalance.UseVisualStyleBackColor = true;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Enabled = false;
            this.btnOpenAccount.Location = new System.Drawing.Point(12, 132);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(89, 69);
            this.btnOpenAccount.TabIndex = 4;
            this.btnOpenAccount.Text = "Öppna konto";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.Enabled = false;
            this.btnDepositMoney.Location = new System.Drawing.Point(12, 207);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(89, 69);
            this.btnDepositMoney.TabIndex = 5;
            this.btnDepositMoney.Text = "Sätt in $";
            this.btnDepositMoney.UseVisualStyleBackColor = true;
            // 
            // btnTransactions
            // 
            this.btnTransactions.Enabled = false;
            this.btnTransactions.Location = new System.Drawing.Point(12, 449);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(89, 69);
            this.btnTransactions.TabIndex = 6;
            this.btnTransactions.Text = "Engagemang";
            this.btnTransactions.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(812, 81);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 160);
            this.listBox1.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(812, 298);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 160);
            this.listBox2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(846, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Välj Kund";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(855, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Välj konto";
            // 
            // pnlOpenAccount
            // 
            this.pnlOpenAccount.Controls.Add(this.txbFirstDeposit);
            this.pnlOpenAccount.Controls.Add(this.label6);
            this.pnlOpenAccount.Controls.Add(this.label7);
            this.pnlOpenAccount.Controls.Add(this.txbAccountName);
            this.pnlOpenAccount.Location = new System.Drawing.Point(107, 57);
            this.pnlOpenAccount.Name = "pnlOpenAccount";
            this.pnlOpenAccount.Size = new System.Drawing.Size(325, 252);
            this.pnlOpenAccount.TabIndex = 11;
            // 
            // txbAccountName
            // 
            this.txbAccountName.Location = new System.Drawing.Point(118, 24);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(100, 20);
            this.txbAccountName.TabIndex = 16;
            // 
            // pnlWithdrawMoney
            // 
            this.pnlWithdrawMoney.Controls.Add(this.label9);
            this.pnlWithdrawMoney.Controls.Add(this.txbWithdrawMoney);
            this.pnlWithdrawMoney.Location = new System.Drawing.Point(107, 315);
            this.pnlWithdrawMoney.Name = "pnlWithdrawMoney";
            this.pnlWithdrawMoney.Size = new System.Drawing.Size(325, 175);
            this.pnlWithdrawMoney.TabIndex = 12;
            // 
            // txbWithdrawMoney
            // 
            this.txbWithdrawMoney.Location = new System.Drawing.Point(163, 16);
            this.txbWithdrawMoney.Name = "txbWithdrawMoney";
            this.txbWithdrawMoney.Size = new System.Drawing.Size(100, 20);
            this.txbWithdrawMoney.TabIndex = 18;
            // 
            // pnlDepositMoney
            // 
            this.pnlDepositMoney.Controls.Add(this.label8);
            this.pnlDepositMoney.Controls.Add(this.txbDepositMoney);
            this.pnlDepositMoney.Location = new System.Drawing.Point(438, 57);
            this.pnlDepositMoney.Name = "pnlDepositMoney";
            this.pnlDepositMoney.Size = new System.Drawing.Size(325, 252);
            this.pnlDepositMoney.TabIndex = 13;
            // 
            // txbDepositMoney
            // 
            this.txbDepositMoney.Location = new System.Drawing.Point(116, 21);
            this.txbDepositMoney.Name = "txbDepositMoney";
            this.txbDepositMoney.Size = new System.Drawing.Size(100, 20);
            this.txbDepositMoney.TabIndex = 17;
            // 
            // pnlAccountBalance
            // 
            this.pnlAccountBalance.Controls.Add(this.lbl1);
            this.pnlAccountBalance.Location = new System.Drawing.Point(438, 315);
            this.pnlAccountBalance.Name = "pnlAccountBalance";
            this.pnlAccountBalance.Size = new System.Drawing.Size(325, 175);
            this.pnlAccountBalance.TabIndex = 14;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.lbxTransactions);
            this.pnlTransactions.Controls.Add(this.label10);
            this.pnlTransactions.Location = new System.Drawing.Point(107, 496);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(325, 174);
            this.pnlTransactions.TabIndex = 15;
            // 
            // pnlNewCustomer
            // 
            this.pnlNewCustomer.Controls.Add(this.txPersonalID);
            this.pnlNewCustomer.Controls.Add(this.txbPersonalID);
            this.pnlNewCustomer.Controls.Add(this.txbLastName);
            this.pnlNewCustomer.Controls.Add(this.txbFirstName);
            this.pnlNewCustomer.Controls.Add(this.label5);
            this.pnlNewCustomer.Controls.Add(this.label4);
            this.pnlNewCustomer.Location = new System.Drawing.Point(438, 496);
            this.pnlNewCustomer.Name = "pnlNewCustomer";
            this.pnlNewCustomer.Size = new System.Drawing.Size(325, 174);
            this.pnlNewCustomer.TabIndex = 21;
            // 
            // txPersonalID
            // 
            this.txPersonalID.Location = new System.Drawing.Point(144, 82);
            this.txPersonalID.Name = "txPersonalID";
            this.txPersonalID.Size = new System.Drawing.Size(100, 20);
            this.txPersonalID.TabIndex = 22;
            // 
            // txbPersonalID
            // 
            this.txbPersonalID.AutoSize = true;
            this.txbPersonalID.Location = new System.Drawing.Point(17, 89);
            this.txbPersonalID.Name = "txbPersonalID";
            this.txbPersonalID.Size = new System.Drawing.Size(80, 13);
            this.txbPersonalID.TabIndex = 21;
            this.txbPersonalID.Text = "Personnummer:";
            // 
            // txbLastName
            // 
            this.txbLastName.Location = new System.Drawing.Point(144, 49);
            this.txbLastName.Name = "txbLastName";
            this.txbLastName.Size = new System.Drawing.Size(100, 20);
            this.txbLastName.TabIndex = 4;
            // 
            // txbFirstName
            // 
            this.txbFirstName.Location = new System.Drawing.Point(144, 19);
            this.txbFirstName.Name = "txbFirstName";
            this.txbFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbFirstName.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Efternamn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Förnamn:";
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Enabled = false;
            this.btnNewCustomer.Location = new System.Drawing.Point(12, 57);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(89, 69);
            this.btnNewCustomer.TabIndex = 22;
            this.btnNewCustomer.Text = "Ny kund";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            // 
            // txbFirstDeposit
            // 
            this.txbFirstDeposit.Location = new System.Drawing.Point(118, 88);
            this.txbFirstDeposit.Name = "txbFirstDeposit";
            this.txbFirstDeposit.Size = new System.Drawing.Size(100, 20);
            this.txbFirstDeposit.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Konto namn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Sätt in belopp:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Sätt in belopp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Ta ut belopp:";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(27, 23);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 13);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Ditt saldo är:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Transactions";
            // 
            // lbxTransactions
            // 
            this.lbxTransactions.FormattingEnabled = true;
            this.lbxTransactions.Location = new System.Drawing.Point(21, 25);
            this.lbxTransactions.Name = "lbxTransactions";
            this.lbxTransactions.Size = new System.Drawing.Size(277, 95);
            this.lbxTransactions.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 741);
            this.Controls.Add(this.btnNewCustomer);
            this.Controls.Add(this.pnlNewCustomer);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.pnlAccountBalance);
            this.Controls.Add(this.pnlDepositMoney);
            this.Controls.Add(this.pnlWithdrawMoney);
            this.Controls.Add(this.pnlOpenAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnDepositMoney);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.btnAccountBalance);
            this.Controls.Add(this.btnWithdrawMoney);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOpenAccount.ResumeLayout(false);
            this.pnlOpenAccount.PerformLayout();
            this.pnlWithdrawMoney.ResumeLayout(false);
            this.pnlWithdrawMoney.PerformLayout();
            this.pnlDepositMoney.ResumeLayout(false);
            this.pnlDepositMoney.PerformLayout();
            this.pnlAccountBalance.ResumeLayout(false);
            this.pnlAccountBalance.PerformLayout();
            this.pnlTransactions.ResumeLayout(false);
            this.pnlTransactions.PerformLayout();
            this.pnlNewCustomer.ResumeLayout(false);
            this.pnlNewCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnWithdrawMoney;
        private System.Windows.Forms.Button btnAccountBalance;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Button btnDepositMoney;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlOpenAccount;
        private System.Windows.Forms.Panel pnlWithdrawMoney;
        private System.Windows.Forms.Panel pnlDepositMoney;
        private System.Windows.Forms.Panel pnlAccountBalance;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.TextBox txbAccountName;
        private System.Windows.Forms.TextBox txbWithdrawMoney;
        private System.Windows.Forms.TextBox txbDepositMoney;
        private System.Windows.Forms.Panel pnlNewCustomer;
        private System.Windows.Forms.TextBox txbLastName;
        private System.Windows.Forms.TextBox txbFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.TextBox txPersonalID;
        private System.Windows.Forms.Label txbPersonalID;
        private System.Windows.Forms.TextBox txbFirstDeposit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.ListBox lbxTransactions;
        private System.Windows.Forms.Label label10;
    }
}

