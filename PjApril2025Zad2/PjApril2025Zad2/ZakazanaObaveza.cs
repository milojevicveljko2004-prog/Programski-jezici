using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjApril2025Zad2
{
    public enum PrevoznoSredstvo { Pesice, Auto, Bicikl }
    public class ZakazanaObaveza : Obaveza
    {
        private PrevoznoSredstvo _prevoznoSredstvo;

        public ZakazanaObaveza() { }

        public ZakazanaObaveza(string naziv, int prioritetIzvrsenja, int satPocetka, int satKraja,
            PrevoznoSredstvo prevoznoSredstvo) : base(naziv, prioritetIzvrsenja, satPocetka, satKraja)
        {
            _prevoznoSredstvo = prevoznoSredstvo;
        }

        public override int VremeIzvrsenja
        {
            get
            {
                int vrednost = (this._satKrajaIzvrsenja - this._satPocetkaIzvrsenja) * 60;

                if (_prevoznoSredstvo == PrevoznoSredstvo.Bicikl) //povecaj za 20%
                {
                    return (int)(vrednost * 1.2);
                }

                else if (_prevoznoSredstvo == PrevoznoSredstvo.Pesice) //povecaj za 30%
                {
                    return (int)(vrednost * 1.3);
                }
                else
                {
                    return vrednost;
                }
            }
        }

        public override void UpisiUFajl(TextWriter tw)
        {
            base.UpisiUFajl(tw);
            tw.Write(" " + _prevoznoSredstvo);
            tw.WriteLine();
        }

        public override void UcitajIzFajla(TextReader tr)
        {
            //base ce u UcitajIzFajla() da pozove i overridovanu pomocnu f-ju
            base.UcitajIzFajla(tr);
        }

        public override void ProcitajIzNiza(string[] delovi)
        {
            if (delovi.Length != 5)  
                throw new Exception("Neispravan broj podataka u fajlu! ");

            base.ProcitajIzNiza(delovi); //procitace atribute osnovne klase

            string prevoznoSredstvo = delovi[4].Trim();

            bool pronadjen = false;
            foreach (PrevoznoSredstvo p in Enum.GetValues(typeof(PrevoznoSredstvo)))
            {
                if (string.Equals(p.ToString(), prevoznoSredstvo, StringComparison.OrdinalIgnoreCase))
                {
                    pronadjen = true;
                    this._prevoznoSredstvo = p;
                    break;
                }
            }

            if (!pronadjen)
                throw new Exception("Neispravno prevozno sredstvo u fajlu! ");

        }

        //public override void print()
        //{
        //    base.print();
        //    Console.Write(" " + _prevoznoSredstvo);
        //    Console.WriteLine();
        //}

        public override string ToString()
        {
            return base.ToString() + " " + _prevoznoSredstvo.ToString() + "\n";
        }
    }
}
