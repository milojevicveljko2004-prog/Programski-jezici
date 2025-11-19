using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2Septembar2025
{
    public class StalniGlumac : Glumac
    {
        private float _faktor_skaliranja;

        public StalniGlumac() { }
        public StalniGlumac(string ime, string prezime, NacinIsplate isplata,
            double osnPlata, float popul, float faktor) : base(ime, prezime, isplata, osnPlata, popul)
        {
            _faktor_skaliranja = faktor;
        }
        public override double StvarnaPlata => _osnovnaPlata * _faktor_skaliranja;

        public override void print()
        {
            base.print();
            Console.Write(" " + _faktor_skaliranja); //nastavlja ispis
            Console.WriteLine();
        }
    }
}
