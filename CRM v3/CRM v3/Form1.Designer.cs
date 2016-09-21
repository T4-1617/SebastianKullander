namespace CRM_v3
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
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.Cancel1 = new System.Windows.Forms.Button();
            this.btnAdd1 = new System.Windows.Forms.Button();
            this.pnlEmployee = new System.Windows.Forms.Panel();
            this.Cancel2 = new System.Windows.Forms.Button();
            this.btnAdd2 = new System.Windows.Forms.Button();
            this.pnlSupplier = new System.Windows.Forms.Panel();
            this.Cancel3 = new System.Windows.Forms.Button();
            this.btnAdd3 = new System.Windows.Forms.Button();
            this.pnlEditPeople = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtEmpFirstName = new System.Windows.Forms.TextBox();
            this.txtEmpLastName = new System.Windows.Forms.TextBox();
            this.txtEmpPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtSuppFirstName = new System.Windows.Forms.TextBox();
            this.txtSuppLastName = new System.Windows.Forms.TextBox();
            this.txtSuppCompany = new System.Windows.Forms.TextBox();
            this.txtFirstNameEdit = new System.Windows.Forms.TextBox();
            this.txtLastNameEdit = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.pnlCustomerEdit = new System.Windows.Forms.Panel();
            this.pnlEmployeeEdit = new System.Windows.Forms.Panel();
            this.pnlSupplierEdit = new System.Windows.Forms.Panel();
            this.txtPhoneNumberEdit = new System.Windows.Forms.TextBox();
            this.txtEmployeeIDEdit = new System.Windows.Forms.TextBox();
            this.txtEmpTitle = new System.Windows.Forms.TextBox();
            this.txtSuppPhoneNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEmpTitleEdit = new System.Windows.Forms.TextBox();
            this.txtSuppCompanyEdit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.pnlCustomer.SuspendLayout();
            this.pnlEmployee.SuspendLayout();
            this.pnlSupplier.SuspendLayout();
            this.pnlEditPeople.SuspendLayout();
            this.pnlCustomerEdit.SuspendLayout();
            this.pnlEmployeeEdit.SuspendLayout();
            this.pnlSupplierEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jag vill registrera en ny:";
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Items.AddRange(new object[] {
            "Kund",
            "Anställd",
            "Leverantör"});
            this.ComboBox.Location = new System.Drawing.Point(154, 33);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(121, 21);
            this.ComboBox.TabIndex = 1;
            this.ComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(34, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(192, 368);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.label2);
            this.pnlCustomer.Controls.Add(this.label4);
            this.pnlCustomer.Controls.Add(this.label3);
            this.pnlCustomer.Controls.Add(this.Cancel1);
            this.pnlCustomer.Controls.Add(this.txtFirstName);
            this.pnlCustomer.Controls.Add(this.txtLastName);
            this.pnlCustomer.Controls.Add(this.txtPhoneNumber);
            this.pnlCustomer.Controls.Add(this.btnAdd1);
            this.pnlCustomer.Location = new System.Drawing.Point(34, 60);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(192, 137);
            this.pnlCustomer.TabIndex = 3;
            this.pnlCustomer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCustomer_Paint);
            // 
            // Cancel1
            // 
            this.Cancel1.Location = new System.Drawing.Point(111, 111);
            this.Cancel1.Name = "Cancel1";
            this.Cancel1.Size = new System.Drawing.Size(75, 23);
            this.Cancel1.TabIndex = 3;
            this.Cancel1.Text = "Cancel";
            this.Cancel1.UseVisualStyleBackColor = true;
            this.Cancel1.Click += new System.EventHandler(this.Cancel1_Click);
            // 
            // btnAdd1
            // 
            this.btnAdd1.Location = new System.Drawing.Point(3, 110);
            this.btnAdd1.Name = "btnAdd1";
            this.btnAdd1.Size = new System.Drawing.Size(75, 23);
            this.btnAdd1.TabIndex = 2;
            this.btnAdd1.Text = "Add";
            this.btnAdd1.UseVisualStyleBackColor = true;
            this.btnAdd1.Click += new System.EventHandler(this.btnAdd1_Click);
            // 
            // pnlEmployee
            // 
            this.pnlEmployee.Controls.Add(this.label8);
            this.pnlEmployee.Controls.Add(this.label7);
            this.pnlEmployee.Controls.Add(this.label6);
            this.pnlEmployee.Controls.Add(this.label5);
            this.pnlEmployee.Controls.Add(this.txtEmpFirstName);
            this.pnlEmployee.Controls.Add(this.txtEmpTitle);
            this.pnlEmployee.Controls.Add(this.txtEmpLastName);
            this.pnlEmployee.Controls.Add(this.txtEmpPhoneNumber);
            this.pnlEmployee.Controls.Add(this.Cancel2);
            this.pnlEmployee.Controls.Add(this.btnAdd2);
            this.pnlEmployee.Location = new System.Drawing.Point(232, 60);
            this.pnlEmployee.Name = "pnlEmployee";
            this.pnlEmployee.Size = new System.Drawing.Size(212, 137);
            this.pnlEmployee.TabIndex = 0;
            // 
            // Cancel2
            // 
            this.Cancel2.Location = new System.Drawing.Point(130, 110);
            this.Cancel2.Name = "Cancel2";
            this.Cancel2.Size = new System.Drawing.Size(75, 23);
            this.Cancel2.TabIndex = 1;
            this.Cancel2.Text = "Cancel";
            this.Cancel2.UseVisualStyleBackColor = true;
            this.Cancel2.Click += new System.EventHandler(this.Cancel2_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Location = new System.Drawing.Point(3, 110);
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Size = new System.Drawing.Size(75, 23);
            this.btnAdd2.TabIndex = 0;
            this.btnAdd2.Text = "Add";
            this.btnAdd2.UseVisualStyleBackColor = true;
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // pnlSupplier
            // 
            this.pnlSupplier.Controls.Add(this.label9);
            this.pnlSupplier.Controls.Add(this.label10);
            this.pnlSupplier.Controls.Add(this.label11);
            this.pnlSupplier.Controls.Add(this.label12);
            this.pnlSupplier.Controls.Add(this.txtSuppPhoneNumber);
            this.pnlSupplier.Controls.Add(this.txtSuppFirstName);
            this.pnlSupplier.Controls.Add(this.txtSuppLastName);
            this.pnlSupplier.Controls.Add(this.txtSuppCompany);
            this.pnlSupplier.Controls.Add(this.Cancel3);
            this.pnlSupplier.Controls.Add(this.btnAdd3);
            this.pnlSupplier.Location = new System.Drawing.Point(450, 60);
            this.pnlSupplier.Name = "pnlSupplier";
            this.pnlSupplier.Size = new System.Drawing.Size(206, 137);
            this.pnlSupplier.TabIndex = 4;
            // 
            // Cancel3
            // 
            this.Cancel3.Location = new System.Drawing.Point(122, 110);
            this.Cancel3.Name = "Cancel3";
            this.Cancel3.Size = new System.Drawing.Size(75, 23);
            this.Cancel3.TabIndex = 1;
            this.Cancel3.Text = "Cancel";
            this.Cancel3.UseVisualStyleBackColor = true;
            this.Cancel3.Click += new System.EventHandler(this.Cancel3_Click);
            // 
            // btnAdd3
            // 
            this.btnAdd3.Location = new System.Drawing.Point(3, 110);
            this.btnAdd3.Name = "btnAdd3";
            this.btnAdd3.Size = new System.Drawing.Size(75, 23);
            this.btnAdd3.TabIndex = 0;
            this.btnAdd3.Text = "Add";
            this.btnAdd3.UseVisualStyleBackColor = true;
            this.btnAdd3.Click += new System.EventHandler(this.btnAdd3_Click);
            // 
            // pnlEditPeople
            // 
            this.pnlEditPeople.Controls.Add(this.label15);
            this.pnlEditPeople.Controls.Add(this.label14);
            this.pnlEditPeople.Controls.Add(this.label13);
            this.pnlEditPeople.Controls.Add(this.txtPhoneNumberEdit);
            this.pnlEditPeople.Controls.Add(this.pnlEmployeeEdit);
            this.pnlEditPeople.Controls.Add(this.pnlSupplierEdit);
            this.pnlEditPeople.Controls.Add(this.pnlCustomerEdit);
            this.pnlEditPeople.Controls.Add(this.txtLastNameEdit);
            this.pnlEditPeople.Controls.Add(this.txtFirstNameEdit);
            this.pnlEditPeople.Controls.Add(this.button8);
            this.pnlEditPeople.Controls.Add(this.Save);
            this.pnlEditPeople.Location = new System.Drawing.Point(232, 203);
            this.pnlEditPeople.Name = "pnlEditPeople";
            this.pnlEditPeople.Size = new System.Drawing.Size(575, 368);
            this.pnlEditPeople.TabIndex = 0;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(106, 342);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 3;
            this.button8.Text = "Cancel";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(3, 342);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Firstname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lastname:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(86, 0);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(86, 22);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 6;
            this.txtLastName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Phone number:";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(86, 45);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // txtEmpFirstName
            // 
            this.txtEmpFirstName.Location = new System.Drawing.Point(105, 3);
            this.txtEmpFirstName.Name = "txtEmpFirstName";
            this.txtEmpFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpFirstName.TabIndex = 9;
            // 
            // txtEmpLastName
            // 
            this.txtEmpLastName.Location = new System.Drawing.Point(105, 26);
            this.txtEmpLastName.Name = "txtEmpLastName";
            this.txtEmpLastName.Size = new System.Drawing.Size(100, 20);
            this.txtEmpLastName.TabIndex = 10;
            // 
            // txtEmpPhoneNumber
            // 
            this.txtEmpPhoneNumber.Location = new System.Drawing.Point(105, 48);
            this.txtEmpPhoneNumber.Name = "txtEmpPhoneNumber";
            this.txtEmpPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtEmpPhoneNumber.TabIndex = 11;
            // 
            // txtSuppFirstName
            // 
            this.txtSuppFirstName.Location = new System.Drawing.Point(97, 4);
            this.txtSuppFirstName.Name = "txtSuppFirstName";
            this.txtSuppFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtSuppFirstName.TabIndex = 12;
            // 
            // txtSuppLastName
            // 
            this.txtSuppLastName.Location = new System.Drawing.Point(97, 26);
            this.txtSuppLastName.Name = "txtSuppLastName";
            this.txtSuppLastName.Size = new System.Drawing.Size(100, 20);
            this.txtSuppLastName.TabIndex = 13;
            // 
            // txtSuppCompany
            // 
            this.txtSuppCompany.Location = new System.Drawing.Point(97, 71);
            this.txtSuppCompany.Name = "txtSuppCompany";
            this.txtSuppCompany.Size = new System.Drawing.Size(100, 20);
            this.txtSuppCompany.TabIndex = 14;
            // 
            // txtFirstNameEdit
            // 
            this.txtFirstNameEdit.Location = new System.Drawing.Point(88, 9);
            this.txtFirstNameEdit.Name = "txtFirstNameEdit";
            this.txtFirstNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNameEdit.TabIndex = 4;
            // 
            // txtLastNameEdit
            // 
            this.txtLastNameEdit.Location = new System.Drawing.Point(88, 35);
            this.txtLastNameEdit.Name = "txtLastNameEdit";
            this.txtLastNameEdit.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameEdit.TabIndex = 5;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(88, 3);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 6;
            // 
            // pnlCustomerEdit
            // 
            this.pnlCustomerEdit.Controls.Add(this.label16);
            this.pnlCustomerEdit.Controls.Add(this.txtCustomerID);
            this.pnlCustomerEdit.Location = new System.Drawing.Point(0, 87);
            this.pnlCustomerEdit.Name = "pnlCustomerEdit";
            this.pnlCustomerEdit.Size = new System.Drawing.Size(197, 27);
            this.pnlCustomerEdit.TabIndex = 7;
            // 
            // pnlEmployeeEdit
            // 
            this.pnlEmployeeEdit.Controls.Add(this.label18);
            this.pnlEmployeeEdit.Controls.Add(this.label17);
            this.pnlEmployeeEdit.Controls.Add(this.txtEmpTitleEdit);
            this.pnlEmployeeEdit.Controls.Add(this.txtEmployeeIDEdit);
            this.pnlEmployeeEdit.Location = new System.Drawing.Point(203, 87);
            this.pnlEmployeeEdit.Name = "pnlEmployeeEdit";
            this.pnlEmployeeEdit.Size = new System.Drawing.Size(184, 55);
            this.pnlEmployeeEdit.TabIndex = 0;
            // 
            // pnlSupplierEdit
            // 
            this.pnlSupplierEdit.Controls.Add(this.label19);
            this.pnlSupplierEdit.Controls.Add(this.txtSuppCompanyEdit);
            this.pnlSupplierEdit.Location = new System.Drawing.Point(393, 87);
            this.pnlSupplierEdit.Name = "pnlSupplierEdit";
            this.pnlSupplierEdit.Size = new System.Drawing.Size(172, 27);
            this.pnlSupplierEdit.TabIndex = 0;
            // 
            // txtPhoneNumberEdit
            // 
            this.txtPhoneNumberEdit.Location = new System.Drawing.Point(88, 61);
            this.txtPhoneNumberEdit.Name = "txtPhoneNumberEdit";
            this.txtPhoneNumberEdit.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumberEdit.TabIndex = 0;
            // 
            // txtEmployeeIDEdit
            // 
            this.txtEmployeeIDEdit.Location = new System.Drawing.Point(75, 3);
            this.txtEmployeeIDEdit.Name = "txtEmployeeIDEdit";
            this.txtEmployeeIDEdit.ReadOnly = true;
            this.txtEmployeeIDEdit.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeIDEdit.TabIndex = 8;
            // 
            // txtEmpTitle
            // 
            this.txtEmpTitle.Location = new System.Drawing.Point(105, 71);
            this.txtEmpTitle.Name = "txtEmpTitle";
            this.txtEmpTitle.Size = new System.Drawing.Size(100, 20);
            this.txtEmpTitle.TabIndex = 15;
            // 
            // txtSuppPhoneNumber
            // 
            this.txtSuppPhoneNumber.Location = new System.Drawing.Point(97, 49);
            this.txtSuppPhoneNumber.Name = "txtSuppPhoneNumber";
            this.txtSuppPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtSuppPhoneNumber.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Firstname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Lastname:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Phone number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Title:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Firstname:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Lastname:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Phone number:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Company";
            // 
            // txtEmpTitleEdit
            // 
            this.txtEmpTitleEdit.Location = new System.Drawing.Point(75, 29);
            this.txtEmpTitleEdit.Name = "txtEmpTitleEdit";
            this.txtEmpTitleEdit.Size = new System.Drawing.Size(100, 20);
            this.txtEmpTitleEdit.TabIndex = 9;
            // 
            // txtSuppCompanyEdit
            // 
            this.txtSuppCompanyEdit.Location = new System.Drawing.Point(63, 3);
            this.txtSuppCompanyEdit.Name = "txtSuppCompanyEdit";
            this.txtSuppCompanyEdit.Size = new System.Drawing.Size(100, 20);
            this.txtSuppCompanyEdit.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Firstname:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Lastname:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Phone number:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "CustomerID:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(5, 7);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 13);
            this.label17.TabIndex = 10;
            this.label17.Text = "EmployeeID:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 36);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Title:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 6);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(54, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Company:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 587);
            this.Controls.Add(this.pnlEditPeople);
            this.Controls.Add(this.pnlSupplier);
            this.Controls.Add(this.pnlEmployee);
            this.Controls.Add(this.pnlCustomer);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ComboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlEmployee.ResumeLayout(false);
            this.pnlEmployee.PerformLayout();
            this.pnlSupplier.ResumeLayout(false);
            this.pnlSupplier.PerformLayout();
            this.pnlEditPeople.ResumeLayout(false);
            this.pnlEditPeople.PerformLayout();
            this.pnlCustomerEdit.ResumeLayout(false);
            this.pnlCustomerEdit.PerformLayout();
            this.pnlEmployeeEdit.ResumeLayout(false);
            this.pnlEmployeeEdit.PerformLayout();
            this.pnlSupplierEdit.ResumeLayout(false);
            this.pnlSupplierEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Button Cancel1;
        private System.Windows.Forms.Button btnAdd1;
        private System.Windows.Forms.Panel pnlEmployee;
        private System.Windows.Forms.Button Cancel2;
        private System.Windows.Forms.Button btnAdd2;
        private System.Windows.Forms.Panel pnlSupplier;
        private System.Windows.Forms.Button Cancel3;
        private System.Windows.Forms.Button btnAdd3;
        private System.Windows.Forms.Panel pnlEditPeople;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtEmpFirstName;
        private System.Windows.Forms.TextBox txtEmpLastName;
        private System.Windows.Forms.TextBox txtEmpPhoneNumber;
        private System.Windows.Forms.TextBox txtSuppFirstName;
        private System.Windows.Forms.TextBox txtSuppLastName;
        private System.Windows.Forms.TextBox txtSuppCompany;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtLastNameEdit;
        private System.Windows.Forms.TextBox txtFirstNameEdit;
        private System.Windows.Forms.Panel pnlEmployeeEdit;
        private System.Windows.Forms.Panel pnlSupplierEdit;
        private System.Windows.Forms.Panel pnlCustomerEdit;
        private System.Windows.Forms.TextBox txtPhoneNumberEdit;
        private System.Windows.Forms.TextBox txtEmployeeIDEdit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSuppPhoneNumber;
        private System.Windows.Forms.TextBox txtEmpTitleEdit;
        private System.Windows.Forms.TextBox txtSuppCompanyEdit;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label16;
    }
}

