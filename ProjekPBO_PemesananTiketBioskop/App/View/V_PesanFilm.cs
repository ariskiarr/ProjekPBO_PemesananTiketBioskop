using ProjekPBO_PemesananTiketBioskop.App.Context;
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
    public partial class V_PesanFilm : Form
    {
        private int filmId;
        private int detailfilmID;

        public V_PesanFilm(int filmId)
        {
            InitializeComponent();
            this.filmId = filmId;
            LoadFilm(); // Memuat data film dan ruangan saat form diinisialisasi
        }
        public void LoadFilm()
        {
            try
            {
                // Ambil data film dan ruangan berdasarkan ID film
                var (film, ruangan, detailfilmID) = C_film.GetDataFilmAndRuangan(filmId);

                if (film != null)
                {
                    this.detailfilmID = detailfilmID; // Menyimpan detailfilmID yang diterima dari query

                    lbJudulFilmPesan.Text = film.judul_film;
                    lbHargaPesan.Text = $"Rp.{film.harga.ToString("N0")}";

                    // Menampilkan nama ruangan
                    lbruanganPesan.Text = ruangan.nama_ruangan;

                    // Menampilkan gambar film
                    if (film.gambar != null && film.gambar.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(film.gambar))
                        {
                            pbGambarFilmPesan.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pbGambarFilmPesan.Image = null; // Jika gambar tidak ada
                    }

                    lbtanggalTayangPesan.Text = film.tanggalTayang.ToString("dd MMMM yyyy");
                    lbWaktuTayangPesan.Text = film.waktuTayang.ToString(@"hh\:mm");
                    lbBatasUmurPesan.Text = film.batas_umur.ToString();
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
    

        private void btKembaliPesan_Click(object sender, EventArgs e)
        {
            V_DetailFilm HaldetailFilm = new V_DetailFilm(filmId);
            this.Hide();
            HaldetailFilm.Show();

        }

        private void btPilihKursi_Click(object sender, EventArgs e)
        {
            V_PilihKursiPelanggan HalPilihKursi = new V_PilihKursiPelanggan(filmId,detailfilmID);
            this.Hide();
            HalPilihKursi.Show();
        }
    }
}

