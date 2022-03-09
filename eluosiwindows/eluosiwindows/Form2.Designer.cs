namespace eluosiwindows
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.返回主界面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.级别选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.幼儿级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正常级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.大神级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.跳崖级ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.返回主页面ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重玩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 570);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "暂停";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(474, 469);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 63);
            this.button2.TabIndex = 1;
            this.button2.Text = "开始";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(184, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 700;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(34, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 650);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.返回主界面ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.级别选择ToolStripMenuItem,
            this.返回主页面ToolStripMenuItem,
            this.重玩ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 32);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 返回主界面ToolStripMenuItem
            // 
            this.返回主界面ToolStripMenuItem.Name = "返回主界面ToolStripMenuItem";
            this.返回主界面ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.返回主界面ToolStripMenuItem.Text = "开始";
            this.返回主界面ToolStripMenuItem.Click += new System.EventHandler(this.返回主界面ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.设置ToolStripMenuItem.Text = "设置";
            // 
            // 级别选择ToolStripMenuItem
            // 
            this.级别选择ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.幼儿级ToolStripMenuItem,
            this.正常级ToolStripMenuItem,
            this.大神级ToolStripMenuItem,
            this.跳崖级ToolStripMenuItem});
            this.级别选择ToolStripMenuItem.Name = "级别选择ToolStripMenuItem";
            this.级别选择ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.级别选择ToolStripMenuItem.Text = "级别选择";
            // 
            // 幼儿级ToolStripMenuItem
            // 
            this.幼儿级ToolStripMenuItem.Name = "幼儿级ToolStripMenuItem";
            this.幼儿级ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.幼儿级ToolStripMenuItem.Text = "幼儿级";
            this.幼儿级ToolStripMenuItem.Click += new System.EventHandler(this.幼儿级ToolStripMenuItem_Click);
            // 
            // 正常级ToolStripMenuItem
            // 
            this.正常级ToolStripMenuItem.Name = "正常级ToolStripMenuItem";
            this.正常级ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.正常级ToolStripMenuItem.Text = "正常级";
            this.正常级ToolStripMenuItem.Click += new System.EventHandler(this.正常级ToolStripMenuItem_Click);
            // 
            // 大神级ToolStripMenuItem
            // 
            this.大神级ToolStripMenuItem.Name = "大神级ToolStripMenuItem";
            this.大神级ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.大神级ToolStripMenuItem.Text = "大神级";
            this.大神级ToolStripMenuItem.Click += new System.EventHandler(this.大神级ToolStripMenuItem_Click);
            // 
            // 跳崖级ToolStripMenuItem
            // 
            this.跳崖级ToolStripMenuItem.Name = "跳崖级ToolStripMenuItem";
            this.跳崖级ToolStripMenuItem.Size = new System.Drawing.Size(146, 30);
            this.跳崖级ToolStripMenuItem.Text = "跳崖级";
            this.跳崖级ToolStripMenuItem.Click += new System.EventHandler(this.跳崖级ToolStripMenuItem_Click);
            // 
            // 返回主页面ToolStripMenuItem
            // 
            this.返回主页面ToolStripMenuItem.Name = "返回主页面ToolStripMenuItem";
            this.返回主页面ToolStripMenuItem.Size = new System.Drawing.Size(112, 28);
            this.返回主页面ToolStripMenuItem.Text = "返回主页面";
            this.返回主页面ToolStripMenuItem.Click += new System.EventHandler(this.返回主页面ToolStripMenuItem_Click);
            // 
            // 重玩ToolStripMenuItem
            // 
            this.重玩ToolStripMenuItem.Name = "重玩ToolStripMenuItem";
            this.重玩ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.重玩ToolStripMenuItem.Text = "重玩";
            this.重玩ToolStripMenuItem.Click += new System.EventHandler(this.重玩ToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pictureBox2.Location = new System.Drawing.Point(453, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(189, 193);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(509, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 80);
            this.button4.TabIndex = 7;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(503, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "下一个";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(474, 386);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 30);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "0";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(518, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "分数";
            // 
            // Form2
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 726);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "正常俄罗斯方块";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 返回主界面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 级别选择ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 幼儿级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 正常级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 大神级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 跳崖级ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 返回主页面ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重玩ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}