using eCabinRental.WinUi.Forme.Klijenti;
using eCabinRental.WinUi.Forme.Objekti;
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
    public partial class Pocetna : Form
    {
        private int childFormNumber = 0;

        public Pocetna()
        {
            InitializeComponent();
        }

        private void PregledajKorisnikeToolStripeMenuItem_Click(object sender, EventArgs e)
        {
            frmKorisnici forma = new frmKorisnici();
            forma.MdiParent = this;
            forma.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        //}

        //private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        //}

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            HomePage forma = new HomePage();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledKlijenataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new Klijentifrm();
            forma.MdiParent = this;
            forma.Show();

        }

        private void dodajKlijentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new DodajKlijenta();
            forma.MdiParent = this;
            forma.Show();
        }

        private void pregledObjekataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form forma = new PregledObjekata();
            forma.MdiParent = this;
            forma.Show();
        }

        //private void KorisniciToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form forma = new frmKorisnici();
        //    forma.MdiParent = this;
        //    forma.Show();
        //}

    }
}
