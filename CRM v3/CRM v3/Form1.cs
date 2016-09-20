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
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
