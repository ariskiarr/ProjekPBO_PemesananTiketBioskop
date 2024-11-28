﻿using core;
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
using static System.Collections.Specialized.BitVector32;

namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    public partial class V_tambahFilm : UserControl
    {
        private byte[] imageBytes;
        private string sinopsisFilm = "";
        public V_tambahFilm()
        {
            InitializeComponent();

        }
        public bool Validasiinput()
        {
            if (string.IsNullOrWhiteSpace(tbTambahJudul.Text) ||
               string.IsNullOrWhiteSpace(tbTambahDurasi.Text) ||
               string.IsNullOrWhiteSpace(tbTambahAktor.Text) ||
               string.IsNullOrWhiteSpace(tbTambahBatasUmur.Text) ||
               string.IsNullOrWhiteSpace(tbTambahGenre.Text) ||
               string.IsNullOrWhiteSpace(tbTambahHarga.Text) ||
               string.IsNullOrWhiteSpace(tbTambahProduksi.Text) ||
               string.IsNullOrWhiteSpace(tbTambahSutradara.Text) ||
               string.IsNullOrWhiteSpace(cbTambahRuangan.Text) ||
               string.IsNullOrWhiteSpace(cbTambahStatus.Text) ||
               string.IsNullOrWhiteSpace(cbWaktuTayang.Text) ||
               string.IsNullOrWhiteSpace(dtTambahTanggalTayang.Text))

            {
                return false;
            }
            return true;
        }
        private void ClearInput()
        {
            tbTambahJudul.Clear();
            tbTambahDurasi.Clear();
            tbTambahAktor.Clear();
            tbTambahBatasUmur.Clear();
            tbTambahGenre.Clear();
            tbTambahHarga.Clear();
            tbTambahProduksi.Clear();
            tbTambahSutradara.Clear();
            cbTambahRuangan.SelectedIndex = -1; // Reset ComboBox
            cbTambahStatus.SelectedIndex = -1; // Reset ComboBox
            cbWaktuTayang.SelectedIndex = -1; // Reset ComboBox
            dtTambahTanggalTayang.Value = DateTime.Now; // Reset ke tanggal sekarang
            pbGambarFilm.Image = null; // Hapus gambar di PictureBox
            sinopsisFilm = "";
            
        }
        private void V_tambahFilm_Load(object sender, EventArgs e)
        {

        }

        private void btSimpanTambahFilm_Click(object sender, EventArgs e)
        {
            if (!Validasiinput())
            {
                MessageBox.Show("Inputan Tidak Valid! Mohon Cek Data Kembali!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi gambar
            if (pbGambarFilm.Image == null)
            {
                MessageBox.Show("Gambar belum dipilih! Silakan unggah gambar terlebih dahulu.", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Menghentikan proses jika gambar belum dipilih
            }

            try
            {
                int batasUmur = int.Parse(tbTambahBatasUmur.Text); // mencoba mengonversi ke integer
            }
            catch (FormatException) //  jika input bukan angka
            {
                MessageBox.Show("Batas Umur harus berupa angka!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi durasi (harus berupa angka)
            try
            {
                int durasi = int.Parse(tbTambahDurasi.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Durasi harus berupa angka!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi harga (harus berupa angka)
            try
            {
                int harga = int.Parse(tbTambahHarga.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Harga harus berupa angka!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            M_Film dataFilm = new M_Film();

            TimeSpan waktuTayang;
            if (!TimeSpan.TryParseExact(cbWaktuTayang.Text, "hh\\:mm\\:ss",
                System.Globalization.CultureInfo.InvariantCulture,
                out waktuTayang))
            {
                // Jika format waktu tidak valid
                MessageBox.Show("Format waktu tidak valid! Harus dalam format hh:mm:ss", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dataFilm.aktor = tbTambahAktor.Text;
            dataFilm.produksi = tbTambahProduksi.Text;
            dataFilm.batas_umur = int.Parse(tbTambahBatasUmur.Text);
            dataFilm.harga = int.Parse(tbTambahHarga.Text);
            dataFilm.durasi = tbTambahDurasi.Text;
            dataFilm.genre = tbTambahGenre.Text;
            dataFilm.judul_film = tbTambahJudul.Text;
            dataFilm.sutradara = tbTambahSutradara.Text;
            dataFilm.status = cbTambahStatus.Text;
            dataFilm.sinopsis = sinopsisFilm;
            dataFilm.tanggalTayang = dtTambahTanggalTayang.Value;
            dataFilm.waktuTayang = waktuTayang;

            using (MemoryStream ms = new MemoryStream())
            {
                pbGambarFilm.Image.Save(ms, pbGambarFilm.Image.RawFormat);
                dataFilm.gambar = ms.ToArray(); // Konversi ke byte array
            }
           
            C_film.addDataFilm(dataFilm);
            MessageBox.Show("Data Film Berhasil Dibuat !");
            ClearInput();

        }
       
        private void pbGambarFilm_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbGambarFilm.Image = new Bitmap(openFileDialog.FileName);
            }
        }

        private void btTambahSinopsis_Click(object sender, EventArgs e)
        {
            using (V_Sinopsis formSinopsis = new V_Sinopsis(sinopsisFilm)) // Kirim nilai sinopsisFilm ke FormSinopsis
            {
                if (formSinopsis.ShowDialog() == DialogResult.OK)
                {
                    sinopsisFilm = formSinopsis.Sinopsis; // Ambil nilai sinopsis dari form
                    MessageBox.Show("Sinopsis berhasil disimpan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


    }

}
