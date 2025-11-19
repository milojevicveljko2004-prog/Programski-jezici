using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadVozilo
{

    public delegate void UpozorenjeNosivost(double maxNosivostPuta);
    public class Put
    {
        //private int _brVozila; //trenutni broj vozila
        private List<IVozilo> _niz;
        private int _ogranicenjeBrzina; // km/h
        private int _duzina_puta; //km
        private string _tip;
        private double _maxNosivostPuta; //dodato zbog delegata

        public event UpozorenjeNosivost EventUpozorenje;

        public Put() { }

        public Put(int ogranicenje, int duzina, string tip, double nosivost)
        {
            if (ogranicenje < 0 || duzina < 0)
                throw new Exception("Neispravni atributi prosledjeni konstruktoru Put! ");

            _ogranicenjeBrzina = ogranicenje;
            _duzina_puta = duzina;
            _tip = tip;
            _maxNosivostPuta = nosivost;
            _niz = new List<IVozilo>();
        }

        public void addVozilo(IVozilo v)
        {
            if (v == null)
                throw new Exception("Metodi addVozilo je prosledjen null kao argument! ");

            _niz.Add(v);
            //_brVozila++;

            if (v is Kamion k)
            {
                EventUpozorenje += k.ObradiUpozorenjeNosivost; //pretplata metoda za sve kamione

                //odmah salje upozorenje i poziva pretplatnike
                if (EventUpozorenje != null)
                {
                    EventUpozorenje(_maxNosivostPuta);
                }
            }
        }

        public void PostaviMaxNosivost(double novaNosivost)
        {
            if (novaNosivost < 0)
                throw new Exception("novaNosivost ne sme biti manja od 0! ");

            _maxNosivostPuta = novaNosivost;

            //Ako ima pretplatnika, pozovi ih:
            if (EventUpozorenje != null)
            {
                EventUpozorenje(_maxNosivostPuta);
            }
        }

        //Resenje: I Automobil i Kamion u fajlu imaju na prvoj poziciji tip koji je ili "AUTO" ili "KAMION"
        public void ucitaj(string filename) //ucitava sva vozila iz datoteke, sve automobile ili kamione
        {
            string line;

            using (TextReader tr = new StreamReader(filename))
            {
                while((line=tr.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        throw new Exception("Prazna linija u fajlu! ");

                    string[] delovi = line.Split();

                    if (delovi[0] == "AUTO")
                    {
                        Automobil a = new Automobil();
                        a.ucitaj(new StringReader(line));
                        _niz.Add(a);
                    }
                    else if (delovi[0] == "KAMION")
                    {
                        Kamion k = new Kamion();
                        k.ucitaj(new StringReader(line));
                        _niz.Add(k);
                    }
                    else
                    {
                        throw new Exception("Nepoznat tip vozila u fajlu! ");
                    }
                }
            }
        }


        public void upisi(string filename)
        {
            string line;

            using (TextWriter tw = new StreamWriter(filename, false))
            {
                for (int i = 0; i < _niz.Count; i++)
                {
                    _niz[i].upisi(tw);
                }
            }
        }

        //Izbacuje vozilo u prekrsaju:
        public void remove(int zadatoVreme) //zadato vreme je u satima
        {
            if (zadatoVreme <= 0)
                throw new Exception("Nevalidan argument u metodi remove! ");

            Random rnd = new Random();


            for (int i = _niz.Count-1; i >= 0; i--)
            {
                double prosecna_brzina = rnd.NextDouble() * _niz[i].MaxBrzina;

                              // km/h < h znaci da ne moze da predje put za zadato vreme
                if (_niz[i].MaxBrzina < zadatoVreme || prosecna_brzina>_ogranicenjeBrzina) //to je vozilo za izbacivanje
                {
                    _niz.RemoveAt(i);
                }
            }
        }

        public void print()
        {
            for (int i = 0; i < _niz.Count; i++)
            {
                _niz[i].print();
            }
        }
    }
}
