﻿using System;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form sf = this.Owner;
            if (sf != null)
            {
                sf.Show();
            }
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
