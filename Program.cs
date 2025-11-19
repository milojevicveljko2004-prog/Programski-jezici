using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad4
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Korpa k = new Korpa();

                k.ucitaj("ulaz.txt");
                //print je samo za DEBUG
                k.print();

                k.remove(StatusProizvoda.NarucenOdProizvodjaca);
                k.upisi("izlaz.txt");
                Console.WriteLine("Nakon izbacivanja: ");
                k.print();
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska: " + e);
            }
        }
    }
}
