using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1Project
{
    public class StudentFIB : Student
    {
        private int brBodovaKlk1;
        private int brBodovaKlk2;
        private int brBodovaLabVezbe;

        public StudentFIB() { }

        public StudentFIB(int brIndeksa, string ime, string prezime, int brBodovaKlk1, 
            int brBodovaKlk2, int brBodovaLabVezbe) : base(brIndeksa, ime, prezime)
        {
            this.brBodovaKlk1 = brBodovaKlk1;
            this.brBodovaKlk2 = brBodovaKlk2;
            this.brBodovaLabVezbe = brBodovaLabVezbe;
        }

        public override int BrBodova
        {
            get { return this.brBodovaKlk1 + this.brBodovaKlk2 + this.brBodovaLabVezbe; }
        }
    }
}
