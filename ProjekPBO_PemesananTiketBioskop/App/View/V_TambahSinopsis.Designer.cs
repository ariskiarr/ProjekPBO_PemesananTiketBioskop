namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_TambahSinopsis
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
            tbSinopsis = new TextBox();
            btsimpanSinopsis = new Button();
            SuspendLayout();
            // 
            // tbSinopsis
            // 
            tbSinopsis.BorderStyle = BorderStyle.None;
            tbSinopsis.Location = new Point(21, 12);
            tbSinopsis.Multiline = true;
            tbSinopsis.Name = "tbSinopsis";
            tbSinopsis.Size = new Size(723, 414);
            tbSinopsis.TabIndex = 1;
            // 
            // btsimpanSinopsis
            // 
            btsimpanSinopsis.BackColor = Color.Purple;
            btsimpanSinopsis.FlatStyle = FlatStyle.Popup;
            btsimpanSinopsis.ForeColor = SystemColors.Window;
            btsimpanSinopsis.Location = new Point(632, 448);
            btsimpanSinopsis.Name = "btsimpanSinopsis";
            btsimpanSinopsis.Size = new Size(112, 34);
            btsimpanSinopsis.TabIndex = 2;
            btsimpanSinopsis.Text = "Simpan";
            btsimpanSinopsis.UseVisualStyleBackColor = false;
            btsimpanSinopsis.Click += btsimpanSinopsis_Click;
            // 
            // V_TambahSinopsis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 494);
            Controls.Add(btsimpanSinopsis);
            Controls.Add(tbSinopsis);
            Name = "V_TambahSinopsis";
            Text = "V_TambahSinopsis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbSinopsis;
        private Button btsimpanSinopsis;
    }
}