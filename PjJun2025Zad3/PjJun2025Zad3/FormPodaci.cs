using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjJun2025Zad3
{
    public partial class FormPodaci : Form
    {
        public FormPodaci(Automobil a)
        {
            InitializeComponent();
            UcitajPodatkeUKontrole(a);
        }

        private void UcitajPodatkeUKontrole(Automobil a)
        {
            //treba jos, odnosno sve sto je na blanketu. Ja nisam stavio jer me je verovatno mrzelo.
            lblDatumProizvodnje.Text = a.DatumProizvodnje.ToString();
            lblProizvodjac.Text = a.Proizvodjac.ToString();
            lblVrstaGoriva.Text = a.VrstaGoriva.ToString();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
