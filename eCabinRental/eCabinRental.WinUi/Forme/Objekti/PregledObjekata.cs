using eCabinRental.Model.Request.Objekat;
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

namespace eCabinRental.WinUi.Forme.Objekti
{
    public partial class PregledObjekata : Form
    {
        private readonly APIService _apiService = new APIService("Objekat");
        protected APIService _servisTipObjektum = new APIService("TipObjektum");

        public PregledObjekata()
        {
            InitializeComponent();
        }

        private void PregledObjekata_Load(object sender, EventArgs e)
        {
            UcitajPodatke();
            UcitajTipove();

        }

        private async Task UcitajTipove()
        {
            var lista = await _servisTipObjektum.Get<List<Model.TipObjektum>>();
            lista.Insert(0, new Model.TipObjektum());
            cmbTipObjekta.ValueMember = "TipObjektaId";
            cmbTipObjekta.DisplayMember = "Tip";
            cmbTipObjekta.DataSource = lista;
        }

        private async void UcitajPodatke()
        {
            var podaci = await _apiService.Get<List<Model.Objekat>>(null);
            List<eCabinRental.Model.VM.frmObjekti> lista = new List<frmObjekti>();
            foreach (var item in podaci)
            {
                frmObjekti forma = new frmObjekti
                {
                    ObjekatId = item.ObjekatId,
                    Naziv = item.Naziv,
                    Povrsina = item.Povrsina,
                    BrojMjestaDjeca = item.BrojMjestaDjeca.ToString(),
                    BrojMjestaOdrasli = item.BrojMjestaOdrasli.ToString(),
                    Cijena = item.Cijena.ToString(),
                    TipObjektaId = item.TipObjektaId

                };
                lista.Add(forma);
            }
            dgvObjekti.AutoGenerateColumns = false;
            dgvObjekti.DataSource = lista;
            label2.Text = lista.Count().ToString();

        }

        private async void btnTrazi_Click(object sender, EventArgs e)
        {
            //var pretraga = new ObjekatSearchRequest()
            //{
            //    TipObjektaId = (int)cmbTipObjekta.SelectedValue

            //};
            var podaci = await _apiService.GetById<List<Model.Objekat>>(cmbTipObjekta.SelectedValue);
            dgvObjekti.AutoGenerateColumns = false;
            dgvObjekti.DataSource = podaci;

            if (podaci.Count == 0 || podaci==null)
            {
                MessageBox.Show("Nema rezultata pretrage", "Poruka", MessageBoxButtons.OK);
            }
        }
    }
}
