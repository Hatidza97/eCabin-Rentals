
namespace eCabinRental.WinUi.Forme.Objekti
{
    partial class PregledObjekata
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNaslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvObjekti = new System.Windows.Forms.DataGridView();
            this.ObjekatId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Povrsina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojMjestaDjece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojMjestaOdrasli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbTipObjekta = new System.Windows.Forms.ComboBox();
            this.lblTip = new System.Windows.Forms.Label();
            this.btnTrazi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaslov.Location = new System.Drawing.Point(268, 21);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(247, 36);
            this.lblNaslov.TabIndex = 0;
            this.lblNaslov.Text = "Ponuda objekata ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Trenutno objekata na stranici:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // dgvObjekti
            // 
            this.dgvObjekti.AllowUserToAddRows = false;
            this.dgvObjekti.AllowUserToDeleteRows = false;
            this.dgvObjekti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvObjekti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObjekti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObjekatId,
            this.Naziv,
            this.Povrsina,
            this.BrojMjestaDjece,
            this.BrojMjestaOdrasli,
            this.Cijena});
            this.dgvObjekti.Location = new System.Drawing.Point(12, 133);
            this.dgvObjekti.Name = "dgvObjekti";
            this.dgvObjekti.ReadOnly = true;
            this.dgvObjekti.RowHeadersWidth = 51;
            this.dgvObjekti.RowTemplate.Height = 24;
            this.dgvObjekti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvObjekti.Size = new System.Drawing.Size(776, 305);
            this.dgvObjekti.TabIndex = 3;
            // 
            // ObjekatId
            // 
            this.ObjekatId.DataPropertyName = "ObjekatId";
            this.ObjekatId.HeaderText = "ObjekatId";
            this.ObjekatId.MinimumWidth = 6;
            this.ObjekatId.Name = "ObjekatId";
            this.ObjekatId.ReadOnly = true;
            this.ObjekatId.Visible = false;
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.MinimumWidth = 6;
            this.Naziv.Name = "Naziv";
            this.Naziv.ReadOnly = true;
            // 
            // Povrsina
            // 
            this.Povrsina.DataPropertyName = "Povrsina";
            this.Povrsina.HeaderText = "Povrsina";
            this.Povrsina.MinimumWidth = 6;
            this.Povrsina.Name = "Povrsina";
            this.Povrsina.ReadOnly = true;
            // 
            // BrojMjestaDjece
            // 
            this.BrojMjestaDjece.DataPropertyName = "BrojMjestaDjeca";
            this.BrojMjestaDjece.HeaderText = "Broj mjesta(djeca)";
            this.BrojMjestaDjece.MinimumWidth = 6;
            this.BrojMjestaDjece.Name = "BrojMjestaDjece";
            this.BrojMjestaDjece.ReadOnly = true;
            // 
            // BrojMjestaOdrasli
            // 
            this.BrojMjestaOdrasli.DataPropertyName = "BrojMjestaOdrasli";
            this.BrojMjestaOdrasli.HeaderText = "Broj mjesta(odrasli)";
            this.BrojMjestaOdrasli.MinimumWidth = 6;
            this.BrojMjestaOdrasli.Name = "BrojMjestaOdrasli";
            this.BrojMjestaOdrasli.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.MinimumWidth = 6;
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // cmbTipObjekta
            // 
            this.cmbTipObjekta.FormattingEnabled = true;
            this.cmbTipObjekta.Location = new System.Drawing.Point(113, 94);
            this.cmbTipObjekta.Name = "cmbTipObjekta";
            this.cmbTipObjekta.Size = new System.Drawing.Size(121, 24);
            this.cmbTipObjekta.TabIndex = 4;
            // 
            // lblTip
            // 
            this.lblTip.AutoSize = true;
            this.lblTip.Location = new System.Drawing.Point(16, 94);
            this.lblTip.Name = "lblTip";
            this.lblTip.Size = new System.Drawing.Size(82, 17);
            this.lblTip.TabIndex = 5;
            this.lblTip.Text = "Tip objekta:";
            // 
            // btnTrazi
            // 
            this.btnTrazi.Location = new System.Drawing.Point(264, 94);
            this.btnTrazi.Name = "btnTrazi";
            this.btnTrazi.Size = new System.Drawing.Size(75, 23);
            this.btnTrazi.TabIndex = 6;
            this.btnTrazi.Text = "Trazi";
            this.btnTrazi.UseVisualStyleBackColor = true;
            this.btnTrazi.Click += new System.EventHandler(this.btnTrazi_Click);
            // 
            // PregledObjekata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTrazi);
            this.Controls.Add(this.lblTip);
            this.Controls.Add(this.cmbTipObjekta);
            this.Controls.Add(this.dgvObjekti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNaslov);
            this.Name = "PregledObjekata";
            this.Text = "PregledObjekata";
            this.Load += new System.EventHandler(this.PregledObjekata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObjekti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvObjekti;
        private System.Windows.Forms.ComboBox cmbTipObjekta;
        private System.Windows.Forms.Label lblTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObjekatId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Povrsina;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojMjestaDjece;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojMjestaOdrasli;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.Button btnTrazi;
    }
}