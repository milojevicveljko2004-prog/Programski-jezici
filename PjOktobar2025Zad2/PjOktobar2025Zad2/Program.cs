using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace PjOktobar2025Zad2
{
    public class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                Selekcija s = new Selekcija(25, 15);

                s.AddPlayer(new Napadac("Marko", "Markovic", 370, 7));
                s.AddPlayer(new Napadac("Nikola", "Nikolic", 400, 6));
                s.AddPlayer(new Napadac("Pera", "Peric", 390, 14));
                s.AddPlayer(new Napadac("Laza", "Lazic", 450, 15));
                s.AddPlayer(new Napadac("Ivan", "Ilic", 300, 4));
                s.AddPlayer(new Napadac("Stefan", "Stefanovic", 370, 4));
                s.AddPlayer(new Napadac("Novak", "Novakovic", 420, 10));
                s.AddPlayer(new Napadac("Milos", "Milosevic", 500, 12));

                s.AddPlayer(new Golman("Uros", "Urosevic", true, 40));
                s.AddPlayer(new Golman("Branko", "Brankovic", false, 9));
                s.AddPlayer(new Golman("Ilija", "Ilic", true, 10));

                Selekcija s2 = s.RazvrstajFudbalere();

                s.upisiUFajl("PrvaPostava.txt");
                s2.upisiUFajl("RezervnaPostava.txt");

            }
            catch (Exception e)
            {
                Console.WriteLine("Greska: " + e);
            }
        }
    }
}
