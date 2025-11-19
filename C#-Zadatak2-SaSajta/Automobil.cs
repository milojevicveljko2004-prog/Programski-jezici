using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadVozilo
{
    public class Automobil : IVozilo
    {
        private int _brMestaZaSedenje;
        private string _naziv;
        private int _serijskiBroj;
        private int _maxBrzina; //izmedju 90 i 250 km/h

        //ocekivana linija fajla: brMesta + Naziv + SerijskiBroj + MaxBrzina
        public void ucitaj(TextReader tr) 
        {
            string line = tr.ReadLine();

            if (line == null)
                throw new Exception("Neocekivan kraj fajla! ");

            if (string.IsNullOrWhiteSpace(line))
                throw new Exception("Neocekivan nailazak na prazan red! ");

            string[] delovi = line.Split();

            if (delovi.Length != 4)
                throw new Exception("U liniji fajla se ocekuje 4 argumenata, a nema ih toliko! ");

            string naziv = delovi[0].Trim();
            int brMesta = int.Parse(delovi[1]); //program automatski baca izuzetak ako brMesta nije int
            int broj = int.Parse(delovi[2]);
            int brzina = int.Parse(delovi[3]);

            //sad ogranicenja:
            if (brMesta < 0)
                throw new Exception("Neispravna vrednost u fajlu za mesta za sedenje! ");

            if(brzina<90 || brzina>250)
                throw new Exception("Neispravna vrednost u fajlu za brzinu, mora biti izmedju 90 i 250! ");

            //ako je sve uredu citaju se podaci:
            _brMestaZaSedenje = brMesta;
            _naziv = naziv;
            _serijskiBroj = broj;
            _maxBrzina = brzina;
        }

        public void upisi(TextWriter tw) 
        {
            tw.WriteLine(_naziv + " " + _brMestaZaSedenje + " " + _serijskiBroj + " " + _maxBrzina);
        }

        public int BrMestaZaSedenje => _brMestaZaSedenje;
        public string Naziv => _naziv;
        public int SerijskiBroj => _serijskiBroj;
        public int MaxBrzina => _maxBrzina;

        public Automobil() { }

        public Automobil(int br, string n, int sb, int mb)
        {
            if (br < 0)
                throw new Exception("Invalid value in constructor Automobil! ");
            if (mb < 90 || mb > 250)
                throw new Exception("Brzina mora biti izmedju 90 i 250 km/h! ");

            _brMestaZaSedenje = br;
            _naziv = n;
            _serijskiBroj = sb;
            _maxBrzina = mb;
        }

        //public string getTip()
        //{
        //    return "AUTO";
        //}

        //public int getMaxBrzina() { return _maxBrzina; }

        public void print()
        {
            Console.WriteLine(_naziv + " " + _brMestaZaSedenje + " " + _maxBrzina + " " + _serijskiBroj);
        }
    }
}
