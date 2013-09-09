﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Collections;
using System.IO;

using DBConnection;
using System.Drawing;


namespace DBConnection
{
    // DAO - Data Access Object

    public class DAO
    {

        private MySqlConnection dataConnection;

        public DAO(string server, string dbname, string username, string password)
        {
            dataConnection = new MySqlConnection();
            dataConnection.ConnectionString = "Server=" + server + ";Database=" + dbname + ";Uid=" + username + ";Pwd=" + password + ";Charset=utf8;";
            dataConnection.Open();
        }

        public void ZatvoriKonekciju()
        {
            dataConnection.Close();
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

                Korisnik k = null;

                if (dataReader.HasRows)
                {
                    dataReader.Read();

                    string ime = dataReader.GetString(0);
                    string prezime = dataReader.GetString(1);
                    string fiksniTelefon = dataReader.GetString(2);
                    string mobilniTelefon = dataReader.GetString(3);
                    string email = dataReader.GetString(4);
                    string adresa = dataReader.GetString(5);
                    string grad = dataReader.GetString(6);
                    string kIme = dataReader.GetString(7);
                    string lozinka = dataReader.GetString(8);

                    k = new Korisnik(ime, prezime, fiksniTelefon, mobilniTelefon, email, adresa, grad, kIme, lozinka);
                }                
                                
                dataReader.Close();

                return k;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }



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

        public bool UnesiNekretninu(Nekretnina n)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;                

                MemoryStream m = new MemoryStream();
                n.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();

                MySqlCommand nekretnine =
                new MySqlCommand("INSERT INTO nekretnine(naziv, adresa, lokacija, grad, brojKvadrata, godinaIzgradnje, nabavnaCijena, slika, biljeske) "
                   + "VALUES(@naziv, @adresa, @lokacija, @grad, @brojKvadrata, @godinaIzgradnje, @nabavnaCijena, @slika, @biljeske);", dataConnection);

                nekretnine.Parameters.AddWithValue("@naziv", (Object)n.Naziv);
                nekretnine.Parameters.AddWithValue("@adresa", (Object)n.Adresa);
                nekretnine.Parameters.AddWithValue("@lokacija", (Object)n.Lokacija);
                nekretnine.Parameters.AddWithValue("@grad", (Object)n.Grad);
                nekretnine.Parameters.AddWithValue("@brojKvadrata", (Object)n.BrojKvadrata);
                nekretnine.Parameters.AddWithValue("@godinaIzgradnje", (Object)n.GodinaIzgradnje);
                nekretnine.Parameters.AddWithValue("@nabavnaCijena", (Object)n.NabavnaCijena);
                nekretnine.Parameters.AddWithValue("@biljeske", (Object)n.Biljeske);
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

