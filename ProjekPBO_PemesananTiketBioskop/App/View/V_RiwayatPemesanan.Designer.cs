namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_RiwayatPemesanan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RiwayatPemesanan));
            dgvRiwayatPesanan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPesanan).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayatPesanan
            // 
            dgvRiwayatPesanan.BackgroundColor = Color.White;
            dgvRiwayatPesanan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiwayatPesanan.Location = new Point(235, 227);
            dgvRiwayatPesanan.Name = "dgvRiwayatPesanan";
            dgvRiwayatPesanan.RowHeadersWidth = 62;
            dgvRiwayatPesanan.Size = new Size(1462, 705);
            dgvRiwayatPesanan.TabIndex = 0;
            // 
            // V_RiwayatPemesanan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1064);
            Controls.Add(dgvRiwayatPesanan);
            Name = "V_RiwayatPemesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_RiwayatPemesanan";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPesanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRiwayatPesanan;
    }
}