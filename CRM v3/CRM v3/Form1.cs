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

        public Form1()
        {
            InitializeComponent();
            People = new System.Collections.ArrayList();

            People.Add(new Customer() { FirstName = "Alex", LastName = "Soederboearg", CustomerID = 127, PhoneNumber = 123123123 });
            People.Add(new Customer() { FirstName = "Jesper", LastName = "Oscarsson", CustomerID = 1238, PhoneNumber = 123123123 });

            People.Add(new Employee() { FirstName = "Daniel", LastName = "Eriksson", EmployeeID = 124, PhoneNumber = 123123123 });
            People.Add(new Employee() { FirstName = "Sebastian", LastName = "Kullander", EmployeeID = 123, PhoneNumber = 123123123  });

            People.Add(new Supplier() { FirstName = "Daniel", LastName = "Lundgren", Company = "Hellgren-linander", PhoneNumber = 123123123  });
            People.Add(new Supplier() { FirstName = "Stephan", LastName = "MountainStick", Company = "KooraBilAB", PhoneNumber = 123123123 });

            foreach (var Customer in People)
            {
                listBox1.Items.Add(Customer);
            }
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
    }
}

