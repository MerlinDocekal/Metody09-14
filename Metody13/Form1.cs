using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool JeAlfanum(string retezec, out int pocetMalych, out int pocetVelkych, out int pocetJinych)
        {
            bool je = true;
            pocetMalych = 0;
            pocetVelkych = 0;
            pocetJinych = 0;


            foreach(char c in retezec)
            {
                if(Char.IsLower(c))
                {
                    pocetMalych++;
                }

                if (Char.IsUpper(c))
                {
                    pocetVelkych++;
                }

                if (!Char.IsLetterOrDigit(c))
                {
                    je = false;
                    pocetJinych++;
                }
            }

            return je;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;

            int pocetMalych;
            int pocetVelkych;
            int pocetJinych;

            if(JeAlfanum(s, out pocetMalych, out pocetVelkych, out pocetJinych))
            {
                MessageBox.Show("Ano, je. Počet malých je " + pocetMalych + " a počet velkých je " + pocetVelkych);
            }
            else
            {
                MessageBox.Show("Ne, není. Počet malých je " + pocetMalych + ", počet velkých je " + pocetVelkych + " a počet jiných je " + pocetJinych);
            }
        }
    }
}
