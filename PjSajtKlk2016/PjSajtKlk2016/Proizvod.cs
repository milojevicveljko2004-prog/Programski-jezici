using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjSajtKlk2016
{
    public enum Status { Prodavnica, Magacin, Proizvodjac }
    public abstract class Proizvod
    {
        private string _naziv;
        private int _sifra;
        private Status _statusProizvoda;

        public Proizvod() { }

        public Proizvod(string n, int s, Status status)
        {
            Naziv = n;
            Sifra = s;
            StatusProizvoda = status;
        }

        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        public int Sifra
        {
            get { return _sifra; }
            set 
            {
                if (value < 0)
                    throw new Exception("Sifra ne moze biti manja od 0! ");

                _sifra = value;
            }
        }

        public Status StatusProizvoda
        {
            get { return _statusProizvoda; }
            set 
            { _statusProizvoda = value; }
        }

        public abstract double Cena { get; }

        public virtual void UpisiUFajl(TextWriter tw)
        {
            tw.Write(Naziv + " " + Sifra.ToString() + " " + StatusProizvoda.ToString());
        }

        public virtual void UcitajIzFajla(TextReader tr)
        {
            string line = tr.ReadLine();

            if (line == null)
                throw new Exception("Neocekivan kraj fajla! ");

            if (string.IsNullOrWhiteSpace(line))
                throw new Exception("Prazna linija u fajlu! ");

            string[] delovi = line.Split();

            ProcitajIzNiza(delovi);
        }

        public virtual void ProcitajIzNiza(string[] delovi)
        {
            if (delovi.Length < 3) //samo osnovna klasa ima 3, pa sigurno ne moze da ih ima manje
                throw new Exception("Nedovoljan broj podataka u fajlu! ");

            string naziv = delovi[0].Trim();
            int sifra = int.Parse(delovi[1]);
            string status = delovi[2].Trim();

            //provera za enum status:

            bool nadjen = false;
            foreach (Status s in Enum.GetValues(typeof(Status)))
            {
                if (string.Equals(s.ToString(), status, StringComparison.OrdinalIgnoreCase))
                {
                    nadjen = true;
                    StatusProizvoda = s;
                    break;
                }
            }

            if (!nadjen)
                throw new Exception("Neispravan status u fajlu! ");

            Naziv = naziv; 
            Sifra = sifra; //provera je u property-ju
        }
    }
}
