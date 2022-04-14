using eCabinRental.Model;
using eCabinRental.Model.Request.Klijent;
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
    public partial class UrediKlijentafrm : Form
    {
        protected APIService _servisKlijent = new APIService("Klijent");
        protected APIService _servisGrad = new APIService("Grad");
        private int? _v;

        public UrediKlijentafrm(int? klijent)
        {
            InitializeComponent();
            _v = klijent;
        }

       
        private async void UrediKlijentafrm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private async void LoadData()
        {
            await LoadTip();
            if (_v.HasValue)
            {

                var podaci = await _servisKlijent.GetById<Model.Klijent>(_v);
                txtIme.Text = podaci.Ime;
                txtPrezime.Text = podaci.Prezime;
                txtEmail.Text = podaci.Email.ToString();
                txtTelefon.Text = podaci.Telefon;
                txtKorisnicko.Text = podaci.KorisnickoIme;
                if(podaci.Slika.Length>0)
                    pbSlika.Image = ImageHelper.FromByteToImage(podaci.Slika);
            }
        }
        private async Task LoadTip()
        {
            var lista = await _servisKlijent.Get<List<Model.Grad>>();
            lista.Insert(0, new Model.Grad());
            cmbGrad.ValueMember = "GradId";
            cmbGrad.DisplayMember = "Naziv";
            cmbGrad.DataSource = lista;
        }

        KlijentUpdateRequest request = new KlijentUpdateRequest();
        private async void btnSpasi_Click(object sender, EventArgs e)
        {

            if (_v.HasValue)
            {
                if (this.ValidateChildren())
                {
                    request.Ime = txtIme.Text;
                    request.Prezime = txtPrezime.Text;
                    request.KorisnickoIme = txtKorisnicko.Text;
                    request.Email = txtEmail.Text;
                    request.Telefon = txtTelefon.Text;
                    var tipId = cmbGrad.SelectedValue;
                    if (int.TryParse(tipId.ToString(), out int TipId))
                    {
                        request.GradId = TipId;
                    }

                    await _servisKlijent.Update<Klijent>(_v, request);
                    MessageBox.Show("Podaci o fotografu su izmijenjeni", "Poruka", MessageBoxButtons.OK);
                    this.Close();
                }

            }
        }
    }
}
