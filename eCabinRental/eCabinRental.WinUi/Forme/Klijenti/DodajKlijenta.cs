using eCabinRental.Model.Request.Klijent;
using eCabinRental.WinUi.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCabinRental.WinUi.Forme
{
    public partial class DodajKlijenta : Form
    {
        protected APIService _servisKlijent = new APIService("Klijent");
        protected APIService _servisGrad = new APIService("Grad");

        public DodajKlijenta()
        {
            InitializeComponent();
        }
        private async void DodajKlijentaAsync()
        {
            var lista = await _servisGrad.Get<List<Model.Grad>>();
            lista.Insert(0, new Model.Grad());
            cmbGrad.ValueMember = "GradId";
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.DataSource = lista;
        }
        private async void DodajKlijenta_Load(object sender, EventArgs e)
        {
            DodajKlijentaAsync();
        }

        private void txtIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIme.Text))
            {
                errorProvider1.SetError(txtIme, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtIme, null);
            }
        }

        private void txtPrezime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPrezime.Text))
            {
                errorProvider1.SetError(txtPrezime, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtPrezime, null);
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtEmail, null);
            }
        }

        private void txtTelefon_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefon.Text))
            {
                errorProvider1.SetError(txtTelefon, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtTelefon, null);
            }
        }

        private void txtKorisnickoIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKorisnickoIme.Text))
            {
                errorProvider1.SetError(txtKorisnickoIme, " Obavezno polje");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(txtKorisnickoIme, null);
            }
        }
        KlijentInsertRequest request = new KlijentInsertRequest();

        private async void btnSpasi_ClickAsync(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                request.Ime = txtIme.Text;
                request.Prezime = txtPrezime.Text;
                request.Email = txtEmail.Text;
                request.Telefon = txtTelefon.Text;
                request.KorisnickoIme = txtKorisnickoIme.Text;
                request.Lozinka = txtLozinka.Text;
                request.LozinkaSalt = Hashing.GenerateSalt();
                request.LozinkaHash = Hashing.GenerateHash(request.LozinkaSalt, request.Lozinka);
                var tipId = cmbGrad.SelectedValue;
                if (int.TryParse(tipId.ToString(), out int TipId))
                {
                    request.GradId = TipId;
                }
                request.Slika = ImageHelper.FromImageToByte(pbSlikaKlijenta.Image);
                var search = new KlijentSearchRequest
                {
                    Ime = txtIme.Text,
                    Prezime = txtPrezime.Text
                };
                var listaKlijenata = await _servisKlijent.Get<List<Model.Klijent>>(search);
                if (listaKlijenata.Count >= 1)
                {
                    MessageBox.Show("Klijent je već unijet u sistem, pokušajte ponovo sa novim klijentom.", "Greška", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    await _servisKlijent.Insert<Model.Klijent>(request);
                    
                    MessageBox.Show("Klijent je dodan u bazu", "Poruka", MessageBoxButtons.OK);
                    this.Close();
                }
            }
         }

        private void btnDodajSliku_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog1.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Slika = file;
                textBox1.Text = fileName;

                Image img = Image.FromFile(fileName);
                pbSlikaKlijenta.Image = img;
                pbSlikaKlijenta.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
