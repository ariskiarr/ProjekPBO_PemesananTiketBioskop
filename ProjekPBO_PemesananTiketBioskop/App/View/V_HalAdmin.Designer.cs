namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_HalAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_HalAdmin));
            panel1 = new Panel();
            btLogoutAdmin = new Button();
            btLaporanAdmin = new Button();
            btFilmAdmin = new Button();
            btProfilAdmin = new Button();
            panel2 = new Panel();
            panelMain = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(btLogoutAdmin);
            panel1.Controls.Add(btLaporanAdmin);
            panel1.Controls.Add(btFilmAdmin);
            panel1.Controls.Add(btProfilAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 1064);
            panel1.TabIndex = 0;
            // 
            // btLogoutAdmin
            // 
            btLogoutAdmin.BackColor = Color.Transparent;
            btLogoutAdmin.FlatAppearance.BorderSize = 0;
            btLogoutAdmin.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btLogoutAdmin.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btLogoutAdmin.FlatStyle = FlatStyle.Flat;
            btLogoutAdmin.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLogoutAdmin.ForeColor = Color.White;
            btLogoutAdmin.Image = (Image)resources.GetObject("btLogoutAdmin.Image");
            btLogoutAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btLogoutAdmin.Location = new Point(-1, 590);
            btLogoutAdmin.Name = "btLogoutAdmin";
            btLogoutAdmin.Size = new Size(285, 107);
            btLogoutAdmin.TabIndex = 3;
            btLogoutAdmin.Text = "           LogOut";
            btLogoutAdmin.UseVisualStyleBackColor = false;
            btLogoutAdmin.Click += btLogoutAdmin_Click;
            // 
            // btLaporanAdmin
            // 
            btLaporanAdmin.BackColor = Color.Transparent;
            btLaporanAdmin.FlatAppearance.BorderSize = 0;
            btLaporanAdmin.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btLaporanAdmin.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btLaporanAdmin.FlatStyle = FlatStyle.Flat;
            btLaporanAdmin.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btLaporanAdmin.ForeColor = Color.White;
            btLaporanAdmin.Image = (Image)resources.GetObject("btLaporanAdmin.Image");
            btLaporanAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btLaporanAdmin.Location = new Point(-1, 476);
            btLaporanAdmin.Name = "btLaporanAdmin";
            btLaporanAdmin.Size = new Size(285, 107);
            btLaporanAdmin.TabIndex = 2;
            btLaporanAdmin.Text = "            Laporan";
            btLaporanAdmin.UseVisualStyleBackColor = false;
            btLaporanAdmin.Click += btLaporanAdmin_Click;
            // 
            // btFilmAdmin
            // 
            btFilmAdmin.BackColor = Color.Transparent;
            btFilmAdmin.FlatAppearance.BorderSize = 0;
            btFilmAdmin.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btFilmAdmin.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btFilmAdmin.FlatStyle = FlatStyle.Flat;
            btFilmAdmin.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btFilmAdmin.ForeColor = Color.White;
            btFilmAdmin.Image = (Image)resources.GetObject("btFilmAdmin.Image");
            btFilmAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btFilmAdmin.Location = new Point(0, 364);
            btFilmAdmin.Name = "btFilmAdmin";
            btFilmAdmin.Size = new Size(284, 107);
            btFilmAdmin.TabIndex = 1;
            btFilmAdmin.Text = "    Film";
            btFilmAdmin.UseVisualStyleBackColor = false;
            btFilmAdmin.Click += btFilmAdmin_Click;
            // 
            // btProfilAdmin
            // 
            btProfilAdmin.BackColor = Color.Transparent;
            btProfilAdmin.FlatAppearance.BorderSize = 0;
            btProfilAdmin.FlatAppearance.MouseDownBackColor = Color.LightGray;
            btProfilAdmin.FlatAppearance.MouseOverBackColor = Color.LightGray;
            btProfilAdmin.FlatStyle = FlatStyle.Flat;
            btProfilAdmin.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btProfilAdmin.ForeColor = Color.White;
            btProfilAdmin.Image = (Image)resources.GetObject("btProfilAdmin.Image");
            btProfilAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btProfilAdmin.Location = new Point(2, 244);
            btProfilAdmin.Name = "btProfilAdmin";
            btProfilAdmin.Size = new Size(282, 107);
            btProfilAdmin.TabIndex = 0;
            btProfilAdmin.Text = "      Profil";
            btProfilAdmin.UseVisualStyleBackColor = false;
            btProfilAdmin.Click += btProfilAdmin_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelMain);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(284, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1614, 1064);
            panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1614, 1064);
            panelMain.TabIndex = 0;
            // 
            // V_HalAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1898, 1064);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "V_HalAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_HalAdmin";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btProfilAdmin;
        private Button btFilmAdmin;
        private Button btLaporanAdmin;
        private Button btLogoutAdmin;
        private Panel panelMain;
    }
}