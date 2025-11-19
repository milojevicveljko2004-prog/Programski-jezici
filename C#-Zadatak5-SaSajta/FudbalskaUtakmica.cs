using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad5
{
    public class FudbalskaUtakmica : Utakmica
    {
        private int _brGolovaDomaci;
        private int _brGolovaGosti;
        private int _brIskljucenihIgracaDomaci;
        private int _brIskljucenihIgracaGosti;

        public FudbalskaUtakmica() { }

        public FudbalskaUtakmica(string imeDomaci, string imeGosti, int goloviDomaci, int goloviGosti
            , int iskljuceniDomaci, int iskljuceniGosti) : base(imeDomaci, imeGosti)
        {
            if (goloviDomaci < 0 || goloviGosti < 0 || iskljuceniDomaci < 0 || iskljuceniGosti < 0)
                throw new Exception("Neispravni atributi u konstruktoru FudbalskaUtakmica! ");

            _brGolovaDomaci = goloviDomaci;
            _brGolovaGosti = goloviGosti;
            _brIskljucenihIgracaDomaci = iskljuceniDomaci;
            _brIskljucenihIgracaGosti = iskljuceniGosti;
        }

        public override IshodUtakmice Ishod
        {
            get 
            {
                if (_brGolovaDomaci > _brGolovaGosti)
                    return IshodUtakmice.PobedaDomacina;

                else if (_brGolovaGosti > _brGolovaDomaci)
                    return IshodUtakmice.PobedaGosta;
                else
                    return IshodUtakmice.Nereseno;
            }
        }

        public override int UkupanBrIskljucenihIgraca => _brIskljucenihIgracaDomaci + _brIskljucenihIgracaGosti;

        public void upisi(TextWriter tw) //radi, testirano je
        {
            base.upisi(tw); //prvo roditeljska klasa upisuje svoje podatke
            //nastavak zapisa iz osnovne klase
            tw.Write(" " + _brGolovaDomaci + " " + _brGolovaGosti + " " + _brIskljucenihIgracaDomaci
                + " " + _brIskljucenihIgracaGosti);

            tw.WriteLine(); //da bi sledeci objekat bio u narednom redu
        }

        public void ucitaj(TextReader tr)
        {
            string line = tr.ReadLine(); //Izvedena(ova) klasa otvara liniju

            if (line == null)
                throw new Exception("Neocekivan kraj fajla! ");

            if (string.IsNullOrWhiteSpace(line))
                throw new Exception("Prazna linija u fajlu! ");

            string[] delovi = line.Split(); 

            if (delovi.Length != 6) //ukljucujuci sve atribute i osnovne i izvedene klase
                throw new Exception("Neocekivan broj podataka u liniji fajla! ");

            base.ucitaj(delovi); //osnovna klasa cita svoje atribute

            //a izvedena svoje
            int goloviDomaci = int.Parse(delovi[2]);
            int goloviGosti = int.Parse(delovi[3]);
            int iskljuceniDomaci=int.Parse(delovi[4]);
            int iskljuceniGosti=int.Parse(delovi[5]);

            if (goloviDomaci < 0 || goloviGosti < 0 || iskljuceniDomaci < 0 || iskljuceniGosti < 0)
                throw new Exception("Neispravni atributi u fajlu! ");

            _brGolovaDomaci = goloviDomaci;
            _brGolovaGosti = goloviGosti;
            _brIskljucenihIgracaDomaci = iskljuceniDomaci;
            _brIskljucenihIgracaGosti = iskljuceniGosti;
        }

        public override void print()
        {
            base.print();
            Console.Write(" " + _brGolovaDomaci + " " + _brGolovaGosti + " " + _brIskljucenihIgracaDomaci
                + " " + _brIskljucenihIgracaGosti);
            Console.WriteLine();
        }
    }
}
