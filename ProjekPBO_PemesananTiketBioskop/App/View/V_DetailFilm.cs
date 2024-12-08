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
    public partial class V_DetailFilm : Form
    {
        private int filmId;
        public V_DetailFilm(int filmId)
        {
            InitializeComponent();
            this.filmId = filmId;
            LoadFilmDetail();
        }
        private void LoadFilmDetail()
        {
            M_Film film = C_film.GetFilmById(filmId); // Ambil data film berdasarkan ID

            if (film != null)
            {
                // Menampilkan detail film ke elemen UI
                lbJudulFilmDetail.Text = film.judul_film;
                lbGenre.Text = film.genre;
                lbSutradara.Text = film.sutradara;
                lbProduksi.Text = film.produksi;
                tbAktorDetail.Text = film.aktor;
                lbBatasUmurDetail.Text = $"{film.batas_umur}+";
                lbDurasiDetail.Text = $"{film.durasi} menit";
                tbSinopsisdetail.Text = film.sinopsis ?? "Sinopsis tidak tersedia.";

                // Menampilkan gambar film
                if (film.gambar != null)
                {
                    pbGambarFilmDetail.Image = Image.FromStream(new MemoryStream(film.gambar));
                }
                else
                {
                    pbGambarFilmDetail.Image = null; // Jika gambar tidak ada
                }
            }
            else
            {
                MessageBox.Show("Film tidak ditemukan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Tutup form jika film tidak ditemukan
            }
        }
        private void btLanjutkanDetailFilm_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_PesanFilm formPesanFilm = new V_PesanFilm(filmId);
            formPesanFilm.Show();
            
        }

        private void btKembaliDetail_Click(object sender, EventArgs e)
        {
            this.Close();
            V_HalPelanggan halPelanggan = new V_HalPelanggan();
            halPelanggan.Show();
        }
    }
}
