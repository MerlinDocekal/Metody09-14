using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Identicke(string s1, string s2, out int pocetPozic, out int prvniIndex)
        {
            bool jsou = true;
            pocetPozic = 0;
            bool prvniIndexNalezen = false;
            prvniIndex = 0;
            if (s1.Length == s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    if(s1[i] != s2[i])
                    {
                        jsou = false;
                        pocetPozic++;
                        if(!prvniIndexNalezen)
                        {
                            prvniIndex = i;
                            prvniIndexNalezen = true;
                        }
                    }
                }
            }
            else
            {
                jsou = false;

                int kratsi = s1.Length;
                if(s2.Length < kratsi)
                {
                    kratsi = s2.Length;
                }

                for (int i = 0; i < kratsi; i++)
                {
                    if (s1[i] != s2[i])
                    {
                        pocetPozic++;
                        if (!prvniIndexNalezen)
                        {
                            prvniIndex = i;
                            prvniIndexNalezen = true;
                        }
                    }
                }

                pocetPozic += Math.Abs(s1.Length - s2.Length);
                if(!prvniIndexNalezen)
                {
                    prvniIndex = kratsi;
                }
            }
            return jsou;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s1 = textBox1.Text;
            string s2 = textBox2.Text;

            int pocetPozic;
            int prvniIndex;

            if(Identicke(s1, s2, out pocetPozic, out prvniIndex))
            {
                MessageBox.Show("Ano, jsou.");
            }
            else
            {
                MessageBox.Show("Ne, nejsou. Počet pozic je " + pocetPozic + " a první index odlišnosti je " + prvniIndex);
            }
        }
    }
}
