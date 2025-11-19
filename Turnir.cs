using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    public class Turnir : FairPlay
    {
        private List<Utakmica> _niz;
        private int _limit; //najveci dozvoljeni broj isključenja po utakmici

        public int Limit => _limit;

        public Turnir() 
        {
            _niz = new List<Utakmica>();
        }

        public Turnir(int l)
        {
            if (l < 0)
                throw new Exception("Limit ne moze biti manji od 0! ");

            _limit = l;
            _niz = new List<Utakmica>();
        }

        public void ucitaj(string filename)
        {
            using (TextReader tr = new StreamReader(filename))
            {
                //prvo trebam da procitam privatan atribut limit pa onda niz utakmica
                string line = tr.ReadLine();

                if (line == null)
                    throw new Exception("Neocekivan kraj fajla! ");

                if (string.IsNullOrWhiteSpace(line))
                    throw new Exception("Prazna linija u fajlu! ");

                string[] delovi = line.Split();

                if (delovi.Length != 1) //prvi red ima samo limit
                    throw new Exception("Neisprvan broj podataka u redu! ");

                int limit = int.Parse(delovi[0]);
                if (limit < 0)
                    throw new Exception("Limit ne sme biti negativan! ");

                _limit = limit;

                while(tr.Peek()!=-1) //do kraja fajla
                {
                    FudbalskaUtakmica fu = new FudbalskaUtakmica();
                    fu.ucitaj(tr);
                    _niz.Add(fu);
                }
            }
        }

        public void upisi(string filename)
        {
            using (TextWriter tw = new StreamWriter(filename))
            {
                tw.WriteLine(_limit); //U posebnoj liniji limit pa nakon toga red po red utakmice

                for (int i = 0; i < _niz.Count; i++)
                {
                    FudbalskaUtakmica f = (FudbalskaUtakmica)_niz[i];
                    f.upisi(tw);
                    //_niz[i].upisi(tw);
                }
            }
        }

        //Ako je FudbalskaUtakmica.UkupanBrIskljucenihIgraca>=Limit odnosno _limit
        public void remove() //ako treba limit kao argument onda umesto >=Limit samo >=argument
        {
            for (int i = _niz.Count-1; i >= 0; i--) //kod izbacivanja mora da se ide unazad
            {
                if (_niz[i].UkupanBrIskljucenihIgraca >= Limit)
                {
                    _niz.RemoveAt(i);
                }
            }
        }

        public void print()
        {
            Console.WriteLine(_limit);

            for (int i = 0; i < _niz.Count; i++)
            {
                _niz[i].print();
            }
        }
    }
}
