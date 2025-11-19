using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    public class ProizvodNaMerenje : Proizvod
    {
        private int _masa; //u kg
        private double _cena; //cena po kg

        public override double Cena => _masa * _cena;

        public override StatusProizvoda Status => _status;

        public ProizvodNaMerenje() { }

        public ProizvodNaMerenje(string n, int s, string p, int m, double c)
            : base(n, s, p)
        {
            if (m < 0 || c < 0)
                throw new Exception("Argumenti konstruktora ProizvodNaMerenje ne smeju biti negativni! ");

            _masa = m;
            _cena = c;
        }

        public override void upisi(TextWriter tw)
        {
            tw.WriteLine(_naziv + " " + _sifra + " " + _status + " " + _masa + " " + _cena);
        }

        public override void ucitaj(TextReader tr)
        {
            string line = tr.ReadLine();

            if (line == null)
                throw new Exception("Neocekivan kraj fajla! ");

            if (string.IsNullOrWhiteSpace(line))
                throw new Exception("Nailazak na prazan red pri citanju fajla! ");

            string[] delovi = line.Split();

            if (delovi.Length != 5)
                throw new Exception("Ocekivani broj podataka u liniji fajla je 5! ");

            //Provera tipova za svaki podatak je u konstruktoru:

            ProizvodNaMerenje p = new ProizvodNaMerenje(delovi[0].Trim(), int.Parse(delovi[1]), delovi[2].Trim(),
                int.Parse(delovi[3]), double.Parse(delovi[4]));

            _naziv = p._naziv;
            _sifra = p._sifra;
            _status = p._status;
            _masa = p._masa;
            _cena = p._cena;
        }

        public override void print()
        {
            Console.WriteLine(_naziv + " " + _sifra + " " + _status + " " + _masa + " " + _cena);
        }
    }
}
