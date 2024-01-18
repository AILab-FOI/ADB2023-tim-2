using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_trudnoce.Modeli
{
    public class Dnevnik
    {
        public int IdDnevnik { get; set; }
        public DateTime Datum { get; set; }
        public string Opis { get; set; }
        public Plod Plod { get; set; }
        public int SpecificanPlod { get; set; }
        public Trudnoca Trudnoca { get; set; }
        public Doktor Doktor { get; set; }
    }

}
