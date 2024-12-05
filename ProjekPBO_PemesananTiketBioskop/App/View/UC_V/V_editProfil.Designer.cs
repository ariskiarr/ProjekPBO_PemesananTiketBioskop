namespace ProjekPBO_PemesananTiketBioskop.App.View.UC_V
{
    partial class V_editProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_editProfil));
            tbUsernameAdmin = new TextBox();
            tbEmailAdmin = new TextBox();
            tbPasswordAmin = new TextBox();
            tbNomorTeleponAdmin = new TextBox();
            btSimpanProfilAdmin = new Button();
            btBatalProfilAdmin = new Button();
            SuspendLayout();
            // 
            // tbUsernameAdmin
            // 
            tbUsernameAdmin.BorderStyle = BorderStyle.None;
            tbUsernameAdmin.Font = new Font("Segoe UI", 12F);
            tbUsernameAdmin.Location = new Point(631, 308);
            tbUsernameAdmin.Name = "tbUsernameAdmin";
            tbUsernameAdmin.Size = new Size(429, 32);
            tbUsernameAdmin.TabIndex = 0;
            // 
            // tbEmailAdmin
            // 
            tbEmailAdmin.BorderStyle = BorderStyle.None;
            tbEmailAdmin.Font = new Font("Segoe UI", 12F);
            tbEmailAdmin.Location = new Point(631, 426);
            tbEmailAdmin.Name = "tbEmailAdmin";
            tbEmailAdmin.Size = new Size(429, 32);
            tbEmailAdmin.TabIndex = 1;
            // 
            // tbPasswordAmin
            // 
            tbPasswordAmin.BorderStyle = BorderStyle.None;
            tbPasswordAmin.Font = new Font("Segoe UI", 12F);
            tbPasswordAmin.Location = new Point(631, 547);
            tbPasswordAmin.Name = "tbPasswordAmin";
            tbPasswordAmin.Size = new Size(429, 32);
            tbPasswordAmin.TabIndex = 2;
            // 
            // tbNomorTeleponAdmin
            // 
            tbNomorTeleponAdmin.BorderStyle = BorderStyle.None;
            tbNomorTeleponAdmin.Font = new Font("Segoe UI", 12F);
            tbNomorTeleponAdmin.Location = new Point(631, 669);
            tbNomorTeleponAdmin.Name = "tbNomorTeleponAdmin";
            tbNomorTeleponAdmin.Size = new Size(429, 32);
            tbNomorTeleponAdmin.TabIndex = 3;
            // 
            // btSimpanProfilAdmin
            // 
            btSimpanProfilAdmin.BackColor = Color.Transparent;
            btSimpanProfilAdmin.FlatStyle = FlatStyle.Popup;
            btSimpanProfilAdmin.Location = new Point(862, 827);
            btSimpanProfilAdmin.Name = "btSimpanProfilAdmin";
            btSimpanProfilAdmin.Size = new Size(209, 61);
            btSimpanProfilAdmin.TabIndex = 4;
            btSimpanProfilAdmin.UseVisualStyleBackColor = false;
            btSimpanProfilAdmin.Click += btSimpanProfilAdmin_Click;
            // 
            // btBatalProfilAdmin
            // 
            btBatalProfilAdmin.BackColor = Color.Transparent;
            btBatalProfilAdmin.FlatStyle = FlatStyle.Popup;
            btBatalProfilAdmin.Location = new Point(613, 827);
            btBatalProfilAdmin.Name = "btBatalProfilAdmin";
            btBatalProfilAdmin.Size = new Size(209, 61);
            btBatalProfilAdmin.TabIndex = 5;
            btBatalProfilAdmin.UseVisualStyleBackColor = false;
            btBatalProfilAdmin.Click += btBatalProfilAdmin_Click;
            // 
            // V_editProfil
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(btBatalProfilAdmin);
            Controls.Add(btSimpanProfilAdmin);
            Controls.Add(tbNomorTeleponAdmin);
            Controls.Add(tbPasswordAmin);
            Controls.Add(tbEmailAdmin);
            Controls.Add(tbUsernameAdmin);
            Name = "V_editProfil";
            Size = new Size(1618, 1079);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUsernameAdmin;
        private TextBox tbEmailAdmin;
        private TextBox tbPasswordAmin;
        private TextBox tbNomorTeleponAdmin;
        private Button btSimpanProfilAdmin;
        private Button btBatalProfilAdmin;
    }
}
