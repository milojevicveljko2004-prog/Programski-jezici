using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1Project
{
    public abstract class Student
    {
        protected int brIndeksa;
        protected string ime;
        protected string prezime;

        public Student() { }

        public Student(int brIndeksa, string ime, string prezime)
        {
            this.brIndeksa = brIndeksa;
            this.ime = ime;
            this.prezime = prezime;
        }

        public abstract int BrBodova { get; }

        public override string ToString()
        {
            return this.ime + " " + this.prezime + " " + this.brIndeksa;
        }

        //Operatori porede studente po broju bodova
        public static bool operator >(Student a, Student b)
        {
            if (a == null || b == null)
                return false;

            return a.BrBodova > b.BrBodova;
        }

        public static bool operator <(Student a, Student b)
        {
            return a.BrBodova < b.BrBodova;
        }
    }
}
