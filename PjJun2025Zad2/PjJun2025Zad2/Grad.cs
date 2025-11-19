using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace PjJun2025Zad2
{
    public class Grad
    {
        private string _naziv;
        private Parcela[,] _mat;
        int _n; //kvadratna matrica, pa ima samo jednu dimenziju n x n

        public Grad() { }

        public Grad(string naziv, int n)
        {
            if (n < 0)
                throw new Exception("Dimenzije matrice ne mogu biti negativne! ");

            _naziv = naziv;
            _n = n;
            _mat = new Parcela[n, n];
        }

        private bool opseg(int i, int j) { return i < 0 || j < 0 || i >= _n || j >= _n; }

        //Samo prolaziš kroz zauzete parcele, računaš njihov doprinos toj jednoj slobodnoj poziciji
        //i sabiraš u lokalnu promenljivu
        public double GetFaktorParcele(int i, int j)
        {
            //if (!opseg(i, j))
            //    throw new Exception("Nevalidni indeksi matrice! ");

            if (_mat[i, j] != null) //ako pozicija nije slobodna, krsi se uslov zadatka
                return 0.0;

            //ChatGPT:
            double res;

            double suma = 0.0;
            for (int x = 0; x < _n; x++)
            {
                for (int y = 0; y < _n; y++)
                {
                    if (_mat[x, y] == null) continue;

                    int dist = Math.Abs(x - i) + Math.Abs(y - j); // Manhattan
                    if (dist == 1)
                        suma += 0.50 * _mat[x, y].VrednostParcele;
                    else if (dist == 2)
                        suma += 0.25 * _mat[x, y].VrednostParcele;
                    else if (dist == 3)
                        suma += 0.125 * _mat[x, y].VrednostParcele;
                }
            }
            return suma;
        }

        public List<Parcela> ParceleKupljeneUPoslednjih30Dana()
        {
            List<Parcela> res = new List<Parcela>();
            DateTime granica = DateTime.Now.AddDays(-30);

            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    if (_mat[i, j] != null && _mat[i, j].DatumKupovine >= granica)
                    {
                        res.Add(_mat[i, j]);
                    }
                }
            }

            return res;
        }

        //vraca poziciju dakle par, a to je Tuple
        public Tuple<int, int> NaOptimalnuPozicijuDodajParcelu(Parcela p)
        {
            if (p == null) throw new Exception("Prosleđena parcela je null.");

            double najoptimalnija = double.NegativeInfinity;
            int bestI=-1, bestJ=-1;

            for (int i = 0; i < _n; i++)
            {
                for (int j = 0; j < _n; j++)
                {
                    if (_mat[i, j] != null) continue; // tražimo samo prazna mesta
                    //ako je if true ovo se nece izvrsiti nego se u petlji ide dalje: 

                    double f = GetFaktorParcele(i, j);
                    if (f > najoptimalnija)
                    {
                        najoptimalnija = f;
                        bestI = i;
                        bestJ = j;
                    }
                }
            }

            if (bestI==-1)
                throw new Exception("Sve pozicije su zauzete! ");

            _mat[bestI, bestJ] = p; //dodaj
            return Tuple.Create(bestI, bestJ);
        }

        public void UpisiUFajl(string filename)
        {
            if (string.IsNullOrWhiteSpace(filename))
                throw new Exception("Poslat je prazan fajl! ");

            using (TextWriter tw = new StreamWriter(filename))
            {
                //prvo upisuje svoje atribute:
                tw.WriteLine("Naziv: " + _naziv + ", Dimenzije: " + _n + ", PARCELE: ");

                for (int i = 0; i < _n; i++)
                {
                    for (int j = 0; j < _n; j++)
                    {
                        if (_mat[i, j] != null)
                        {
                            _mat[i, j].UpisiUFajl(tw);
                        }
                    }
                }
            }
        }
    }
}
