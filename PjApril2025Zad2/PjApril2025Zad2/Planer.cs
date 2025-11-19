using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjApril2025Zad2
{
    public class Planer
    {
        private string _ime;
        private string _prezime;
        private int _raspolozivoVreme; //u minutima
        private List<Obaveza> _lista;

        public Planer() { _lista = new List<Obaveza>(); }

        public Planer(string ime, string prezime, int raspolozivoVreme)
        {
            if (raspolozivoVreme < 0)
                throw new Exception("Vreme ne moze biti manje od 0! ");

            _ime = ime;
            _prezime = prezime;
            _raspolozivoVreme = raspolozivoVreme;
            _lista = new List<Obaveza>();
        }

        //indekser
        public Obaveza this[int i]
        {
            get { return _lista[i]; }
        }

        public void DodajObavezu(Obaveza o)
        {
            int ukupnoRaspolozivoVreme = 0; //odnosno vreme izvrsenja za sve obaveze

            foreach (Obaveza obaveza in _lista)
            {
                ukupnoRaspolozivoVreme += obaveza.VremeIzvrsenja;
            }

            if (ukupnoRaspolozivoVreme > this._raspolozivoVreme)
                throw new Exception("Prekoraceno raspolozivo vreme! ");

            _lista.Add(o);
        }

        //uredjuje obaveze u rastuci redosled po prioritetu
        public void UrediPoPrioritetu()
        {
            for (int i = 0; i < _lista.Count-1; i++)
            {
                for (int j = i+1; j < _lista.Count; j++)
                {
                    if (_lista[j].PrioritetIzvrsenja > _lista[i].PrioritetIzvrsenja)
                    {
                        Obaveza pom = _lista[j];
                        _lista[j] = _lista[i];
                        _lista[i] = pom;
                    }
                }
            }
        }

        //izbacuje sve obaveze cije je vreme izvrsenja vece od prosledjenog
        public void IzbaciOdredjene(int vreme)
        {
            if (vreme < 0)
                throw new Exception("vreme ne sme biti negativno! ");

            for (int i = _lista.Count-1; i>=0;  i--)
            {
                if (_lista[i].VremeIzvrsenja > vreme)
                {
                    _lista.RemoveAt(i);
                }
            }
        }

        public void UpisiUFajl(string filename)
        {
            using (TextWriter tw = new StreamWriter(filename))
            {
                //prvo upisuje svoje atribute u jednoj liniji
                tw.WriteLine(_ime + " " + _prezime + " " + _raspolozivoVreme);

                //sad upisuje obaveze liniju po liniju
                foreach (Obaveza o in _lista)
                {
                    o.UpisiUFajl(tw);
                }
            }
        }

        public void UcitajIzFajla(string filename)
        {
            using (TextReader tr = new StreamReader(filename))
            {
                //prvo cita svoje atribute

                string linija = tr.ReadLine();

                if (linija == null)
                    throw new Exception("Neocekivan kraj fajla! ");

                if (string.IsNullOrWhiteSpace(linija))
                    throw new Exception("Prazna linija u fajlu! ");

                string[] delovi = linija.Split();

                if (delovi.Length != 3)
                    throw new Exception("Ocekivan broj podataka u fajlu je 3! ");

                string ime = delovi[0].Trim();
                string prezime = delovi[1].Trim();
                int raspolozivoVreme = int.Parse(delovi[2].Trim());

                if(raspolozivoVreme<0)
                    throw new Exception("Vreme ne moze biti manje od 0! ");

                _ime = ime;
                _prezime = prezime;
                _raspolozivoVreme = raspolozivoVreme;

                //sad citanje Obaveza iz liste:

                while(tr.Peek() != -1) //sve dok ima linija u fajlu
                {
                    string line = tr.ReadLine(); //nova linija, u njoj je obaveza

                    if (string.IsNullOrWhiteSpace(linija))
                        throw new Exception("Prazna linija u fajlu! ");

                    string[] tokeni = line.Split();
                    string oznaka = tokeni[4].Trim();

                    Obaveza o;
                    if (tokeni.Length == 6)
                    {
                        o = new OnlineSastanak();
                    }
                    else if (tokeni.Length == 5)
                    {
                        o = new ZakazanaObaveza();
                    }
                    else
                    {
                        throw new Exception("Nepoznata vrsta obaveze u fajlu! ");
                    }

                    //Moze i ovo ali da se prepravi fajl
                    //if (oznaka == "O")
                    //{
                    //    o = new OnlineSastanak();
                    //}
                    //else if (oznaka == "Z")
                    //{
                    //    o = new OnlineSastanak();
                    //}
                    //else
                    //{
                    //    throw new Exception("Nepoznata vrsta obaveze u fajlu! ");
                    //}

                    o.ProcitajIzNiza(tokeni); //ne sme ponovo da se otvori linija
                    _lista.Add(o);
                }
            }
        }

        //public void print()
        //{
        //    Console.WriteLine(_ime + " " + _prezime + " " + _raspolozivoVreme);

        //    foreach (Obaveza o in _lista)
        //    {
        //        o.print();
        //    }
        //}

        public override string ToString()
        { 
            string output = _ime + " " + _prezime + " " + _raspolozivoVreme + "\n";
            foreach (Obaveza o in _lista)
            {
                output += o.ToString();
            }
            return output;
        }
    }
}
