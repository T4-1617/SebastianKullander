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
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;

            Car c = new Car() { Name="Volvo V70", Fuel="Bensin 95", HP="170", Trunksize="1m2", Seats="5", Reg = "FKF 999" };
            Car d = new Car() { Name="Audi A6", Fuel = "Bensin 95", HP = "150", Trunksize = "2m2", Seats = "5", Reg = "FSA 531" };
            Car a = new Car() { Name ="Ferrari", Fuel = "bensin 98", HP = "unlimited", Trunksize = "3m2", Seats = "4", Reg ="AGE 142" };
            Car f = new Car() { Name = "koenigsegg", Fuel = "bensin 98", HP = "1065", Trunksize = "1m2", Seats = "2", Reg = "JDG 032" };
            Car g = new Car() { Name = "volkswagen", Fuel = "bensin 95", HP = "30", Trunksize = "4m2", Seats = "8", Reg = "SDA 574" };
            MyCars.Add(c);
            MyCars.Add(d);
            MyCars.Add(a);
            MyCars.Add(f);
            MyCars.Add(g);

            listBox1.Items.Add(c.Name);
            listBox1.Items.Add(d.Name);
            listBox1.Items.Add(a.Name);
            listBox1.Items.Add(f.Name);
            listBox1.Items.Add(g.Name);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car x = (Car)MyCars[listBox1.SelectedIndex];

            panel1.Visible = true;
            textBox1.Text = string.Format("{0}", x.Fuel);
            textBox2.Text = string.Format("{0}", x.HP);
            textBox3.Text = string.Format("{0}", x.Trunksize);
            textBox4.Text = string.Format("{0}", x.Seats);
            textBox5.Text = string.Format("{0}", x.Reg);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Car x = (Car)MyCars[listBox1.SelectedIndex];
            x.Fuel = textBox1.Text;
            x.HP = textBox2.Text;
            x.Trunksize = textBox3.Text;
            x.Seats = textBox4.Text;
            x.Reg = textBox5.Text;

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

            panel1.Visible = false;
        }
    }
}
