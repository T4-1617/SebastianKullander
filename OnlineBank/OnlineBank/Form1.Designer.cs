namespace OnlineBank
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
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnAccountBlanace = new System.Windows.Forms.Button();
            this.btnWithdrawMoney = new System.Windows.Forms.Button();
            this.btnDepositMoney = new System.Windows.Forms.Button();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlNewCustomer = new System.Windows.Forms.Panel();
            this.pnlOpenAccount = new System.Windows.Forms.Panel();
            this.pnlDepositMoney = new System.Windows.Forms.Panel();
            this.pnlWithdrawMoney = new System.Windows.Forms.Panel();
            this.pnlAccountBalance = new System.Windows.Forms.Panel();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbCustomerFirstName = new System.Windows.Forms.TextBox();
            this.txbCustomerLastName = new System.Windows.Forms.TextBox();
            this.txbCustomerID = new System.Windows.Forms.TextBox();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAccountName = new System.Windows.Forms.TextBox();
            this.txbFirstDeposit = new System.Windows.Forms.TextBox();
            this.btnAccountAdd = new System.Windows.Forms.Button();
            this.btnAccountCancel = new System.Windows.Forms.Button();
            this.txbDepositMoney = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbWithdrawMoney = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDepositCancel = new System.Windows.Forms.Button();
            this.btnDepositAdd = new System.Windows.Forms.Button();
            this.btnWithdrawCancel = new System.Windows.Forms.Button();
            this.btnWithdrawAdd = new System.Windows.Forms.Button();
            this.label2000 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbxTransactions = new System.Windows.Forms.ListBox();
            this.lbxCustomer = new System.Windows.Forms.ListBox();
            this.lbxAccount = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.pnlNewCustomer.SuspendLayout();
            this.pnlOpenAccount.SuspendLayout();
            this.pnlDepositMoney.SuspendLayout();
            this.pnlWithdrawMoney.SuspendLayout();
            this.pnlAccountBalance.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(12, 486);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(90, 84);
            this.btnTransactions.TabIndex = 11;
            this.btnTransactions.Text = "Transaktioner";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnAccountBlanace
            // 
            this.btnAccountBlanace.Location = new System.Drawing.Point(12, 372);
            this.btnAccountBlanace.Name = "btnAccountBlanace";
            this.btnAccountBlanace.Size = new System.Drawing.Size(90, 84);
            this.btnAccountBlanace.TabIndex = 10;
            this.btnAccountBlanace.Text = "Saldo";
            this.btnAccountBlanace.UseVisualStyleBackColor = true;
            this.btnAccountBlanace.Click += new System.EventHandler(this.btnAccountBlanace_Click);
            // 
            // btnWithdrawMoney
            // 
            this.btnWithdrawMoney.Location = new System.Drawing.Point(12, 282);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(90, 84);
            this.btnWithdrawMoney.TabIndex = 9;
            this.btnWithdrawMoney.Text = "Ta ut";
            this.btnWithdrawMoney.UseVisualStyleBackColor = true;
            this.btnWithdrawMoney.Click += new System.EventHandler(this.btnWithdrawMoney_Click);
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.Location = new System.Drawing.Point(12, 192);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(90, 84);
            this.btnDepositMoney.TabIndex = 8;
            this.btnDepositMoney.Text = "Sätt in";
            this.btnDepositMoney.UseVisualStyleBackColor = true;
            this.btnDepositMoney.Click += new System.EventHandler(this.btnDepositMoney_Click);
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(12, 102);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(90, 84);
            this.btnOpenAccount.TabIndex = 7;
            this.btnOpenAccount.Text = "Öppna konto";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(12, 12);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(90, 84);
            this.btnNewCustomer.TabIndex = 6;
            this.btnNewCustomer.Text = "Ny kund";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Välj användarroll:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kund",
            "Anställd"});
            this.comboBox1.Location = new System.Drawing.Point(385, 45);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pnlNewCustomer
            // 
            this.pnlNewCustomer.Controls.Add(this.btnCustomerCancel);
            this.pnlNewCustomer.Controls.Add(this.btnCustomerAdd);
            this.pnlNewCustomer.Controls.Add(this.txbCustomerID);
            this.pnlNewCustomer.Controls.Add(this.txbCustomerLastName);
            this.pnlNewCustomer.Controls.Add(this.txbCustomerFirstName);
            this.pnlNewCustomer.Controls.Add(this.label2);
            this.pnlNewCustomer.Controls.Add(this.label3);
            this.pnlNewCustomer.Controls.Add(this.label4);
            this.pnlNewCustomer.Location = new System.Drawing.Point(223, 72);
            this.pnlNewCustomer.Name = "pnlNewCustomer";
            this.pnlNewCustomer.Size = new System.Drawing.Size(216, 162);
            this.pnlNewCustomer.TabIndex = 14;
            // 
            // pnlOpenAccount
            // 
            this.pnlOpenAccount.Controls.Add(this.btnAccountCancel);
            this.pnlOpenAccount.Controls.Add(this.btnAccountAdd);
            this.pnlOpenAccount.Controls.Add(this.txbFirstDeposit);
            this.pnlOpenAccount.Controls.Add(this.txbAccountName);
            this.pnlOpenAccount.Controls.Add(this.label5);
            this.pnlOpenAccount.Controls.Add(this.label6);
            this.pnlOpenAccount.Location = new System.Drawing.Point(445, 72);
            this.pnlOpenAccount.Name = "pnlOpenAccount";
            this.pnlOpenAccount.Size = new System.Drawing.Size(216, 162);
            this.pnlOpenAccount.TabIndex = 15;
            // 
            // pnlDepositMoney
            // 
            this.pnlDepositMoney.Controls.Add(this.btnDepositCancel);
            this.pnlDepositMoney.Controls.Add(this.txbDepositMoney);
            this.pnlDepositMoney.Controls.Add(this.btnDepositAdd);
            this.pnlDepositMoney.Controls.Add(this.label7);
            this.pnlDepositMoney.Location = new System.Drawing.Point(223, 240);
            this.pnlDepositMoney.Name = "pnlDepositMoney";
            this.pnlDepositMoney.Size = new System.Drawing.Size(216, 162);
            this.pnlDepositMoney.TabIndex = 15;
            // 
            // pnlWithdrawMoney
            // 
            this.pnlWithdrawMoney.Controls.Add(this.btnWithdrawCancel);
            this.pnlWithdrawMoney.Controls.Add(this.txbWithdrawMoney);
            this.pnlWithdrawMoney.Controls.Add(this.btnWithdrawAdd);
            this.pnlWithdrawMoney.Controls.Add(this.label8);
            this.pnlWithdrawMoney.Location = new System.Drawing.Point(445, 240);
            this.pnlWithdrawMoney.Name = "pnlWithdrawMoney";
            this.pnlWithdrawMoney.Size = new System.Drawing.Size(216, 162);
            this.pnlWithdrawMoney.TabIndex = 15;
            // 
            // pnlAccountBalance
            // 
            this.pnlAccountBalance.Controls.Add(this.lblAccountBalance);
            this.pnlAccountBalance.Controls.Add(this.label2000);
            this.pnlAccountBalance.Location = new System.Drawing.Point(223, 408);
            this.pnlAccountBalance.Name = "pnlAccountBalance";
            this.pnlAccountBalance.Size = new System.Drawing.Size(216, 162);
            this.pnlAccountBalance.TabIndex = 15;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.lbxTransactions);
            this.pnlTransactions.Controls.Add(this.label10);
            this.pnlTransactions.Location = new System.Drawing.Point(445, 408);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(216, 162);
            this.pnlTransactions.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Förnamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Efternamn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Personnummer:";
            // 
            // txbCustomerFirstName
            // 
            this.txbCustomerFirstName.Location = new System.Drawing.Point(103, 8);
            this.txbCustomerFirstName.Name = "txbCustomerFirstName";
            this.txbCustomerFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbCustomerFirstName.TabIndex = 19;
            // 
            // txbCustomerLastName
            // 
            this.txbCustomerLastName.Location = new System.Drawing.Point(103, 34);
            this.txbCustomerLastName.Name = "txbCustomerLastName";
            this.txbCustomerLastName.Size = new System.Drawing.Size(100, 20);
            this.txbCustomerLastName.TabIndex = 20;
            // 
            // txbCustomerID
            // 
            this.txbCustomerID.Location = new System.Drawing.Point(103, 63);
            this.txbCustomerID.Name = "txbCustomerID";
            this.txbCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txbCustomerID.TabIndex = 21;
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(18, 120);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerAdd.TabIndex = 22;
            this.btnCustomerAdd.Text = "Lägg till";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerCancel
            // 
            this.btnCustomerCancel.Location = new System.Drawing.Point(128, 120);
            this.btnCustomerCancel.Name = "btnCustomerCancel";
            this.btnCustomerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerCancel.TabIndex = 23;
            this.btnCustomerCancel.Text = "Avbryt";
            this.btnCustomerCancel.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kontonamn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "sätt in belopp:";
            // 
            // txbAccountName
            // 
            this.txbAccountName.Location = new System.Drawing.Point(96, 13);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(100, 20);
            this.txbAccountName.TabIndex = 18;
            // 
            // txbFirstDeposit
            // 
            this.txbFirstDeposit.Location = new System.Drawing.Point(96, 39);
            this.txbFirstDeposit.Name = "txbFirstDeposit";
            this.txbFirstDeposit.Size = new System.Drawing.Size(100, 20);
            this.txbFirstDeposit.TabIndex = 19;
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.Location = new System.Drawing.Point(20, 120);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAccountAdd.TabIndex = 24;
            this.btnAccountAdd.Text = "Lägg till";
            this.btnAccountAdd.UseVisualStyleBackColor = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // btnAccountCancel
            // 
            this.btnAccountCancel.Location = new System.Drawing.Point(121, 120);
            this.btnAccountCancel.Name = "btnAccountCancel";
            this.btnAccountCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAccountCancel.TabIndex = 24;
            this.btnAccountCancel.Text = "Avbryt";
            this.btnAccountCancel.UseVisualStyleBackColor = true;
            // 
            // txbDepositMoney
            // 
            this.txbDepositMoney.Location = new System.Drawing.Point(103, 10);
            this.txbDepositMoney.Name = "txbDepositMoney";
            this.txbDepositMoney.Size = new System.Drawing.Size(100, 20);
            this.txbDepositMoney.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sätt in belopp:";
            // 
            // txbWithdrawMoney
            // 
            this.txbWithdrawMoney.Location = new System.Drawing.Point(100, 10);
            this.txbWithdrawMoney.Name = "txbWithdrawMoney";
            this.txbWithdrawMoney.Size = new System.Drawing.Size(100, 20);
            this.txbWithdrawMoney.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ta ut belopp:";
            // 
            // btnDepositCancel
            // 
            this.btnDepositCancel.Location = new System.Drawing.Point(126, 121);
            this.btnDepositCancel.Name = "btnDepositCancel";
            this.btnDepositCancel.Size = new System.Drawing.Size(75, 23);
            this.btnDepositCancel.TabIndex = 25;
            this.btnDepositCancel.Text = "Avbryt";
            this.btnDepositCancel.UseVisualStyleBackColor = true;
            // 
            // btnDepositAdd
            // 
            this.btnDepositAdd.Location = new System.Drawing.Point(16, 121);
            this.btnDepositAdd.Name = "btnDepositAdd";
            this.btnDepositAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDepositAdd.TabIndex = 24;
            this.btnDepositAdd.Text = "Lägg till";
            this.btnDepositAdd.UseVisualStyleBackColor = true;
            this.btnDepositAdd.Click += new System.EventHandler(this.btnDepositAdd_Click);
            // 
            // btnWithdrawCancel
            // 
            this.btnWithdrawCancel.Location = new System.Drawing.Point(125, 121);
            this.btnWithdrawCancel.Name = "btnWithdrawCancel";
            this.btnWithdrawCancel.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawCancel.TabIndex = 27;
            this.btnWithdrawCancel.Text = "Avbryt";
            this.btnWithdrawCancel.UseVisualStyleBackColor = true;
            // 
            // btnWithdrawAdd
            // 
            this.btnWithdrawAdd.Location = new System.Drawing.Point(15, 121);
            this.btnWithdrawAdd.Name = "btnWithdrawAdd";
            this.btnWithdrawAdd.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawAdd.TabIndex = 26;
            this.btnWithdrawAdd.Text = "Lägg till";
            this.btnWithdrawAdd.UseVisualStyleBackColor = true;
            // 
            // label2000
            // 
            this.label2000.AutoSize = true;
            this.label2000.Location = new System.Drawing.Point(18, 16);
            this.label2000.Name = "label2000";
            this.label2000.Size = new System.Drawing.Size(66, 13);
            this.label2000.TabIndex = 26;
            this.label2000.Text = "Ditt saldo är:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Transaktioner";
            // 
            // lbxTransactions
            // 
            this.lbxTransactions.FormattingEnabled = true;
            this.lbxTransactions.Location = new System.Drawing.Point(15, 32);
            this.lbxTransactions.Name = "lbxTransactions";
            this.lbxTransactions.Size = new System.Drawing.Size(181, 108);
            this.lbxTransactions.TabIndex = 28;
            // 
            // lbxCustomer
            // 
            this.lbxCustomer.FormattingEnabled = true;
            this.lbxCustomer.Location = new System.Drawing.Point(698, 138);
            this.lbxCustomer.Name = "lbxCustomer";
            this.lbxCustomer.Size = new System.Drawing.Size(181, 108);
            this.lbxCustomer.TabIndex = 29;
            this.lbxCustomer.SelectedIndexChanged += new System.EventHandler(this.lbxCustomer_SelectedIndexChanged);
            // 
            // lbxAccount
            // 
            this.lbxAccount.FormattingEnabled = true;
            this.lbxAccount.Location = new System.Drawing.Point(698, 372);
            this.lbxAccount.Name = "lbxAccount";
            this.lbxAccount.Size = new System.Drawing.Size(181, 108);
            this.lbxAccount.TabIndex = 30;
            this.lbxAccount.SelectedIndexChanged += new System.EventHandler(this.lbxAccount_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(753, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "Välj Kund:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(753, 353);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "Välj konto:";
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(90, 16);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(35, 13);
            this.lblAccountBalance.TabIndex = 27;
            this.lblAccountBalance.Text = "label9";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 789);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbxCustomer);
            this.Controls.Add(this.lbxAccount);
            this.Controls.Add(this.pnlOpenAccount);
            this.Controls.Add(this.pnlDepositMoney);
            this.Controls.Add(this.pnlWithdrawMoney);
            this.Controls.Add(this.pnlAccountBalance);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.pnlNewCustomer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnAccountBlanace);
            this.Controls.Add(this.btnWithdrawMoney);
            this.Controls.Add(this.btnDepositMoney);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.btnNewCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlNewCustomer.ResumeLayout(false);
            this.pnlNewCustomer.PerformLayout();
            this.pnlOpenAccount.ResumeLayout(false);
            this.pnlOpenAccount.PerformLayout();
            this.pnlDepositMoney.ResumeLayout(false);
            this.pnlDepositMoney.PerformLayout();
            this.pnlWithdrawMoney.ResumeLayout(false);
            this.pnlWithdrawMoney.PerformLayout();
            this.pnlAccountBalance.ResumeLayout(false);
            this.pnlAccountBalance.PerformLayout();
            this.pnlTransactions.ResumeLayout(false);
            this.pnlTransactions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnAccountBlanace;
        private System.Windows.Forms.Button btnWithdrawMoney;
        private System.Windows.Forms.Button btnDepositMoney;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel pnlNewCustomer;
        private System.Windows.Forms.Button btnCustomerCancel;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.TextBox txbCustomerID;
        private System.Windows.Forms.TextBox txbCustomerLastName;
        private System.Windows.Forms.TextBox txbCustomerFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlOpenAccount;
        private System.Windows.Forms.Button btnAccountCancel;
        private System.Windows.Forms.Button btnAccountAdd;
        private System.Windows.Forms.TextBox txbFirstDeposit;
        private System.Windows.Forms.TextBox txbAccountName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlDepositMoney;
        private System.Windows.Forms.Button btnDepositCancel;
        private System.Windows.Forms.TextBox txbDepositMoney;
        private System.Windows.Forms.Button btnDepositAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlWithdrawMoney;
        private System.Windows.Forms.Button btnWithdrawCancel;
        private System.Windows.Forms.TextBox txbWithdrawMoney;
        private System.Windows.Forms.Button btnWithdrawAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlAccountBalance;
        private System.Windows.Forms.Label label2000;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.ListBox lbxTransactions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbxCustomer;
        private System.Windows.Forms.ListBox lbxAccount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblAccountBalance;
    }
}

