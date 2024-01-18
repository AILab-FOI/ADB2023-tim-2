using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracenje_trudnoce.Modeli
{
    public class Trudnica
    {
        private Osoba _osoba;
        private string _krvnaGrupa;
        private float _visina;
        private float _tezina;
        private DateTime _datumRodenja;
        private Doktor _glavniDoktor;

        // Getter i setter za osoba
        public Osoba Osoba
        {
            get { return _osoba; }
            set { _osoba = value; }
        }

        // Getter i setter za krvnaGrupa
        public string KrvnaGrupa
        {
            get { return _krvnaGrupa; }
            set { _krvnaGrupa = value; }
        }

        // Getter i setter za visina
        public float Visina
        {
            get { return _visina; }
            set { _visina = value; }
        }

        // Getter i setter za tezina
        public float Tezina
        {
            get { return _tezina; }
            set { _tezina = value; }
        }

        // Getter i setter za datumRodenja
        public DateTime DatumRodenja
        {
            get { return _datumRodenja; }
            set { _datumRodenja = value; }
        }

        // Getter i setter za glavniDoktor
        public Doktor GlavniDoktor
        {
            get { return _glavniDoktor; }
            set { _glavniDoktor = value; }
        }
    }
}
