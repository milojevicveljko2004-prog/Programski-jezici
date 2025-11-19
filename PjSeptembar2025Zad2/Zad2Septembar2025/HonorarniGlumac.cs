using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2Septembar2025
{
    public class HonorarniGlumac : Glumac
    {
        private int _brSati;
        private float _cenaPoSatu; //u dinarima

        public HonorarniGlumac() { }
        public HonorarniGlumac(string ime, string prezime, NacinIsplate isplata,
            double osnPlata, float popul, int brSati, float cena) : base(ime, prezime, isplata, osnPlata, popul)
        {
            if (brSati < 0 || cena < 0)
                throw new Exception("Neispravni argumenti u konstruktoru HonorarniGlumac! ");

            _brSati = brSati;
            _cenaPoSatu = cena;
        }
        public override double StvarnaPlata => _osnovnaPlata + _brSati * _cenaPoSatu;

        public override void print()
        {
            base.print();
            Console.Write(" " + _brSati + " " + _cenaPoSatu);
            Console.WriteLine();
        }
    }
}
