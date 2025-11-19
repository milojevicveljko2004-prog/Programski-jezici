using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadVozilo
{
    public interface IVozilo
    {
        void ucitaj(TextReader tr);
        void upisi(TextWriter tw);

        string Naziv { get; }
        int SerijskiBroj { get; }
        int MaxBrzina { get; }

        //string getTip();
        //int getMaxBrzina();

        void print();
    }
}
