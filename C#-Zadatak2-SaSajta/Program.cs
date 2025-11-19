using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadVozilo 
{
    public static class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Put p = new Put(80, 100, "autoput", 2.5);

                p.ucitaj("vozila.txt");
                Console.WriteLine("Sva vozila: ");
                //print je samo za DEBUG
                p.print();

                p.remove(2); //izbacuje vozila u prekrsaju
                p.upisi("VozilaIzlaz.txt");
                Console.WriteLine("Vozila nakon izbacivanja: ");
                p.print();

            }
            catch (Exception e)
            {
                Console.WriteLine("Greska: " + e);
            }
        }
    }
}
