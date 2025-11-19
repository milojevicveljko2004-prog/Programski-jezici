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
    public partial class Form1 : Form
    {
        private List<Automobil> _lista;
        public Form1()
        {
            InitializeComponent();
            _lista = new List<Automobil>();
        }

        private void cmbBoxVrstaGoriva_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ako je odabran Elektricni pogon
            if (cmbBoxVrstaGoriva.SelectedIndex == 2)
            {
                numUpDownZapreminaMotora.Enabled = false;
                numUpDownKapacitetBaterije.Enabled = true;
            }
            else
            {
                numUpDownZapreminaMotora.Enabled = true;
                numUpDownKapacitetBaterije.Enabled = false;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string proizvodjac = txtBoxProizvodjac.Text.Trim();
            string model = txtBoxModel.Text.Trim();
            Gorivo VrstaGoriva;

            if (cmbBoxVrstaGoriva.SelectedIndex == 0) //dizel
                VrstaGoriva = Gorivo.Dizel;

            else if (cmbBoxVrstaGoriva.SelectedIndex == 1) //benzin
                VrstaGoriva = Gorivo.Benzin;

            else if (cmbBoxVrstaGoriva.SelectedIndex == 2) //elektricni pogon
                VrstaGoriva = Gorivo.ElektricniPogon;

            else
                throw new Exception("Neispravna vrsta goriva! ");

            double zapreminaMotora = (double)numUpDownZapreminaMotora.Value;

            if (zapreminaMotora < 0 || zapreminaMotora > 10)
                throw new Exception("Zapremina motora mora biti izmedju 0 i 10! ");

            double kapacitetBaterije = (double)numUpDownKapacitetBaterije.Value;

            if (kapacitetBaterije < 0 || kapacitetBaterije > 100)
                throw new Exception("Kapacitet baterije mora biti izmedju 0 i 100! ");

            DateTime datumProizvodnje = dateTimePickerDatumProizvodnje.Value;

            Automobil a = new Automobil(proizvodjac, model, VrstaGoriva, zapreminaMotora,
                kapacitetBaterije, datumProizvodnje);

            _lista.Add(a);

            //Sad ucitati automobile iz liste u kontrolu listBox:

            listBox.Items.Clear();

            foreach (Automobil auto in _lista)
            {
                listBox.Items.Add(auto);
            }

        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text files (*.txt)|*.txt";
                sfd.DefaultExt = "txt";
                sfd.AddExtension = true;
                sfd.Title = "Snimi automobile";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Automobil.SnimiUFajl(sfd.FileName, _lista);

                    MessageBox.Show("Uspesno snimanje u fajl! ", "Info", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is Automobil a)
            {
                using (var dlg = new FormPodaci(a))
                {
                    dlg.ShowDialog();
                }
            }
        }
    }
}
