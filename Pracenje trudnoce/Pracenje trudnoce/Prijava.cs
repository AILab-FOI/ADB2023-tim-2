using Pracenje_trudnoce.Klase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracenje_trudnoce
{
    public partial class Prijava : Form
    {
        public Prijava()
        {
            InitializeComponent();
            DatabaseRepository.kreirajKonekciju();
        }

        private void buttonPrijava_Click(object sender, EventArgs e)
        {
            if (DatabaseRepository.PrijaviSe(tbIme.Text, tbLozinka.Text))
            {
                this.Hide();
                Pocetna pocetna = new Pocetna();
                pocetna.ShowDialog();
                this.Show();
            }
            else 
            {
                MessageBox.Show("Ne postoji korisnik sa unesenom kombinacijom Email-a i Lozinke");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registracija registracija = new Registracija();
            registracija.ShowDialog();
        }
    }
}
