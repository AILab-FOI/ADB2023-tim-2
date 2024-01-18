namespace Pracenje_trudnoce.Modeli
{
    public class Osoba
    {
        private int _idOsoba;
        private string _ime;
        private string _prezime;
        private string _email;
        private string _telefon;
        private string _lozinka;

        public int IdOsoba
        {
            get { return _idOsoba; }
            set { _idOsoba = value; }
        }

        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }

        public string Prezime
        {
            get { return _prezime; }
            set { _prezime = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Telefon
        {
            get { return _telefon; }
            set { _telefon = value; }
        }

        public string Lozinka
        {
            get { return _lozinka; }
            set { _lozinka = value; }
        }

        public override string ToString()
        {
            return this.Ime + this.Prezime;
        }
    }
}
