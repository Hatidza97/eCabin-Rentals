using eCabinRental.Model;
using eCabinRental.Model.Request.Klijent;
using eCabinRental.Model.VM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace eCabinRental.WinUi.Forme.Klijenti
{
    public partial class Klijentifrm : Form
    {
        private readonly APIService _apiService = new APIService("Klijent");
        public Klijentifrm()
        {
            InitializeComponent();
        }

        private async void Klijenti_Load(object sender, EventArgs e)
        {
            var podaci = await _apiService.Get<List<Model.Klijent>>(null);
            List<frmKlijenti> lista = new List<frmKlijenti>();
            foreach (var item in podaci)
            {
                frmKlijenti forma = new frmKlijenti
                {
                    KlijentId = item.KlijentId,
                    Ime = item.Ime,
                    Prezime = item.Prezime,
                    Slika = item.Slika,
                    GradID = item.GradId,
                   //Grad=item.Grad.Naziv,
                    Telefon=item.Telefon,
                    Username=item.KorisnickoIme

                };
                lista.Add(forma);
            }
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = lista;
        }

        private async void btnPretraga_Click(object sender, EventArgs e)
        {
            var pretraga = new KlijentSearchRequest()
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text
            };
            var podaci = await _apiService.Get<List<Model.Klijent>>(pretraga);
            var lista = new List<frmKlijenti>();

            foreach (var item in podaci)
            {
                var forma = new frmKlijenti
                {
                    KlijentId = item.KlijentId,
                    Ime = item.Ime,
                    Prezime = item.Prezime,
                    Slika = item.Slika,
                    Telefon = item.Telefon,
                    Username = item.KorisnickoIme

                };
                lista.Add(forma);
            }
            dgvKlijenti.AutoGenerateColumns = false;
            dgvKlijenti.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
            }
        }

        private void dgvKlijenti_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var klijent = dgvKlijenti.SelectedRows[0].Cells[0].Value;
            // var korisnik = dgvKorisnici.SelectedRows[0].DataBoundItem;
            // MessageBox.Show(korisnik.ToString());
            var rez = klijent.ToString();
            Form forma = new DetaljiKlijenta(int.Parse(rez));
            forma.Show();
        }
    }
}
