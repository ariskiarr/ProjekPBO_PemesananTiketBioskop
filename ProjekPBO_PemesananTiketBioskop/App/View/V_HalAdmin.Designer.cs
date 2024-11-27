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
            label1 = new Label();
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
            panel1.BackColor = Color.Moccasin;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btLogoutAdmin);
            panel1.Controls.Add(btLaporanAdmin);
            panel1.Controls.Add(btFilmAdmin);
            panel1.Controls.Add(btProfilAdmin);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(273, 1064);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(48, 95);
            label1.Name = "label1";
            label1.Size = new Size(179, 65);
            label1.TabIndex = 4;
            label1.Text = "Admin";
            // 
            // btLogoutAdmin
            // 
            btLogoutAdmin.BackColor = Color.Transparent;
            btLogoutAdmin.BackgroundImage = (Image)resources.GetObject("btLogoutAdmin.BackgroundImage");
            btLogoutAdmin.FlatAppearance.BorderSize = 0;
            btLogoutAdmin.FlatStyle = FlatStyle.Popup;
            btLogoutAdmin.Font = new Font("Segoe UI", 14F);
            btLogoutAdmin.Location = new Point(0, 581);
            btLogoutAdmin.Name = "btLogoutAdmin";
            btLogoutAdmin.Size = new Size(279, 107);
            btLogoutAdmin.TabIndex = 3;
            btLogoutAdmin.UseVisualStyleBackColor = false;
            btLogoutAdmin.Click += btLogoutAdmin_Click;
            // 
            // btLaporanAdmin
            // 
            btLaporanAdmin.BackColor = Color.Transparent;
            btLaporanAdmin.BackgroundImage = (Image)resources.GetObject("btLaporanAdmin.BackgroundImage");
            btLaporanAdmin.FlatAppearance.BorderSize = 0;
            btLaporanAdmin.FlatStyle = FlatStyle.Popup;
            btLaporanAdmin.Font = new Font("Segoe UI", 14F);
            btLaporanAdmin.Location = new Point(2, 468);
            btLaporanAdmin.Name = "btLaporanAdmin";
            btLaporanAdmin.Size = new Size(279, 107);
            btLaporanAdmin.TabIndex = 2;
            btLaporanAdmin.UseVisualStyleBackColor = false;
            btLaporanAdmin.Click += btLaporanAdmin_Click;
            // 
            // btFilmAdmin
            // 
            btFilmAdmin.BackColor = Color.Transparent;
            btFilmAdmin.BackgroundImage = (Image)resources.GetObject("btFilmAdmin.BackgroundImage");
            btFilmAdmin.FlatAppearance.BorderSize = 0;
            btFilmAdmin.FlatStyle = FlatStyle.Popup;
            btFilmAdmin.Font = new Font("Segoe UI", 14F);
            btFilmAdmin.Location = new Point(3, 355);
            btFilmAdmin.Name = "btFilmAdmin";
            btFilmAdmin.Size = new Size(279, 107);
            btFilmAdmin.TabIndex = 1;
            btFilmAdmin.UseVisualStyleBackColor = false;
            btFilmAdmin.Click += btFilmAdmin_Click;
            // 
            // btProfilAdmin
            // 
            btProfilAdmin.BackColor = Color.Transparent;
            btProfilAdmin.BackgroundImage = (Image)resources.GetObject("btProfilAdmin.BackgroundImage");
            btProfilAdmin.FlatAppearance.BorderSize = 0;
            btProfilAdmin.FlatStyle = FlatStyle.Popup;
            btProfilAdmin.Font = new Font("Segoe UI", 14F);
            btProfilAdmin.ForeColor = Color.Transparent;
            btProfilAdmin.Location = new Point(1, 242);
            btProfilAdmin.Name = "btProfilAdmin";
            btProfilAdmin.Size = new Size(279, 107);
            btProfilAdmin.TabIndex = 0;
            btProfilAdmin.UseVisualStyleBackColor = false;
            btProfilAdmin.Click += btProfilAdmin_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panelMain);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(273, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1625, 1064);
            panel2.TabIndex = 1;
            // 
            // panelMain
            // 
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1625, 1064);
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
            Text = "V_HalAdmin";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btProfilAdmin;
        private Button btFilmAdmin;
        private Button btLaporanAdmin;
        private Label label1;
        private Button btLogoutAdmin;
        private Panel panelMain;
    }
}