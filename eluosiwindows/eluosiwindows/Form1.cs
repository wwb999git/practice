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
    public partial class Form1 : Form
    {
        public static Form f;
        public Form1()
        {
            InitializeComponent();
            f = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 sf = new Form2();
            this.Hide();
            sf.Show(this);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 from = new Form4();
            this.Hide();
            from.Show(this);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
