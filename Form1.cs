using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_giaiphuong_trinh_bac_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            txtb.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            txtc.Text = trackBar3.Value.ToString();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            double a, b, c;
            Console.WriteLine("nhập hệ số a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhập hệ số b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("nhập hệ số c:");
            c = Convert.ToDouble(Console.ReadLine());

            double delta = b * b - 4 * a * c;
            if(delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b + Math.Sqrt(delta))/(2* a);
                Console.WriteLine("phương trình có 2 nghiệm phân biệt:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 =" + x2);
            }
            else if (delta == 0) 
            {  
                double x = -b/(2 * a);
                Console.WriteLine("phương trình có nghiệm kép:");
                Console.WriteLine("x = " + x);
            }
            else 
            {
                Console.WriteLine("phương trình vô nghiệm");
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            txta.Text =trackBar1.Value.ToString();
        }
    }
}
