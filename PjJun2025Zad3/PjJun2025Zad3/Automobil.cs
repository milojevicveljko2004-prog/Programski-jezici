using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjJun2025Zad3
{
    public enum Gorivo { Benzin, Dizel, ElektricniPogon }
    public class Automobil
    {
        private string _proizvodjac;
        private string _model;
        private Gorivo _vrstaGoriva;
        private double _zapreminaMotora; //u litrima
        private double _kapacitetBaterija; //u kWh
        private DateTime _datumProizvodnje;

        #region Properties
        public string Proizvodjac
        { 
            get { return _proizvodjac; }
            set { _proizvodjac = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public Gorivo VrstaGoriva
        {
            get { return _vrstaGoriva; }
            set 
            {
                if (value != Gorivo.ElektricniPogon && value != Gorivo.Benzin && value != Gorivo.Dizel)
                {
                    throw new Exception("Neispravna vrsta goriva! ");
                }
                _vrstaGoriva = value; 
            }
        }

        public double ZapreminaMotora
        {
            get { return _zapreminaMotora; }
            set 
            {
                if (value < 0 || value > 10)
                    throw new Exception("Zapremina motora mora biti izmedju 0 i 10! ");

                _zapreminaMotora = value; 
            }
        }

        public double KapacitetBaterija
        {
            get { return _kapacitetBaterija; }
            set 
            {
                if (value < 0 || value > 100)
                    throw new Exception("Kapacitet baterije mora biti izmedju 0 i 100! ");

                _kapacitetBaterija = value; 
            }
        }

        public DateTime DatumProizvodnje
        {
            get { return _datumProizvodnje; }
            set { _datumProizvodnje = value; }
        }

        #endregion

        public Automobil() { }

        public Automobil(string proizvodjac, string model, Gorivo vrstaGoriva, double zapreminaMotora,
            double kapacitetBaterija, DateTime datumProizvodnje)
        {
            Proizvodjac = proizvodjac;
            Model = model;
            VrstaGoriva = vrstaGoriva;
            ZapreminaMotora = zapreminaMotora;
            KapacitetBaterija = kapacitetBaterija;
            DatumProizvodnje = datumProizvodnje;
        }

        public static void SnimiUFajl(string filename, List<Automobil> lista)
        {
            if (string.IsNullOrWhiteSpace(filename))
                throw new Exception("Prosledjeno je prazno ime fajla! ");

            using (TextWriter tw = new StreamWriter(filename))
            {
                foreach (Automobil a in lista)
                {
                    tw.WriteLine(a.ToString());
                }
            }
        }

        public override string ToString()
        {
            if (this._vrstaGoriva == Gorivo.ElektricniPogon) //ne prikazuj zapreminu motora 
            {
                return Proizvodjac + " " + Model + " " + VrstaGoriva + 
                    " Kapacitet baterija: " + KapacitetBaterija + ", " + DatumProizvodnje;
            }
            else //ne prikazuj kapacitet baterije
            {
                return Proizvodjac + " " + Model + " " + VrstaGoriva +
                    " Zapremina motora: " + ZapreminaMotora + ", " + DatumProizvodnje;
            }
        }
    }
}
