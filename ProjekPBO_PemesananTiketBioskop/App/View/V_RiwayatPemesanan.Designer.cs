namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_RiwayatPemesanan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_RiwayatPemesanan));
            dgvRiwayatPesanan = new DataGridView();
            btKembaliRIwayat = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPesanan).BeginInit();
            SuspendLayout();
            // 
            // dgvRiwayatPesanan
            // 
            dgvRiwayatPesanan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvRiwayatPesanan.BackgroundColor = Color.White;
            dgvRiwayatPesanan.BorderStyle = BorderStyle.None;
            dgvRiwayatPesanan.ColumnHeadersHeight = 34;
            dgvRiwayatPesanan.GridColor = Color.Black;
            dgvRiwayatPesanan.Location = new Point(235, 227);
            dgvRiwayatPesanan.Name = "dgvRiwayatPesanan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRiwayatPesanan.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRiwayatPesanan.RowHeadersWidth = 62;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dgvRiwayatPesanan.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvRiwayatPesanan.Size = new Size(1462, 705);
            dgvRiwayatPesanan.TabIndex = 0;
            dgvRiwayatPesanan.CellContentClick += dgvRiwayatPesanan_CellContentClick;
            // 
            // btKembaliRIwayat
            // 
            btKembaliRIwayat.BackColor = Color.Transparent;
            btKembaliRIwayat.FlatAppearance.BorderSize = 0;
            btKembaliRIwayat.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btKembaliRIwayat.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btKembaliRIwayat.FlatStyle = FlatStyle.Flat;
            btKembaliRIwayat.Location = new Point(1529, 964);
            btKembaliRIwayat.Name = "btKembaliRIwayat";
            btKembaliRIwayat.RightToLeft = RightToLeft.No;
            btKembaliRIwayat.Size = new Size(297, 64);
            btKembaliRIwayat.TabIndex = 1;
            btKembaliRIwayat.UseVisualStyleBackColor = false;
            btKembaliRIwayat.Click += btKembaliRIwayat_Click;
            // 
            // V_RiwayatPemesanan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1898, 1064);
            Controls.Add(btKembaliRIwayat);
            Controls.Add(dgvRiwayatPesanan);
            Name = "V_RiwayatPemesanan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "V_RiwayatPemesanan";
            ((System.ComponentModel.ISupportInitialize)dgvRiwayatPesanan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRiwayatPesanan;
        private Button btKembaliRIwayat;
    }
}