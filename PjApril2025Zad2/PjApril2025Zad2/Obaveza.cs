using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjApril2025Zad2
{
    public abstract class Obaveza
    {
        protected string _naziv;
        protected int _prioritetIzvrsenja;
        protected int _satPocetkaIzvrsenja;
        protected int _satKrajaIzvrsenja;

        public Obaveza() { }

        public Obaveza(string naziv, int prioritetIzvrsenja, int satPocetka, int satKraja)
        {
            if (prioritetIzvrsenja < 0 || satPocetka < 0 || satKraja < 0)
            {
                throw new Exception("Nevalidni argumenti prosledjeni konstruktoru! ");
            }

            _naziv = naziv;
            _prioritetIzvrsenja = prioritetIzvrsenja;
            _satPocetkaIzvrsenja = satPocetka;
            _satKrajaIzvrsenja = satKraja;
        }

        public string Naziv => _naziv;

        public int PrioritetIzvrsenja => _prioritetIzvrsenja;

        public abstract int VremeIzvrsenja { get; }

        public static bool operator <=(Obaveza o1, Obaveza o2)
        {
            if (o1.PrioritetIzvrsenja <= o2.PrioritetIzvrsenja)
                return true;
            else
                return false;
        }

        public static bool operator >=(Obaveza o1, Obaveza o2)
        {
            if (o1.PrioritetIzvrsenja >= o2.PrioritetIzvrsenja)
                return true;
            else
                return false;
        }

        //u fajl upisuje vrednosti svojih atributa, izvedene klase ce da nastave ispis
        public virtual void UpisiUFajl(TextWriter tw)
        {
            tw.Write(_naziv + " " + _prioritetIzvrsenja + " " + _satPocetkaIzvrsenja + " " + 
                _satKrajaIzvrsenja);
        }


        //Osnovna klasa ce da otvori liniju fajla, a izvedena ce da procita svoje podatke
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
            if (delovi.Length < 4) //osnovna klasa ima 4, pa sigurno ne moze da bude manje
                throw new Exception("Neocekivan broj podataka u liniji fajla! ");

            string naziv = delovi[0].Trim();
            int prioritet = int.Parse(delovi[1]);
            int satPocetka = int.Parse(delovi[2]);
            int satKraja = int.Parse(delovi[3]);

            if (prioritet < 0 || satPocetka < 0 || satKraja < 0)
            {
                throw new Exception("Nevalidni podaci u fajlu ");
            }

            this._naziv = naziv;
            this._prioritetIzvrsenja = prioritet;
            this._satPocetkaIzvrsenja = satPocetka;
            this._satKrajaIzvrsenja = satKraja;
        }

        //public virtual void print()
        //{
        //    Console.Write(_naziv + " " + _prioritetIzvrsenja + " " + _satPocetkaIzvrsenja + " " +
        //        _satKrajaIzvrsenja);
        //}

        public override string ToString()
        {
            return _naziv + " " + _prioritetIzvrsenja + " " + _satPocetkaIzvrsenja + " " 
                +  _satKrajaIzvrsenja;
        }
    }
}
