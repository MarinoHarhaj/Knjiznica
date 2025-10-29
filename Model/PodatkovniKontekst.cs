using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Knjiznica.Model
{
    public class PodatkovniKontekst
    {

        //kolekcije

        public List<Ucenik> Ucenici;
        public List<Knjiga> Knjige;
        public List<Posudba> Posudbe;

        private string datUcenici = "ucenici.txt";
        private string datKnjige = "knjige.txt";
        public PodatkovniKontekst()
        {
            Ucenici = UcitajUcenike();
            Knjige = UcitajKnjige();
        }

        public void DodajKnjigu(Knjiga knjiga)
        {
            this.Knjige.Add(knjiga);
            SpremiKnjige();
        }

        public void BrisiKnjigu(Knjiga knjiga)
        {
            this.Knjige.Remove(knjiga);
            SpremiKnjige();
        }


        public void DodajUcenika(Ucenik ucenik)
        {

            this.Ucenici.Add(ucenik);
            SpremiUcenike();


        }

        public void BrisiUcenika(Ucenik ucenik)
        {
            this.Ucenici.Remove(ucenik);
            SpremiUcenike();
        }

        private List<Knjiga> UcitajKnjige()
        {
            List<Knjiga> rezultat = new List<Knjiga>();

            if (File.Exists(datKnjige))
            {
                using (StreamReader sr = new StreamReader(datKnjige))
                {
                    while (!sr.EndOfStream)

                    {
                        string Linija = sr.ReadLine();
                        //Splitamo liniju i definiramo bojekt ucenik
                        Knjiga trenutnaKnjiga = new Knjiga();
                        string[] polja = Linija.Split('|');
                        trenutnaKnjiga.ISBN = polja[0];
                        trenutnaKnjiga.Autor = polja[1];
                        trenutnaKnjiga.Naslov = polja[2];
                        trenutnaKnjiga.GodinaIzdanja = int.Parse(polja[3]);
                        trenutnaKnjiga.BrojPrimjeraka = int.Parse(polja[4]);
                        

                        //dodajemo pročitanog ucenik u listu
                        rezultat.Add(trenutnaKnjiga);
                    }
                }
            }

            return rezultat;
        }

        public void SpremiKnjige()
        {
            using (StreamWriter sw = new StreamWriter(datKnjige))
            {
                foreach (Knjiga k in this.Knjige)
                {
                    sw.WriteLine($"{k.ISBN}|{k.Autor}|{k.Naslov}|{k.GodinaIzdanja}|{k.BrojPrimjeraka}");

                }
            }
        }



        private List<Ucenik> UcitajUcenike()
        {
            List<Ucenik> rezultat = new List<Ucenik>();

            if(File.Exists(datUcenici) )
            {
                using (StreamReader sr = new StreamReader(datUcenici))
                {
                    while (!sr.EndOfStream)

                    {
                        string Linija = sr.ReadLine();
                        //Splitamo liniju i definiramo bojekt ucenik
                        Ucenik trenutniUcenik = new Ucenik();                    
                        string[] polja = Linija.Split('|');
                        trenutniUcenik.OIB = polja[0];
                        trenutniUcenik.Ime = polja[1];
                        trenutniUcenik.Prezime = polja[2];
                        trenutniUcenik.Adresa = polja[3];
                        trenutniUcenik.Telefon = polja[4];
                        trenutniUcenik.Razred = int.Parse(polja[5]);

                        //dodajemo pročitanog ucenik u listu
                        rezultat.Add(trenutniUcenik);
                    }
                }
            }

            return rezultat;
        }

        public void SpremiUcenike()
        {
            using (StreamWriter sw = new StreamWriter(datUcenici))
            {
                foreach (Ucenik u in this.Ucenici)
                {
                    sw.WriteLine($"{u.OIB}|{u.Ime}|{u.Prezime}|{u.Adresa}|{u.Telefon}|{u.Razred}");

                }
            }
        }
    }
}
