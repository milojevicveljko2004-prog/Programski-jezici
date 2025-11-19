using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    public enum StatusProizvoda { Prodavnica, Magacin, NarucenOdProizvodjaca  }
    public abstract class Proizvod
    {
        protected string _naziv;
        protected int _sifra;
        protected StatusProizvoda _status;

        public Proizvod() { }
        public Proizvod(string n, int s, string p)
        {
            _naziv = n;
            _sifra = s;

            //prevera da li je unet ispravan enum
            bool pronadjen = false;
            foreach (StatusProizvoda st in Enum.GetValues(typeof(StatusProizvoda)))
            { 
                if(string.Equals(st.ToString(), p, StringComparison.OrdinalIgnoreCase))
                {
                    pronadjen = true;
                    _status = st;
                    break;
                }
            }

            if (pronadjen == false)
                throw new Exception("Neispravno unet enum! ");
        }

        public abstract double Cena { get; }

        public abstract StatusProizvoda Status { get; }

        public abstract void upisi(TextWriter tw);

        public abstract void ucitaj(TextReader tr);

        public abstract void print();
    }
}
