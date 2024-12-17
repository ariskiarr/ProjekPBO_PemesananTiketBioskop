using ProjekPBO_PemesananTiketBioskop.App.Context;
using ProjekPBO_PemesananTiketBioskop.App.Core;
using ProjekPBO_PemesananTiketBioskop.App.Model;
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
    public partial class V_Pembayaran : Form
    {
        private int transaksi_id;
        private int detailfilmID;
        private int filmId;
        private string nomorKursi;
        private int idDetailKursi;
        private int akunId;
        private int selectedMetodeId = 0;
        public V_Pembayaran(int detailfilmID, string nomorKursi, int filmId)
        {
            InitializeComponent();
            this.detailfilmID = detailfilmID;
            this.nomorKursi = nomorKursi;
            this.filmId = filmId;

            btMandiri.Tag = 1;
            btBCA.Tag = 2;
            btBRI.Tag = 3;
            btJATIM.Tag = 4;
            btOVO.Tag = 5;
            btDANA.Tag = 6;

            btMandiri.Click += MetodePembayaran_Click;
            btBCA.Click += MetodePembayaran_Click;
            btBRI.Click += MetodePembayaran_Click;
            btJATIM.Click += MetodePembayaran_Click;
            btOVO.Click += MetodePembayaran_Click;
            btDANA.Click += MetodePembayaran_Click;
            LoadFilmDetail();
        }

        private void MetodePembayaran_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                selectedMetodeId = (int)button.Tag; // Ambil ID dari Tag
              
            }
        }
   
        private void LoadFilmDetail()
        {
            try
            {
                // Ambil data film dan ruangan berdasarkan ID film
                var (film, ruangan, detailfilmId) = C_film.GetDataFilmAndRuangan(filmId);

                if (film != null)
                {
                    // Menampilkan detail film ke elemen UI
                    tbJudulFilm.Text = film.judul_film;
                    tbRuangan.Text = ruangan.nama_ruangan;
                    tbKursi.Text = nomorKursi;
                    tbTotalHarga.Text = $"Rp.{film.harga.ToString("N0")}";
                    tbJumblahUang.Text = "0";
                }
                else
                {
                    MessageBox.Show("Film tidak ditemukan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close(); // Tutup form jika film tidak ditemukan
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data film: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btBayarPembayaran_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi apakah metode pembayaran dipilih
                if (selectedMetodeId == 0)
                {
                    MessageBox.Show("Pilih metode pembayaran terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validasi apakah jumlah uang valid
                decimal jumlahUang;
                if (!decimal.TryParse(tbJumblahUang.Text, out jumlahUang))
                {
                    MessageBox.Show("Jumlah uang yang dimasukkan tidak valid!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Parsing total harga
                decimal totalHarga;
                if (!decimal.TryParse(tbTotalHarga.Text.Replace("Rp.", "").Replace(",", ""), out totalHarga))
                {
                    MessageBox.Show("Total harga tidak valid!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validasi apakah jumlah uang mencukupi
                if (jumlahUang < totalHarga)
                {
                    MessageBox.Show("Jumlah uang tidak cukup!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                this.idDetailKursi = C_KursiPelanggan.PesanKursi(detailfilmID, nomorKursi);

                // Jika semua validasi lolos, lakukan proses pembayaran
                M_Pembayaran pembayaran = new M_Pembayaran
                {
                    akun_id = userSession.CurrentUser.akun_id,
                    MetodeId = selectedMetodeId,
                    TotalHarga = totalHarga,
                    JumlahUang = jumlahUang,
                    Kursi = this.idDetailKursi,
                    waktu_transaksi = DateTime.Now,
                    tanggal_transaksi = DateTime.Now
                };

                // Menambahkan pembayaran ke database
                this.transaksi_id = C_Pembayaran.AddPembayaran(pembayaran);
                // Memberikan notifikasi sukses
                MessageBox.Show($"Pembayaran selesai. Kursi {nomorKursi} berhasil dipesan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigasi ke halaman tiket pelanggan
                this.Hide();
                akunId = userSession.CurrentUser.akun_id;
                V_E_TiketPelanggan HalTiket = new V_E_TiketPelanggan(transaksi_id,akunId);
                HalTiket.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btKembaliPembayaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_PilihKursiPelanggan HalPilihKursi = new V_PilihKursiPelanggan(filmId, detailfilmID);
            HalPilihKursi.Show();
        }
    }
}
