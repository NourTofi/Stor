using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace WindowsFormsApplication1
{

    public partial class Form2 : Form
    {
        store[] dev = new store[100];
        int count = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = store.print_for_data();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title_device = textBox1.Text;
            string id_device = textBox2.Text;
            string type_device = textBox3.Text;
            double price_device = double.Parse(textBox4.Text);
            string is_sall = textBox5.Text;

            if (type_device.Trim() != "موبايل" && type_device.Trim() != "كمبيوتر" && type_device.Trim() != "تاب")
            {
                MessageBox.Show("يجب ان يكون الجهاز اما موبايل او كمبيوتر او تاب  ");
                textBox3.Text = "";
                textBox3.Focus();
                return;
            }
            if (price_device <= 0)
            {
                MessageBox.Show("يجب ان يكون السعر موجب   ");
                textBox4.Text = "";
                textBox4.Focus();
                return;
            }
            if (is_sall.Trim() != "مباع" && is_sall.Trim() != "غير مباع")
            {
                MessageBox.Show("يجب ان تدخل نص مباع او غير مباع ");
                textBox5.Text = "";
                textBox5.Focus();
                return;
            }
            if (type_device.Trim() == "موبايل" && is_sall.Trim() == "غير مباع")
            {
                price_device = price_device - (price_device * 25 / 100);
                MessageBox.Show("تم اجراء حسم 25% من قيمة الجهاز الموبايل ");
            }
            dev[count] = new store(title_device, id_device, type_device, price_device, is_sall);
            count++;
            label7.Text = Convert.ToString(count);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("هل تريد الخروج ", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (i == DialogResult.Yes)
                Application.Exit();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            store.deletion(textBox8.Text);
            dataGridView1.DataSource = store.print_for_data();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            store s = new store();
            if (s.jard() != 0)
            {
                MessageBox.Show("الجرد كما الاتي: " + s.jard());
            }
            else MessageBox.Show("لم يتم العثور على اجهزة مباعة");

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                mb1.Enabled = true;
            else
                mb1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                mb1.Enabled = true;
            else
                mb1.Enabled = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                mb1.Enabled = true;
            else
                mb1.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                mb1.Enabled = true;
            else
                mb1.Enabled = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                mb1.Enabled = true;
            else
                mb1.Enabled = false;
        }
        private void بإنتظار_إدخال_البيانات_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Mb3_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("هل تريد الخروج ", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (i == DialogResult.Yes)
                Application.Exit();
        }
        private void Mb1_Click(object sender, EventArgs e)
        {
            int sa = 0;
            if (textBox3.Text.Trim() != "موبايل" && textBox3.Text.Trim() != "كمبيوتر" && textBox3.Text.Trim() != "تاب")
            {
                MessageBox.Show("يجب ان يكون الجهاز اما موبايل او كمبيوتر او تاب  ");
                textBox3.Text = "";
                textBox3.Focus();
                sa = 1;
                return;
            }
            if (double.Parse(textBox4.Text.Trim()) <= 0)
            {
                MessageBox.Show("يجب ان يكون السعر موجب   ");
                textBox4.Text = "";
                textBox4.Focus();
                sa = 1;
                return;
            }
            if (textBox5.Text.Trim() != "مباع" && textBox5.Text.Trim() != "غير مباع")
            {
                MessageBox.Show("يجب ان تدخل نص مباع او غير مباع ");
                textBox5.Text = "";
                textBox5.Focus();
                sa = 1;
                return;
            }
            bool pricee = false;
            if (textBox3.Text.Trim() == "موبايل" && textBox5.Text.Trim() == "غير مباع")
            {
                pricee = true;
                MessageBox.Show("تم اجراء حسم 25% من قيمة الجهاز الموبايل ");
            }
            if (pricee)
            {
                store s = new store(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), double.Parse(textBox4.Text) - (double.Parse(textBox4.Text) * 0.25), textBox5.Text.Trim());
                if (sa != 1)
                {
                    try
                    {
                        s.chackn(textBox2.Text);
                        s.save();   
                        count++;
                        label7.Text = Convert.ToString(count);
                    }
                    catch (numberEx i) { MessageBox.Show(i.Message); }
                }
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
            }
            else
            {
                store s = new store(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), double.Parse(textBox4.Text), textBox5.Text.Trim());
                if (sa != 1)
                {
                    try
                    {
                        s.chackn(textBox2.Text);
                        s.save();
                        count++;
                        label7.Text = Convert.ToString(count);
                    }
                    catch (numberEx i) { MessageBox.Show(i.Message); }
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
                    textBox5.Clear();
                }
            }
            dataGridView1.DataSource = store.print_for_data();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Mb2_Click(object sender, EventArgs e)
        {
            Form3 s = new Form3();
            s.ShowDialog();
        }

        private void DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

