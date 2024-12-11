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
    public partial class V_PilihKursiPelanggan : Form
    {
        private Button lastSelectedButton = null;  // Menyimpan referensi tombol yang terakhir dipilih
        private int filmId;
        private int detailfilmID;
        public V_PilihKursiPelanggan(int filmId, int detailfilmID)
        {
            InitializeComponent();
            this.filmId = filmId;
            this.detailfilmID = detailfilmID;
            LoadKursi();
        }

        private void LoadKursi()
        {
            try
            {
                List<string> nomorKursi = new List<string>();
                char[] rows = { 'A', 'B', 'C', 'D', 'E' }; // Baris A, B, C, D, E
                for (int i = 0; i < rows.Length; i++)
                {
                    for (int j = 1; j <= 6; j++)
                    {
                        nomorKursi.Add($"{rows[i]}{j}");
                    }
                }

                for (int i = 0; i < nomorKursi.Count; i++)
                {
                    var tombol = this.Controls.Find($"btKursi{i + 1}", true);
                    if (tombol.Length > 0 && tombol[0] is Button button)
                    {
                        button.Text = nomorKursi[i];

                        // Cek apakah kursi sudah terpesan
                        if (C_KursiPelanggan.IsKursiTerpesan(detailfilmID, nomorKursi[i]))
                        {
                            button.BackColor = Color.Red; // Tandai kursi yang sudah terpesan
                            button.Enabled = false; // Nonaktifkan tombol kursi yang sudah terpesan
                        }
                        else
                        {
                            button.BackColor = SystemColors.Control; // Kembalikan warna default
                            button.Enabled = true; // Aktifkan tombol untuk kursi yang belum terpesan
                        }

                        button.Click += Kursi_Click; // Tambahkan event handler
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }





        // Event handler ketika kursi dipilih
        private void Kursi_Click(object sender, EventArgs e)
        {
            Button tombol = sender as Button;
            if (tombol != null)
            {
                // Jika kursi yang dipilih sudah terpesan, tampilkan pesan dan hentikan
                if (C_KursiPelanggan.IsKursiTerpesan(detailfilmID, tombol.Text))
                {
                    MessageBox.Show("Kursi ini telah dipesan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return; // Menghentikan pemilihan jika kursi sudah terpesan
                }

                // Jika kursi belum terpesan, lanjutkan pemilihan kursi
                if (lastSelectedButton != null && lastSelectedButton != tombol)
                {
                    lastSelectedButton.BackColor = SystemColors.Control; // Reset warna tombol sebelumnya
                }

                tombol.BackColor = Color.Red; // Tandai kursi yang dipilih dengan warna merah
                lastSelectedButton = tombol; // Simpan tombol yang dipilih
            }
        }

        private void PesanKursi()
        {
            if (lastSelectedButton != null)
            {
                string nomorKursi = lastSelectedButton.Text;

                // Panggil fungsi untuk memesan kursi
                C_KursiPelanggan.PesanKursi(detailfilmID, nomorKursi);

                // Update tampilan tombol
                lastSelectedButton.BackColor = Color.Red; // Tandai kursi yang sudah terpesan
                lastSelectedButton.Enabled = false; // Nonaktifkan tombol kursi yang sudah terpesan

                MessageBox.Show($"Kursi {nomorKursi} berhasil dipesan.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Silakan pilih kursi terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        private void btBayarKursi_Click(object sender, EventArgs e)
        {
            //PesanKursi(); ini kalau sudah bayar aja yah hil ini aku cuman contoh kalau kursinya dah di pesan 
        }

        private void btKembaliPilihKursi_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_PesanFilm HalPesanFilm = new V_PesanFilm(filmId);
            HalPesanFilm.Show();
        }
    }
}
