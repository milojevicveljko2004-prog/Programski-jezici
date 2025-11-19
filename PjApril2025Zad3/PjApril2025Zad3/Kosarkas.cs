using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PjApril2025Zad3
{
    public enum Liga { ABA, EuroLeague, NBA }
    public class Kosarkas
    {
        private string _ime;
        private string _prezime;
        private int _broj; //sa dresa
        private Liga _liga;
        private bool _zauzet; //da li je zauzet u terminu kvalifikacija
        private DateTime _datumRodjenja;

        #region Properties
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

        public int Broj
        {
            get { return _broj; }
            set 
            {
                if (value < 1 || value > 99)
                    throw new Exception("Broj mora biti izmedju 1 i 99! ");

                _broj = value; 
            }
        }

        public Liga Liga
        {
            get { return _liga; }
            set { _liga = value; }
        }

        public bool Zauzet
        {
            get { return _zauzet; }
            set { _zauzet = value; }
        }

        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { _datumRodjenja = value; }
        }

        #endregion

        public Kosarkas() { }

        public Kosarkas(string ime, string prezime, int broj, Liga liga, bool zauzet, 
            DateTime datumRodjenja)
        {
            Ime = ime;
            Prezime = prezime;
            Broj = broj;
            Liga = liga;
            Zauzet = zauzet;
            DatumRodjenja = datumRodjenja;
        }

        public override string ToString()
        {
            return Ime.ToString() + " " + Prezime.ToString() + " " + Broj.ToString() + " " 
                + Liga.ToString() + " " + Zauzet.ToString() + " " + DatumRodjenja.ToString();
        }

        //snimanje liste kosarkasa u zadati tekstualni fajl
        public static void UpisiUFajl(string path, List<Kosarkas> lista)
        {
            if (lista == null)
                throw new Exception("Prosledjena lista kosarkasa je null! ");

            if (string.IsNullOrWhiteSpace(path))
                throw new Exception("Prosledjeno je prazno ime fajla! ");

            using (TextWriter tw = new StreamWriter(path))
            {
                foreach (Kosarkas k in lista)
                {
                    tw.WriteLine(k.ToString());
                }
            }
        }
    }
}
