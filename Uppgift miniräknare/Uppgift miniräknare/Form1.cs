using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uppgift_miniräknare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string namnF;
            namnF = label1.Text;
            
            string namnE; 
            namnE= label2.Text;
            
            string fullname;
            fullname = string.Format("{0} {1}",namnF,namnE);
            
            listBox1.Items.Add(fullname);
            
            textBox1.Text = string.Empty;

            textBox1.Focus();
        }
    }
}
