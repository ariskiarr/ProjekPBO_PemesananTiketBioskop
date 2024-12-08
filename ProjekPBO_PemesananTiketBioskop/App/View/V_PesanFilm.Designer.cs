namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_PesanFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_PesanFilm));
            pbGambarFilmPesan = new PictureBox();
            btPilihKursi = new Button();
            cbPilihRuanganFIlm = new ComboBox();
            lbHargaPesan = new Label();
            btKembaliPesan = new Button();
            btLanjutPesan = new Button();
            ((System.ComponentModel.ISupportInitialize)pbGambarFilmPesan).BeginInit();
            SuspendLayout();
            // 
            // pbGambarFilmPesan
            // 
            pbGambarFilmPesan.Location = new Point(309, 346);
            pbGambarFilmPesan.Name = "pbGambarFilmPesan";
            pbGambarFilmPesan.Size = new Size(294, 427);
            pbGambarFilmPesan.TabIndex = 0;
            pbGambarFilmPesan.TabStop = false;
            // 
            // btPilihKursi
            // 
            btPilihKursi.Font = new Font("Segoe UI", 16F);
            btPilihKursi.Location = new Point(955, 361);
            btPilihKursi.Name = "btPilihKursi";
            btPilihKursi.Size = new Size(227, 48);
            btPilihKursi.TabIndex = 1;
            btPilihKursi.Text = "Klik";
            btPilihKursi.UseVisualStyleBackColor = true;
            btPilihKursi.Click += btPilihKursi_Click;
            // 
            // cbPilihRuanganFIlm
            // 
            cbPilihRuanganFIlm.DropDownStyle = ComboBoxStyle.DropDownList;
            cbPilihRuanganFIlm.Font = new Font("Segoe UI", 16F);
            cbPilihRuanganFIlm.FormattingEnabled = true;
            cbPilihRuanganFIlm.Items.AddRange(new object[] { "Ruangan A", "Ruangan B", "Ruangan C" });
            cbPilihRuanganFIlm.Location = new Point(955, 445);
            cbPilihRuanganFIlm.Name = "cbPilihRuanganFIlm";
            cbPilihRuanganFIlm.Size = new Size(227, 53);
            cbPilihRuanganFIlm.TabIndex = 2;
            // 
            // lbHargaPesan
            // 
            lbHargaPesan.AutoSize = true;
            lbHargaPesan.BackColor = Color.White;
            lbHargaPesan.Font = new Font("Segoe UI", 18F);
            lbHargaPesan.Location = new Point(946, 523);
            lbHargaPesan.Name = "lbHargaPesan";
            lbHargaPesan.Size = new Size(116, 48);
            lbHargaPesan.TabIndex = 3;
            lbHargaPesan.Text = "Harga";
            // 
            // btKembaliPesan
            // 
            btKembaliPesan.BackColor = Color.Transparent;
            btKembaliPesan.FlatAppearance.BorderSize = 0;
            btKembaliPesan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btKembaliPesan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btKembaliPesan.FlatStyle = FlatStyle.Flat;
            btKembaliPesan.ForeColor = Color.Transparent;
            btKembaliPesan.Location = new Point(1093, 967);
            btKembaliPesan.Name = "btKembaliPesan";
            btKembaliPesan.Size = new Size(295, 55);
            btKembaliPesan.TabIndex = 4;
            btKembaliPesan.UseVisualStyleBackColor = false;
            btKembaliPesan.Click += btKembaliPesan_Click;
            // 
            // btLanjutPesan
            // 
            btLanjutPesan.BackColor = Color.Transparent;
            btLanjutPesan.FlatAppearance.BorderSize = 0;
            btLanjutPesan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btLanjutPesan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btLanjutPesan.FlatStyle = FlatStyle.Flat;
            btLanjutPesan.ForeColor = Color.Transparent;
            btLanjutPesan.Location = new Point(1450, 967);
            btLanjutPesan.Name = "btLanjutPesan";
            btLanjutPesan.Size = new Size(296, 55);
            btLanjutPesan.TabIndex = 5;
            btLanjutPesan.UseVisualStyleBackColor = false;
            btLanjutPesan.Click += btLanjutPesan_Click;
            // 
            // V_PesanFilm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1064);
            Controls.Add(btLanjutPesan);
            Controls.Add(btKembaliPesan);
            Controls.Add(lbHargaPesan);
            Controls.Add(cbPilihRuanganFIlm);
            Controls.Add(btPilihKursi);
            Controls.Add(pbGambarFilmPesan);
            Name = "V_PesanFilm";
            StartPosition = FormStartPosition.Manual;
            Text = "V_PesanFilm";
            ((System.ComponentModel.ISupportInitialize)pbGambarFilmPesan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbGambarFilmPesan;
        private Button btPilihKursi;
        private ComboBox cbPilihRuanganFIlm;
        private Label lbHargaPesan;
        private Button btKembaliPesan;
        private Button btLanjutPesan;
    }
}