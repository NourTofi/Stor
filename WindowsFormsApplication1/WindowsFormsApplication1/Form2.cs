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
        // التصريح عن مصفوفة اغراض من الصف 
        store[] dev = new store[100];
        // التصريح عن متحول عداد مع اسناد قيمة ابتدائية 
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
            // التصريح عن مجموعة من المتحولات ليتم التعرف على الدخل 

            string title_device = textBox1.Text;
            string id_device = textBox2.Text;
            string type_device = textBox3.Text;
            double price_device = double.Parse(textBox4.Text);
            string is_sall = textBox5.Text;



            // التاكد من ادخال اسم الجهاز بشكل صحيح 
            if (type_device.Trim() != "موبايل" && type_device.Trim() != "كمبيوتر" && type_device.Trim() != "تاب")
            {
                //اظهار رسالة خطا للمستخدم 
                MessageBox.Show("يجب ان يكون الجهاز اما موبايل او كمبيوتر او تاب  ");
                textBox3.Text = "";
                textBox3.Focus();
                //الخروج من التابع بحال حصول الخطا
                return;
            }

            // التاكد من ان السعر قيمته موجبة 
            if (price_device <= 0)
            {
                //اظهار رسالة خطا للمستخدم 
                MessageBox.Show("يجب ان يكون السعر موجب   ");
                textBox4.Text = "";
                textBox4.Focus();
                //الخروج من التابع بحال حصول الخطا
                return;
            }

            // التاكد من ادخال المستخدم لاحد خيارات المبيع
            if (is_sall.Trim() != "مباع" && is_sall.Trim() != "غير مباع")
            {
                //اظهار رسالة خطا للمستخدم 
                MessageBox.Show("يجب ان تدخل نص مباع او غير مباع ");
                textBox5.Text = "";
                textBox5.Focus();
                //الخروج من التابع بحال حصول الخطا
                return;
            }

            //التاكد من ان نوع الجهاز موبايل لحسم 25 بالمائة من قيمة الجهاز قبل الاضافة 
            if (type_device.Trim() == "موبايل" && is_sall.Trim() == "غير مباع")
            {
                // حسم 25 بالمائة من قيمة سعر الجهاز 
                price_device = price_device - (price_device * 25 / 100);
                // اظهار رسالة للمستخدم بعملية الحسم 
                MessageBox.Show("تم اجراء حسم 25% من قيمة الجهاز الموبايل ");
            }

            //استدعاء الباني مع القيم و اسناده لمصفوفة الاغراض 
            dev[count] = new store(title_device, id_device, type_device, price_device, is_sall);
            // اضافة الغرض الى القائمة


            // زيادة عددا الاغراض بمقدار واحد
            count++;
            // اظهار عدد المنتجات 
            label7.Text = Convert.ToString(count);
            //تفعيل زر الجرد
            //if (Convert.ToInt32(count) > 0)
            //    button6.Enabled = true;
            //else
            //    button6.Enabled = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //رسالة تاكيد للخروج من البرنامج
        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("هل تريد الخروج ", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (i == DialogResult.Yes)
                Application.Exit();
        }
        //زر حذف 
        private void button3_Click(object sender, EventArgs e)
        {
            store.deletion(textBox8.Text);
            dataGridView1.DataSource = store.print_for_data();
        }
        //برمجة زر الجرد
        private void button6_Click(object sender, EventArgs e)
        {
            //التصريح عن متحول و اسناد نص البحث له
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

        //تفعيل زر الحذف
        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            //if (textBox8.Text != "" && Convert.ToInt32(count) > 0)
            //{
            //    button3.Enabled = true;
            //}
            //else
            //{
            //    button3.Enabled = false;
            //}
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //تفعيل زر الاضافة
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
        //انتهاء كود تفعيل زر الاضافة 
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
        //رسالة تاكيد للخروج من البرنامج
        private void Mb3_Click(object sender, EventArgs e)
        {
            DialogResult i = MessageBox.Show("هل تريد الخروج ", "خروج", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (i == DialogResult.Yes)
                Application.Exit();
        }
        private void Mb1_Click(object sender, EventArgs e)
        {

            // التصريح عن مجموعة من المتحولات ليتم التعرف على الدخل 
            int sa = 0;


            //// التاكد من ادخال اسم الجهاز بشكل صحيح 
            if (textBox3.Text.Trim() != "موبايل" && textBox3.Text.Trim() != "كمبيوتر" && textBox3.Text.Trim() != "تاب")
            {
                //اظهار رسالة خطا للمستخدم 
                MessageBox.Show("يجب ان يكون الجهاز اما موبايل او كمبيوتر او تاب  ");
                textBox3.Text = "";
                textBox3.Focus();
                //الخروج من التابع بحال حصول الخطا
                sa = 1;
                return;
            }

            //// التاكد من ان السعر قيمته موجبة 
            if (double.Parse(textBox4.Text.Trim()) <= 0)
            {
                //اظهار رسالة خطا للمستخدم 
                MessageBox.Show("يجب ان يكون السعر موجب   ");
                textBox4.Text = "";
                textBox4.Focus();
                //الخروج من التابع بحال حصول الخطا
                sa = 1;
                return;
            }

            //// التاكد من ادخال المستخدم لاحد خيارات المبيع
            if (textBox5.Text.Trim() != "مباع" && textBox5.Text.Trim() != "غير مباع")
            {
                //اظهار رسالة خطا للمستخدم 
                MessageBox.Show("يجب ان تدخل نص مباع او غير مباع ");
                textBox5.Text = "";
                textBox5.Focus();
                //الخروج من التابع بحال حصول الخطا
                sa = 1;
                return;
            }
            bool pricee = false;
            ////التاكد من ان نوع الجهاز موبايل لحسم 25 بالمائة من قيمة الجهاز قبل الاضافة 
            if (textBox3.Text.Trim() == "موبايل" && textBox5.Text.Trim() == "غير مباع")
            {
                // حسم 25 بالمائة من قيمة سعر الجهاز 

                pricee = true;
                // اظهار رسالة للمستخدم بعملية الحسم 
                MessageBox.Show("تم اجراء حسم 25% من قيمة الجهاز الموبايل ");
            }

            //// اضافة الغرض الى القائمة
            if (pricee)
            {
                store s = new store(textBox1.Text.Trim(), textBox2.Text.Trim(), textBox3.Text.Trim(), double.Parse(textBox4.Text) - (double.Parse(textBox4.Text) * 0.25), textBox5.Text.Trim());
                if (sa != 1)
                {
                    try
                    {
                        s.chackn(textBox2.Text);
                        s.save();
                        //// زيادة عددا الاغراض بمقدار واحد
                        count++;
                        //// اظهار عدد المنتجات 
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
                        //// زيادة عددا الاغراض بمقدار واحد
                        count++;
                        //// اظهار عدد المنتجات 
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

