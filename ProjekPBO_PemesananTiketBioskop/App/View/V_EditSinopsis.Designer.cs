namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_EditSinopsis
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
            tbEditSinopsis = new TextBox();
            btsimpanEditSinopsis = new Button();
            SuspendLayout();
            // 
            // tbEditSinopsis
            // 
            tbEditSinopsis.BorderStyle = BorderStyle.None;
            tbEditSinopsis.Location = new Point(27, 22);
            tbEditSinopsis.Multiline = true;
            tbEditSinopsis.Name = "tbEditSinopsis";
            tbEditSinopsis.Size = new Size(723, 414);
            tbEditSinopsis.TabIndex = 0;
            // 
            // btsimpanEditSinopsis
            // 
            btsimpanEditSinopsis.BackColor = Color.Purple;
            btsimpanEditSinopsis.FlatStyle = FlatStyle.Popup;
            btsimpanEditSinopsis.ForeColor = SystemColors.Window;
            btsimpanEditSinopsis.Location = new Point(638, 448);
            btsimpanEditSinopsis.Name = "btsimpanEditSinopsis";
            btsimpanEditSinopsis.Size = new Size(112, 34);
            btsimpanEditSinopsis.TabIndex = 1;
            btsimpanEditSinopsis.Text = "Simpan";
            btsimpanEditSinopsis.UseVisualStyleBackColor = false;
            btsimpanEditSinopsis.Click += btsimpanSinopsis_Click;
            // 
            // V_EditSinopsis
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 494);
            Controls.Add(btsimpanEditSinopsis);
            Controls.Add(tbEditSinopsis);
            Name = "V_EditSinopsis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_Sinopsis";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbEditSinopsis;
        private Button btsimpanEditSinopsis;
    }
}