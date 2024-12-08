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
        public V_PesanFilm(int filmId)
        {
            InitializeComponent();
            this.filmId = filmId;
            LoadFilm();

        }
        public void LoadFilm()
        {
            M_Film film = C_PesanFilm.GetdataFilm(filmId); // Ambil data film berdasarkan ID

            if (film != null)
            {
                // Menampilkan detail film ke elemen UI
                lbHargaPesan.Text = $"Rp.{film.harga.ToString()}";
                // Menampilkan gambar film
                if (film.gambar != null)
                {
                    pbGambarFilmPesan.Image = Image.FromStream(new MemoryStream(film.gambar));
                }
                else
                {
                    pbGambarFilmPesan.Image = null; // Jika gambar tidak ada
                }
            }
            else
            {
                MessageBox.Show("Film tidak ditemukan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close(); // Tutup form jika film tidak ditemukan
            };
        }
        private void btKembaliPesan_Click(object sender, EventArgs e)
        {
            V_DetailFilm formDetailFilm = new V_DetailFilm(filmId);
            formDetailFilm.Show();
            this.Hide();

        }

        private void btPilihKursi_Click(object sender, EventArgs e)
        {
            if (cbPilihRuanganFIlm.SelectedIndex == -1) // -1 berarti belum ada yang dipilih
            {
                MessageBox.Show("Silakan pilih ruangan terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Hentikan eksekusi jika belum memilih ruangan
            }

            // Melanjutkan ke pemilihan kursi jika ruangan sudah dipilih
            this.Hide();
            V_PilihKursiPelanggan FormPilihKursi = new V_PilihKursiPelanggan(filmId);
            FormPilihKursi.Show();
        }

        private void btLanjutPesan_Click(object sender, EventArgs e)
        {

        }
    }
}

