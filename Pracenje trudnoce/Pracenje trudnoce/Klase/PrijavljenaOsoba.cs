using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pracenje_trudnoce.Modeli;

namespace Pracenje_trudnoce.Klase
{
    public static class PrijavljenaOsoba
    {
        public static Trudnica _prijavljenaTrudnica;


        public static void OdjaviTrudnicu()
        {
            _prijavljenaTrudnica = null;
        }

        public static void PrijaviKorisnika(Trudnica trudnica) 
        {
            _prijavljenaTrudnica = trudnica;
        }


    }

}
