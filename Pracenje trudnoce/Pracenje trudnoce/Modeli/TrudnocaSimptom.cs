using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_trudnoce.Modeli
{
    class TrudnocaSimptom
    {
        public Simptom simptom { get; set; }
        public Trudnoca trudnoca { get; set; }
        public DateTime datumPojavljivanja { get; set; }

        public String opis { get; set; }
    }
}
