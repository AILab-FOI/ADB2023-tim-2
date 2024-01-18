using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_trudnoce.Modeli
{
    public class Trudnoca
    {
        public int IdTrudnoca { get; set; }
        public DateTime DatumPocetka { get; set; }
        public Osoba Osoba { get; set; }

        public override string ToString()
        {
            return DatumPocetka.ToString();
        }
    }

}
