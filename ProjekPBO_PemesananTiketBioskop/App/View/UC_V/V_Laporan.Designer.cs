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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_Laporan));
            dgLaporanTransaksi = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgLaporanTransaksi).BeginInit();
            SuspendLayout();
            // 
            // dgLaporanTransaksi
            // 
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgLaporanTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgLaporanTransaksi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgLaporanTransaksi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgLaporanTransaksi.BackgroundColor = Color.White;
            dgLaporanTransaksi.BorderStyle = BorderStyle.None;
            dgLaporanTransaksi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 18F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgLaporanTransaksi.DefaultCellStyle = dataGridViewCellStyle2;
            dgLaporanTransaksi.GridColor = Color.Black;
            dgLaporanTransaksi.Location = new Point(261, 239);
            dgLaporanTransaksi.Name = "dgLaporanTransaksi";
            dgLaporanTransaksi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgLaporanTransaksi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgLaporanTransaksi.RowHeadersWidth = 80;
            dgLaporanTransaksi.Size = new Size(1255, 709);
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
