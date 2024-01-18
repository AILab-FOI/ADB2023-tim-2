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
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void buttonPregledi_Click(object sender, EventArgs e)
        {
            PreglediIRezultati preglediIRezultati = new PreglediIRezultati();
            preglediIRezultati.ShowDialog();
        }

        private void buttonSimptomi_Click(object sender, EventArgs e)
        {
            Simptomi simptomi = new Simptomi();
            simptomi.ShowDialog();
        }

        private void buttonPlod_Click(object sender, EventArgs e)
        {

        }

        private void buttonTrudovi_Click(object sender, EventArgs e)
        {

        }

        private void buttonDnevnikDogadaja_Click(object sender, EventArgs e)
        {

        }
    }
}
