using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_trudnoce.Modeli
{
    public class Pregled
    {
        public int IdPregled { get; set; }
        public string VrstaPregleda { get; set; }
        public Doktor Doktor { get; set; }
    }
}
