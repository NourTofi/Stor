using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            string user = textBox1.Text;
            string pass = textBox2.Text;
            if (user == "امير" && pass == "123")
            {
                f.Text = "مرحبا بك : " + user;
                f.Show();
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة السر غير صحيحة ");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            if (user != "" && pass != "")
            {
                mb1.Enabled = true;
            }
            else
            {
                mb1.Enabled = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string pass = textBox2.Text;
            if (user != "" && pass != "")
            {
                mb1.Enabled = true;
            }
            else
            {
                mb1.Enabled = false;
            }
        }
        private void Label1_Click(object sender, EventArgs e)
        {
        }
        private void Mb1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            string user = textBox1.Text;
            string pass = textBox2.Text;
            if (user == "امير" && pass == "123")
            {
                f.Text = "مرحبا بك : " + user;
                f.Show();
            }
            else
            {
                MessageBox.Show("اسم المستخدم او كلمة السر غير صحيحة ");
            }
        }
    }
}
