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
        string status;
        int i = 100;
        
        List<Customer> MyCustomers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer c = new Customer();
            c.id = i;
            c.firstName = textBox1.Text;
            c.lastName = textBox2.Text;
            c.Active = true;
          
            MyCustomers.Add(c);

            listBox1.Items.Clear();

            foreach (Customer item in MyCustomers)
            {
                listBox1.Items.Add(item.fullName());
            }

            
            if (c.Active)
            {
                status = "Active";
            }
            else
            {
                status = "Unactive";
            }

            label3.Text = string.Format("du har {0} kunder", MyCustomers.Count);

            i++;
       
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = MyCustomers[listBox1.SelectedIndex];
            MessageBox.Show(string.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nStatus: {3}",
                c.id, c.firstName,c.lastName, status ));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
