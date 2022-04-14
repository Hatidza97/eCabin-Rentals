using eCabinRental.Model.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eCabinRental.WinUi.Forme
{
    public partial class frmKorisnici : Form
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        public frmKorisnici()
        {
            InitializeComponent();
        }

        private async void frmKorisnici_Load(object sender, EventArgs e)
        {
            var data = await _apiService.Get<List<KorisniciSearchRequest>>(null);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = data;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var pretraga = new KorisniciSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Email = txtEmail.Text
            };
            var podaci = await _apiService.Get<List<Model.Korisnik>>(pretraga);
            dgvKorisnici.AutoGenerateColumns = false;
            dgvKorisnici.DataSource = podaci;

            if (podaci.Count == 0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
            }
        }

        private void dgvKorisnici_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var korisnik = dgvKorisnici.SelectedRows[0].Cells[0].Value;
            // var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem;
            // MessageBox.Show(korisnik.ToString());
            var rez = korisnik.ToString();
            frmDetaljiKorisnika forma = new frmDetaljiKorisnika(int.Parse(rez));
            forma.Show();
        }
    }
}
