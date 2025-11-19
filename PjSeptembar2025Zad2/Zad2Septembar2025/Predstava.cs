using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2Septembar2025
{
    public class Predstava
    {
        private string _naziv;
        private int _budzet;
        private List<Glumac> _niz; //glumci angazovani na predstavi
        private int _minBrGlumaca;
        private int _maxBrGlumaca;

        public Predstava() 
        {
            _niz = new List<Glumac>();
        }

        public Predstava(string naziv, int budzet, int min, int max)
        {
            if (budzet < 0 || min < 0 || max < 0)
                throw new Exception("Neispravni argumenti u konstruktoru Predstava! ");

            if (max < min)
                throw new Exception("minBrGlumaca mora biti manji od maxBrGlumaca! ");

            _naziv = naziv;
            _budzet = budzet;
            _minBrGlumaca = min;
            _maxBrGlumaca= max;
            _niz = new List<Glumac>(_maxBrGlumaca);
        }

        //metoda koja treba da vrati ukupan broj TrenutnaPlata za sve glumce kojima je status Trenutno
        public double sredstva()
        {
            double res = 0;
            for (int i = 0; i < _niz.Count; i++)
            {
                if (_niz[i].Isplata == NacinIsplate.Trenutno)
                {
                    res += _niz[i].StvarnaPlata;
                }
            }

            return res;
        }

        public void print()
        {
            Console.WriteLine("PREDSTAVA: " + _naziv + " " + _budzet + " " + _minBrGlumaca + " " + _maxBrGlumaca);
            Console.WriteLine("GLUMCI: ");

            for (int i = 0; i < _niz.Count; i++)
            {
                _niz[i].print(); 
            }
        }

        //iz prosledjene liste se u listu _niz dodaju glumci po odnosu dobijeno/ulozeo (postoji metoda za svakog glumca)
        //dodaju se najpre glumci kod kojih je ovaj odnos najveci. Dodaje se dok se ne ispuni min broj glumaca
        public void izborGlumaca(List<Glumac> potencijalniGlumci)
        {
            sortList(potencijalniGlumci);
            _niz.Clear();

            double potrosnja = 0;

            foreach (var g in potencijalniGlumci)
            {
                if (_niz.Count >= _maxBrGlumaca) break;

                if (g.Isplata == NacinIsplate.Trenutno)
                {
                    if (potrosnja + g.StvarnaPlata <= _budzet)
                    {
                        _niz.Add(g);
                        potrosnja += g.StvarnaPlata;
                    }
                }
                else // Odlozeno
                {
                    _niz.Add(g);
                }
            }

            // 3) ako nemamo minimum, pokušaj još da dodaš 'Odlozeno' (ne diraju budžet)
            if (_niz.Count < _minBrGlumaca)
            {
                foreach (var g in potencijalniGlumci)
                {
                    if (_niz.Count >= _minBrGlumaca) break;
                    if (_niz.Contains(g)) continue;
                    if (g.Isplata == NacinIsplate.Odlozeno)
                        _niz.Add(g);
                }
            }

            // 4) ako i dalje nema minimuma -> izuzetak
            if (_niz.Count < _minBrGlumaca)
                throw new Exception("Nemoguće formirati ansambl uz dati budžet i ograničenja (min/max).");

        }

        //pomocna f-ja sortira glumce po odnosu dobijeno/ulozeno
        private void sortList(List<Glumac> lista)
        {
            if (lista.Count == 0 || lista==null)
                throw new Exception("Prosledjena je prazna lista! ");

            if (lista.Count == 1)
                return; //lista je vec sortirana jer ima samo jedan element

            for (int i = 0; i < lista.Count-1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[j].DobijenoUlozeno() > lista[i].DobijenoUlozeno())
                    {
                        var pom = lista[j];
                        lista[j] = lista[i];
                        lista[i] = pom;
                    }
                }
            }
        }
    }
}
