namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_DetailFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DetailFilm));
            lbGenre = new Label();
            lbSutradara = new Label();
            lbProduksi = new Label();
            tbSinopsisdetail = new TextBox();
            tbAktorDetail = new TextBox();
            pbGambarFilmDetail = new PictureBox();
            btLanjutkanDetailFilm = new Button();
            lbJudulFilmDetail = new Label();
            lbDurasiDetail = new Label();
            btKembaliDetail = new Button();
            lbBatasUmurDetail = new Label();
            ((System.ComponentModel.ISupportInitialize)pbGambarFilmDetail).BeginInit();
            SuspendLayout();
            // 
            // lbGenre
            // 
            lbGenre.AutoSize = true;
            lbGenre.BackColor = Color.White;
            lbGenre.Font = new Font("Segoe UI", 16F);
            lbGenre.Location = new Point(884, 283);
            lbGenre.Name = "lbGenre";
            lbGenre.Size = new Size(105, 45);
            lbGenre.TabIndex = 0;
            lbGenre.Text = "Genre";
            // 
            // lbSutradara
            // 
            lbSutradara.AutoSize = true;
            lbSutradara.BackColor = Color.White;
            lbSutradara.Font = new Font("Segoe UI", 16F);
            lbSutradara.Location = new Point(884, 350);
            lbSutradara.Name = "lbSutradara";
            lbSutradara.Size = new Size(155, 45);
            lbSutradara.TabIndex = 1;
            lbSutradara.Text = "Sutradara";
            // 
            // lbProduksi
            // 
            lbProduksi.AutoSize = true;
            lbProduksi.BackColor = Color.White;
            lbProduksi.Font = new Font("Segoe UI", 16F);
            lbProduksi.Location = new Point(883, 482);
            lbProduksi.Name = "lbProduksi";
            lbProduksi.Size = new Size(143, 45);
            lbProduksi.TabIndex = 3;
            lbProduksi.Text = "Produksi";
            // 
            // tbSinopsisdetail
            // 
            tbSinopsisdetail.BackColor = Color.White;
            tbSinopsisdetail.BorderStyle = BorderStyle.None;
            tbSinopsisdetail.Font = new Font("Segoe UI", 12F);
            tbSinopsisdetail.Location = new Point(883, 604);
            tbSinopsisdetail.Multiline = true;
            tbSinopsisdetail.Name = "tbSinopsisdetail";
            tbSinopsisdetail.ReadOnly = true;
            tbSinopsisdetail.ScrollBars = ScrollBars.Horizontal;
            tbSinopsisdetail.Size = new Size(897, 307);
            tbSinopsisdetail.TabIndex = 4;
            // 
            // tbAktorDetail
            // 
            tbAktorDetail.BackColor = Color.White;
            tbAktorDetail.BorderStyle = BorderStyle.None;
            tbAktorDetail.Font = new Font("Segoe UI", 16F);
            tbAktorDetail.Location = new Point(895, 423);
            tbAktorDetail.Name = "tbAktorDetail";
            tbAktorDetail.ReadOnly = true;
            tbAktorDetail.ScrollBars = ScrollBars.Horizontal;
            tbAktorDetail.Size = new Size(897, 43);
            tbAktorDetail.TabIndex = 5;
            // 
            // pbGambarFilmDetail
            // 
            pbGambarFilmDetail.Location = new Point(226, 283);
            pbGambarFilmDetail.Name = "pbGambarFilmDetail";
            pbGambarFilmDetail.Size = new Size(291, 428);
            pbGambarFilmDetail.TabIndex = 6;
            pbGambarFilmDetail.TabStop = false;
            // 
            // btLanjutkanDetailFilm
            // 
            btLanjutkanDetailFilm.BackColor = Color.Transparent;
            btLanjutkanDetailFilm.FlatAppearance.BorderSize = 0;
            btLanjutkanDetailFilm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btLanjutkanDetailFilm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btLanjutkanDetailFilm.FlatStyle = FlatStyle.Flat;
            btLanjutkanDetailFilm.ForeColor = Color.Transparent;
            btLanjutkanDetailFilm.Location = new Point(1446, 969);
            btLanjutkanDetailFilm.Name = "btLanjutkanDetailFilm";
            btLanjutkanDetailFilm.Size = new Size(300, 55);
            btLanjutkanDetailFilm.TabIndex = 7;
            btLanjutkanDetailFilm.UseVisualStyleBackColor = false;
            btLanjutkanDetailFilm.Click += btLanjutkanDetailFilm_Click;
            // 
            // lbJudulFilmDetail
            // 
            lbJudulFilmDetail.AutoSize = true;
            lbJudulFilmDetail.BackColor = Color.White;
            lbJudulFilmDetail.Font = new Font("Segoe UI", 16F);
            lbJudulFilmDetail.Location = new Point(226, 225);
            lbJudulFilmDetail.Name = "lbJudulFilmDetail";
            lbJudulFilmDetail.Size = new Size(163, 45);
            lbJudulFilmDetail.TabIndex = 8;
            lbJudulFilmDetail.Text = "Judul Film";
            // 
            // lbDurasiDetail
            // 
            lbDurasiDetail.AutoSize = true;
            lbDurasiDetail.BackColor = Color.White;
            lbDurasiDetail.Font = new Font("Segoe UI", 16F);
            lbDurasiDetail.Location = new Point(884, 543);
            lbDurasiDetail.Name = "lbDurasiDetail";
            lbDurasiDetail.Size = new Size(109, 45);
            lbDurasiDetail.TabIndex = 10;
            lbDurasiDetail.Text = "Durasi";
            // 
            // btKembaliDetail
            // 
            btKembaliDetail.BackColor = Color.Transparent;
            btKembaliDetail.FlatAppearance.BorderSize = 0;
            btKembaliDetail.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btKembaliDetail.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btKembaliDetail.FlatStyle = FlatStyle.Flat;
            btKembaliDetail.ForeColor = Color.Transparent;
            btKembaliDetail.Location = new Point(1089, 969);
            btKembaliDetail.Name = "btKembaliDetail";
            btKembaliDetail.Size = new Size(300, 55);
            btKembaliDetail.TabIndex = 11;
            btKembaliDetail.UseVisualStyleBackColor = false;
            btKembaliDetail.Click += btKembaliDetail_Click;
            // 
            // lbBatasUmurDetail
            // 
            lbBatasUmurDetail.AutoSize = true;
            lbBatasUmurDetail.BackColor = Color.Transparent;
            lbBatasUmurDetail.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lbBatasUmurDetail.Location = new Point(285, 739);
            lbBatasUmurDetail.Name = "lbBatasUmurDetail";
            lbBatasUmurDetail.Size = new Size(42, 32);
            lbBatasUmurDetail.TabIndex = 9;
            lbBatasUmurDetail.Text = "13";
            // 
            // V_DetailFilm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1064);
            Controls.Add(btKembaliDetail);
            Controls.Add(lbDurasiDetail);
            Controls.Add(lbBatasUmurDetail);
            Controls.Add(lbJudulFilmDetail);
            Controls.Add(btLanjutkanDetailFilm);
            Controls.Add(pbGambarFilmDetail);
            Controls.Add(tbAktorDetail);
            Controls.Add(tbSinopsisdetail);
            Controls.Add(lbProduksi);
            Controls.Add(lbSutradara);
            Controls.Add(lbGenre);
            Name = "V_DetailFilm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_DetailFilm";
            ((System.ComponentModel.ISupportInitialize)pbGambarFilmDetail).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbGenre;
        private Label lbSutradara;
        private Label lbProduksi;
        private TextBox tbSinopsisdetail;
        private TextBox tbAktorDetail;
        private PictureBox pbGambarFilmDetail;
        private Button btLanjutkanDetailFilm;
        private Label lbJudulFilmDetail;
        private Label lbDurasiDetail;
        private Button btKembaliDetail;
        private Label lbBatasUmurDetail;
    }
}