        public bool AzurirajNekretninu(Nekretnina n)
        {
            try
            {

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                MemoryStream m = new MemoryStream();
                n.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();

                MySqlCommand nekretnine = new MySqlCommand("UPDATE nekretnine SET naziv = @naziv, adresa = @adresa, lokacija = @lokacija, grad = @grad, brojKvadrata = @brojKvadrata, godinaIzgradnje = @godinaIzgradnje, nabavnaCijena = @nabavnaCijena, biljeske = @biljeske, slika = @slika WHERE nekretninaID = '" + n.Id + "'", dataConnection);

                nekretnine.Parameters.AddWithValue("@naziv", n.Naziv);
                nekretnine.Parameters.AddWithValue("@adresa", n.Adresa);
                nekretnine.Parameters.AddWithValue("@lokacija", n.Lokacija);
                nekretnine.Parameters.AddWithValue("@grad", n.Grad);
                nekretnine.Parameters.AddWithValue("@brojKvadrata", n.BrojKvadrata);
                nekretnine.Parameters.AddWithValue("@godinaIzgradnje", n.GodinaIzgradnje);
                nekretnine.Parameters.AddWithValue("@nabavnaCijena", n.NabavnaCijena);
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

        public List<Nekretnina> PretraziNekretnine(string atribut, string uneseno)
        {

            try
            {
                List<Nekretnina> nekretnine = new List<Nekretnina>();
                
                string pretraga;
                if (atribut == "Naziv")
                    pretraga = "naziv";
                else if (atribut == "Adresa")
                    pretraga = "adresa";
                else
                    pretraga = "lokacija";

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM nekretnine WHERE " + pretraga + " LIKE '%" + uneseno + "%';";

                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Nekretnina n = new Nekretnina(dataReader.GetString(1), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(8));
                    n.Id = dataReader.GetInt16(0);
                    n.BrojKvadrata = dataReader.GetInt32(5);
                    n.GodinaIzgradnje = dataReader.GetInt32(6);
                    n.NabavnaCijena = dataReader.GetDouble(7);

                    nekretnine.Add(n);
                }

                return nekretnine;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }

        
        public Bitmap VratiSlikuNekretnine(int id)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT slika FROM nekretnine WHERE nekretninaID = " + id + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                byte[] bajtovi = (byte[])dataReader.GetValue(0);
                MemoryStream m = new MemoryStream(bajtovi, 0, bajtovi.Length);
                m.Write(bajtovi, 0, bajtovi.Length);
                m.Position = 0;
                dataReader.Close();
                return (Bitmap)Image.FromStream(m, true);

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }

        
        public int VratiIdNekretnine(String naziv, String adresa, String grad)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT nekretninaID FROM nekretnine WHERE naziv = '" + naziv + "' AND adresa = '" + adresa + "' AND grad = '" + grad + "';";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                int id = -1;
                if (dataReader.Read())
                {
                    id = dataReader.GetInt16(0);
                    dataReader.Close();
                }
                return id;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }
        

// DIO NEKRETNINE

        public bool UnesiDioNekretnine(DioNekretnine dn, int nekretninaID)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                MemoryStream m = new MemoryStream();
                dn.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();

                MySqlCommand dijeloviNekretnina =
                new MySqlCommand("INSERT INTO dijelovinekretnina(sifra, Nekretnine_nekretninaID, naziv, vrstaNekretnine, brojKvadrata, iznosNajma, status, biljeske, slika) "
                   + "VALUES(@sifra, @Nekretnine_nekretninaID, @naziv, @vrstaNekretnine, @brojKvadrata, @iznosNajma, @status, @biljeske, @slika);", dataConnection);

                dijeloviNekretnina.Parameters.AddWithValue("@sifra", (Object)dn.Sifra);
                dijeloviNekretnina.Parameters.AddWithValue("@Nekretnine_nekretninaID", (Object)nekretninaID);
                dijeloviNekretnina.Parameters.AddWithValue("@naziv", (Object)dn.Naziv);
                dijeloviNekretnina.Parameters.AddWithValue("@vrstaNekretnine", (Object)dn.VrstaNekretnine);
                dijeloviNekretnina.Parameters.AddWithValue("@brojKvadrata", (Object)dn.BrojKvadrata);
                dijeloviNekretnina.Parameters.AddWithValue("@iznosNajma", (Object)dn.IznosNajma);
                dijeloviNekretnina.Parameters.AddWithValue("@status", (Object)dn.Status);
                dijeloviNekretnina.Parameters.AddWithValue("@biljeske", (Object)dn.Biljeske);
                MySqlParameter p = dijeloviNekretnina.Parameters.Add("@slika", MySqlDbType.Blob);
                p.Value = bajtovi;

                dijeloviNekretnina.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }
        
        public bool AzurirajDioNekretnine(DioNekretnine dn)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                MemoryStream m = new MemoryStream();
                dn.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();

                MySqlCommand dijeloviNekretnine = new MySqlCommand("UPDATE dijelovinekretnina SET naziv = @naziv, vrstaNekretnine = @vrstaNekretnine, brojKvadrata = @brojKvadrata, iznosNajma = @iznosNajma, status = @status, biljeske = @biljeske, slika = @slika WHERE sifra = '" + dn.Sifra + "'", dataConnection);

