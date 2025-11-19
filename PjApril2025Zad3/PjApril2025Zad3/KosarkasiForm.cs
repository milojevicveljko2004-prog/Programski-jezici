using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjApril2025Zad3
{
    public partial class KosarkasiForm : System.Windows.Forms.Form
    {
        public KosarkasiForm(Kosarkas k)
        {
            InitializeComponent();
            UcitajPodatkeUKontrole(k);
        }

        private void UcitajPodatkeUKontrole(Kosarkas k)
        {
            lblIme.Text = k.Ime;
            lblBroj.Text = k.Broj.ToString();
            lblDatumRodjenja.Text = k.DatumRodjenja.ToString();
            lblLiga.Text = k.Liga.ToString();
            lblPrezime.Text = k.Prezime.ToString();

            if (k.Zauzet)
                lblZauzet.Text = "Zauzet za kvalifikacije! ";
            else
                lblZauzet.Text = "Nije zauzet. ";
        }
    }
}
