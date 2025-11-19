using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjSajtKlk2016
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Korpa k = new Korpa();

                k.UcitajIzFajla("proizvodi.txt");
                k.UpisiUFajl("rezultatProizvodi.txt");
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska: " + e);
            }
        }
    }
}
