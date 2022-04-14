using eCabinRental.WinUi.Helper;
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
    public partial class DetaljiKlijenta : Form
    {
        private readonly APIService _apiService = new APIService("Klijent");
        private int? _v;

    
        public DetaljiKlijenta(int v)
        {
            InitializeComponent();
            _v = v;
        }

        private async void DetaljiKlijenta_Load(object sender, EventArgs e)
        {
            if (_v.HasValue)
            {
                var podaci = await _apiService.GetById<Model.Klijent>(_v);
                txtIme.Text = podaci.Ime;
                txtPrezime.Text = podaci.Prezime;
                txtTelefon.Text = podaci.Telefon;
                txtEamail.Text = podaci.Email;
                txtKorisnickoIme.Text = podaci.KorisnickoIme;
                if(podaci.Slika.Length>0)
                    pictureBox1.Image= ImageHelper.FromByteToImage(podaci.Slika);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            UrediKlijentafrm nova = new UrediKlijentafrm(_v);
            //if(nova.ShowDialog()==DialogResult.OK)
            nova.Show();

        }
    }
}
