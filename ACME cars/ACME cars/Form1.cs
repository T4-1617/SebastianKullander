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


    }
}
