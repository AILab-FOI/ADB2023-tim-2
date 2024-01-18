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
    public partial class PreglediIRezultati : Form
    {
        public PreglediIRezultati()
        {
            InitializeComponent();
            this.refreshDGV();
        }

        private void refreshDGV() 
        {
            dgvPregledi.DataSource = DatabaseRepository.dohvatiPreglede(PrijavljenaOsoba._prijavljenaTrudnica.Osoba.IdOsoba);
        }

        private void refreshDgvPregled() 
        {
            dgvRezultatiPregleda.DataSource = DatabaseRepository.dohvatiRezultatePregleda(dgvPregledi.CurrentRow.DataBoundItem as Pregled);
        }

        private void dgvPregledi_SelectionChanged(object sender, EventArgs e)
        {
            dgvRezultatiPregleda.DataSource = DatabaseRepository.dohvatiRezultatePregleda(dgvPregledi.CurrentRow.DataBoundItem as Pregled);
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonDodajPregled_Click(object sender, EventArgs e)
        {
            PreglediUnos preglediUnos = new PreglediUnos(null);
            preglediUnos.ShowDialog();
            refreshDGV();
        }

        private void buttonAzuriraj_Click(object sender, EventArgs e)
        {
            PreglediUnos preglediUnos = new PreglediUnos(dgvPregledi.CurrentRow.DataBoundItem as Pregled);
            preglediUnos.ShowDialog();
            refreshDGV();
        }

        private void buttonObrisi_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Jeste li sigurni da želite obrisati rezultat pregleda s ID-em: " + (dgvPregledi.CurrentRow.DataBoundItem as Pregled).IdPregled + "?", "Upozorenje o brisanju", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
            {
                DatabaseRepository.obrisiPregled(dgvPregledi.CurrentRow.DataBoundItem as Pregled);
                refreshDGV();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RezultatiPregledaUnos rezultatiPregledaUnos = new RezultatiPregledaUnos(null, dgvPregledi.CurrentRow.DataBoundItem as Pregled);
            rezultatiPregledaUnos.ShowDialog();
            refreshDgvPregled();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RezultatiPregledaUnos rezultatiPregledaUnos = new RezultatiPregledaUnos(dgvRezultatiPregleda.CurrentRow.DataBoundItem as RezultatiPregleda, dgvPregledi.CurrentRow.DataBoundItem as Pregled);
            rezultatiPregledaUnos.ShowDialog();
            refreshDgvPregled();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult rezultat = MessageBox.Show("Jeste li sigurni da želite obrisati rezultat pregleda s ID-em: " + (dgvRezultatiPregleda.CurrentRow.DataBoundItem as Pregled).IdPregled + "?", "Upozorenje o brisanju", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rezultat == DialogResult.Yes)
            {
                DatabaseRepository.obrisiPregled(dgvPregledi.CurrentRow.DataBoundItem as Pregled);
                refreshDgvPregled();
            }
        }
    }
}
