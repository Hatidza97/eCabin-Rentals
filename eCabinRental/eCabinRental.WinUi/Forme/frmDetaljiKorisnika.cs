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
    public partial class frmDetaljiKorisnika : Form
    {
        private readonly APIService _apiService = new APIService("Korisnici");
        private int? _korisnik = null;
        public frmDetaljiKorisnika(int korisnik)
        {
            InitializeComponent();
            _korisnik = korisnik;
        }

        private async void frmDetaljiKorisnika_Load(object sender, EventArgs e)
        {
            if (_korisnik.HasValue)
            {
                var podaci = await _apiService.GetById<Model.Korisnik>(_korisnik);
                txtIme.Text = podaci.Ime;
                txtPrezime.Text = podaci.Prezime;
                txtTelefon.Text = podaci.Telefon;
                txtEmail.Text = podaci.Email;
                txtKorisnickoIme.Text = podaci.KorisnickoIme;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
