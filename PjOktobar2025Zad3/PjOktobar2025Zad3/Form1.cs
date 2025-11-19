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
    public partial class Form1 : Form
    {
        private List<Zivotinja> _lista;
        public Form1()
        {
            InitializeComponent();
            _lista = new List<Zivotinja>();
        }

        //ako je selektovan biljojed, kontrola za kolicinu mesa je neaktivna
        private void btnBiljojed_CheckedChanged(object sender, EventArgs e)
        {
            if (btnBiljojed.Checked == true)
            {
                numUpDownKolicinaMesa.Enabled = false;
                numUpDownKolicinaMesa.Value = 0;
            }
            else
            {
                numUpDownKolicinaMesa.Enabled = true;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string naziv=txtBoxNaziv.Text.Trim();
            string vrsta=txtBoxVrsta.Text.Trim();
            double visina = (double)numUpDownVisina.Value;

            if (visina < 0.05 || visina > 6)
                throw new Exception("Visina mora biti izmedju 0,05 i 6! ");

            double tezina = (double)numUpDownTezina.Value;

            if (tezina < 0.002 || tezina > 7000)
                throw new Exception("Tezina mora biti izmedju 0.002 i 7000! ");

            DateTime datum = dateTimeDatumRodj.Value;

            Ishrana NacinIshrane;

            if (btnBiljojed.Checked == true)
                NacinIshrane = Ishrana.Biljojed;

            else if (btnMesojed.Checked == true)
                NacinIshrane = Ishrana.Mesojed;

            else
                NacinIshrane = Ishrana.Svastojed;

            double kolicinaMesa = (double)numUpDownKolicinaMesa.Value;

            if (kolicinaMesa < 0 || kolicinaMesa > 10)
                throw new Exception("Kolicina mesa mora biti izmedju 0 i 10! ");

            Zivotinja z = new Zivotinja(naziv, vrsta, visina, tezina, NacinIshrane,
                datum, kolicinaMesa);

            _lista.Add(z);

            //sad dodavanje u kontrolu listBox

            listBox.Items.Clear();

            for (int i = 0; i < _lista.Count; i++)
            {
                listBox.Items.Add(_lista[i]);
            }
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is Zivotinja z)
            {
                using (var dlg = new FormDetalji(z))
                {
                    dlg.ShowDialog(this);
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
