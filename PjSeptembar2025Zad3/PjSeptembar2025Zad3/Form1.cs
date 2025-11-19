using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PjSeptembar2025Zad3
{
    public partial class Form1 : Form
    {
        private List<Teniser> _listaTenisera = new List<Teniser>();
        public Form1()
        {
            InitializeComponent();
        }

        //ako je cekirano polje Penzionisan, onemoguci unos za trenutni ranking
        private void checkBoxPenzionisan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPenzionisan.Checked == true)
                upDownRanking.Enabled = false; //onemoguci
            else
                upDownRanking.Enabled = true; //onemoguci
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                string ime = txtBoxIme.Text.Trim();
                string prezime=txtBoxPrezime.Text.Trim();
                int trenutniRanking = (int)upDownRanking.Value;
                //ne moze da bude ali ako je korisnik ipak nekako uneo:
                if (trenutniRanking < 1 || trenutniRanking > 100)
                    throw new Exception("Ranking mora biti izmedju 1 i 100! ");

                DateTime datumRodjenja = dateTimeDatumRodj.Value;
                int brTitula = (int)upDownBrTitula.Value;
                if (brTitula < 0 || brTitula > 109)
                    throw new Exception("Broj titula mora biti izmedju 0 i 109! ");

                StilIgre stilIgre;

                //zavisi od toga koji je RadioButton kliknut
                if (btnBaseline.Checked == true)
                    stilIgre = StilIgre.BaseLine;

                else if (btnServe.Checked == true)
                    stilIgre = StilIgre.ServeAndVolley;

                else if (btnAllRound.Checked == true)
                    stilIgre = StilIgre.AllRound;

                else //Da li trebam da smatram da mora da bude odabran stil igre?
                     //Ako u zadatku nije receno?
                    throw new Exception("Morate odabrati stil igre! ");
                //proveri sta ce da se desi ako nema ovog?

                bool penzionisan = checkBoxPenzionisan.Checked;

                Teniser teniser = new Teniser(ime, prezime, trenutniRanking, datumRodjenja, brTitula,
                    stilIgre, penzionisan);

                _listaTenisera.Add(teniser);

                //sad osvezi ListBox i dodaj sve tenisere iz liste u ListBox:

                listBox.Items.Clear();

                for (int i = 0; i < _listaTenisera.Count; i++)
                {
                    listBox.Items.Add(_listaTenisera[i].ToString());
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Greska: " + ex);
            }
        }

        private void snimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Text Files (*.txt)|*.txt";
                sfd.DefaultExt = "txt";
                sfd.AddExtension = true;
                sfd.Title = "Sacuvaj listu tenisera";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Teniser.SnimiTenisere(sfd.FileName, _listaTenisera);

                    MessageBox.Show("Teniseri su uspesno sacuvani! ", "Info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void listBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
