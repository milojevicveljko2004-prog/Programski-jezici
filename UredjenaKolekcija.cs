using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1Project
{
    public class UredjenaKolekcija : Kolekcija, Uredjivac
    {
        private StanjeKolekcije stanje;

        public UredjenaKolekcija(int max) : base(max)
        {
            this.stanje = StanjeKolekcije.Neuredjena;
        }

        //od najmanjeg do najveceg
        private void urediURastuci() //clanica klase, pa ne treba da se prosledjuju argumenti?
        {
            for (int i = 0; i < this.trenutniBrElemenata-1; i++)
            {
                for (int j = i + 1; j < this.trenutniBrElemenata; j++)
                {
                    if (niz[j] < niz[i])
                    {
                        Student pom = niz[j];
                        niz[j] = niz[i];
                        niz[i] = pom;
                    }
                }
            }
        }

        //od najveceg do najmanjeg
        private void urediUOpadajuci()
        {
            for (int i = 0; i < this.trenutniBrElemenata - 1; i++)
            {
                for (int j = i + 1; j < this.trenutniBrElemenata; j++)
                {
                    if (niz[j] > niz[i])
                    {
                        Student pom = niz[j];
                        niz[j] = niz[i];
                        niz[i] = pom;
                    }
                }
            }
        }

        public void Uredi(SortOrder redosled)
        {
            if (this.trenutniBrElemenata < 2) //nema sta da se sortira
                return;

            if (redosled == SortOrder.Rastuci)
            {
                urediURastuci();
                this.stanje = StanjeKolekcije.UredjenaURastuci;
            }
            else if (redosled == SortOrder.Opadajuci)
            {
                urediUOpadajuci();
                this.stanje = StanjeKolekcije.UredjenaUOpadajuci;
            }
        }
    }
}
