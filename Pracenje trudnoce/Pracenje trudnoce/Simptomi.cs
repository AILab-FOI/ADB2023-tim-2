using Pracenje_trudnoce.Klase;
using Pracenje_trudnoce.Modeli;
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
    public partial class Simptomi : Form
    {
        public Simptomi()
        {
            InitializeComponent();
            this.refreshDGV();
        }

        private void refreshDGV()
        {
            this.dgvSimptomi.DataSource = DatabaseRepository.dohvatiSimptomeKorisnika();
            this.cbSimptomi.DataSource = DatabaseRepository.dohvatiSimptome();
            this.dbTrudnoce.DataSource = DatabaseRepository.dohvatiTrudnoce();
        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            TrudnocaSimptom trudnocaSimptom = new TrudnocaSimptom();
            trudnocaSimptom.opis = rtbOpis.Text;
            trudnocaSimptom.datumPojavljivanja = dtpDatumPocetkaSimptoma.Value;
            trudnocaSimptom.trudnoca = dbTrudnoce.SelectedItem as Trudnoca;
            trudnocaSimptom.simptom = cbSimptomi.SelectedItem as Simptom;

            DatabaseRepository.kreirajSimptom(trudnocaSimptom);
            this.refreshDGV();
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