                dijeloviNekretnine.Parameters.AddWithValue("@naziv", dn.Naziv);
                dijeloviNekretnine.Parameters.AddWithValue("@vrstaNekretnine", dn.VrstaNekretnine);
                dijeloviNekretnine.Parameters.AddWithValue("@brojKvadrata", dn.BrojKvadrata);
                dijeloviNekretnine.Parameters.AddWithValue("@iznosNajma", dn.IznosNajma);
                dijeloviNekretnine.Parameters.AddWithValue("@status", dn.Status);
                dijeloviNekretnine.Parameters.AddWithValue("@biljeske", dn.Biljeske);
                MySqlParameter p = dijeloviNekretnine.Parameters.Add("@slika", MySqlDbType.Blob);
                p.Value = bajtovi;

                dijeloviNekretnine.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }

        
        public bool IzbrisiDioNekretnine(string sifra)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                dataCommand.CommandText = "DELETE FROM dijelovinekretnina WHERE sifra = " + sifra + ";";
                return dataCommand.ExecuteNonQuery() > 0;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }      
       

        public List<DioNekretnine> PretraziDioNekretnine(int idNekretnine)
        {

            try
            {
                List<DioNekretnine> dijeloviNekretnine = new List<DioNekretnine>();

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM dijelovinekretnina WHERE Nekretnine_nekretninaID = " + idNekretnine + ";";

                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    DioNekretnine dn = new DioNekretnine(dataReader.GetString(0), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(6), dataReader.GetString(7));
                    dn.BrojKvadrata = dataReader.GetInt32(4);
                    dn.IznosNajma = dataReader.GetDouble(5);

                    dijeloviNekretnine.Add(dn);
                }

                return dijeloviNekretnine;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }
        
        public Bitmap VratiSlikuDijelaNekretnine(string sifra)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT slika FROM dijelovinekretnina WHERE sifra = " + sifra + ";";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                dataReader.Read();
                byte[] bajtovi = (byte[])dataReader.GetValue(0);
                MemoryStream m = new MemoryStream(bajtovi, 0, bajtovi.Length);
                m.Write(bajtovi, 0, bajtovi.Length);
                m.Position = 0;
                dataReader.Close();
                return (Bitmap)Image.FromStream(m, true);
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }


        public List<string> VratiSifreDijelovaNekretnine(int FkIdNekretnine)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT sifra FROM dijelovinekretnina WHERE Nekretnine_nekretninaID = '" + FkIdNekretnine + "';";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                List<string> sifre = new List<string>();
                
                while (dataReader.Read())
                {
                    string sifra = dataReader.GetString(0);
                    sifre.Add(sifra);
                }
                return sifre;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }

        public List<DioNekretnine> DijeloviZaIznajmljivanje()
        {

            try
            {
                List<DioNekretnine> dijeloviNekretnine = new List<DioNekretnine>();

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM dijelovinekretnina WHERE status = 'Slobodno';";

                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    DioNekretnine dn = new DioNekretnine(dataReader.GetString(0), dataReader.GetString(2), dataReader.GetString(3), dataReader.GetString(6), dataReader.GetString(7));
                    dn.BrojKvadrata = dataReader.GetInt32(4);
                    dn.IznosNajma = dataReader.GetDouble(5);

                    dijeloviNekretnine.Add(dn);
                }

                return dijeloviNekretnine;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }

