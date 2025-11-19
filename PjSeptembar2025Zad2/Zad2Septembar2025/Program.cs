using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2Septembar2025 
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StalniGlumac g = new StalniGlumac();
                g.popularnost = 10;
                // 1) Kreiramo KANDIDATE (različite kombinacije isplate/faktora/sati)
                var kandidati = new List<Glumac>
                {
                    new StalniGlumac("Ana",   "Anic",  NacinIsplate.Trenutno, 800, 7f,   1.4f), // stvarna: 1120
                    new StalniGlumac("Boris", "Boric", NacinIsplate.Odlozeno,  900, 8f,   1.3f), // stvarna: 1170 (odlozeno)
                    new HonorarniGlumac("Ceca","Cvetkovic", NacinIsplate.Trenutno, 300, 6f, 20, 15), // 300 + 20*15 = 600
                    new HonorarniGlumac("Dejan","Delic",    NacinIsplate.Odlozeno, 200, 6f, 35, 12), // 200 + 35*12 = 620 (odlozeno)
                    new StalniGlumac("Eva",   "Eric",  NacinIsplate.Trenutno, 700, 9.5f, 1.2f) // 840
                };

                // 2) Kreiramo predstavu (budžet -> važi SAMO za 'Trenutno')
                var p = new Predstava("Hamlet (test)", budzet: 1500, min: 3, max: 4);

                // 3) Napravimo izbor ansambla po zadatim pravilima
                p.izborGlumaca(kandidati);

                // 4) Prikaz rezultata i provere
                Console.WriteLine("\n--- REZULTAT IZBORA ANSAMBLA ---");
                p.print();

                double odmah = p.sredstva(); // suma 'Trenutno' (tvoja metoda)
                Console.WriteLine($"\nIznos koji treba ODMAH izdvojiti (Trenutno): {odmah}");

                // 5) Provera da je ispoštovan budžet
                //    (po zadatku: odmah izdvojena sredstva ne smeju preći budžet predstave)
                //    Ovu proveru obično radiš u izboru, ali možemo i ovde da potvrdimo:
                //    (nije nužno, čisto demonstracija)
                // if (odmah > 1500) throw new Exception("Prekoračen budžet!");

                Console.WriteLine("\nSve OK.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Greska: " + e);
            }
        }
    }
}
