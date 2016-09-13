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
        //lista som innehåller kunderna
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
            c.Active = checkBox1.Checked;
            //lägger till kunderna
            MyCustomers.Add(c);
            //clearar list boxen
            listBox1.Items.Clear();
            //lägger till kunderna i listboxen
            foreach (Customer item in MyCustomers)
            {
                listBox1.Items.Add(item.fullName());
            }

            //kollar om statusen ör active eller unactive, kan bara vara active i detta fall
            if (c.Active)
            {
                status = "Active";
            }
            else
            {
                status = "Inactive";
            }
            //när man trycker på knappen så visar den hur många kunder man har varje gång
            label3.Text = string.Format("du har {0} kunder", MyCustomers.Count);
            //addar 1 på id efter varje kund
            i++;
       
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //håller koll på vart man klickar i listboxen o hämtar det
            Customer c = MyCustomers[listBox1.SelectedIndex];
            //skriver ut infon
            MessageBox.Show(string.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nStatus: {3}",
                c.id, c.firstName,c.lastName, c.Active ));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }


}
