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
            this.pnlWithdrawMoney = new System.Windows.Forms.Panel();
            this.pnlDepositMoney = new System.Windows.Forms.Panel();
            this.pnlAccountBalance = new System.Windows.Forms.Panel();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.pnlOpenAccount.SuspendLayout();
            this.pnlWithdrawMoney.SuspendLayout();
            this.pnlDepositMoney.SuspendLayout();
            this.pnlAccountBalance.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
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
            this.btnWithdrawMoney.Location = new System.Drawing.Point(12, 207);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(89, 69);
            this.btnWithdrawMoney.TabIndex = 2;
            this.btnWithdrawMoney.Text = "Ta ut $";
            this.btnWithdrawMoney.UseVisualStyleBackColor = true;
            // 
            // btnAccountBalance
            // 
            this.btnAccountBalance.Enabled = false;
            this.btnAccountBalance.Location = new System.Drawing.Point(12, 282);
            this.btnAccountBalance.Name = "btnAccountBalance";
            this.btnAccountBalance.Size = new System.Drawing.Size(89, 69);
            this.btnAccountBalance.TabIndex = 3;
            this.btnAccountBalance.Text = "Saldo";
            this.btnAccountBalance.UseVisualStyleBackColor = true;
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Enabled = false;
            this.btnOpenAccount.Location = new System.Drawing.Point(12, 57);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(89, 69);
            this.btnOpenAccount.TabIndex = 4;
            this.btnOpenAccount.Text = "Öppna konto";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.Enabled = false;
            this.btnDepositMoney.Location = new System.Drawing.Point(12, 132);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(89, 69);
            this.btnDepositMoney.TabIndex = 5;
            this.btnDepositMoney.Text = "Sätt in $";
            this.btnDepositMoney.UseVisualStyleBackColor = true;
            // 
            // btnTransactions
            // 
            this.btnTransactions.Enabled = false;
            this.btnTransactions.Location = new System.Drawing.Point(12, 374);
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
            this.pnlOpenAccount.Controls.Add(this.textBox1);
            this.pnlOpenAccount.Location = new System.Drawing.Point(107, 57);
            this.pnlOpenAccount.Name = "pnlOpenAccount";
            this.pnlOpenAccount.Size = new System.Drawing.Size(325, 252);
            this.pnlOpenAccount.TabIndex = 11;
            // 
            // pnlWithdrawMoney
            // 
            this.pnlWithdrawMoney.Controls.Add(this.textBox3);
            this.pnlWithdrawMoney.Location = new System.Drawing.Point(107, 315);
            this.pnlWithdrawMoney.Name = "pnlWithdrawMoney";
            this.pnlWithdrawMoney.Size = new System.Drawing.Size(325, 252);
            this.pnlWithdrawMoney.TabIndex = 12;
            // 
            // pnlDepositMoney
            // 
            this.pnlDepositMoney.Controls.Add(this.textBox2);
            this.pnlDepositMoney.Location = new System.Drawing.Point(438, 57);
            this.pnlDepositMoney.Name = "pnlDepositMoney";
            this.pnlDepositMoney.Size = new System.Drawing.Size(325, 252);
            this.pnlDepositMoney.TabIndex = 13;
            // 
            // pnlAccountBalance
            // 
            this.pnlAccountBalance.Controls.Add(this.textBox4);
            this.pnlAccountBalance.Location = new System.Drawing.Point(438, 315);
            this.pnlAccountBalance.Name = "pnlAccountBalance";
            this.pnlAccountBalance.Size = new System.Drawing.Size(325, 252);
            this.pnlAccountBalance.TabIndex = 14;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.textBox5);
            this.pnlTransactions.Location = new System.Drawing.Point(107, 573);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(325, 252);
            this.pnlTransactions.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(60, 100);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(133, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(36, 133);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 19;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(118, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 920);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}

