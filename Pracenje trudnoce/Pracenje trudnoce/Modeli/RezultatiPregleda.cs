using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_trudnoce.Modeli
{
    public class RezultatiPregleda
    {
        public Osoba Osoba { get; set; }
        public Pregled Pregled { get; set; }
        public string Rezultati { get; set; }
        public DateTime DatumPregleda { get; set; }
        public string KomentarPregleda { get; set; }
        public Plod Plod { get; set; }
        public Trudnoca Trudnoca { get; set; }
        public Dnevnik Dnevnik { get; set; }
    }

}
