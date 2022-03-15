using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObsahujeSlovo(string s, out string nejdelsi, out string nejkratsi)
        {
            bool obsahuje = false;
            nejdelsi = string.Empty;
            nejkratsi = string.Empty;

            char[] separator = { ' ' };
            string[] poleSlov = s.Split(separator, StringSplitOptions.RemoveEmptyEntries);

            if(poleSlov.Length > 0)
            {

                obsahuje = true;

                int maxDelka = 0;
                int minDelka = poleSlov[0].Length;

                foreach (string x in poleSlov)
                {
                    if (x.Length > maxDelka)
                    {
                        nejdelsi = x;
                        maxDelka = x.Length;
                    }
                    else if (x.Length < minDelka)
                    {
                        nejkratsi = x;
                        minDelka = x.Length;
                    }
                }
            }

            

            return obsahuje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string nejdelsi;
            string nejkratsi;

            if(ObsahujeSlovo(s, out nejdelsi, out nejkratsi))
            {
                MessageBox.Show("Ano, obsahuje. Nejdelší je " + nejdelsi + " a nejkratší je " + nejkratsi);
            }
            else
            {
                MessageBox.Show("Ne, neobsahuje.");
            }
        }
    }
}
