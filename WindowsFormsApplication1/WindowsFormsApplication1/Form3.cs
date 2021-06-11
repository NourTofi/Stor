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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = store.type_Search(textBox6.Text);
            textBox6.Clear();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = store.id_search(textBox7.Text);
            textBox7.Clear();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                button4.Enabled = true;
            }
            else button4.Enabled = false;
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                button2.Enabled = true;
            }
            else button2.Enabled = false;
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
