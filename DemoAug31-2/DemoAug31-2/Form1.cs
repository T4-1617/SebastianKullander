using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAug31_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Här kan ni börja skriva egen kod, dvs alla kontroller är uppritade och redo att användas
            label1.Text = "Hello";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Här hamnar vi om knappen klickas, dvs koden nedan körs
            label1.Text = "Hej " + textBox1.Text;

            //Exempel på omvandling (konvertering)
            int i;
            i = Int32.Parse( textBox1.Text);

            MessageBox.Show(i.ToString());

        }
    }
}
