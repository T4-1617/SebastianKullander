using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_cars
{
    public partial class Form1 : Form
    {

        System.Collections.ArrayList Cars;

        public Form1()
        {
            InitializeComponent();
            Cars = new System.Collections.ArrayList();

            panel1.Visible = false;

            Cars.Add(new Car() { Make = "volvo", Model = "v70", Color = "blue", Rented = false });
            Cars.Add(new Car() { Make = "Audi", Model = "A6", Color = "black", Rented = false });
            Cars.Add(new Car() { Make = "Mercedes benz", Model = "AMG", Color = "red", Rented = false });

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;

            listBox1.Items.Clear();

            foreach (Car item in Cars)
            {
                if (!item.Rented)
                {
                    listBox1.Items.Add(item);
                    listBox1.DisplayMember = "MakeModel";
                }
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Cars.Add(new Car { Make = textBox1.Text, Model = textBox2.Text, Color = textBox3.Text, Rented = false });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car x = (Car)listBox1.SelectedItem;
            panel1.Visible = true;
            lblMake.Text = x.Make;
            lblModel.Text = x.Model;
            lblColor.Text = x.Color;
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Car x = (Car)listBox1.SelectedItem;
            x.Rented = true;
            listBox1.Items.Clear();

            foreach (Car Item in Cars)
            {
                if (!Item.Rented)
                {
                    listBox1.Items.Add(Item);
                    listBox1.DisplayMember = "MakeModel";
                }
            }
        }
    }
}
