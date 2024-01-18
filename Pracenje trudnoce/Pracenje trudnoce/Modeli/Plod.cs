using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_trudnoce.Modeli
{
    public class Plod
    {
        public string IdPlod { get; set; }
        public Trudnoca Trudnoca { get; set; }
        public char Pol { get; set; }
        public string KrvnaGrupa { get; set; }

        public override string ToString()
        {
            return Pol + " " + KrvnaGrupa + IdPlod;
        }
    }

}
