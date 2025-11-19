using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    public class Korpa : INaplata
    {
        private string _valuta; //RSD ili EUR ili USD
        //private double _cena;
        private double _limit;
        private List<Proizvod> _niz;

        public Korpa() 
        {
            _niz = new List<Proizvod>();
        }

        public Korpa(string v, double l)
        {
            if (!v.Equals("RSD") && !v.Equals("EUR") && !v.Equals("USD"))
                throw new Exception("Neispravno uneta valuta u konstruktoru Korpa! ");

            //if (c < 0)
            //    throw new Exception("Cena ne moze biti manja od 0! ");

            if (l < 0)
                throw new Exception("Limit ne sme biti manji od 0! ");

            _valuta = v;
            //_cena = c;
            _limit = l;
            _niz = new List<Proizvod>();
        }

        public string Valuta => _valuta;

        //misli se na ukupnu cenu svih proizvoda, a ne da korpa ima cenu
        public double Cena
        {
            get
            {
                double cena = 0;
                for (int i = 0; i < _niz.Count; i++)
                {
                    cena = cena + _niz[i].Cena;
                }
                return cena;
            }
        }

        public double Limit => _limit;

        //tekstualni fajl je takav da idu privatni atributi klase Korpa pa onda
        //ispod njih redom atributi svakog proizvoda iz liste
        public void upisi(string filename)
        {
            using (TextWriter tw = new StreamWriter(filename))
            {
                tw.WriteLine(_valuta + " " + _limit); 

                for (int i = 0; i < _niz.Count; i++)
                {
                    _niz[i].upisi(tw); 
                }
                //tw.Close(); //using sam zatvara, pa ovo ne treba
            }
        }

        public void ucitaj(string filename)
        {
            using (TextReader tr = new StreamReader(filename))
            {
                //prvo trebam da procitam atribute ove klase Korpa

                string line = tr.ReadLine();

                if (line == null)
                    throw new Exception("Neocekivan kraj fajla! ");

                if (string.IsNullOrWhiteSpace(line))
                    throw new Exception("Prazna linija u fajlu! ");

                string[] delovi = line.Split();

                if (delovi.Length != 2)
                    throw new Exception("Fajl mora imati dva podatka u liniji za korpu! ");

                string valuta = delovi[0].Trim();
                //double cena = double.Parse(delovi[1]); //program automatski javlja gresku ako tip nije ispravan
                double limit = double.Parse(delovi[1]);

                //konstruktor i postavlja vrednosti i pre toga ih proverava
                Korpa k = new Korpa(valuta, limit);

                _valuta = k.Valuta;
                _limit = k.Limit;
                _niz.Clear(); 

                //sad treba procitati vrednosti proizvoda i redom ih smestiti u listu/niz

                while (tr.Peek()!=-1) //dok se ne dodje do kraja fajla
                {
                    var p = new ProizvodNaMerenje();
                    p.ucitaj(tr); //objekat p dobija kao atribute vrednosti koje su u fajlu
                    _niz.Add(p);

                    //if (Cena > _limit) //program javlja gresku kada imam ovo najverovatnije zbog parse
                    //    throw new Exception("Ukupna cena je premasila limit! ");

                }
            }
        }

        //Izbacuje sve proizvode koji imaju zadati status
        public void remove(StatusProizvoda status) 
        {
            for(int i=_niz.Count-1; i>=0; i--)
            {
                if (_niz[i].Status == status) 
                {
                    _niz.RemoveAt(i);
                }
            }
        }

        public void print()
        {
            Console.WriteLine("Valuta: " + _valuta + ", Limit: " + _limit);
            Console.WriteLine("PROIZVODI: ");
            for (int i = 0; i < _niz.Count; i++)
            {
                _niz[i].print();
            }
        }
    }
}
