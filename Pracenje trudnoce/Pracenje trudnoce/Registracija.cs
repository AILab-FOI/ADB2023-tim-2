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

namespace Pracenje_trudnoce
{
    public partial class Registracija : Form
    {
        public Registracija()
        {
            InitializeComponent();
        }

        private void buttonRegistracija_Click(object sender, EventArgs e)
        {
            DatabaseRepository.RegistrirajSe(this.tbIme.Text, tbPrezime.Text, tbEmail.Text, tbTelefon.Text, tbLozinka.Text, dtpDatum.Value);
        }
    }
}
