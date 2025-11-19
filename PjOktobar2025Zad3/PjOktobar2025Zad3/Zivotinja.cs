using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PjOktobar2025Zad3
{
    public enum Ishrana { Biljojed, Mesojed, Svastojed }
    public class Zivotinja
    {
        private string _naziv;
        private string _vrsta;
        private double _visina;
        private double _tezina;
        private Ishrana _nacinIshrane;
        private DateTime _datumRodjenja;
        private double _kolicinaMesa;

        #region Properties

        public string Naziv
        {
            get { return _naziv; }
            set { _naziv = value; }
        }

        public string Vrsta
        {
            get { return _vrsta; }
            set { _vrsta = value; }
        }

        public double Visina
        {
            get { return _visina; }
            set 
            {
                if (value < 0.05 || value > 6)
                    throw new Exception("Visina mora biti izmedju 0,05 i 6! ");

                _visina = value; 
            }
        }

        public double Tezina
        {
            get { return _tezina; }
            set 
            {
                if (value < 0.002 || value > 7000)
                    throw new Exception("Tezina mora biti izmedju 0.002 i 7000! ");

                _tezina = value; 
            }
        }

        public Ishrana NacinIshrane
        {
            get { return _nacinIshrane; }
            set { _nacinIshrane = value; }
        }

        public DateTime DatumRodjenja
        {
            get { return _datumRodjenja; }
            set { _datumRodjenja = value; }
        }

        public double KolicinaMesa
        {
            get { return _kolicinaMesa; }
            set 
            {
                if (value < 0 || value > 10)
                    throw new Exception("Kolicina mesa mora biti izmedju 0 i 10! ");

                _kolicinaMesa = value; 
            }
        }

        #endregion

        public Zivotinja() { }

        public Zivotinja(string naziv, string vrsta, double visina, double tezina, Ishrana nacinIshrane,
            DateTime datumRodjenja, double kolicinaMesa)
        {
            Naziv = naziv;
            Vrsta = vrsta;
            Visina = visina;
            Tezina = tezina;
            NacinIshrane = nacinIshrane;
            DatumRodjenja = datumRodjenja;
            KolicinaMesa = kolicinaMesa;
        }

        public override string ToString()
        {
            if (_nacinIshrane == Ishrana.Biljojed)
            {
                return _naziv + " - " + _vrsta + " / " + _datumRodjenja + " / " + _nacinIshrane + " / ";
            }
            else
            {
                return _naziv + " - " + _vrsta + " / " + _datumRodjenja + " / " + _nacinIshrane + " / "
                    + _kolicinaMesa;
            }
        }
    }
}
