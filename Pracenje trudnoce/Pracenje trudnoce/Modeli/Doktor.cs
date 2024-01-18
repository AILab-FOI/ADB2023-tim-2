namespace Pracenje_trudnoce.Modeli
{
    public class Doktor
    {
        public Osoba osoba { get; set; }

        public override string ToString()
        {
            return osoba.Ime + " " + osoba.Prezime;
        }
    }
}