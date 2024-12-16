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

            dgLaporanTransaksi.Columns["username"].HeaderText = "Username";
            dgLaporanTransaksi.Columns["judul_film"].HeaderText = "Judul Film";
            dgLaporanTransaksi.Columns["nama_ruangan"].HeaderText = "Nama Ruangan";
            dgLaporanTransaksi.Columns["waktu_transaksi"].HeaderText = "Waktu Transaksi";
            dgLaporanTransaksi.Columns["tanggal_transaksi"].HeaderText = "Tanggal Transaksi";
            dgLaporanTransaksi.Columns["metode_pembayaran"].HeaderText = "Metode Pembayaran";
            dgLaporanTransaksi.Columns["nomor_kursi"].HeaderText = "Nomor Kursi";
            dgLaporanTransaksi.Columns["jumlah_pembayaran"].HeaderText = "Jumlah Pembayaran";


            dgLaporanTransaksi.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold); 
            dgLaporanTransaksi.ColumnHeadersHeight = 50;


        }
        private void dgLaporanTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
