using ProjekPBO_PemesananTiketBioskop.App.Context;
using ProjekPBO_PemesananTiketBioskop.App.View.UC_V;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    public partial class V_Laporan : UserControl
    {
        public V_Laporan()
        {
            InitializeComponent();
            LoadDataTransaksi();
        }

        public void LoadDataTransaksi()
        {
            DataTable dataTransaksi = C_LaporanAdmin.getdataTransaksi();
            dgLaporanTransaksi.DataSource = dataTransaksi;
            dgLaporanTransaksi.AllowUserToAddRows = false;
            dgLaporanTransaksi.RowHeadersVisible = false;
         

        }
        private void dgLaporanTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
