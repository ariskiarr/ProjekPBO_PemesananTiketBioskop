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

namespace ProjekPBO_PemesananTiketBioskop.App.View.UC_V
{
    public partial class V_EditFilm : UserControl
    {
        private int filmId;
        private M_Film film;


        public V_EditFilm(int filmId)
        {
            InitializeComponent();
            this.filmId = filmId;

            // Panggil metode untuk memuat data film berdasarkan ID
            LoadFilmById();
        }
        private void LoadFilmById()
        {
            film = C_film.GetFilmById(filmId); // Memanggil metode yang mengembalikan objek M_Film, bukan DataTable

            if (film != null)
            {
                // Menyusun data ke dalam kontrol form
                tbEditJudul.Text = film.judul_film;
                tbEditGenre.Text = film.genre;
                tbEditSutradara.Text = film.sutradara;
                tbEditProduksi.Text = film.produksi;
                tbEditAktor.Text = film.aktor;
                tbEditBatasUmur.Text = film.batas_umur.ToString();
                tbEditDurasi.Text = film.durasi;
                tbEditHarga.Text = film.harga.ToString();
                cbEditStatus.Text = film.status;
                dtEditTanggalTayang.Value = film.tanggalTayang;
                cbEditWaktuTayang.Text = film.waktuTayang.ToString(@"hh\:mm\:ss");



                // Menangani gambar
                if (film.gambar != null)
                {
                    using (MemoryStream ms = new MemoryStream(film.gambar))
                    {
                        pbGambarEditFilm.Image = Image.FromStream(ms);
                    }
                }
            }
            else
            {
                MessageBox.Show("Film tidak ditemukan.");
            }
        }

        private void btBatalEdit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah Anda yakin ingin Membatalkan Perubahan ",
                                          "Konfirmasi",
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                V_DaftarFilm halDaftarFilm = new V_DaftarFilm();
                V_HalAdmin.loadUserControl(halDaftarFilm);
            }
            else
            {
               
            }

        }

        private void btEditSinopsis_Click(object sender, EventArgs e)
        {
            V_EditSinopsis formSinopsis = new V_EditSinopsis(film);
            if (formSinopsis.ShowDialog() == DialogResult.OK)
            {
                // Setelah form sinopsis ditutup dengan hasil OK, perbarui sinopsis di film
                film.sinopsis = formSinopsis.Sinopsis; // Dapatkan sinopsis yang telah diedit
                MessageBox.Show("Sinopsis berhasil DiUbah!", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        public bool Validasiinput()
        {
            if (string.IsNullOrWhiteSpace(tbEditJudul.Text) ||
               string.IsNullOrWhiteSpace(tbEditDurasi.Text) ||
               string.IsNullOrWhiteSpace(tbEditAktor.Text) ||
               string.IsNullOrWhiteSpace(tbEditBatasUmur.Text) ||
               string.IsNullOrWhiteSpace(tbEditGenre.Text) ||
               string.IsNullOrWhiteSpace(tbEditHarga.Text) ||
               string.IsNullOrWhiteSpace(tbEditProduksi.Text) ||
               string.IsNullOrWhiteSpace(tbEditSutradara.Text) ||
               string.IsNullOrWhiteSpace(cbEditRuangan.Text) ||
               string.IsNullOrWhiteSpace(cbEditStatus.Text) ||
               string.IsNullOrWhiteSpace(cbEditWaktuTayang.Text) ||
               string.IsNullOrWhiteSpace(dtEditTanggalTayang.Text))

            {
                return false;
            }
            return true;
        }

        private void btSimpanEdit_Click(object sender, EventArgs e)
        {
            if (!Validasiinput())
            {
                MessageBox.Show("Inputan Tidak Valid! Mohon Cek Data Kembali!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi gambar
            if (pbGambarEditFilm.Image == null)
            {
                MessageBox.Show("Gambar belum dipilih! Silakan unggah gambar terlebih dahulu.", "peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;  // Menghentikan proses jika gambar belum dipilih
            }

            try
            {
                int batasUmur = int.Parse(tbEditBatasUmur.Text); // mencoba mengonversi ke integer
            }
            catch (FormatException) //  jika input bukan angka
            {
                MessageBox.Show("Batas Umur harus berupa angka!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi durasi (harus berupa angka)
            try
            {
                int durasi = int.Parse(tbEditDurasi.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Durasi harus berupa angka!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi harga (harus berupa angka)
            try
            {
                int harga = int.Parse(tbEditHarga.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Harga harus berupa angka!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            M_Film dataFilm = new M_Film();


            TimeSpan waktuTayang;
            if (!TimeSpan.TryParseExact(cbEditWaktuTayang.Text, "hh\\:mm\\:ss",
                System.Globalization.CultureInfo.InvariantCulture,
                out waktuTayang))
            {
                // Jika format waktu tidak valid
                MessageBox.Show("Format waktu tidak valid! Harus dalam format hh:mm:ss", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dataFilm.film_id = filmId; 
            dataFilm.aktor = tbEditAktor.Text;
            dataFilm.produksi = tbEditProduksi.Text;
            dataFilm.batas_umur = int.Parse(tbEditBatasUmur.Text);
            dataFilm.harga = int.Parse(tbEditHarga.Text);
            dataFilm.durasi = tbEditDurasi.Text;
            dataFilm.genre = tbEditGenre.Text;
            dataFilm.judul_film = tbEditJudul.Text;
            dataFilm.sutradara = tbEditSutradara.Text;
            dataFilm.status = cbEditStatus.Text;
            dataFilm.sinopsis = film.sinopsis;
            dataFilm.tanggalTayang = dtEditTanggalTayang.Value;
            dataFilm.waktuTayang = waktuTayang;

            using (MemoryStream ms = new MemoryStream())
            {
                pbGambarEditFilm.Image.Save(ms, pbGambarEditFilm.Image.RawFormat);
                dataFilm.gambar = ms.ToArray(); // Konversi ke byte array
            }

  
            C_film.UpdateFilm(dataFilm);

            M_DetailFilm dataDetail = new M_DetailFilm
            {
                film_id = filmId,
            };

           
             string selectedValue = cbEditRuangan.SelectedItem.ToString();
             int id_ruangan = 0;

             // Menentukan ID ruangan berdasarkan pilihan ComboBox
             if (selectedValue == "Ruangan A")
             {
                 id_ruangan = 1;
             }
             else if (selectedValue == "Ruangan B")
             {
                 id_ruangan = 2;
             }
             else if (selectedValue == "Ruangan C")
             {
                 id_ruangan = 3;
             }

             // Menambahkan id_ruangan ke dataDetail
             dataDetail.ruangan_id = id_ruangan;

             // Panggil metode untuk memperbarui detail film
             C_detailFilm.updateDetailFilm(dataDetail);
            
         
        
            MessageBox.Show("Data Film Berhasil Diedit", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            V_HalAdmin.loadUserControl(new V_DaftarFilm());


        }
    

        private void pbGambarEditFilm_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbGambarEditFilm.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}

