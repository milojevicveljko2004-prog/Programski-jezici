using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2Septembar2025
{
    public enum NacinIsplate { Trenutno, Odlozeno }
    public abstract class Glumac
    {
        protected string _ime;
        protected string _prezime;
        protected NacinIsplate _isplata;
        protected double _osnovnaPlata;
        protected float _popularnost; //realan broj izmedju 1 i 10
        public float popularnost
        {
            get
            {
                return this._popularnost;
            }
            set
            {
                if(value >= 1 && value <= 10)
                    this._popularnost = value;
                else
                    throw new Exception("Popularnost mora biti izmedju 1 i 10! ");
            }
        }

        public Glumac() { }

        public Glumac(string ime, string prezime, NacinIsplate isplata, double osnPlata, float popul)
        {
            if (osnPlata < 0)
                throw new Exception("Plata ne sme biti manja od 0! ");

            if (popul < 1 || popul > 10)
                throw new Exception("Popularnost mora biti izmedju 1 i 10! ");
            this.popularnost = popul;

            _ime= ime;
            _prezime= prezime;
            _isplata= isplata;
            _osnovnaPlata= osnPlata; 
            //_popularnost= popul;
        }

        public NacinIsplate Isplata => _isplata;

        public abstract double StvarnaPlata { get; }

        public double DobijenoUlozeno() { return StvarnaPlata / _popularnost; }

        public virtual void print()
        {
            Console.Write(_ime + " " + _prezime + " " + _isplata + " " + _osnovnaPlata + " " + _popularnost);
        }
    }
}
