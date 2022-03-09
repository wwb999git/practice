using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eluosiwindows
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.f.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 ss=new Form2();
            ss.Show();
            this.Close();
        }
    }
}
