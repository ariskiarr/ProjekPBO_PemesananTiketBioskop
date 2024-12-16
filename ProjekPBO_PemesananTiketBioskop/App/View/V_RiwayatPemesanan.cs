using ProjekPBO_PemesananTiketBioskop.App.Context;
using ProjekPBO_PemesananTiketBioskop.App.Core;
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
    public partial class V_RiwayatPemesanan : Form
    {
        private int akunId;
        public V_RiwayatPemesanan()
        {
            InitializeComponent();
            akunId = userSession.CurrentUser.akun_id;
            LoadDataFilm();
        }

        private void LoadDataFilm()
        {
            try
            {

                if (!dgvRiwayatPesanan.Columns.Contains("btnLihat"))
                {
                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                    btnEdit.Name = "btnLihat";
                    btnEdit.HeaderText = "Tombol";
                    btnEdit.Text = "Lihat";
                    btnEdit.UseColumnTextForButtonValue = true; // Menampilkan teks tombol di kolom
                    dgvRiwayatPesanan.Columns.Add(btnEdit);
                }

                DataTable dataRiwayat = C_RiwayatPemesanan.getdataRiwayat(akunId);
                dgvRiwayatPesanan.DataSource = dataRiwayat;
                dgvRiwayatPesanan.AllowUserToAddRows = false;
                dgvRiwayatPesanan.RowHeadersVisible = false;
                dgvRiwayatPesanan.Columns["transaksi_id"].HeaderText = "Transaksi ID";
                dgvRiwayatPesanan.Columns["judul_film"].HeaderText = "Judul Film";
                dgvRiwayatPesanan.Columns["nama_ruangan"].HeaderText = "Nama Ruangan";
                dgvRiwayatPesanan.Columns["nomor_kursi"].HeaderText = "Nomor Kursi";
                dgvRiwayatPesanan.Columns["waktu_tayang"].HeaderText = "Waktu Tayang";
                dgvRiwayatPesanan.Columns["Tanggal_tayang"].HeaderText = "Tanggal Tayang";
                dgvRiwayatPesanan.Columns["waktu_transaksi"].HeaderText = "Waktu Transaksi";
                dgvRiwayatPesanan.Columns["tanggal_transaksi"].HeaderText = "Tanggal Transaksi";
                dgvRiwayatPesanan.Columns["metode_pembayaran"].HeaderText = "Metode Pembayaran";
                dgvRiwayatPesanan.Columns["jumlah_pembayaran"].HeaderText = "Jumlah Pembayaran";

                dgvRiwayatPesanan.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold);
                dgvRiwayatPesanan.ColumnHeadersHeight = 50;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data: " + ex.Message);
            }


        }

        private void dgvRiwayatPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && dgvRiwayatPesanan.Columns[e.ColumnIndex].Name == "btnLihat")
            {
                // Ambil transaksi_id dari DataGridView
                int transaksiId = Convert.ToInt32(dgvRiwayatPesanan.Rows[e.RowIndex].Cells["transaksi_id"].Value);

                // Pastikan akunId sudah didefinisikan sebelumnya di form ini
                this.Hide();
                V_E_TiketPelanggan halEtiket = new V_E_TiketPelanggan(transaksiId, akunId); // Memberikan kedua parameter
                halEtiket.Show(); // Pastikan untuk memanggil Show() agar form muncul


            }
        }

        private void btKembaliRIwayat_Click(object sender, EventArgs e)
        {
            V_HalPelanggan halPelanggan = new V_HalPelanggan();
            this.Hide();
            halPelanggan.Show();
        }
    }
}
