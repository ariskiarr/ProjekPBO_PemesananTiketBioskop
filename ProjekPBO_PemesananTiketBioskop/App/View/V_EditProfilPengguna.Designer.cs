namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_EditProfilPengguna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_EditProfilPengguna));
            tbUsernamePengguna = new TextBox();
            tbEmailPengguna = new TextBox();
            tbPasswordPengguna = new TextBox();
            tbNomorTelpPengguna = new TextBox();
            btKembaliEditProfilPengguna = new Button();
            btSimpanEditProfilPengguna = new Button();
            SuspendLayout();
            // 
            // tbUsernamePengguna
            // 
            tbUsernamePengguna.BorderStyle = BorderStyle.None;
            tbUsernamePengguna.Font = new Font("Segoe UI", 12F);
            tbUsernamePengguna.Location = new Point(788, 408);
            tbUsernamePengguna.Name = "tbUsernamePengguna";
            tbUsernamePengguna.Size = new Size(429, 32);
            tbUsernamePengguna.TabIndex = 1;
            // 
            // tbEmailPengguna
            // 
            tbEmailPengguna.BorderStyle = BorderStyle.None;
            tbEmailPengguna.Font = new Font("Segoe UI", 12F);
            tbEmailPengguna.Location = new Point(788, 525);
            tbEmailPengguna.Name = "tbEmailPengguna";
            tbEmailPengguna.Size = new Size(429, 32);
            tbEmailPengguna.TabIndex = 2;
            // 
            // tbPasswordPengguna
            // 
            tbPasswordPengguna.BorderStyle = BorderStyle.None;
            tbPasswordPengguna.Font = new Font("Segoe UI", 12F);
            tbPasswordPengguna.Location = new Point(788, 647);
            tbPasswordPengguna.Name = "tbPasswordPengguna";
            tbPasswordPengguna.Size = new Size(429, 32);
            tbPasswordPengguna.TabIndex = 3;
            // 
            // tbNomorTelpPengguna
            // 
            tbNomorTelpPengguna.BorderStyle = BorderStyle.None;
            tbNomorTelpPengguna.Font = new Font("Segoe UI", 12F);
            tbNomorTelpPengguna.Location = new Point(788, 763);
            tbNomorTelpPengguna.Name = "tbNomorTelpPengguna";
            tbNomorTelpPengguna.Size = new Size(429, 32);
            tbNomorTelpPengguna.TabIndex = 4;
            // 
            // btKembaliEditProfilPengguna
            // 
            btKembaliEditProfilPengguna.BackColor = Color.Transparent;
            btKembaliEditProfilPengguna.FlatStyle = FlatStyle.Popup;
            btKembaliEditProfilPengguna.Location = new Point(777, 913);
            btKembaliEditProfilPengguna.Name = "btKembaliEditProfilPengguna";
            btKembaliEditProfilPengguna.Size = new Size(207, 60);
            btKembaliEditProfilPengguna.TabIndex = 5;
            btKembaliEditProfilPengguna.UseVisualStyleBackColor = false;
            btKembaliEditProfilPengguna.Click += btKembaliEditProfilPengguna_Click;
            // 
            // btSimpanEditProfilPengguna
            // 
            btSimpanEditProfilPengguna.BackColor = Color.Transparent;
            btSimpanEditProfilPengguna.FlatStyle = FlatStyle.Popup;
            btSimpanEditProfilPengguna.Location = new Point(1022, 913);
            btSimpanEditProfilPengguna.Name = "btSimpanEditProfilPengguna";
            btSimpanEditProfilPengguna.Size = new Size(207, 60);
            btSimpanEditProfilPengguna.TabIndex = 6;
            btSimpanEditProfilPengguna.UseVisualStyleBackColor = false;
            btSimpanEditProfilPengguna.Click += btSimpanEditProfilPengguna_Click;
            // 
            // V_EditProfilPengguna
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1064);
            Controls.Add(btSimpanEditProfilPengguna);
            Controls.Add(btKembaliEditProfilPengguna);
            Controls.Add(tbNomorTelpPengguna);
            Controls.Add(tbPasswordPengguna);
            Controls.Add(tbEmailPengguna);
            Controls.Add(tbUsernamePengguna);
            Name = "V_EditProfilPengguna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_EditProfilPengguna";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsernamePengguna;
        private TextBox tbEmailPengguna;
        private TextBox tbPasswordPengguna;
        private TextBox tbNomorTelpPengguna;
        private Button btKembaliEditProfilPengguna;
        private Button btSimpanEditProfilPengguna;
    }
}