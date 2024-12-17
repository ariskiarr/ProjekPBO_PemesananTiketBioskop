namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_ProfilAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_ProfilAdmin));
            lbUsernameAdmin = new Label();
            lbEmailAdmin = new Label();
            lbNomorTelp = new Label();
            btEditProfilAdmin = new Button();
            tbpasswordprofiladmin = new TextBox();
            SuspendLayout();
            // 
            // lbUsernameAdmin
            // 
            lbUsernameAdmin.AutoSize = true;
            lbUsernameAdmin.BackColor = Color.White;
            lbUsernameAdmin.Font = new Font("Segoe UI", 12F);
            lbUsernameAdmin.Location = new Point(682, 317);
            lbUsernameAdmin.Name = "lbUsernameAdmin";
            lbUsernameAdmin.Size = new Size(121, 32);
            lbUsernameAdmin.TabIndex = 0;
            lbUsernameAdmin.Text = "Username";
            // 
            // lbEmailAdmin
            // 
            lbEmailAdmin.AutoSize = true;
            lbEmailAdmin.BackColor = Color.White;
            lbEmailAdmin.Font = new Font("Segoe UI", 12F);
            lbEmailAdmin.Location = new Point(682, 434);
            lbEmailAdmin.Name = "lbEmailAdmin";
            lbEmailAdmin.Size = new Size(71, 32);
            lbEmailAdmin.TabIndex = 1;
            lbEmailAdmin.Text = "Email";
            // 
            // lbNomorTelp
            // 
            lbNomorTelp.AutoSize = true;
            lbNomorTelp.BackColor = Color.White;
            lbNomorTelp.Font = new Font("Segoe UI", 12F);
            lbNomorTelp.Location = new Point(682, 676);
            lbNomorTelp.Name = "lbNomorTelp";
            lbNomorTelp.Size = new Size(181, 32);
            lbNomorTelp.TabIndex = 3;
            lbNomorTelp.Text = "Nomor Telepon";
            // 
            // btEditProfilAdmin
            // 
            btEditProfilAdmin.BackColor = Color.Transparent;
            btEditProfilAdmin.FlatStyle = FlatStyle.Popup;
            btEditProfilAdmin.Location = new Point(784, 848);
            btEditProfilAdmin.Name = "btEditProfilAdmin";
            btEditProfilAdmin.Size = new Size(207, 54);
            btEditProfilAdmin.TabIndex = 4;
            btEditProfilAdmin.UseVisualStyleBackColor = false;
            btEditProfilAdmin.Click += btEditProfilAdmin_Click;
            // 
            // tbpasswordprofiladmin
            // 
            tbpasswordprofiladmin.BackColor = Color.White;
            tbpasswordprofiladmin.BorderStyle = BorderStyle.None;
            tbpasswordprofiladmin.Font = new Font("Segoe UI", 12F);
            tbpasswordprofiladmin.Location = new Point(682, 552);
            tbpasswordprofiladmin.Name = "tbpasswordprofiladmin";
            tbpasswordprofiladmin.ReadOnly = true;
            tbpasswordprofiladmin.Size = new Size(417, 32);
            tbpasswordprofiladmin.TabIndex = 5;
            tbpasswordprofiladmin.UseSystemPasswordChar = true;
            // 
            // V_ProfilAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(tbpasswordprofiladmin);
            Controls.Add(btEditProfilAdmin);
            Controls.Add(lbNomorTelp);
            Controls.Add(lbEmailAdmin);
            Controls.Add(lbUsernameAdmin);
            Name = "V_ProfilAdmin";
            Size = new Size(1618, 1079);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbUsernameAdmin;
        private Label lbEmailAdmin;
        private Label lbNomorTelp;
        private Button btEditProfilAdmin;
        private TextBox tbpasswordprofiladmin;
    }
}
