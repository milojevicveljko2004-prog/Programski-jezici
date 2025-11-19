using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjJun2025Zad2
{
    public class Program 
    {
        static void Main(string[] args)
        {
            try
            {
                Grad g = new Grad("Nis", 5);

                g.NaOptimalnuPozicijuDodajParcelu(
                    new Park(1, 500, "Bulevar Oslobodjenja 12", DateTime.Now.AddDays(-10), 2, 8, true));

                g.NaOptimalnuPozicijuDodajParcelu(
                    new Nekretnina(2, 200, "Trg Republike 1", DateTime.Now.AddDays(-25),
                                   TipNekretnine.Zgrada, 10, true));

                g.NaOptimalnuPozicijuDodajParcelu(
                    new Nekretnina(3, 150, "Kralja Petra 5", DateTime.Now.AddDays(-60),
                                   TipNekretnine.Kuca, 1, false));

                Console.WriteLine("Parcele kupljene u poslednjih 30 dana: ");
                List<Parcela> lista=g.ParceleKupljeneUPoslednjih30Dana();

                foreach (Parcela p in lista)
                {
                    p.print();
                }

                g.UpisiUFajl("gradovi.txt"); //svi gradovi u tekstualnom fajlu
            }
            catch (Exception e)
            { 
                Console.WriteLine("Greska: " + e);
            }
        }
    }
}
