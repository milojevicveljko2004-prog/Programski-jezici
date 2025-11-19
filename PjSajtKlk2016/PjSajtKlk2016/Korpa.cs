using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjSajtKlk2016
{
    public class Korpa : INaplata
    {
        private string _valuta;
        private double _cenaZaNaplatu;
        private double _limit; //najveca cena za naplatu
        private List<Proizvod> _lista;

        public Korpa()
        {
            _lista = new List<Proizvod>();
        }

        public Korpa(string valuta, double cenaZaNaplatu, double limit)
        {
            if (cenaZaNaplatu < 0 || limit < 0 || cenaZaNaplatu > limit)
                throw new Exception("Nevalidni argumenti u konstruktoru! ");

            _valuta = valuta;
            _cenaZaNaplatu = cenaZaNaplatu;
            _limit = limit;
            _lista = new List<Proizvod>();
        }

        public string Valuta => _valuta;

        public double CenaZaNaplatu => _cenaZaNaplatu;

        public double Limit => _limit;

        public void UpisiUFajl(string filename)
        {
            using (TextWriter fw = new StreamWriter(filename))
            {
                //prvo zapisi svoje atribute:
                fw.WriteLine(Valuta + " " + CenaZaNaplatu.ToString() + " " + Limit.ToString());

                foreach (Proizvod p in _lista)
                {
                    p.UpisiUFajl(fw);
                }
            }
        }

        public void UcitajIzFajla(string filename)
        {
            using (TextReader tr = new StreamReader(filename))
            {
                //prvo procitaj svoje argumente

                string line = tr.ReadLine();

                if (line == null)
                    throw new Exception("Neocekivani kraj fajla! ");

                if (string.IsNullOrWhiteSpace(line))
                    throw new Exception("Prazan red u fajlu! ");

                string[] delovi = line.Split();

                string valuta = delovi[0].Trim();
                double cena = double.Parse(delovi[1]);
                double limit = double.Parse(delovi[2]);

                if (cena < 0 || limit < 0 || cena > limit)
                    throw new Exception("Nevalidni argumenti u fajlu! ");

                _valuta = valuta;
                _limit = limit;
                _cenaZaNaplatu = cena;

                //a sad procitaj argumente za objekte liste:

                while(tr.Peek() != -1) //sve dok ima objekata
                {
                    string newLine = tr.ReadLine(); //prelazak na sledeci red svaki put

                    if (newLine == null)
                        throw new Exception("Neocekivani kraj fajla! ");

                    if (string.IsNullOrWhiteSpace(newLine))
                        throw new Exception("Prazan red u fajlu! ");

                    string[] delovi2 = newLine.Split();

                    //u obe klase je na cetvrtom mestu naziv vrste
                    string vrsta = delovi2[3].Trim();

                    Proizvod proizvod;
                    if (vrsta == "Merenje")
                    {
                        proizvod = new ProizvodNaMerenje();
                    }
                    else if (vrsta == "Gotovo")
                    {
                        proizvod = new ProizvodNaGotovo();
                    }
                    else
                    {
                        throw new Exception("Nevalidan naziv vrste u fajlu! ");
                    }

                    proizvod.ProcitajIzNiza(delovi2);
                    _lista.Add(proizvod);
                }
            }
        }
    }
}
