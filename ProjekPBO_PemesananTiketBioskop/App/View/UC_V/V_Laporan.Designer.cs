namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    partial class V_Laporan
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Laporan));
            dgLaporanTransaksi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgLaporanTransaksi).BeginInit();
            SuspendLayout();
            // 
            // dgLaporanTransaksi
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 11F);
            dgLaporanTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgLaporanTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgLaporanTransaksi.BackgroundColor = Color.White;
            dgLaporanTransaksi.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgLaporanTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgLaporanTransaksi.ColumnHeadersHeight = 34;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgLaporanTransaksi.DefaultCellStyle = dataGridViewCellStyle3;
            dgLaporanTransaksi.GridColor = Color.Black;
            dgLaporanTransaksi.Location = new Point(86, 239);
            dgLaporanTransaksi.Name = "dgLaporanTransaksi";
            dgLaporanTransaksi.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = Color.Chartreuse;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgLaporanTransaksi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgLaporanTransaksi.RowHeadersWidth = 80;
            dgLaporanTransaksi.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 11F);
            dgLaporanTransaksi.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgLaporanTransaksi.Size = new Size(1454, 709);
            dgLaporanTransaksi.TabIndex = 0;
            dgLaporanTransaksi.CellContentClick += dgLaporanTransaksi_CellContentClick;
            // 
            // V_Laporan
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(dgLaporanTransaksi);
            Name = "V_Laporan";
            Size = new Size(1618, 1079);
            ((System.ComponentModel.ISupportInitialize)dgLaporanTransaksi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgLaporanTransaksi;
    }
}
