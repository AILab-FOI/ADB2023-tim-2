using Npgsql;
using Pracenje_trudnoce.Modeli;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracenje_trudnoce.Klase

{
    public static class DatabaseRepository
    {

        public static NpgsqlConnection connection;
        public static NpgsqlConnection kreirajKonekciju()
        {
            NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=PracenjeTrudnoce;UserId=DBUser;" +
                "Password=1234;");
            connection.Open();
            return connection;

        }

        internal static List<Simptom> dohvatiSimptome()
        {
            NpgsqlConnection veza = kreirajKonekciju();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT id_simptom, naziv_simptoma, pocetak_normalnosti, zavrsetak_normalnosti FROM public.simptomi";
            NpgsqlDataReader dr = command.ExecuteReader();
            List<Simptom> simptomi = new List<Simptom>();

            while (dr.Read())
            {
                Simptom simptom = new Simptom();
                simptom.Naziv = dr["naziv_simptoma"].ToString();
                simptom.IdSimptom = int.Parse(dr["id_simptom"].ToString());
                simptom.pocetak_nor = int.Parse(dr["pocetak_normalnosti"].ToString());
                simptom.zavrsetak_nor = int.Parse(dr["zavrsetak_normalnosti"].ToString());

                simptomi.Add(simptom);
            }

            return simptomi;
        }

        internal static object dohvatiTrudnoce()
        {
            NpgsqlConnection veza = kreirajKonekciju();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT id_trudnoca, datum_pocetka, id_osoba " +
                         "FROM trudnoca " +
                         "WHERE id_osoba = @osobaId";
            command.Parameters.AddWithValue("@osobaId", PrijavljenaOsoba._prijavljenaTrudnica.Osoba.IdOsoba);
            NpgsqlDataReader dr = command.ExecuteReader();
            List<Trudnoca> simptomi = new List<Trudnoca>();

            while (dr.Read())
            {
                Trudnoca trudnoca = new Trudnoca();

                trudnoca.IdTrudnoca = int.Parse(dr["id_trudnoca"].ToString());
                trudnoca.DatumPocetka = DateTime.Parse(dr["datum_pocetka"].ToString());

                simptomi.Add(trudnoca);
            }

            return simptomi;
        }

        internal static object dohvatiTrudnoce(Trudnica prijavljenaTrudnica)
        {
            NpgsqlConnection veza = kreirajKonekciju();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT p.*,o.* FROM public.pregled AS p JOIN public.osoba AS o ON p.id_doktor = o.id_osoba;";
            NpgsqlDataReader dr = command.ExecuteReader();
            List<Pregled> pregledi = new List<Pregled>();

            while (dr.Read())
            {
                Pregled pregled = new Pregled();
                pregled.IdPregled = int.Parse(dr["id_pregled"].ToString());
                pregled.VrstaPregleda = dr["vrsta_pregleda"].ToString();
                Osoba osoba = new Osoba();
                osoba.Ime = dr["ime"].ToString();
                osoba.Prezime = dr["prezime"].ToString();
                osoba.Email = dr["email"].ToString();
                osoba.Telefon = dr["telefon"].ToString();
                Doktor doktor = new Doktor();
                doktor.osoba = osoba;
                pregled.Doktor = doktor;

                pregledi.Add(pregled);
            }

            return pregledi;
        }

        internal static object dohvatiSimptomeKorisnika()
        {
            NpgsqlConnection veza = kreirajKonekciju();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT s.id_simptom, s.naziv_simptoma, s.pocetak_normalnosti, s.zavrsetak_normalnosti, t.id_trudnoca, t.datum_pocetka, t.id_osoba, ts.id_trudnoca AS ts_id_trudnoca, ts.datum_pocetka_simptoma, ts.opis FROM simptomi s JOIN trudnoca_simptom ts ON s.id_simptom = ts.id_simptom JOIN trudnoca t ON ts.id_trudnoca = t.id_trudnoca WHERE t.id_osoba = @id; ";
            command.Parameters.AddWithValue("@id", PrijavljenaOsoba._prijavljenaTrudnica.Osoba.IdOsoba);

            NpgsqlDataReader dr = command.ExecuteReader();
            List<TrudnocaSimptom> trudnocaSimptoms = new List<TrudnocaSimptom>();

            while (dr.Read())
            {
                TrudnocaSimptom trudnocaSimptom = new TrudnocaSimptom();
                trudnocaSimptom.opis = dr["opis"].ToString();
                string lel = dr["datum_pocetka_simptoma"].ToString();
                trudnocaSimptom.datumPojavljivanja = DateTime.Parse(dr["datum_pocetka_simptoma"].ToString());

                Trudnoca trudnoca = new Trudnoca();
                trudnoca.IdTrudnoca = int.Parse(dr["id_trudnoca"].ToString());
                trudnoca.DatumPocetka = DateTime.Parse(dr["datum_pocetka"].ToString());

                Simptom simptom = new Simptom();
                simptom.Naziv = dr["naziv_simptoma"].ToString();
                simptom.IdSimptom = int.Parse(dr["id_simptom"].ToString());
                simptom.pocetak_nor = int.Parse(dr["pocetak_normalnosti"].ToString());
                simptom.zavrsetak_nor = int.Parse(dr["zavrsetak_normalnosti"].ToString());

                trudnocaSimptom.simptom = simptom;
                trudnocaSimptom.trudnoca = trudnoca;


                trudnocaSimptoms.Add(trudnocaSimptom);
            }

            return trudnocaSimptoms;
        }

        internal static List<Pregled> dohvatiPreglede(int idOsoba)
        {
            NpgsqlConnection veza = kreirajKonekciju();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT p.*,o.* FROM public.pregled AS p JOIN public.osoba AS o ON p.id_doktor = o.id_osoba;";
            NpgsqlDataReader dr = command.ExecuteReader();
            List<Pregled> pregledi = new List<Pregled>();

            while (dr.Read())
            {
                Pregled pregled = new Pregled();
                pregled.IdPregled = int.Parse(dr["id_pregled"].ToString());
                pregled.VrstaPregleda = dr["vrsta_pregleda"].ToString();
                Osoba osoba = new Osoba();
                osoba.Ime = dr["ime"].ToString();
                osoba.Prezime = dr["prezime"].ToString();
                osoba.Email = dr["email"].ToString();
                osoba.Telefon = dr["telefon"].ToString();
                Doktor doktor = new Doktor();
                doktor.osoba = osoba;
                pregled.Doktor = doktor;

                pregledi.Add(pregled);
            }

            return pregledi;

        }

        internal static void kreirajSimptom(TrudnocaSimptom trudnocaSimptom)
        {
            NpgsqlConnection veza = kreirajKonekciju();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO trudnoca_simptom (id_simptom, datum_pocetka_simptoma, opis) VALUES " +
                    "(@id_simpt, @poc, @opis) ";

            
            command.Parameters.AddWithValue("@id_simpt", trudnocaSimptom.simptom.IdSimptom);
            //@id_trudnocacommand.Parameters.AddWithValue("@id_trudnoca", trudnocaSimptom.trudnoca.IdTrudnoca);
            command.Parameters.AddWithValue("@poc", trudnocaSimptom.datumPojavljivanja);
            command.Parameters.AddWithValue("@opis", trudnocaSimptom.opis);
            

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            veza.Close();
        }

        internal static void azurirajPregled(Pregled pregled)
        {
            NpgsqlConnection veza = kreirajKonekciju();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "UPDATE public.pregled SET vrsta_pregleda=@vrsta_pregleda, id_doktor=@id_doktor WHERE pregled.id_pregled=@id_pregled";

            command.Parameters.AddWithValue("@vrsta_pregleda", pregled.VrstaPregleda);
            command.Parameters.AddWithValue("@id_doktor", pregled.Doktor.osoba.IdOsoba);
            command.Parameters.AddWithValue("@id_pregled", pregled.IdPregled);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            veza.Close();
        }

        internal static void obrisiPregled(Pregled pregled)
        {
            NpgsqlConnection veza = kreirajKonekciju();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "DELETE FROM public.pregled WHERE id_pregled = @id_pregled; ";

            command.Parameters.AddWithValue("@id_pregled", pregled.IdPregled);

            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            veza.Close();
        }

        internal static List<Doktor> dohvatiDoktore()
        {
            NpgsqlConnection veza = kreirajKonekciju();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT d.*, o.* FROM public.doktor AS d JOIN public.osoba AS o ON d.id_osoba = o.id_osoba;";
            NpgsqlDataReader dr = command.ExecuteReader();
            List<Doktor> doktori = new List<Doktor>();

            while (dr.Read())
            {
                Osoba osoba = new Osoba();
                osoba.IdOsoba = int.Parse(dr["id_osoba"].ToString());
                osoba.Ime = dr["ime"].ToString();
                osoba.Prezime = dr["prezime"].ToString();
                osoba.Email = dr["email"].ToString();
                osoba.Telefon = dr["telefon"].ToString();
                Doktor doktor = new Doktor();
                doktor.osoba = osoba;

                doktori.Add(doktor);
            }

            return doktori;

        }

        internal static void dodajPregled(Pregled pregled)
        {
            NpgsqlConnection veza = kreirajKonekciju();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "INSERT INTO pregled (vrsta_pregleda, id_doktor) VALUES " +
                    "(@vrsta_pregleda, @doktor) ";

            command.Parameters.AddWithValue("@vrsta_pregleda", pregled.VrstaPregleda);
            command.Parameters.AddWithValue("@doktor", pregled.Doktor.osoba.IdOsoba);


            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            veza.Close();

        }

        internal static List<RezultatiPregleda> dohvatiRezultatePregleda(Pregled pregled)
        {
            NpgsqlConnection veza = kreirajKonekciju();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM public.rezultati_pregleda as rp JOIN plod as p on p.id_plod = rp.id_plod JOIN trudnoca as t on t.id_trudnoca = rp.id_trudnoca;";
            NpgsqlDataReader dr = command.ExecuteReader();
            List<RezultatiPregleda> rezultati = new List<RezultatiPregleda>();

            while (dr.Read())
            {
                RezultatiPregleda rezultat = new RezultatiPregleda();

                rezultat.Pregled = pregled;
                rezultat.Rezultati = dr["rezultati"].ToString();
                rezultat.DatumPregleda = DateTime.Parse(dr["datum_pregleda"].ToString());
                rezultat.KomentarPregleda = dr["komentar_pregleda"].ToString();
                Trudnoca trudnoca = new Trudnoca();
                trudnoca.IdTrudnoca = int.Parse(dr["id_trudnoca"].ToString());
                trudnoca.DatumPocetka = DateTime.Parse(dr["datum_pocetka"].ToString());
                trudnoca.Osoba = PrijavljenaOsoba._prijavljenaTrudnica.Osoba;

                Plod plod = new Plod();
                plod.IdPlod = dr["id_plod"].ToString();
                plod.KrvnaGrupa = dr["krvna_grupa"].ToString();
                plod.Pol = dr["pol"].ToString().First();
                plod.Trudnoca = trudnoca;

                rezultat.Plod = plod;
                rezultat.Trudnoca = trudnoca;

                rezultati.Add(rezultat);
            }

            return rezultati;
        }

        public static void initConnection() {
            DatabaseRepository.connection = DatabaseRepository.kreirajKonekciju();
        }

        public static NpgsqlConnection dohvatiKonekciju() 
        {
            return DatabaseRepository.connection;
        }

        public static void RegistrirajSe(string ime, string prezime, string email, string telefon, string lozinka, DateTime datumRodenja)
        {
            NpgsqlConnection veza = kreirajKonekciju();

            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT * FROM public.dodaj_osobu_i_trudnicu(@p_ime,@p_prezime,@p_email,@p_telefon,@p_lozinka)";

            command.Parameters.AddWithValue("@p_ime", ime);
            command.Parameters.AddWithValue("@p_prezime", prezime);
            command.Parameters.AddWithValue("@p_email", email);
            command.Parameters.AddWithValue("@p_telefon", telefon);
            command.Parameters.AddWithValue("@p_lozinka", lozinka);

            try { 
                command.ExecuteNonQuery();
            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }

            veza.Close();
        }

        public static void ZatvoriKonekciju()
        {
            connection.Close();
        }

        public static bool PrijaviSe(string email, string lozinka)
        {
            NpgsqlConnection veza = kreirajKonekciju();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = veza;
            command.CommandType = CommandType.Text;
            command.CommandText = "SELECT o.*, t.* FROM public.osoba AS o JOIN public.trudnica AS t ON t.id_osoba = o.id_osoba WHERE o.email = '" + email + "' AND t.lozinka = '" + lozinka + "';";
            NpgsqlDataReader dr = command.ExecuteReader();
            if(dr.Read())
            {
                Osoba osoba = new Osoba();
                Trudnica trudnica = new Trudnica();

                osoba.IdOsoba = int.Parse(dr["id_osoba"].ToString());
                osoba.Ime = dr["ime"].ToString();
                osoba.Prezime = dr["prezime"].ToString();
                osoba.Email = dr["email"].ToString();
                osoba.Telefon = dr["telefon"].ToString();

                trudnica.Osoba = osoba;
                trudnica.KrvnaGrupa = dr["krv_grupna"].ToString();
                trudnica.Visina = int.Parse(dr["visina"].ToString());
                trudnica.Tezina = int.Parse(dr["tezina"].ToString());
                trudnica.DatumRodenja = DateTime.Parse(dr["datum_rodjenja"].ToString());

                Doktor doktor = new Doktor();

                trudnica.GlavniDoktor = doktor;

                PrijavljenaOsoba.PrijaviKorisnika(trudnica);

                veza.Close();
                return true;
            }

            veza.Close();
            return false;
        }

    }
}
