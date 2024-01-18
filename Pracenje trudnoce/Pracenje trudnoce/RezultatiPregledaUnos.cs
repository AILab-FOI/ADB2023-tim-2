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
    public partial class RezultatiPregledaUnos : Form
    {
        private RezultatiPregleda rezultatiPregledaUnos;
        public RezultatiPregledaUnos(RezultatiPregleda rezultati, Pregled pregled)
        {
            InitializeComponent();
            this.rezultatiPregledaUnos = rezultati;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSpremi_Click(object sender, EventArgs e)
        {
            if (this.rezultatiPregledaUnos != null)
            {
   


            }
            else
            {
                Pregled pregled = new Pregled();

            }

            this.Close();

        }
    }
}
