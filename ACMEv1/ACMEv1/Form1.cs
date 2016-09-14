using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACMEv1
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList MyCars = new System.Collections.ArrayList();

        public Form1()
        {
            InitializeComponent();

            panel1.Visible = false;

            Car c = new Car() { Name="Volvo V70", Fuel="Bensin 95", HP="170", Trunksize="1m2", Seats="5" };
            Car d = new Car() { Name="Audi A6", Fuel = "Bensin 95", HP = "150", Trunksize = "2m2", Seats = "5" };
            Car a = new Car() { Name ="Ferrari", Fuel = "bensin 98", HP = "unlimited", Trunksize = "3m2", Seats = "4" };
            MyCars.Add(c);
            MyCars.Add(d);
            MyCars.Add(a);

            listBox1.Items.Add(c.Name);
            listBox1.Items.Add(d.Name);
            listBox1.Items.Add(a.Name);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car c = (Car)MyCars[listBox1.SelectedIndex];

            panel1.Visible = true;
            label2.Text = string.Format("fuel: {0}", c.Fuel);
            label3.Text = string.Format("HP {0}", c.HP);
            label4.Text = string.Format("Trunksize {0}", c.Trunksize);
            label5.Text = string.Format("Seats {0}", c.Seats);

            Car d = (Car)MyCars[listBox1.SelectedIndex];

            panel1.Visible = true;
            label2.Text = string.Format("fuel: {0}", c.Fuel);
            label3.Text = string.Format("HP {0}", c.HP);
            label4.Text = string.Format("Trunksize {0}", c.Trunksize);
            label5.Text = string.Format("Seats {0}", c.Seats);

            Car a = (Car)MyCars[listBox1.SelectedIndex];

            panel1.Visible = true;
            label2.Text = string.Format("fuel: {0}", c.Fuel);
            label3.Text = string.Format("HP {0}", c.HP);
            label4.Text = string.Format("Trunksize {0}", c.Trunksize);
            label5.Text = string.Format("Seats {0}", c.Seats);


        }
    }
}
