using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerForm
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList MyCustomers = new System.Collections.ArrayList();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.firstName = textBox1.Text;
            c.lastName = textBox2.Text;

            MyCustomers.Add(c);

            listBox1.Items.Clear();

            foreach (Customer item in MyCustomers)
            {
                listBox1.Items.Add(item.fullName());
            }

       
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
