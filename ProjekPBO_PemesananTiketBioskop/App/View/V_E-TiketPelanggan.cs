using ProjekPBO_PemesananTiketBioskop.App.Context;
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
    public partial class V_E_TiketPelanggan : Form
    {
        private int akunId;
        private int transaksi_id;
        public V_E_TiketPelanggan(int transaksi_id, int akunId)
        {
            InitializeComponent();
            this.transaksi_id = transaksi_id;
            this.akunId = akunId;
            LoadTicketData();
        }
        private void LoadTicketData()
        {
            try
            {
                DataTable dataTiket = C_RiwayatPemesanan.getdataEtiket(transaksi_id, akunId);
                DataRow row = dataTiket.Rows[0];  // Misalnya, hanya menampilkan tiket pertama
                lbUsernameEtiket.Text = $"Username : {row["username"].ToString()}";
                tbJudulFilmETiket.Text = row["judul_film"].ToString();
                tbRuanganETiket.Text = row["nama_ruangan"].ToString();
                tbKursiETiket.Text = row["nomor_kursi"]?.ToString();

                DateTime waktuTayang;
                if (DateTime.TryParse(row["waktu_tayang"].ToString(), out waktuTayang))
                    tbWaktuTayang.Text = waktuTayang.ToString("HH:mm");
                else
                    tbWaktuTayang.Text = "Data tidak tersedia";

                DateTime tanggalTayang;
                if (DateTime.TryParse(row["tanggal_tayang"].ToString(), out tanggalTayang))
                    tbTanggalTayang.Text = tanggalTayang.ToString("dd-MM-yyyy");
                else
                    tbTanggalTayang.Text = "Data tidak tersedia";

                DateTime tanggalPembayaran;
                if (DateTime.TryParse(row["tanggal_transaksi"].ToString(), out tanggalPembayaran))
                    lbTanggalPembayaran.Text = tanggalPembayaran.ToString("dd-MM-yyyy ");
                else
                    lbTanggalPembayaran.Text = "Data tidak tersedia";

                DateTime waktuTransaksi;
                if (DateTime.TryParse(row["waktu_transaksi"].ToString(), out waktuTransaksi))
                    lbwaktuPembayaran.Text = waktuTransaksi.ToString("HH:mm:ss");
                else
                    lbwaktuPembayaran.Text = "Data tidak tersedia";

                tbMetodePembayaran.Text = row["metode_pembayaran"]?.ToString() ?? "Data tidak tersedia";
                tbTotalPembayaran.Text = row["jumlah_pembayaran"]?.ToString() ?? "Data tidak tersedia";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btKembaliEtiket_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_HalPelanggan halPelanggan = new V_HalPelanggan();
            halPelanggan.Show();
        }
    }


}
