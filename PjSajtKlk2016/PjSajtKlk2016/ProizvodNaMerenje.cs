using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjSajtKlk2016
{
    public class ProizvodNaMerenje : Proizvod
    {
        private int _masa; //u kilogramima
        private double _cena; //po kilogramu

        public ProizvodNaMerenje() { }

        public ProizvodNaMerenje(string n, int s, Status status, int m, double c) : base(n, s, status)
        {
            if (m < 0 || c < 0)
                throw new Exception("Nevalidni argumenti u konstruktoru! ");

            _masa = m;
            _cena = c;
        }

        public override double Cena => _masa * _cena;

        public override void UpisiUFajl(TextWriter tw)
        {
            base.UpisiUFajl(tw);
            tw.Write(" Merenje " + _masa.ToString() + " " + _cena.ToString());
            tw.WriteLine();
        }

        public override void UcitajIzFajla(TextReader tr)
        {
            base.UcitajIzFajla(tr);
        }

        public override void ProcitajIzNiza(string[] delovi)
        {
            if (delovi.Length != 6) //5 + oznaka
                throw new Exception("Neispravan broj podataka u fajlu! ");

            base.ProcitajIzNiza(delovi); //cita atribute osnovne klase

            //string oznaka = delovi[3];
            int masa = int.Parse(delovi[4]);
            int cena = int.Parse(delovi[5]);

            //posto nema propertija po tekstu zadatka, moram ovde proveru
            //(bolje nego da pozivam konstruktor)
            if (masa < 0 || cena < 0)
                throw new Exception("Nevalidni argumenti u fajlu! ");

            _masa = masa;
            _cena = cena;
        }
    }
}
