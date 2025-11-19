using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadVozilo
{
    public class Kamion : IVozilo
    {
        private int _nosivost; //u tonama
        private string _naziv;
        private int _serijskiBroj;
        private int _maxBrzina; //izmedju 60 i 130 km/h

        public Kamion() { }

        public Kamion(int nosivost, string naziv, int serijskiBroj, int maxBrzina)
        {
            if (maxBrzina < 60 || maxBrzina > 130)
                throw new Exception("maxBrzina kamiona mora biti izmedju 60 i 130! ");

            _nosivost = nosivost;
            _naziv = naziv;
            _serijskiBroj = serijskiBroj;
            _maxBrzina = maxBrzina;
        }

        //metoda koja odgovara delegatu
        public void ObradiUpozorenjeNosivost(double nosivost)
        {
            if (nosivost > _nosivost)
            {
                Console.WriteLine("Upozorenje: Nosivost kamiona prelazi limit! ");
            }
            else
            {
                Console.WriteLine("Kamion je OK za nosivost. ");
            }
        }

        public int Nosivost => _nosivost;
        public string Naziv => _naziv;

        public int SerijskiBroj => _serijskiBroj;

        public int MaxBrzina => _maxBrzina;

        //tekstualni fajl: nosivost + naziv + serijskiBroj + maxBrzina
        public void ucitaj(TextReader tr)
        {
            string line = tr.ReadLine();

            if (line == null)
                throw new Exception("Neocekivan kraj fajla! ");

            if (string.IsNullOrWhiteSpace(line))
                throw new Exception("Prazna linija u fajlu! ");

            string[] delovi = line.Split();

            if (delovi.Length != 4)
                throw new Exception("U liniji fajla mora biti tacno 4 podatka! ");

            //provera za tipove podataka:

            string naziv = delovi[0].Trim();
            int nosivost = int.Parse(delovi[1]); //automatski program baca Exception ako podatak nije int
            int serijskiBroj = int.Parse(delovi[2]);
            int maxBrzina=int.Parse(delovi[3]);

            //sad provera za ogranicenja:

            if(maxBrzina<60 || maxBrzina>130)
                throw new Exception("Greska u fajlu. maxBrzina kamiona mora biti izmedju 60 i 130! ");

            //ako je sve uredu:

            _nosivost = nosivost;
            _naziv = naziv;
            _serijskiBroj= serijskiBroj;
            _maxBrzina= maxBrzina;
        }

        public void upisi(TextWriter tw)
        {
            tw.WriteLine(_naziv + " " + _nosivost + " " + _serijskiBroj + " " + _maxBrzina);
        }

        //public string getTip()
        //{
        //    return "KAMION";
        //}

        //public int getMaxBrzina() { return _maxBrzina; }

        public void print()
        {
            Console.WriteLine(_naziv + " " + _nosivost + " " + _maxBrzina + " " + _serijskiBroj);
        }
    }
}
