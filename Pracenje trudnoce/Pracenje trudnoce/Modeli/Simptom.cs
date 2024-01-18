using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_trudnoce.Modeli
{
    class Simptom
    {
        public int IdSimptom { get; set; }
        public DateTime Datum { get; set; }
        public string Naziv { get; set; }
        public int pocetak_nor { get; set; }
        public int zavrsetak_nor { get; set; }

        public override string ToString()
        {
            return Naziv;
        }
    }
}
