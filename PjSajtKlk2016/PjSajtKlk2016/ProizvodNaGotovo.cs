using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjSajtKlk2016
{
    //ova klasa se nije trazila u zadatku ali sam dodao
    public class ProizvodNaGotovo : Proizvod
    {
        private int _kvalitet;
        private double _ocena; 

        public ProizvodNaGotovo() { }

        public ProizvodNaGotovo(string n, int s, Status status, int kval, int oc)
            : base(n, s, status)
        {
            if (kval < 0 || oc < 0)
                throw new Exception("Nevalidni argumenti u konstruktoru! ");

            _kvalitet = kval;
            _ocena = oc;
        }

        public override double Cena => _kvalitet * _ocena;

        public override void UpisiUFajl(TextWriter tw)
        {
            base.UpisiUFajl(tw);
            tw.Write(" Gotovo " + _kvalitet.ToString() + " " + _ocena.ToString());
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

            base.ProcitajIzNiza(delovi);

            //delovi[3] je oznaka
            int kvalitet = int.Parse(delovi[4]);
            double ocena = double.Parse(delovi[5]);

            if (kvalitet < 0 || ocena < 0)
                throw new Exception("Nevalidni argumenti u fajlu! ");

            _ocena = ocena;
            _kvalitet = kvalitet;
        }
    }
}
