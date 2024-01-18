using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pracenje_trudnoce.Klase;
using Pracenje_trudnoce.Modeli;

namespace Pracenje_trudnoce
{
    public partial class PreglediUnos : Form
    {
        Pregled spremljeniPregled = null;
        public PreglediUnos(Pregled _pregled)
        {
            this.spremljeniPregled = _pregled;
            InitializeComponent();
            initDoctors();
            initPregled();
        }

        private void initPregled()
        {
            if(this.spremljeniPregled != null) 
            {
                tbPregledi.Text = spremljeniPregled.VrstaPregleda;
                MessageBox.Show(spremljeniPregled.IdPregled.ToString());
                //cbIdDoktor.SelectedItem = pregled.Doktor;
                //cbIdDoktor.SelectedIndex = cbIdDoktor.FindStringExact(pregled.Doktor.osoba.ToString());
            }
        }

        public void initDoctors() 
        {
            DatabaseRepository.dohvatiDoktore().ForEach(d => { this.cbIdDoktor.Items.Add(d); });
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            if (this.spremljeniPregled != null)
            {
                spremljeniPregled.VrstaPregleda = tbPregledi.Text;
                spremljeniPregled.Doktor = cbIdDoktor.SelectedItem as Doktor;
                DatabaseRepository.azurirajPregled(spremljeniPregled);
            }
            else {
                Pregled pregled = new Pregled();
                pregled.VrstaPregleda = tbPregledi.Text;
                pregled.Doktor = cbIdDoktor.SelectedItem as Doktor;
                DatabaseRepository.dodajPregled(pregled);
            }

            this.Close();
        }
    }
}
