namespace ProjekPBO_PemesananTiketBioskop.App.View.UC_V
{
    partial class V_DaftarFilm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DaftarFilm));
            btTambahFilm = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btTambahFilm
            // 
            btTambahFilm.BackColor = Color.Transparent;
            btTambahFilm.FlatStyle = FlatStyle.Popup;
            btTambahFilm.Location = new Point(1273, 966);
            btTambahFilm.Name = "btTambahFilm";
            btTambahFilm.Size = new Size(257, 62);
            btTambahFilm.TabIndex = 0;
            btTambahFilm.UseVisualStyleBackColor = false;
            btTambahFilm.Click += btTambahFilm_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.WindowText;
            dataGridView1.Location = new Point(97, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1441, 700);
            dataGridView1.TabIndex = 1;
            // 
            // V_DaftarFilm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(dataGridView1);
            Controls.Add(btTambahFilm);
            Name = "V_DaftarFilm";
            Size = new Size(1618, 1079);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btTambahFilm;
        private DataGridView dataGridView1;
    }
}
