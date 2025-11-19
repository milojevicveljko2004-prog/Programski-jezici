using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjOktobar2025Zad2
{
    public class Golman : Fudbaler
    {
        bool _dobroBraniPenale;
        int _procenatUspesnihOdbrana;

        public Golman() { }

        public Golman(string ime, string prezime, bool brani, int odbrane)
            : base(ime, prezime)
        {
            _dobroBraniPenale = brani;
            UcinakFudbalera = odbrane;
        }

        public bool DobroBraniPenale => _dobroBraniPenale;

        public override int UcinakFudbalera
        {
            get { return _procenatUspesnihOdbrana; }
            set 
            {
                if (value < 0)
                    throw new Exception("Procenat uspesnih odbrana ne moze biti manji od 0! ");

                _procenatUspesnihOdbrana = value;
            }
        }

        public override MeraZaUcinak JedinicaMereUcinak => MeraZaUcinak.ProcenatOdbrana;

        public override void UpisiUFajl(TextWriter tw)
        {
            base.UpisiUFajl(tw);
            tw.Write(" " + _dobroBraniPenale + " " + _procenatUspesnihOdbrana);
            tw.WriteLine();
        }
    }
}
