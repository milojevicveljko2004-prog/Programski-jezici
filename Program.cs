using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5 
{
    public class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                Turnir t = new Turnir();

                t.ucitaj("ulaz.txt");
                //print je samo za DEBUG
                t.print();

                t.remove();
                t.upisi("izlaz.txt");
                Console.WriteLine("Nakon izbacivanja: ");
                t.print();
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska: " + e);
            }
        }
    }
}
