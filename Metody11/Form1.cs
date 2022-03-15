using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int PocetSlov(string s, out string sBezCislic)
        {
            char[] separotor = { ' ' };
            string[] poleSlov = s.Split(separotor, StringSplitOptions.RemoveEmptyEntries);

            for(int i = 0; i < s.Length; i++)
            {
                if(Char.IsDigit(s[i]))
                {
                    s = s.Remove(i, 1);
                }
            }

            sBezCislic = s;
            return poleSlov.Length;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            string sBezCislic;

            MessageBox.Show("Počet slov je " + PocetSlov(s,  out sBezCislic) + " a řetězec bez číslic je:\n" + sBezCislic);
        }
    }
}
