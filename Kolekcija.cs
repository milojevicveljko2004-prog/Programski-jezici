using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1Project
{
    public class Kolekcija
    {
        protected int maxBrElemenata;
        protected int trenutniBrElemenata;
        protected Student[] niz;

        public Kolekcija(int max)
        {
            if (max < 0)
            {
                throw new Exception("Constructor Kolekcija. max can't be less then 0! ");
            }
            this.maxBrElemenata = max;
            this.trenutniBrElemenata=0;
            this.niz = new Student[max];
        }

        public void Add(Student s)
        {
            if (this.trenutniBrElemenata >= this.maxBrElemenata)
            {
                throw new Exception("Array of students is empty! ");
            }

            this.niz[this.trenutniBrElemenata] = s;
            this.trenutniBrElemenata++;
        }

        public void print()
        {
            if (this.trenutniBrElemenata == 0)
            {
                Console.WriteLine("EMPTY");
            }
            else
            { 
                for (int i = 0; i < this.trenutniBrElemenata; i++)
                {
                    Console.WriteLine(this.niz[i]);
                }
                Console.WriteLine("\n");
            }
        }
    }
}
