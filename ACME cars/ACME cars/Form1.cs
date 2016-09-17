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
        
        System.Collections.ArrayList Cars;//skapar en arraylist kallad cars
        int CarsAvailable;//int för bilar som inte blivit hyrda

        public Form1()
        {
            InitializeComponent();
            Cars = new System.Collections.ArrayList();

            panel1.Visible = false;
            //lägger till objekt i arraylisten
            Cars.Add(new Car() { Make = "volvo", Model = "v70", Color = "blue", Rented = false });
            Cars.Add(new Car() { Make = "Audi", Model = "A6", Color = "black", Rented = false });
            Cars.Add(new Car() { Make = "Mercedes benz", Model = "AMG", Color = "red", Rented = false });

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //visar panel1 o gömmer de andra
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            
            //sätter int till 0 så att värdet blir rätt varje gång man trycker
            CarsAvailable = 0;
            //clearar listboxen
            listBox1.Items.Clear();
            //för varje car i arraylisten gör förljande
            foreach (Car item in Cars)
            {
                if (!item.Rented)//om rented är false så lägger den in bilarna i listboxen och räknar varje bil
                {
                    listBox1.Items.Add(item);
                    listBox1.DisplayMember = "MakeModel";

                    CarsAvailable++;
                }
            }

            label1.Text = string.Format("We have {0} cars available", CarsAvailable);//skriver ut hur många bilar som är tillgängliga
           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //ändrar objekten till det användaren skriver in och lägger in det i Car
            Cars.Add(new Car { Make = textBox1.Text, Model = textBox2.Text, Color = textBox3.Text, Rented = false });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;

            listBox2.Items.Clear();

            foreach (Car item in Cars)
            {
                if (item.Rented)
                {
                    listBox2.Items.Add(item);
                    listBox2.DisplayMember = "MakeModel";
                }

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car x = (Car)listBox1.SelectedItem;//håller koll vart man klickar i listboxen
            if (x != null)//gör så att programmet inte krashar om man klickar utanför o inte på någon bil
            {
                panel1.Visible = true;
                lblMake.Text = x.Make;
                lblModel.Text = x.Model;
                lblColor.Text = x.Color;
                panel4.Visible = false;
            }
            
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Car x = (Car)listBox1.SelectedItem;//håller koll vart man klickat
            x.Rented = true;//ändrar rented till true
            x.CustomerName = textBox4.Text;//läser in vad använderen skriver in för namn
            listBox1.Items.Clear();//clearar listboxen

            foreach (Car Item in Cars)
            {
                if (!Item.Rented)//om rented är true gör fäljande
                {
                    listBox1.Items.Add(Item);
                    listBox1.DisplayMember = "MakeModel";
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReturnRentedCar_Click(object sender, EventArgs e)
        {
            //samma som ovan fast ändrar till false så att bilen kommer tillbaka till show cars
            Car x = (Car)listBox2.SelectedItem;
            x.Rented = false;
            listBox2.Items.Clear();

            foreach (Car Item in Cars)
            {
                if (Item.Rented)
                {
                    listBox2.Items.Add(Item);
                    listBox2.DisplayMember = "MakeModel";
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            //för varje bil som är rented så skriver den ut namn och bil så att det står tex sebastian has rented a red audi a6
            foreach (Car Item in Cars)
            {
                if (Item.Rented)
                {
                    listBox3.Items.Add(string.Format("{0} has rented a {1} {2} {3}", Item.CustomerName, Item.Color, Item.Make, Item.Model));
                }
            }
        }
    }
}
