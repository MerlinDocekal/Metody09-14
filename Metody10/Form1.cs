using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool ObsahujeCislici(string retezec, out int cifSoucet, out int soucetLichCif, out int soucetSudCif)
        {
            bool obsahuje = false;
            cifSoucet = 0;
            soucetSudCif = 0;
            soucetLichCif = 0;

            char[] poleCifer = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            for (int i = 0; i < retezec.Length; i++)
            {
                char znak = retezec[i];
                if (poleCifer.Contains(znak))
                {
                    int cifra = int.Parse(znak.ToString());
                    obsahuje = true;
                    cifSoucet += cifra;
                    if(cifra % 2 == 0)
                    {
                        soucetSudCif += cifra;
                    }
                    else
                    {
                        soucetLichCif += cifra;
                    }
                }
            }

            return obsahuje;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            int cifSoucet;
            int soucetLichCif;
            int soucetSudCif;

            if(ObsahujeCislici(s, out cifSoucet, out soucetLichCif, out soucetSudCif))
            {
                MessageBox.Show("Ano, obsahuje. Součet cifer je " + cifSoucet + ", součet lichých cifer je " + soucetLichCif + " a součet sudých cifer je " + soucetSudCif);
            }
            else
            {
                MessageBox.Show("Ne, neobsahuje");
            }
        }
    }
}
