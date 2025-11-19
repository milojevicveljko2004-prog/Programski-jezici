using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjSeptembar2025Zad3
{
    public enum StilIgre { BaseLine, ServeAndVolley, AllRound }
    public class Teniser
    {
        #region Atributes

        private string _ime;
        private string _prezime;
        private int _trenutniRanking;
        private DateTime _datumRodjenja;
        private int _brTitula;
        private StilIgre _stil_igre;
        private bool _penzionisan;

        #endregion

        //nemam proveru za podatke, jer to treba da radi klasa forme? Zbog teksta zadatka?
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

        public int TrenutniRanking
        {
            get { return _trenutniRanking; }
            set { _trenutniRanking = value; }
        }

        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { _datumRodjenja = value; }
        }

        public int BrTitula
        {
            get { return _brTitula; }
            set { _brTitula = value; }
        }

        public StilIgre Stil_Igre
        {
            get { return _stil_igre; }
            set { _stil_igre = value; }
        }

        public bool Penzionisan
        {
            get { return _penzionisan; }
            set { _penzionisan = value; }
        }

        #endregion

        public Teniser() { }

        public Teniser(string ime, string prezime, int trenutniRanking, DateTime datumRodjenja,
            int brTitula, StilIgre stil_igre, bool penzionisan)
        {
            Ime = ime;
            Prezime = prezime;
            TrenutniRanking = trenutniRanking;
            DatumRodjenja = datumRodjenja;
            BrTitula = brTitula;
            Stil_Igre = stil_igre;
            Penzionisan = penzionisan;
        }

        //pratim zapis kako je na slici
        //da li i ovde treba Properti ili privatni atributi?
        public override string ToString()
        {
            return _ime + " " + _prezime + ", " + _stil_igre + ", " + _datumRodjenja +
                ", broj titula: " + _brTitula;
        }

        public static void SnimiTenisere(string path, List<Teniser> listaTenisera)
        {
            if (listaTenisera == null)
                throw new Exception("Prosledjena lista tenisera je null! ");

            if (string.IsNullOrWhiteSpace(path))
                throw new Exception("Prosledjen je prazan fajl! ");

            using (TextWriter tw = new StreamWriter(path))
            {
                for (int i = 0; i < listaTenisera.Count; i++)
                {
                    tw.WriteLine(listaTenisera[i].ToString());
                }
            }
        }
    }
}
