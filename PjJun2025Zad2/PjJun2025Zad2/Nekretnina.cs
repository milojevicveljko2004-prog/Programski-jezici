using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjJun2025Zad2
{
    public enum TipNekretnine { Kuca, Zgrada, Soliter }
    public class Nekretnina : Parcela
    {
        private TipNekretnine _tip;
        private int _brStambenihJedinica;
        private bool _prikljucenaNaGrejanje;

        public Nekretnina() { }

        public Nekretnina(int id, double povrsina, string adresa, DateTime datumKupovine, 
            TipNekretnine tip, int brStambenihJedinica, bool prikljucenaNaGrejanje) 
            :base(id, povrsina, adresa, datumKupovine)
        {
            if (brStambenihJedinica < 0)
                throw new Exception("Nevalidni argumenti u konstruktoru! ");

            _tip = tip;
            _brStambenihJedinica = brStambenihJedinica;
            _prikljucenaNaGrejanje = prikljucenaNaGrejanje;
        }

        public override double VrednostParcele
        {
            get
            {
                double vrednost = (double)this._brStambenihJedinica * this._povrsina;
                if (_tip == TipNekretnine.Kuca)
                {
                    return vrednost * 1.2;
                }
                else if (_tip == TipNekretnine.Zgrada)
                {
                    return vrednost * 1.3;
                }
                else //soliter
                {
                    return vrednost * 1.5;
                }
            }
        }

        public override void UpisiUFajl(TextWriter tw)
        {
            base.UpisiUFajl(tw);
            tw.Write(" " + _tip + " " + _brStambenihJedinica + " " + _prikljucenaNaGrejanje);
            tw.WriteLine();
        }

        public override void print()
        {
            base.print();
            Console.Write(" " + _tip + " " + _brStambenihJedinica + " " + _prikljucenaNaGrejanje);
            Console.WriteLine();
        }
    }
}
