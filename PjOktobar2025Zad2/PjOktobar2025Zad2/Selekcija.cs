using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjOktobar2025Zad2
{
    public class Selekcija
    {
        private List<Fudbaler> _lista;
        private int _maxBrFudbalera;
        private int _ocekivanaNorma;

        public Selekcija() { _lista = new List<Fudbaler>(); }

        public Selekcija(int max, int norma)
        {
            if (max < 0)
                throw new Exception("Max broj elemenata liste ne moze biti manji od 0! ");

            _maxBrFudbalera = max;
            OcekivanaNorma = norma;
            _lista = new List<Fudbaler>(_maxBrFudbalera);
        }

        public int OcekivanaNorma
        {
            get { return _ocekivanaNorma; }
            set
            {
                if (value < 0)
                    throw new Exception("Norma ne moze biti manja od 0! ");

                _ocekivanaNorma = value;
            }
        }

        public void AddPlayer(Fudbaler f)
        {
            if (f == null)
                throw new Exception("Prosledjen fudbaler je null! ");

            if (_lista.Count >= _maxBrFudbalera)
                throw new Exception("Nema vise mesta u selekciji! ");

            _lista.Add(f);
        }

        public void upisiUFajl(string filename)
        {
            using (TextWriter tw = new StreamWriter(filename))
            {
                //prvo privatni atributi ove klase, neka bude da su oni u prvom redu
                // a u svakom sledecem redu su fudbaleri
                tw.WriteLine("Max broj fudbalera: " + _maxBrFudbalera + ", Norma: " + _ocekivanaNorma 
                    + ", FUDBALERI: ");

                for (int i = 0; i < _lista.Count; i++)
                {
                    _lista[i].UpisiUFajl(tw);
                }
            }
        }

        //Ja vec imam listu kada kreiram objekat klase Selekcija.
        //Sad od te liste trebam da napravim nove dve?
        //Da li je jedna od njih this(ta na kojoj sam primenio metodu npr selekcija.razvrstaj())
        //A druga je mozda povratna vrednost?
        //Pa bi u main bilo listaRezerve=selekcija.razvrstaj() ?
        public Selekcija RazvrstajFudbalere()
        {
            Selekcija res = new Selekcija(_lista.Count, _ocekivanaNorma);
            for (int i = _lista.Count-1; i >= 0; i--)
            {
                //rezervna selekcija
                if (_lista[i].RelativniUcinak(_ocekivanaNorma) < 0.8)
                {
                    if (_lista[i].RelativniUcinak(_ocekivanaNorma) < 0.2)
                    {
                        throw new Exception("Greska pri kreiranju selekcije! Relativni ucinak" +
                            " ne sme biti manji od 0,2! ");
                    }
                    else //premesti fudbalera iz startne selekcije i smesti u rezervnu
                    {
                        res.AddPlayer(_lista[i]); //smesten u rezervnu
                        _lista.RemoveAt(i);
                    }
                }
            }

            return res;
        }
    }
}
