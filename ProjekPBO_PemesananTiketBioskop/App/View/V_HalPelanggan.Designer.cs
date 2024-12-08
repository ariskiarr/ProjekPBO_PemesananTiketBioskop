namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_HalPelanggan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalPelanggan));
            btLogoutPelanggan = new Button();
            btRiwayatPelanggan = new Button();
            btProfilPelanggan = new Button();
            SuspendLayout();
            // 
            // btLogoutPelanggan
            // 
            btLogoutPelanggan.BackColor = Color.Transparent;
            btLogoutPelanggan.FlatAppearance.BorderSize = 0;
            btLogoutPelanggan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btLogoutPelanggan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btLogoutPelanggan.FlatStyle = FlatStyle.Flat;
            btLogoutPelanggan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btLogoutPelanggan.ForeColor = Color.Black;
            btLogoutPelanggan.Location = new Point(1184, 92);
            btLogoutPelanggan.Name = "btLogoutPelanggan";
            btLogoutPelanggan.Size = new Size(150, 46);
            btLogoutPelanggan.TabIndex = 1;
            btLogoutPelanggan.UseVisualStyleBackColor = false;
            btLogoutPelanggan.Click += btLogoutPelanggan_Click;
            // 
            // btRiwayatPelanggan
            // 
            btRiwayatPelanggan.BackColor = Color.Transparent;
            btRiwayatPelanggan.FlatAppearance.BorderSize = 0;
            btRiwayatPelanggan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btRiwayatPelanggan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btRiwayatPelanggan.FlatStyle = FlatStyle.Flat;
            btRiwayatPelanggan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btRiwayatPelanggan.ForeColor = Color.Black;
            btRiwayatPelanggan.Location = new Point(965, 92);
            btRiwayatPelanggan.Name = "btRiwayatPelanggan";
            btRiwayatPelanggan.Size = new Size(159, 46);
            btRiwayatPelanggan.TabIndex = 2;
            btRiwayatPelanggan.UseVisualStyleBackColor = false;
            btRiwayatPelanggan.Click += btRiwayatPelanggan_Click;
            // 
            // btProfilPelanggan
            // 
            btProfilPelanggan.BackColor = Color.Transparent;
            btProfilPelanggan.FlatAppearance.BorderSize = 0;
            btProfilPelanggan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btProfilPelanggan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btProfilPelanggan.FlatStyle = FlatStyle.Flat;
            btProfilPelanggan.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            btProfilPelanggan.ForeColor = Color.Black;
            btProfilPelanggan.Location = new Point(804, 92);
            btProfilPelanggan.Name = "btProfilPelanggan";
            btProfilPelanggan.Size = new Size(113, 46);
            btProfilPelanggan.TabIndex = 3;
            btProfilPelanggan.UseVisualStyleBackColor = false;
            btProfilPelanggan.Click += btProfilPelanggan_Click;
            // 
            // V_HalPelanggan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1064);
            Controls.Add(btProfilPelanggan);
            Controls.Add(btRiwayatPelanggan);
            Controls.Add(btLogoutPelanggan);
            Name = "V_HalPelanggan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_HalPelanggan";
            ResumeLayout(false);
        }

        #endregion
        private Button btLogoutPelanggan;
        private Button btRiwayatPelanggan;
        private Button btProfilPelanggan;
    }
}