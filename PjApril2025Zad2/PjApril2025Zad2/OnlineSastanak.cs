using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjApril2025Zad2
{
    public class OnlineSastanak : Obaveza
    {
        private int _maxKasnjenje;
        private bool _jacinaInterneta; //slab ili jak

        public OnlineSastanak() { }

        public OnlineSastanak(string naziv, int prioritetIzvrsenja, int satPocetka, int satKraja,
            int maxKasnjenje, bool internet) : base(naziv, prioritetIzvrsenja, satPocetka, satKraja)
        {
            if (maxKasnjenje < 0)
                throw new Exception("Max kasnjenje ne moze biti manje od 0! ");

            this._maxKasnjenje = maxKasnjenje;
            this._jacinaInterneta = internet;
        }

        public override int VremeIzvrsenja
        {
            get
            {
                if (!_jacinaInterneta) //internet je slab - povecaj za 10%
                {
                    return (int)(((this._satKrajaIzvrsenja - this._satPocetkaIzvrsenja)
                        * 60 + this._maxKasnjenje) * 1.1);
                }
                else
                    return (int)((this._satKrajaIzvrsenja - this._satPocetkaIzvrsenja)
                        * 60 + this._maxKasnjenje);
            }
        }

        public override void UpisiUFajl(TextWriter tw)
        {
            base.UpisiUFajl(tw);
            tw.Write(" " + _maxKasnjenje + " " + _jacinaInterneta);
            tw.WriteLine();
        }

        public override void UcitajIzFajla(TextReader tr)
        {
            //base ce u UcitajIzFajla() da pozove i overridovanu pomocnu f-ju
            base.UcitajIzFajla(tr);

        }

        public override void ProcitajIzNiza(string[] delovi)
        {
            if (delovi.Length != 6)
                throw new Exception("Neispravan broj podataka u fajlu! ");

            base.ProcitajIzNiza(delovi); //procitani su atributi osnovne klase

            //pa sad cita dodatne atribute:

            int maxKasnjenje = int.Parse(delovi[4]);
            bool jacinaInterneta = bool.Parse(delovi[5]);
            //string vrstaSastanka = delovi[6].Trim(); //dodatni atribut

            if (maxKasnjenje < 0)
                throw new Exception("Max kasnjenje ne moze biti manje od 0! ");

            _maxKasnjenje = maxKasnjenje;
            _jacinaInterneta = jacinaInterneta;
        }

        //public override void print()
        //{
        //    base.print();
        //    Console.Write(" " + _maxKasnjenje + " " + _jacinaInterneta);
        //    Console.WriteLine();
        //}

        public override string ToString()
        {
            return base.ToString() + " " + _maxKasnjenje + " " + _jacinaInterneta + "\n";
        }

    }
}
