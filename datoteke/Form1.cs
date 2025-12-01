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

namespace datoteke
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string Linija;
            Linija = label1.Text + "|"+ txtPrezime.Text + ","+ txtIndeks.Text;
            StreamWriter sw = new StreamWriter("podaci.txt", true);
            sw.WriteLine(Linija);
            sw.Close();
            txtIme.Text = "";
            txtPrezime.Text = "";
            txtIndeks.Text = "";
            MessageBox.Show("Podaci su snimljeni");
        }
           
        

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            string Linija;
            StreamReader sr = new StreamReader("studenti.txt");
            Linija=sr .ReadLine();
            List<string> podaci = new List<string>();
            while (Linija != null)
            {
                Linija = Linija.Replace(",", "");
                podaci.Add(Linija);
                Linija=sr.ReadLine();

            }
            lstStudenti.DataSource = lstStudenti;
            sr.Close();
        }
    }
}
