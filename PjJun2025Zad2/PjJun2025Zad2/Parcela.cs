using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjJun2025Zad2
{
    public abstract class Parcela
    {
        protected int _id;
        protected double _povrsina;
        protected string _adresa;
        protected DateTime _datumKupovine;

        public Parcela() { }

        public Parcela(int id, double povrsina, string adresa, DateTime datumKupovine)
        {
            if (id < 0 || povrsina < 0)
                throw new Exception("Nevalidni argumenti u konstruktoru! ");

            _id = id;
            _povrsina = povrsina;
            _adresa = adresa;
            _datumKupovine = datumKupovine;
        }

        public abstract double VrednostParcele { get; }

        public DateTime DatumKupovine => _datumKupovine;

        //upisace svoje atribute
        public virtual void UpisiUFajl(TextWriter tw)
        {
            tw.Write(_id + " " + _povrsina + " " + _adresa + " " + _datumKupovine);
        }

        public virtual void print()
        {
            Console.Write(_id + " " + _povrsina + " " + _adresa + " " + _datumKupovine);
        }
    }
}
