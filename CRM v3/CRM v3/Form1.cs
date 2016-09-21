using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_v3
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList People;
        Random random;

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            People = new System.Collections.ArrayList();

            People.Add(new Customer() { FirstName = "Alex", LastName = "Soederboearg", CustomerID = random.Next(1000, 10000), PhoneNumber = "123123123" });
            People.Add(new Customer() { FirstName = "Jesper", LastName = "Oscarsson", CustomerID = random.Next(1000, 10000), PhoneNumber = "123123123" });

            People.Add(new Employee() { FirstName = "Daniel", LastName = "Eriksson", EmployeeID = random.Next(1000, 10000), Title ="Boss", PhoneNumber = "123123123" });
            People.Add(new Employee() { FirstName = "Sebastian", LastName = "Kullander", EmployeeID = random.Next(1000, 10000), Title = "Manager", PhoneNumber = "123123123"  });

            People.Add(new Supplier() { FirstName = "Daniel", LastName = "Lundgren", Company = "Hellgren-linander", PhoneNumber = "123123123"  });
            People.Add(new Supplier() { FirstName = "Stephan", LastName = "MountainStick", Company = "KooraBilAB", PhoneNumber = "123123123" });

            foreach (var Customer in People)
            {
                listBox1.Items.Add(Customer);
            }

            pnlCustomer.Visible = false;
            pnlEmployee.Visible = false;
            pnlSupplier.Visible = false;

            pnlCustomerEdit.Visible = false;
            pnlEmployeeEdit.Visible = false;
            pnlSupplierEdit.Visible = false;

            pnlEditPeople.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ComboBox.Text)
            {
                case "Kund":
                    pnlCustomer.Visible = true;
                    pnlEmployee.Visible = false;
                    pnlSupplier.Visible = false;
                    break;

                case "Anställd":
                    pnlCustomer.Visible = false;
                    pnlEmployee.Visible = true;
                    pnlSupplier.Visible = false;
                    break;

                case "Leverantör":
                    pnlCustomer.Visible = false;
                    pnlEmployee.Visible = false;
                    pnlSupplier.Visible = true;
                    break;
            }
        }

        private void pnlCustomer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            People.Add(new Customer() { FirstName = txtFirstName.Text, LastName = txtLastName.Text, CustomerID = random.Next(1000, 10000), PhoneNumber = txtPhoneNumber.Text });
            listBox1.Items.Clear();
            foreach (var Customer in People)
            {
                listBox1.Items.Add(Customer);
            }

            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd2_Click(object sender, EventArgs e)
        {
            People.Add(new Employee() { FirstName = txtEmpFirstName.Text, LastName = txtEmpLastName.Text, EmployeeID = random.Next(1000, 10000), Title = txtEmpTitle.Text, PhoneNumber = txtEmpPhoneNumber.Text });
            listBox1.Items.Clear();
            foreach (var Customer in People)
            {
                listBox1.Items.Add(Customer);
            }

            txtEmpFirstName.Clear();
            txtEmpLastName.Clear();
            txtEmpPhoneNumber.Clear();
        }

        private void btnAdd3_Click(object sender, EventArgs e)
        {
            People.Add(new Supplier() { FirstName = txtSuppFirstName.Text, LastName = txtSuppLastName.Text, Company = txtSuppCompany.Text, PhoneNumber = txtSuppPhoneNumber.Text });
            listBox1.Items.Clear();
            foreach (var Customer in People)
            {
                listBox1.Items.Add(Customer);
            }

            txtSuppFirstName.Clear();
            txtSuppLastName.Clear();
            txtSuppCompany.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            People person = (People)listBox1.SelectedItem;

            pnlEditPeople.Visible = true;
            txtFirstNameEdit.Text = person.FirstName.ToString();
            txtLastNameEdit.Text = person.LastName.ToString();
            txtPhoneNumberEdit.Text = person.PhoneNumber.ToString();

            switch(listBox1.SelectedItem.GetType().Name)
            {
                case "Customer":
                    Customer c = (Customer)listBox1.SelectedItem;
                    txtCustomerID.Text = c.CustomerID.ToString();

                    pnlCustomerEdit.Visible = true;
                    pnlEmployeeEdit.Visible = false;
                    pnlSupplierEdit.Visible = false;
                    break;

                case "Employee":
                    Employee emp = (Employee)listBox1.SelectedItem;
                    txtEmployeeIDEdit.Text = emp.EmployeeID.ToString();
                    txtEmpTitleEdit.Text = emp.Title.ToString();

                    pnlCustomerEdit.Visible = false;
                    pnlEmployeeEdit.Visible = true;
                    pnlSupplierEdit.Visible = false;
                    break;

                case "Supplier":
                    Supplier sup = (Supplier)listBox1.SelectedItem;
                    txtSuppCompanyEdit.Text = sup.Company.ToString();

                    pnlCustomerEdit.Visible = false;
                    pnlEmployeeEdit.Visible = false;
                    pnlSupplierEdit.Visible = true;
                    break;

            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {


        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                People person = (People)listBox1.SelectedItem;
                

                person.FirstName = txtFirstNameEdit.Text;
                person.LastName = txtLastNameEdit.Text;
                person.PhoneNumber = txtPhoneNumberEdit.Text;

                switch (listBox1.SelectedItem.GetType().Name)
                {
                    case "Employee":
                        Employee emp = (Employee)listBox1.SelectedItem;
                        emp.Title = txtEmpTitleEdit.Text;
                        break;

                    case "Supplier":
                        Supplier supp = (Supplier)listBox1.SelectedItem;
                        supp.Company = txtSuppCompanyEdit.Text;
                        break;

                    default:
                        break;
                }
                listBox1.Items.Clear();
                foreach (People item in People)
                {
                    listBox1.Items.Add(item);
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void CancelMethod()
        {
            pnlCustomer.Visible = false;
            pnlEmployee.Visible = false;
            pnlSupplier.Visible = false;

            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();

            txtEmpFirstName.Clear();
            txtEmpLastName.Clear();
            txtEmpPhoneNumber.Clear();
            txtEmpTitle.Clear();

            txtSuppFirstName.Clear();
            txtSuppLastName.Clear();
            txtSuppPhoneNumber.Clear();
            txtSuppCompany.Clear();
        }

        private void Cancel1_Click(object sender, EventArgs e)
        {
            CancelMethod();
        }

        private void Cancel2_Click(object sender, EventArgs e)
        {
            CancelMethod();
        }

        private void Cancel3_Click(object sender, EventArgs e)
        {
            CancelMethod();
        }

        private void ListPeople()
        {

            listBox1.Items.Add("Customers:");

            foreach (Customer item in People)
            {
                if (item is Customer)
                {
                    listBox1.Items.Add(item);
                    
                }
            }

            listBox1.Items.Add(string.Empty);
            listBox1.Items.Add("\nEmployees:");

            foreach (People item in People)
            {
                if (item is Employee)
                {
                    listBox1.Items.Add(item);
                   
                }
            }

            listBox1.Items.Add(string.Empty);
            listBox1.Items.Add("Suppliers:");

            foreach (People item in People)
            {
                if (item is Supplier)
                {
                    list   .Items.Add(item);
                    CountSuppliers++;
                }
            }
            
        }

    }
}

