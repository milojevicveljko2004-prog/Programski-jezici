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
    public partial class Form : System.Windows.Forms.Form
    {
        private List<Kosarkas> _lista;
        public Form()
        {
            InitializeComponent();
            _lista = new List<Kosarkas>();
        }

        private void radioBtnNBA_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnNBA.Checked == true) //ako je cekirana NBA liga
            {
                checkBoxZauzet.Enabled = false;
                checkBoxZauzet.Checked = false; //ako je bilo cekirano da se unchek.
            }
            else
            {
                checkBoxZauzet.Enabled = true;
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string ime = txtBoxIme.Text;
            string prezime = txtBoxPrezime.Text;

            int broj = (int)numUpDownBroj.Value;
            if (broj < 1 || broj > 99)
                throw new Exception("Broj mora biti izmedju 1 i 99! ");

            Liga liga;
            if (radioBtnABA.Checked)
                liga = Liga.ABA;

            else if(radioBtnEuroLeague.Checked)
                liga = Liga.EuroLeague;

            else
                liga = Liga.NBA;

            bool zauzet = checkBoxZauzet.Checked;

            DateTime datumRodjenja = dateTimeDatumRodjenja.Value;

            Kosarkas k = new Kosarkas(ime, prezime, broj, liga, zauzet, datumRodjenja);

            _lista.Add(k);

            //sad ucitavanje podataka iz liste u listBox

            listBox.Items.Clear();

            foreach (Kosarkas kosarkas in _lista)
            {
                listBox.Items.Add(kosarkas);
            }

        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|.txt";
                sfd.DefaultExt = "txt";
                sfd.AddExtension = true;
                sfd.Title = "Snimi kosarkase";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Kosarkas.UpisiUFajl(sfd.FileName, _lista);

                    MessageBox.Show("Kosarkasi su uspesno snimljeni u fajl! ", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem is Kosarkas k)
            {
                var frm = new KosarkasiForm(k);

                frm.Show();
            }
        }
    }
}
