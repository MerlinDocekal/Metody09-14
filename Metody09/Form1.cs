using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double Diskriminant(double a, double b, double c)
        {
            double D = b * b - 4 * a * c;
            return D;
        }

        private bool KvadratickaRovnice(double a, double b, double D, out double x1, out double x2)
        {
            bool je = true;

            x1 = 0;
            x2 = 0;
            if (D >= 0)
            {
                x1 = (-b + Math.Sqrt(D)) / 2 * a;
                x2 = (-b - Math.Sqrt(D)) / 2 * a;
            }
            else
            {
                je = false;
            }

            return je;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox1.Text);
            double b = double.Parse(textBox2.Text);
            double c = double.Parse(textBox3.Text);

            double x1;
            double x2;

            if (KvadratickaRovnice(a, b, Diskriminant(a, b, c), out x1, out x2))
            {
                if(x1 != x2)
                {
                    MessageBox.Show("Rovnice má dva kořeny a to jsou:\nx1 = " + x1 + "\nx2 = " + x2);
                }
                else
                {
                    MessageBox.Show("Rovnice má jeden kořen a to je: x = " + x1);
                }
            }
            else
            {
                MessageBox.Show("Rovnice nemá řešení.");
            }
        }
    }
}
