using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eluosiwindows
{
    public partial class Form2 : Form
    {
        public static Form f2;
        int[,] p = new int[7, 13];
        Button[,] c = new Button[7, 13];
        int[,] map = new int[7,13];
        string[,] pa = new string[95,2 ];
        string[] ch = new string[32];
        int x=0, y=0;
        int i=3, j=0;
        int count = 0;
       // int g=0, k=0;
        public Form2()
        {
            InitializeComponent();
            pictureBox1.Height = button3.Height * 13;
            pictureBox1.Width = button3.Width * 7;
            button3.Left=pictureBox1.Left + 3 * button3.Width;
            f2 = this;
            StreamReader rd = File.OpenText("1.txt");
            string s = "";
            int i = 0;
            while((s = rd.ReadLine())!=null)
            {
                s = s.Replace("\n", "");
                ch[i++] = s;
            }
            rd.Close();
            rd = File.OpenText("2.txt");
            s = "";
            i = 0;
            while ((s = rd.ReadLine()) != null)
            {
                s = s.Replace("\n", "");
                string[] age = s.Split('\t');
                pa[i, 0] = age[0];
                pa[i, 1] = age[1];
                i++;
            }
            rd.Close();
            Random ran = new Random();
            x = ran.Next(0,95);//x = ran.Next(0,4)
            y = ran.Next(0,1);
        }

        private void deb()
        {
            if (i != 6 &&p[i + 1, j] == 1)
            {

                string date = c[i, j].Text+ c[i + 1, j].Text;
                string date1= c[i+1, j].Text + c[i , j].Text;
                for (int q = 0; q < 95; q++)
                {
                    if (date == pa[q, 1]||date1== pa[q, 1])
                    {
                        c[i+1, j].Text = pa[q, 0];
                        this.Controls.Remove(c[i,j]);
                        p[i, j] = 0;
                        dec();
                        count++;
                        string good = "";
                        good = good + count;
                        textBox1.Text = good;
                    }
                }
            }
            if (i != 0 && p[i-1, j] == 1)
            {

                string date = c[i, j].Text + c[i - 1, j].Text;
                string date1 = c[i - 1, j].Text + c[i, j].Text;
                for (int q = 0; q < 95; q++)
                {
                    if (date == pa[q, 1]||date1==pa[q,1])
                    {
                        c[i-1, j].Text = pa[q, 0];
                        this.Controls.Remove(c[i, j]);
                        p[i, j] = 0;
                        dec();
                        count++;
                        string good = "";
                        good = good + count;
                        textBox1.Text = good;
                    }
                }
            }
            if (j !=12 && p[i, j+1] == 1)
            {

                string date = c[i, j].Text + c[i, j+1].Text;
                string date1 = c[i, j+1].Text + c[i, j].Text;
                for (int q = 0; q < 95; q++)
                {
                    if (date == pa[q, 1] || date1 == pa[q, 1])
                    {
                        c[i, j+1].Text = pa[q, 0];
                        this.Controls.Remove(c[i , j]);
                        p[i , j] = 0;
                        dec();
                        count++;
                        string good = "";
                        good = good + count;
                        textBox1.Text = good;
                    }
                }
            }
        }


        private void dec()
        {

            for(int m = 0; m < 13; m++)
            {
                for(int n = 0; n < 4; n++)
                {
                    if (p[n, m] == 1 && p[n + 1, m] == 1 && p[n + 2, m] == 1 && p[n + 3, m] == 1)
                    {

                        string date = c[n, m].Text + c[n + 1, m].Text + c[n + 2, m].Text + c[n + 3, m].Text;
                        for (int k = 0; k < 30; k++)
                        {
                            if (date == ch[k])
                            {
                                this.Controls.Remove(c[n, m]);
                                this.Controls.Remove(c[n + 1, m]);
                                this.Controls.Remove(c[n + 2, m]);
                                this.Controls.Remove(c[n + 3, m]);
                                p[n, m] = 0;
                                p[n + 1, m] = 0;
                                p[n + 2, m] = 0;
                                p[n + 3, m] = 0;
                                down();
                            }
                        }
                    }
                }
            }
            for (int m = 0; m < 10; m++)
            {
                for (int n = 0; n < 7; n++)
                {
                    if (p[n, m] == 1 && p[n, m + 1] == 1 && p[n, m + 2] == 1 && p[n, m + 3] == 1)
                    {
                        string date = c[n, m].Text + c[n, m + 1].Text + c[n, m + 2].Text + c[n, m + 3].Text;
                        for (int k = 0; k < 30; k++)
                        {
                            if (date == ch[k])
                            {
                                this.Controls.Remove(c[n, m]);
                                this.Controls.Remove(c[n, m + 1]);
                                this.Controls.Remove(c[n, m + 2]);
                                this.Controls.Remove(c[n, m + 3]);
                                p[n, m] = 0;
                                p[n, m + 1] = 0;
                                p[n, m + 2] = 0;
                                p[n, m + 3] = 0;
                                down();
                            }
                        }
                    }
                }
            }

        }

        private void down()
        {
            for(int m = 6; m >=0; m--)
            {
                for(int n =12; n >=0; n--)
                {
                    while (p[m, n] == 1 &&c[m,n].Top+c[m,n].Height<=pictureBox1.Height&& p[m, n+1] == 0)
                    {
                        c[m, n].Top += c[m, n].Height;
                        c[m, n + 1] = c[m, n];
                        j++;
                        p[m, n+1] = 1;
                        p[m, n] = 0;
                        n--;
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Text = pa[x, 1].Substring(y, 1);
            button4.Text = button3.Text;
            button4.Font = new Font("微软雅黑", 20);
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (button3.Top==pictureBox1.Top+button3.Height&&p[i,2]==1)
            {
                Form3 ff = new Form3();
                this.Hide();
                ff.Show();

            }
            if (button3.Top + button3.Height > pictureBox1.Height||p[i,j+1]==1)
            {
                c[i, j] = new Button();
                c[i, j].Location = button3.Location;
                c[i, j].Height = button3.Height;
                c[i, j].Width = button3.Width;
                c[i, j].Text = button3.Text;
                this.Controls.Add(c[i, j]);
                c[i, j].BringToFront();
                button3.Top = pictureBox1.Top;
                button3.Left = pictureBox1.Left+3 * button3.Width;
                Random ran = new Random();
                x = ran.Next(0, 95);//x = ran.Next(0, 4)
                y = ran.Next(0, 2);
                button3.Text = pa[x, 1].Substring(y, 1);
                button4.Text = button3.Text;
                p[i,j] = 1;

                deb();

                i = 3;
                j = 0;
            }
            else
            {
                button3.Top += button3.Height;
                j++;
            }

        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A&&timer1.Enabled==true)
            {
                if (button3.Left - 10 > pictureBox1.Left&&p[i-1,j]!=1)
                {
                    button3.Left -= button3.Width;
                    i--;
                }
            }
            if (e.KeyCode == Keys.D && timer1.Enabled == true)
            {
                if(button3.Left +10 < pictureBox1.Width&&p[i+1,j]!=1)
                {
                    button3.Left += button3.Width;
                    i++;
                }
            }
            if (e.KeyCode == Keys.S && timer1.Enabled == true)
            {
                if (button3.Top == pictureBox1.Top + button3.Height && p[i, 2] == 1)
                {
                    Form3 ff = new Form3();
                    this.Hide();
                    ff.Show();

                }
                if (button3.Top + button3.Height > pictureBox1.Height||p[i,j+1]==1)
                {
                    c[i, j] = new Button();
                    c[i, j].Location = button3.Location;
                    c[i, j].Height = button3.Height;
                    c[i, j].Width = button3.Width;
                    c[i, j].Text = button3.Text;
                    this.Controls.Add(c[i, j]);
                    c[i, j].BringToFront();
                    button3.Top = pictureBox1.Top;
                    button3.Left = pictureBox1.Left + 3 * button3.Width;
                    Random ran = new Random();
                    x = ran.Next(0, 95);//x = ran.Next(0, 4)
                    y = ran.Next(0, 1);
                    button3.Text = pa[x, 1].Substring(y, 1);
                    button4.Text = button3.Text;
                    p[i, j] = 1;

                    deb();

                    i = 3;
                    j = 0;
                }
                else
                {
                    button3.Top += button3.Height;
                    j++;
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void 返回主界面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button4.Text = button3.Text;
            timer1.Enabled = !timer1.Enabled;
        }

        private void 返回主页面ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1.f.Show();
            this.Close();
        }

        private void 幼儿级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
        }

        private void 正常级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 700;
        }

        private void 大神级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 400;
        }

        private void 跳崖级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
        }

        private void 重玩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 ff=new Form2();
            ff.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
