using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(szam1.Text);
            int b = Convert.ToInt32(szam2.Text);
            int osszeg = a + b;
            ered.Text = osszeg.ToString();
            
        }

        private void szam1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void kiv_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(szam1.Text);
            int b = Convert.ToInt32(szam2.Text);
            int kivonas = a - b;
            ered.Text = kivonas.ToString();

        }
    }
}
