using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjOktobar2025Zad3
{
    public partial class FormDetalji : Form
    {
        public FormDetalji(Zivotinja z)
        {
            InitializeComponent();
            UcitajPodatkeUKontrole(z);
        }

        private void UcitajPodatkeUKontrole(Zivotinja z)
        {
            lblNaziv.Text = z.Naziv;
            lblVrsta.Text = z.Vrsta;
            lblDatumRodj.Text = z.DatumRodjenja.ToString();
            lblKolicinaMesa.Text = z.KolicinaMesa.ToString();
            lblNacinIshrane.Text = z.NacinIshrane.ToString();
            lblTezina.Text = z.Tezina.ToString();
            lblVisina.Text = z.Visina.ToString();
        }

        private void FormDetalji_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
