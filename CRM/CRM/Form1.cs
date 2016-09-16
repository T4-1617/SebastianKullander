using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList CustomersAndEmployees;

        public Form1()
        {
            InitializeComponent();
        }

       

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CustomersAndEmployees.Add(new customer() { LastName = textBox1.Text, FirstName = textBox2.Text });

            label1.Text = string.Empty;
            label2.Text = string.Empty;
            label1.Focus();

            DisplayCustomersAndEmployees();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.FirstName = label1.Text;
            emp.LastName = label2.Text;

            CustomersAndEmployees.Add(emp);

            DisplayCustomersAndEmployees();
        }

        private void DisplayCustomersAndEmployees()
        {
            listBox1.Items.Clear();
            foreach (var xxx in CustomersAndEmployees)
            {
                switch (xxx.GetType().Name)
                {
                    case "Customer":
                        listBox1.Items.Add(xxx);
                        break;

                    case "Employee":
                        listBox2.Items.Add(xxx);
                        break;

                    default:
                        break;
                }
            }
        }

    }
}
