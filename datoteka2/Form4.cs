using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datoteka2
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string line;
            line = txtIme.Text + "|" + txtPrezime + "|" + cbRazred + "|" + cbUspjeh;
            StreamWriter sw = new StreamWriter("imena.txt");
            sw.WriteLine(line);
            sw.Close();
            txtIme.Text = "";
            txtPrezime.Text = "";   
            cbRazred.Text = "";
            cbUspjeh.Text = "";
            MessageBox.Show("Uspješno ste unijeli podatke");
        }
    }
}
