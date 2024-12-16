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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(V_DaftarFilm));
            btTambahFilm = new Button();
            dgDaftarFilm = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgDaftarFilm).BeginInit();
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
            // dgDaftarFilm
            // 
            dgDaftarFilm.AllowUserToDeleteRows = false;
            dgDaftarFilm.AllowUserToResizeColumns = false;
            dgDaftarFilm.AllowUserToResizeRows = false;
            dgDaftarFilm.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgDaftarFilm.BackgroundColor = SystemColors.Window;
            dgDaftarFilm.BorderStyle = BorderStyle.None;
            dgDaftarFilm.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 16F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgDaftarFilm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgDaftarFilm.ColumnHeadersHeight = 34;
            dgDaftarFilm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.DarkOrchid;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgDaftarFilm.DefaultCellStyle = dataGridViewCellStyle2;
            dgDaftarFilm.GridColor = SystemColors.WindowText;
            dgDaftarFilm.Location = new Point(97, 209);
            dgDaftarFilm.Name = "dgDaftarFilm";
            dgDaftarFilm.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 11F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.DarkMagenta;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgDaftarFilm.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgDaftarFilm.RowHeadersWidth = 62;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dgDaftarFilm.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgDaftarFilm.Size = new Size(1441, 700);
            dgDaftarFilm.TabIndex = 1;
            dgDaftarFilm.CellContentClick += dgDaftarFilm_CellContentClick;
            // 
            // V_DaftarFilm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(dgDaftarFilm);
            Controls.Add(btTambahFilm);
            Name = "V_DaftarFilm";
            Size = new Size(1618, 1079);
            ((System.ComponentModel.ISupportInitialize)dgDaftarFilm).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btTambahFilm;
        private DataGridView dgDaftarFilm;
    }
}
