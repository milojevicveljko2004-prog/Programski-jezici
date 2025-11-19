using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    public enum IshodUtakmice { PobedaDomacina, PobedaGosta, Nereseno }
    public abstract class Utakmica
    {
        protected string _nazivDomaci;
        protected string _nazivGosti;

        public Utakmica() { }

        public Utakmica(string domaci, string gosti)
        {
            _nazivDomaci = domaci;
            _nazivGosti = gosti;
        }

        public abstract IshodUtakmice Ishod { get; }

        public abstract int UkupanBrIskljucenihIgraca { get; }

        public virtual void upisi(TextWriter tw)
        {
            //Write umesto WriteLine jer hocu da nastavim sa atributima izvedene klase
            tw.Write(_nazivDomaci + " " + _nazivGosti);
        }

        public virtual void ucitaj(string[] delovi)
        {
            //if (delovi.Length != 2)
            //    throw new Exception("Delovi prosledjeni osnovnoj klasi nisu ispravni! ");

            _nazivDomaci = delovi[0].Trim();
            _nazivGosti = delovi[1].Trim();
        }

        //private void ucitajDelove(string[] delovi)
        //{
        //    if (delovi.Length != 2)
        //        throw new Exception("Delovi prosledjeni osnovnoj klasi nisu ispravni! ");

        //    _nazivDomaci = delovi[0].Trim();
        //    _nazivGosti = delovi[1].Trim();
        //}

        public virtual void print()
        {
            Console.Write(_nazivDomaci + " " + _nazivGosti);
        }

    }
}
