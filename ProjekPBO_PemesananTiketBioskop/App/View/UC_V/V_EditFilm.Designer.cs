namespace ProjekPBO_PemesananTiketBioskop.App.View.UC_V
{
    partial class V_EditFilm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_EditFilm));
            pbGambarEditFilm = new PictureBox();
            label1 = new Label();
            tbEditJudul = new TextBox();
            tbEditGenre = new TextBox();
            tbEditSutradara = new TextBox();
            tbEditProduksi = new TextBox();
            tbEditAktor = new TextBox();
            tbEditBatasUmur = new TextBox();
            cbEditWaktuTayang = new ComboBox();
            dtEditTanggalTayang = new DateTimePicker();
            tbEditDurasi = new TextBox();
            tbEditHarga = new TextBox();
            cbEditStatus = new ComboBox();
            cbEditRuangan = new ComboBox();
            btBatalEdit = new Button();
            btSimpanEdit = new Button();
            btEditSinopsis = new Button();
            ((System.ComponentModel.ISupportInitialize)pbGambarEditFilm).BeginInit();
            SuspendLayout();
            // 
            // pbGambarEditFilm
            // 
            pbGambarEditFilm.BackColor = Color.Transparent;
            pbGambarEditFilm.BackgroundImage = (Image)resources.GetObject("pbGambarEditFilm.BackgroundImage");
            pbGambarEditFilm.ErrorImage = null;
            pbGambarEditFilm.InitialImage = null;
            pbGambarEditFilm.Location = new Point(123, 224);
            pbGambarEditFilm.Name = "pbGambarEditFilm";
            pbGambarEditFilm.Size = new Size(288, 426);
            pbGambarEditFilm.TabIndex = 1;
            pbGambarEditFilm.TabStop = false;
            pbGambarEditFilm.Click += pbGambarEditFilm_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(123, 189);
            label1.Name = "label1";
            label1.Size = new Size(79, 32);
            label1.TabIndex = 2;
            label1.Text = "Poster";
            // 
            // tbEditJudul
            // 
            tbEditJudul.BorderStyle = BorderStyle.None;
            tbEditJudul.Font = new Font("Segoe UI", 12F);
            tbEditJudul.Location = new Point(516, 251);
            tbEditJudul.Name = "tbEditJudul";
            tbEditJudul.Size = new Size(429, 32);
            tbEditJudul.TabIndex = 3;
            // 
            // tbEditGenre
            // 
            tbEditGenre.BorderStyle = BorderStyle.None;
            tbEditGenre.Font = new Font("Segoe UI", 12F);
            tbEditGenre.Location = new Point(516, 365);
            tbEditGenre.Name = "tbEditGenre";
            tbEditGenre.Size = new Size(429, 32);
            tbEditGenre.TabIndex = 4;
            // 
            // tbEditSutradara
            // 
            tbEditSutradara.BorderStyle = BorderStyle.None;
            tbEditSutradara.Font = new Font("Segoe UI", 12F);
            tbEditSutradara.Location = new Point(516, 485);
            tbEditSutradara.Name = "tbEditSutradara";
            tbEditSutradara.Size = new Size(429, 32);
            tbEditSutradara.TabIndex = 5;
            // 
            // tbEditProduksi
            // 
            tbEditProduksi.BorderStyle = BorderStyle.None;
            tbEditProduksi.Font = new Font("Segoe UI", 12F);
            tbEditProduksi.Location = new Point(516, 602);
            tbEditProduksi.Name = "tbEditProduksi";
            tbEditProduksi.Size = new Size(429, 32);
            tbEditProduksi.TabIndex = 6;
            // 
            // tbEditAktor
            // 
            tbEditAktor.BorderStyle = BorderStyle.None;
            tbEditAktor.Font = new Font("Segoe UI", 12F);
            tbEditAktor.Location = new Point(516, 719);
            tbEditAktor.Name = "tbEditAktor";
            tbEditAktor.Size = new Size(429, 32);
            tbEditAktor.TabIndex = 7;
            // 
            // tbEditBatasUmur
            // 
            tbEditBatasUmur.BorderStyle = BorderStyle.None;
            tbEditBatasUmur.Font = new Font("Segoe UI", 12F);
            tbEditBatasUmur.Location = new Point(516, 838);
            tbEditBatasUmur.Name = "tbEditBatasUmur";
            tbEditBatasUmur.Size = new Size(102, 32);
            tbEditBatasUmur.TabIndex = 8;
            // 
            // cbEditWaktuTayang
            // 
            cbEditWaktuTayang.FlatStyle = FlatStyle.Flat;
            cbEditWaktuTayang.Font = new Font("Segoe UI", 12F);
            cbEditWaktuTayang.FormattingEnabled = true;
            cbEditWaktuTayang.Items.AddRange(new object[] { "09:00:00", "11:00:00", "13:00:00", "15:00:00", "17:00:00", "19:00:00", "22:00:00" });
            cbEditWaktuTayang.Location = new Point(1012, 248);
            cbEditWaktuTayang.Name = "cbEditWaktuTayang";
            cbEditWaktuTayang.Size = new Size(429, 40);
            cbEditWaktuTayang.TabIndex = 16;
            // 
            // dtEditTanggalTayang
            // 
            dtEditTanggalTayang.Font = new Font("Segoe UI", 12F);
            dtEditTanggalTayang.Format = DateTimePickerFormat.Custom;
            dtEditTanggalTayang.Location = new Point(1012, 365);
            dtEditTanggalTayang.Name = "dtEditTanggalTayang";
            dtEditTanggalTayang.Size = new Size(429, 39);
            dtEditTanggalTayang.TabIndex = 17;
            dtEditTanggalTayang.Value = new DateTime(2024, 11, 15, 0, 0, 0, 0);
            // 
            // tbEditDurasi
            // 
            tbEditDurasi.BorderStyle = BorderStyle.None;
            tbEditDurasi.Font = new Font("Segoe UI", 12F);
            tbEditDurasi.Location = new Point(1012, 485);
            tbEditDurasi.Name = "tbEditDurasi";
            tbEditDurasi.Size = new Size(322, 32);
            tbEditDurasi.TabIndex = 18;
            // 
            // tbEditHarga
            // 
            tbEditHarga.BorderStyle = BorderStyle.None;
            tbEditHarga.Font = new Font("Segoe UI", 12F);
            tbEditHarga.Location = new Point(1098, 602);
            tbEditHarga.Name = "tbEditHarga";
            tbEditHarga.Size = new Size(343, 32);
            tbEditHarga.TabIndex = 19;
            // 
            // cbEditStatus
            // 
            cbEditStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEditStatus.FlatStyle = FlatStyle.Flat;
            cbEditStatus.Font = new Font("Segoe UI", 12F);
            cbEditStatus.FormattingEnabled = true;
            cbEditStatus.Items.AddRange(new object[] { "Sedang Tayang", "Tidak Tayang" });
            cbEditStatus.Location = new Point(1012, 716);
            cbEditStatus.Name = "cbEditStatus";
            cbEditStatus.Size = new Size(429, 40);
            cbEditStatus.TabIndex = 20;
            // 
            // cbEditRuangan
            // 
            cbEditRuangan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbEditRuangan.FlatStyle = FlatStyle.Flat;
            cbEditRuangan.Font = new Font("Segoe UI", 12F);
            cbEditRuangan.FormattingEnabled = true;
            cbEditRuangan.Items.AddRange(new object[] { "Ruangan A", "Ruangan B", "Ruangan C" });
            cbEditRuangan.Location = new Point(1012, 830);
            cbEditRuangan.Name = "cbEditRuangan";
            cbEditRuangan.Size = new Size(429, 40);
            cbEditRuangan.TabIndex = 21;
            // 
            // btBatalEdit
            // 
            btBatalEdit.BackColor = Color.Transparent;
            btBatalEdit.FlatStyle = FlatStyle.Popup;
            btBatalEdit.Location = new Point(497, 961);
            btBatalEdit.Name = "btBatalEdit";
            btBatalEdit.Size = new Size(448, 59);
            btBatalEdit.TabIndex = 22;
            btBatalEdit.UseVisualStyleBackColor = false;
            btBatalEdit.Click += btBatalEdit_Click;
            // 
            // btSimpanEdit
            // 
            btSimpanEdit.BackColor = Color.Transparent;
            btSimpanEdit.FlatStyle = FlatStyle.Popup;
            btSimpanEdit.Location = new Point(1003, 961);
            btSimpanEdit.Name = "btSimpanEdit";
            btSimpanEdit.Size = new Size(454, 59);
            btSimpanEdit.TabIndex = 23;
            btSimpanEdit.UseVisualStyleBackColor = false;
            btSimpanEdit.Click += btSimpanEdit_Click;
            // 
            // btEditSinopsis
            // 
            btEditSinopsis.BackColor = Color.Transparent;
            btEditSinopsis.FlatStyle = FlatStyle.Popup;
            btEditSinopsis.Location = new Point(764, 819);
            btEditSinopsis.Name = "btEditSinopsis";
            btEditSinopsis.Size = new Size(68, 64);
            btEditSinopsis.TabIndex = 24;
            btEditSinopsis.UseVisualStyleBackColor = false;
            btEditSinopsis.Click += btEditSinopsis_Click;
            // 
            // V_EditFilm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btEditSinopsis);
            Controls.Add(btSimpanEdit);
            Controls.Add(btBatalEdit);
            Controls.Add(cbEditRuangan);
            Controls.Add(cbEditStatus);
            Controls.Add(tbEditHarga);
            Controls.Add(tbEditDurasi);
            Controls.Add(dtEditTanggalTayang);
            Controls.Add(cbEditWaktuTayang);
            Controls.Add(tbEditBatasUmur);
            Controls.Add(tbEditAktor);
            Controls.Add(tbEditProduksi);
            Controls.Add(tbEditSutradara);
            Controls.Add(tbEditGenre);
            Controls.Add(tbEditJudul);
            Controls.Add(label1);
            Controls.Add(pbGambarEditFilm);
            Name = "V_EditFilm";
            Size = new Size(1618, 1079);
            ((System.ComponentModel.ISupportInitialize)pbGambarEditFilm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbGambarEditFilm;
        private Label label1;
        private TextBox tbEditJudul;
        private TextBox tbEditGenre;
        private TextBox tbEditSutradara;
        private TextBox tbEditProduksi;
        private TextBox tbEditAktor;
        private TextBox tbEditBatasUmur;
        private ComboBox cbEditWaktuTayang;
        private DateTimePicker dtEditTanggalTayang;
        private TextBox tbEditDurasi;
        private TextBox tbEditHarga;
        private ComboBox cbEditStatus;
        private ComboBox cbEditRuangan;
        private Button btBatalEdit;
        private Button btSimpanEdit;
        private Button btEditSinopsis;
    }
}
