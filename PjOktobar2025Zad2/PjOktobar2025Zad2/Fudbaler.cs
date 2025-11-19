using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjOktobar2025Zad2
{
    public enum MeraZaUcinak { BrojGolova, ProcenatOdbrana }
    public abstract class Fudbaler
    {
        protected string _ime;
        protected string _prezime;

        public Fudbaler() { }

        public Fudbaler(string ime, string prezime)
        {
            _ime = ime;
            _prezime = prezime;
        }

        public abstract int UcinakFudbalera { get; set; } //u poslednjih godinu dana

        public abstract MeraZaUcinak JedinicaMereUcinak { get; }

        public string Ime => _ime;
        public string Prezime => _prezime;

        public virtual void UpisiUFajl(TextWriter tw)
        {
            tw.Write(Ime + " " + Prezime); //izvedene klase trebaju da nastave upis
        }

        public double RelativniUcinak(int norma)
        {
            if (norma < 0)
                throw new Exception("norma ne sme biti manja od 0! ");

            return (double)UcinakFudbalera / norma;
        }
    }
}
