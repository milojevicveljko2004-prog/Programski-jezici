using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjApril2025Zad2
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                Planer p = new Planer();

                p.UcitajIzFajla("planer.txt");
                // p.print();
                Console.WriteLine(p.ToString());

                p.IzbaciOdredjene(180);
                p.UrediPoPrioritetu();

                p.UpisiUFajl("noviPlaneri.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska: " + e);
            }
        }
    }
}
