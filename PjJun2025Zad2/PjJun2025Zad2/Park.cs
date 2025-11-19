using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjJun2025Zad2
{
    public class Park : Parcela
    {
        private int _brKafica;
        private int _brKlupica;
        private bool _imaOgradjenDeo;

        public Park() { }

        public Park(int id, double povrsina, string adresa, DateTime datumKupovine, int brKafica,
            int brKlupica, bool imaOgradjenDeo) : base(id, povrsina, adresa, datumKupovine)
        {
            if (brKafica < 0 || brKlupica < 0)
                throw new Exception("Nevalidni argumenti u konstruktoru! ");

            _brKafica = brKafica;
            _brKlupica = brKlupica;
            _imaOgradjenDeo = imaOgradjenDeo;
        }

        public override double VrednostParcele
        {
            get
            {
                if (!this._imaOgradjenDeo)
                {
                    return this._povrsina * this._povrsina * this._brKafica * this._brKlupica;
                }
                else //ako ima ogradjen deo za pse, uvecaj za 20%
                {
                    return this._povrsina * this._povrsina * this._brKafica * this._brKlupica * 1.2;
                }
            }
        }

        public override void UpisiUFajl(TextWriter tw)
        {
            base.UpisiUFajl(tw);
            tw.Write(" " + _brKafica + " " + _brKlupica + " " + _imaOgradjenDeo);
            tw.WriteLine();
        }

        public override void print()
        {
            base.print();
            Console.Write(" " + _brKafica + " " + _brKlupica + " " + _imaOgradjenDeo);
            Console.WriteLine();
        }
    }
}
