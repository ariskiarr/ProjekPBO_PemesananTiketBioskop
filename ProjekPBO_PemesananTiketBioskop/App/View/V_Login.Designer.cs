namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Login));
            btLogin = new Button();
            tbEmailUsernameLogin = new TextBox();
            tbPasswordLogin = new TextBox();
            btRegisterHalLogin = new Button();
            SuspendLayout();
            // 
            // btLogin
            // 
            btLogin.AutoSize = true;
            btLogin.BackColor = Color.Transparent;
            btLogin.FlatAppearance.BorderSize = 0;
            btLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btLogin.FlatStyle = FlatStyle.Popup;
            btLogin.ForeColor = Color.Transparent;
            btLogin.Location = new Point(1309, 656);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(455, 66);
            btLogin.TabIndex = 2;
            btLogin.UseVisualStyleBackColor = false;
            // 
            // tbEmailUsernameLogin
            // 
            tbEmailUsernameLogin.BorderStyle = BorderStyle.None;
            tbEmailUsernameLogin.Font = new Font("Segoe UI", 12F);
            tbEmailUsernameLogin.ForeColor = Color.Black;
            tbEmailUsernameLogin.Location = new Point(1322, 451);
            tbEmailUsernameLogin.Name = "tbEmailUsernameLogin";
            tbEmailUsernameLogin.Size = new Size(429, 32);
            tbEmailUsernameLogin.TabIndex = 0;
            // 
            // tbPasswordLogin
            // 
            tbPasswordLogin.BorderStyle = BorderStyle.None;
            tbPasswordLogin.Font = new Font("Segoe UI", 12F);
            tbPasswordLogin.ForeColor = Color.Black;
            tbPasswordLogin.Location = new Point(1322, 575);
            tbPasswordLogin.Name = "tbPasswordLogin";
            tbPasswordLogin.Size = new Size(429, 32);
            tbPasswordLogin.TabIndex = 1;
            tbPasswordLogin.UseSystemPasswordChar = true;
            // 
            // btRegisterHalLogin
            // 
            btRegisterHalLogin.BackColor = Color.Transparent;
            btRegisterHalLogin.BackgroundImageLayout = ImageLayout.None;
            btRegisterHalLogin.FlatAppearance.BorderSize = 0;
            btRegisterHalLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btRegisterHalLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btRegisterHalLogin.FlatStyle = FlatStyle.Flat;
            btRegisterHalLogin.ForeColor = Color.Transparent;
            btRegisterHalLogin.Location = new Point(1605, 972);
            btRegisterHalLogin.Name = "btRegisterHalLogin";
            btRegisterHalLogin.Size = new Size(104, 30);
            btRegisterHalLogin.TabIndex = 2;
            btRegisterHalLogin.UseVisualStyleBackColor = false;
            btRegisterHalLogin.Click += btRegisterHalLogin_Click;
            // 
            // V_Login
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1064);
            Controls.Add(btRegisterHalLogin);
            Controls.Add(btLogin);
            Controls.Add(tbPasswordLogin);
            Controls.Add(tbEmailUsernameLogin);
            ForeColor = Color.Transparent;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "V_Login";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEmailUsernameLogin;
        private TextBox tbPasswordLogin;
        private Button btLogin;
        private Button btRegisterHalLogin;
    }
}