// VRSTA RASHODA

        public bool DodajVrstuRashoda(VrstaRashoda vr)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;                

                MySqlCommand vrsteRashoda =
                new MySqlCommand("INSERT INTO vrsterashoda(naziv, cijena) " + "VALUES(@naziv, @cijena);", dataConnection);

                vrsteRashoda.Parameters.AddWithValue("@naziv", (Object)vr.Naziv);
                vrsteRashoda.Parameters.AddWithValue("@cijena", (Object)vr.Cijena);

                vrsteRashoda.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }

        public List<VrstaRashoda> VratiVrsteRashoda()
        {
            try
            {
                List<VrstaRashoda> vrsteRashoda = new List<VrstaRashoda>();

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT * FROM vrsterashoda;";

                MySqlDataReader dataReader = dataCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    VrstaRashoda vr = new VrstaRashoda(dataReader.GetString(1), dataReader.GetDouble(2));
                    vr.Id = dataReader.GetInt16(0);
                    vrsteRashoda.Add(vr);
                }

                dataReader.Close();
                
                return vrsteRashoda;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }

        public int VratiIdVrsteRashoda(string naziv)
        {
            try
            {               
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                dataCommand.CommandText = "SELECT vrstaRashodaID FROM vrsterashoda WHERE naziv = '" + naziv + "';";
                MySqlDataReader dataReader = dataCommand.ExecuteReader();
                
                dataReader.Read();
                int id = dataReader.GetInt16(0);
                dataReader.Close();

                return id;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }


        public bool AzurirajVrstuRashoda(VrstaRashoda vr)
        {
            try
            {

                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;
                
                MySqlCommand vrsteRashoda =
                new MySqlCommand("UPDATE vrsterashoda SET naziv = @naziv, cijena = @cijena WHERE vrstaRashodaID= '" + vr.Id + "';", dataConnection);


                vrsteRashoda.Parameters.AddWithValue("@naziv", vr.Naziv);
                vrsteRashoda.Parameters.AddWithValue("@cijena", vr.Cijena);

                vrsteRashoda.ExecuteNonQuery();

                return true;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }


        public bool IzbrisiVrstuRashoda(int Id)
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                dataCommand.CommandText = "DELETE FROM vrsterashoda WHERE vrstaRashodaID = " + Id + ";";
                
                return dataCommand.ExecuteNonQuery() > 0;

            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }

        }

// ZAKUPCI
        /*
        public bool UnesiZakupca()
        {
            try
            {
                MySqlCommand dataCommand = new MySqlCommand();
                dataCommand.Connection = dataConnection;

                MemoryStream m = new MemoryStream();
                dn.Slika.Save(m, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] bajtovi = m.ToArray();

                MySqlCommand dijeloviNekretnina =
                new MySqlCommand("INSERT INTO dijelovinekretnina(sifra, Nekretnine_nekretninaID, naziv, vrstaNekretnine, brojKvadrata, iznosNajma, status, biljeske, slika) "
                   + "VALUES(@sifra, @Nekretnine_nekretninaID, @naziv, @vrstaNekretnine, @brojKvadrata, @iznosNajma, @status, @biljeske, @slika);", dataConnection);

                dijeloviNekretnina.Parameters.AddWithValue("@sifra", (Object)dn.Sifra);
                dijeloviNekretnina.Parameters.AddWithValue("@Nekretnine_nekretninaID", (Object)nekretninaID);
                dijeloviNekretnina.Parameters.AddWithValue("@naziv", (Object)dn.Naziv);
                dijeloviNekretnina.Parameters.AddWithValue("@vrstaNekretnine", (Object)dn.VrstaNekretnine);
                dijeloviNekretnina.Parameters.AddWithValue("@brojKvadrata", (Object)dn.BrojKvadrata);
                dijeloviNekretnina.Parameters.AddWithValue("@iznosNajma", (Object)dn.IznosNajma);
                dijeloviNekretnina.Parameters.AddWithValue("@status", (Object)dn.Status);
                dijeloviNekretnina.Parameters.AddWithValue("@biljeske", (Object)dn.Biljeske);
                MySqlParameter p = dijeloviNekretnina.Parameters.Add("@slika", MySqlDbType.Blob);
                p.Value = bajtovi;

                dijeloviNekretnina.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException izuzetak)
            {
                throw new Exception(izuzetak.Message);
            }
        }*/


    }
}