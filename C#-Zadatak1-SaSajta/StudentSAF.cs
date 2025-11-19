using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1Project
{
    public class StudentSAF : Student
    {
        private int pismeni;
        private int semRad;

        public StudentSAF() { }

        public StudentSAF(int brIndeksa, string ime, string prezime, int pismeni, int semRad)
            :base(brIndeksa, ime, prezime)
        {
            this.pismeni = pismeni;
            this.semRad = semRad;
        }

        public override int BrBodova => pismeni + semRad;
    }
}
