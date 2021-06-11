using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace WindowsFormsApplication1
{
    public class store
    {
        private string title_device;
        private string id_device;
        private string type_device;
        private double price_device;
        private string is_sall;

        public store(string ti, string id, string ty, double p, string s)
        {
            title_device = ti;
            id_device = id;
            type_device = ty;
            price_device = p;
            is_sall = s;
        }
        public store()
        { }

        public string Title
        {
            set { title_device = value; }
            get { return title_device; }
        }

        public string Id
        {
            set { id_device = value; }
            get { return id_device; }
        }
        public string Type
        {
            set { type_device = value; }
            get { return type_device; }
        }
        public double Price
        {
            set { price_device = value; }
            get { return price_device; }
        }
        public string Is_sall
        {
            set { is_sall = value; }
            get { return is_sall; }
        }
        public double jard()
        {
            StreamWriter sw = new StreamWriter("s.txt", true);
            sw.Close();
            StreamReader sr = new StreamReader("s.txt");
            double k = 0;
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] data = line.Split('_');
                if (data[4] == "مباع")
                {
                    k = k + double.Parse(data[3]);
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return k;
        }

        public bool chackn(string ide)
        {
            StreamWriter sw = new StreamWriter("s.txt", true);
            sw.Close();
            StreamReader sr = new StreamReader("s.txt");
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] data = line.Split('_');
                if (data[1] == ide)
                {
                    sr.Close();
                    throw new numberEx();
                }
                line = sr.ReadLine();
            }
            sr.Close();
            return true;
        }
        public void save()
        {
            StreamWriter sw = new StreamWriter("s.txt", true);
            sw.WriteLine(title_device + '_' + id_device + '_' + type_device + '_' + price_device + '_' + is_sall);
            sw.Close();
        }
        public static List<store> id_search(string id)
        {
            StreamWriter sw = new StreamWriter("s.txt", true);
            sw.Close();
            StreamReader sr = new StreamReader("s.txt");
            List<store> temp = new List<store>();
            string l = sr.ReadLine();
            while (l != null)
            {
                string[] data = l.Split('_');
                if (id == data[1])
                {
                    store d = new store(data[0], data[1], data[2], double.Parse(data[3]), data[4]);
                    temp.Add(d);
                }
                l = sr.ReadLine();
            }
            sr.Close();
            return temp;
        }
        public static List<store> type_Search(string typee)
        {
            StreamWriter sw = new StreamWriter("s.txt", true);
            sw.Close();
            StreamReader sr = new StreamReader("s.txt");
            List<store> temp = new List<store>();
            string l = sr.ReadLine();
            while (l != null)
            {
                string[] data = l.Split('_');
                if (typee == data[2])
                {
                    store d = new store(data[0], data[1], data[2], int.Parse(data[3]), data[4]);
                    temp.Add(d);
                }
                l = sr.ReadLine();
            }
            sr.Close();
            return temp;
        }
        public static void deletion(string ere)
        {
            StreamReader sr = new StreamReader("s.txt");
            StreamWriter sw = new StreamWriter("se.txt", true);
            string line = sr.ReadLine();
            while (line != null)
            {
                string[] data = line.Split('_');

                string ID = data[1];
                if (ere != ID)
                {
                    sw.WriteLine(line);
                }
                line = sr.ReadLine();
            }
            sw.Close();
            sr.Close();
            File.Delete("s.txt");
            File.Copy("se.txt", "s.txt");
            File.Delete("se.txt");
        }
        public static List<store> print_for_data()
        {
            StreamWriter sw = new StreamWriter("s.txt", true);
            sw.Close();
            StreamReader sr = new StreamReader("s.txt");
            List<store> temp = new List<store>();
            string l = sr.ReadLine();
            while (l != null)
            {
                string[] data = l.Split('_');
                string title_device = data[0];
                string id_device = data[1];
                string type_device = data[2];
                double price = double.Parse(data[3]);
                string is_sall = data[4];
                store d = new store(title_device, id_device, type_device, price, is_sall);
                temp.Add(d);
                l = sr.ReadLine();
            }
            sr.Close();
            return temp;
        }
    }
}
