using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timer_xunhuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string s = textBox1.Text;
            //s = s.Replace("\n", "\r\n");
            //System.IO.File.WriteAllText("c:/1.txt", s, Encoding.Default);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("打开窗体点YES ", "请确认是否打开窗体", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                this.Show();
            }
            else
            {
                Application.Exit();
                this.Close();
            }
                
            
            
        }
        public int zer=0;
        private void button1_Click(object sender, EventArgs e)
        {
            //string s =textBox2.Text;
            //comboBox1.Items.Add(s);
            //textBox1.AppendText(s + "");
            //textBox2.Text = "";

            //comboBox1.Items.Clear();
            //char[] zi = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            //foreach (char x in zi)
            //{
            //    comboBox1.Items.Add((char)(x-32));
            //}

            //timer1.Enabled = true;



        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();
            int i = rd.Next(100);
            zer += i;
            textBox1.AppendText(i + "\n");
            textBox2.Text = zer + "";
        }

        
    }
}
