namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_PilihKursiPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_PilihKursiPelanggan));
            btKembaliPilihKursi = new Button();
            btSelesaiMilihKursi = new Button();
            SuspendLayout();
            // 
            // btKembaliPilihKursi
            // 
            btKembaliPilihKursi.BackColor = Color.Transparent;
            btKembaliPilihKursi.FlatAppearance.BorderSize = 0;
            btKembaliPilihKursi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btKembaliPilihKursi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btKembaliPilihKursi.FlatStyle = FlatStyle.Flat;
            btKembaliPilihKursi.Location = new Point(1630, 988);
            btKembaliPilihKursi.Name = "btKembaliPilihKursi";
            btKembaliPilihKursi.Size = new Size(231, 64);
            btKembaliPilihKursi.TabIndex = 0;
            btKembaliPilihKursi.UseVisualStyleBackColor = false;
            btKembaliPilihKursi.Click += btKembaliPilihKursi_Click;
            // 
            // btSelesaiMilihKursi
            // 
            btSelesaiMilihKursi.BackColor = Color.Transparent;
            btSelesaiMilihKursi.FlatAppearance.BorderSize = 0;
            btSelesaiMilihKursi.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btSelesaiMilihKursi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btSelesaiMilihKursi.FlatStyle = FlatStyle.Flat;
            btSelesaiMilihKursi.Location = new Point(1630, 901);
            btSelesaiMilihKursi.Name = "btSelesaiMilihKursi";
            btSelesaiMilihKursi.Size = new Size(231, 58);
            btSelesaiMilihKursi.TabIndex = 1;
            btSelesaiMilihKursi.UseVisualStyleBackColor = false;
            // 
            // V_PilihKursiPelanggan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1064);
            Controls.Add(btSelesaiMilihKursi);
            Controls.Add(btKembaliPilihKursi);
            Name = "V_PilihKursiPelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_PilihKursiPelanggan";
            ResumeLayout(false);
        }

        #endregion

        private Button btKembaliPilihKursi;
        private Button btSelesaiMilihKursi;
    }
}