using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;

using DBConnection;


namespace DBConnection
{
    // DAO - Data Access Object

    public class DAO
    {

        private MySqlConnection dataConnection;

        public DAO(string server, string dbname, string username, string password)
        {
            dataConnection = new MySqlConnection();
            dataConnection.ConnectionString = "Server=" + server + ";Database=" + dbname + ";Uid=" + username + ";Pwd=" + password + ";";
            dataConnection.Open();
        }

        ~DAO()
        {
            dataConnection.Close();
        }

// KORISNIK
        
        /* IZBRISATI? */

        public int VratiKorisnikID(string korisnicko_ime, string sifra)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT korisnikID FROM korisnici WHERE korisnickoIme = '" + korisnicko_ime + "' AND lozinka = '" + sifra + "';";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();

                int id = dataReader.GetInt32(0);

                dataReader.Close();

                return id;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }


        public bool ProvjeriPristup(string korisnickoIme1, string lozinka1)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                dataCommand.CommandText = "SELECT korisnikID FROM korisnici WHERE korisnickoIme = '" + korisnickoIme1 + "' AND lozinka = '" + lozinka1 + "';";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();

                int id = dataReader.GetInt32(0);
                dataReader.Close();

                return true;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }

        public Korisnik VratiKorisnika(string korisnickoIme3)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                dataCommand.CommandText = "SELECT ime, prezime, fiksniTelefon, mobilniTelefon, email, adresa, grad, korisnickoIme, lozinka FROM korisnici WHERE korisnickoIme = '" + korisnickoIme3 + "';";
                
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();               
                
                string ime = dataReader.GetString(1);
                string prezime = dataReader.GetString(2);
                string fiksniTelefon = dataReader.GetString(3);
                string mobilniTelefon = dataReader.GetString(4);
                string email = dataReader.GetString(5);
                string adresa = dataReader.GetString(6);
                string grad = dataReader.GetString(7);
                string kIme = dataReader.GetString(8);
                string lozinka = dataReader.GetString(9);

                Korisnik k = new Korisnik(ime, prezime, fiksniTelefon, mobilniTelefon, email, adresa, grad, kIme, lozinka);
                                
                dataReader.Close();

                return k;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }

       

        /* možda izbrisati?

        public bool DodajKorisnika(Korisnik k)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                
                
                MySqlCommand korisnici =
                new MySqlCommand("Insert into Korisnici(ime, prezime, fiksniTelefon, mobilniTelefon, email, adresa, grad, korisnickoIme, lozinka) "
                   + "values(@ime,@prezime,@fiksniTelefon,@mobilniTelefon,@email,@adresa,@grad,@krisnickoIme, @lozinka);", dataConnection);

                korisnici.Parameters.AddWithValue("@ime", (Object)k.Ime);
                korisnici.Parameters.AddWithValue("@prezime", (Object)k.Prezime);
                korisnici.Parameters.AddWithValue("@fiksniTelefon", (Object)k.FiksniTelefon);
                korisnici.Parameters.AddWithValue("@mobilniTelefon", (Object)k.MobilniTelefon);
                korisnici.Parameters.AddWithValue("@email", (Object)k.Email);
                korisnici.Parameters.AddWithValue("@adresa", (Object)k.Adresa);
                korisnici.Parameters.AddWithValue("@grad", (Object)k.Grad);
                korisnici.Parameters.AddWithValue("@korisnickoIme", (Object)k.KorisnickoIme);
                korisnici.Parameters.AddWithValue("@lozinka", (Object)k.Lozinka);   
                
                
                korisnici.ExecuteNonQuery();
                
                return true;
            }
            catch (MySqlException)
            {
                throw new Exception("Nije moguće dodati korisnika u bazu.");
            }

        } 
   
        */


        public bool AzurirajKorisnika(Korisnik k, int id)
        {
            try
            {

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;               
               

                MySqlCommand korisnici =
                new MySqlCommand("Update korisnici set ime = @ime, prezime = @prezime, fiksniTelefon = @fiksniTelefon, mobilniTelefon = @mobilniTelefon, email = @email, adresa = @adresa, grad = @grad, korisnickoIme = @korisnickoIme, lozinka = @lozinka where korisnikID= '" + id + "'", dataConnection);

                korisnici.Parameters.AddWithValue("@ime", k.Ime);
                korisnici.Parameters.AddWithValue("@prezime", k.Prezime);
                korisnici.Parameters.AddWithValue("@fiksniTelefon", k.FiksniTelefon);
                korisnici.Parameters.AddWithValue("@mobilniTelefon", k.MobilniTelefon);
                korisnici.Parameters.AddWithValue("@email", k.Email);
                korisnici.Parameters.AddWithValue("@adresa", k.Adresa);
                korisnici.Parameters.AddWithValue("@grad", k.Grad);
                korisnici.Parameters.AddWithValue("@korisnickoIme", k.KorisnickoIme);
                korisnici.Parameters.AddWithValue("@lozinka", k.Lozinka);
               
                korisnici.ExecuteNonQuery();

                return true;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }



// NEKRETNINA

        public bool DodajNekretninu(Nekretnina n)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;                

                MemoryStream m = new MemoryStream();
                n.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();

                MySqlCommand nekretnine =
                new MySqlCommand("Insert into Nekretnine(vrstaNekretnine, naziv, adresa, lokacija, grad, brojKvadrata, godinaIzgradnje, nabavnaCijena, slika, biljeske) "
                   + "values(@vrstaNekretnine, @naziv, @adresa, @lokacija, @grad, @brojKvadrata, @godinaIzgradnje, @nabavnaCijena, @slika, @biljeske);", dataConnection);

                nekretnine.Parameters.AddWithValue("@vrstaNekretnine", (Object)n.VrstaNekretnine);
                nekretnine.Parameters.AddWithValue("@naziv", (Object)n.Naziv);
                nekretnine.Parameters.AddWithValue("@adresa", (Object)n.Adresa);
                nekretnine.Parameters.AddWithValue("@lokacija", (Object)n.Lokacija);
                nekretnine.Parameters.AddWithValue("@grad", (Object)n.Grad);
                nekretnine.Parameters.AddWithValue("@brojKvadrata", (Object)n.BrojKvadrata);
                nekretnine.Parameters.AddWithValue("@godinaIzgradnje", (Object)n.GodinaIzgradnje);
                nekretnine.Parameters.AddWithValue("@nabavnaCijena", (Object)n.NabavnaCijena);
                nekretnine.Parameters.AddWithValue("@slika", (Object)n.Slika);
                nekretnine.Parameters.AddWithValue("@biljeske", (Object)n.Biljeske);

                MySqlParameter p = nekretnine.Parameters.Add("@slika", MySqlDbType.Blob);
                p.Value = bajtovi;


                nekretnine.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException)
            {
                throw new Exception("Nije moguće dodati nekretninu u bazu.");
            }

        }

        public bool AzurirajNekretninu(Nekretnina n, int id)
        {
            try
            {

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                MemoryStream m = new MemoryStream();
                n.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();

                MySqlCommand nekretnine =
                new MySqlCommand("Update nekretnine set vrstaNekretnine = @vrstaNekretnine, naziv = @naziv, adresa = @adresa, lokacija = @lokacija, grad = @grad, brojKvadrata = @brojKvadrata, godinaIzgradnje = @godinaIzgradnje, nabavnaCijena = @nabavnaCijena, slika = @slika, biljeske = @biljeske WHERE nekretninaID= '" + id + "'", dataConnection);

                nekretnine.Parameters.AddWithValue("@vrstaNekretnine", n.VrstaNekretnine);
                nekretnine.Parameters.AddWithValue("@naziv", n.Naziv);
                nekretnine.Parameters.AddWithValue("@adresa", n.Adresa);
                nekretnine.Parameters.AddWithValue("@lokacija", n.Lokacija);
                nekretnine.Parameters.AddWithValue("@grad", n.Grad);
                nekretnine.Parameters.AddWithValue("@brojKvadrata", n.BrojKvadrata);
                nekretnine.Parameters.AddWithValue("@godinaIzgradnje", n.GodinaIzgradnje);
                nekretnine.Parameters.AddWithValue("@nabavnaCijena", n.NabavnaCijena);
                nekretnine.Parameters.AddWithValue("@slika", n.Slika);
                nekretnine.Parameters.AddWithValue("@biljeske", n.Biljeske);
                MySqlParameter p = nekretnine.Parameters.Add("@slika", MySqlDbType.Blob);
                p.Value = bajtovi;

                nekretnine.ExecuteNonQuery();

                return true;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }

        public bool IzbrisiNekretninu(int nekretninaID)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                dataCommand.CommandText = "DELETE FROM nekretnine WHERE nekretninaID = " + nekretninaID + ";";
                return dataCommand.ExecuteNonQuery() > 0;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }

        /*

        public Nekretnina VratiNekretninu(string isbn)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM knjige WHERE ISBN = '" + isbn + "';";

                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                dataReader.Read();
                Knjiga k = new Knjiga(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetInt32(5), dataReader.GetInt32(6), dataReader.GetInt32(7));
                dataReader.Close();
                return k;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }
         * */

// VRSTA RASHODA

        public bool DodajVrstuRashoda(VrstaRashoda vr)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;                

                MySqlCommand vrsteRashoda =
                new MySqlCommand("Insert into vrsterashoda(naziv, cijena) "
                   + "values(@naziv, @cijena);", dataConnection);

                vrsteRashoda.Parameters.AddWithValue("@naziv", vr.Naziv);
                vrsteRashoda.Parameters.AddWithValue("@adresa", vr.Cijena);

                vrsteRashoda.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException)
            {
                throw new Exception("Nije moguće dodati vrstu rashoda u bazu.");
            }

        }


        public bool AzurirajVrstuRashoda(VrstaRashoda vr, int id)
        {
            try
            {

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                
                MySqlCommand vrsteRashoda =
                new MySqlCommand("Update vrsterashoda set naziv = @naziv, cijena = @cijena WHERE vrstaRashodaID= '" + id + "'", dataConnection);


                vrsteRashoda.Parameters.AddWithValue("@naziv", vr.Naziv);
                vrsteRashoda.Parameters.AddWithValue("@adresa", vr.Cijena);

                vrsteRashoda.ExecuteNonQuery();

                return true;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }


    }
}
