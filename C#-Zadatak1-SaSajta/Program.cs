using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1Project //Zadatak radi!
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                UredjenaKolekcija uk = new UredjenaKolekcija(100);

                uk.Add(new StudentFIB(123, "Marko", "Markovic", 40, 30, 15));
                uk.Add(new StudentFIB(155, "Pera", "Peric", 20, 25, 10));
                uk.Add(new StudentSAF(200, "Ana", "Anic", 60, 40));
                uk.Add(new StudentSAF(207, "Ilija", "Ilic", 40, 11));

                Console.WriteLine("Pre sortiranja: \n");
                //print je samo za debug, prikazuje ime, prezime i broj indeksa svakog studenta
                uk.print();

                uk.Uredi(SortOrder.Rastuci);
                Console.WriteLine("Sortirani u rastuci redosled: \n");
                uk.print();

                uk.Uredi(SortOrder.Opadajuci);
                Console.WriteLine("Sortirani u opadajuci redosled: \n");
                uk.print();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska: " + e.Message);
            }
        }
    }
}
