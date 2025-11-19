using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjOktobar2025Zad2
{
    public class Napadac : Fudbaler
    {
        private int _brMinuta; //koliko napadac moze da izdrzi u igri
        private int _brPostignutihGolova; //u poslednjih godinu dana.
                                          //Potrebno da bi implementirao property.

        public Napadac() { }
        public Napadac(string ime, string prezime, int brMinuta, int brPostignutihGolova) 
            : base(ime, prezime)
        {
            if (brMinuta < 0)
                throw new Exception("Broj minuta ne sme biti manji od 0! ");

            _brMinuta = brMinuta;
            UcinakFudbalera = brPostignutihGolova;
        }

        public int BrMinuta => _brMinuta;

        public override int UcinakFudbalera 
        { 
            get { return _brPostignutihGolova; }
            set 
            {
                if (value < 0)
                    throw new Exception("Broj postignutih golova ne moze biti manji od 0! ");

                _brPostignutihGolova = value;
            }
        }

        public override MeraZaUcinak JedinicaMereUcinak => MeraZaUcinak.BrojGolova;

        public override void UpisiUFajl(TextWriter tw)
        {
            base.UpisiUFajl(tw);
            tw.Write(" " + _brMinuta + " " + _brPostignutihGolova); //nastavlja ispis
            tw.WriteLine();
        }
    }
}
