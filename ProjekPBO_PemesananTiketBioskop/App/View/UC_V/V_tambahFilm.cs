using core;
using ProjekPBO_PemesananTiketBioskop.App.Context;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using ProjekPBO_PemesananTiketBioskop.App.View.UC_V;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using System;


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
            cbTambahStatus.SelectedIndex = -1;
            cbWaktuTayang.SelectedIndex = -1;
            dtTambahTanggalTayang.Value = DateTime.Now; 
            pbGambarFilm.Image = null; 
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
                return;  
            }

            try
            {
                int batasUmur = int.Parse(tbTambahBatasUmur.Text); 
            }
            catch (FormatException)
            {
                MessageBox.Show("Batas Umur harus berupa angka!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                int durasi = int.Parse(tbTambahDurasi.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Durasi harus berupa angka!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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

            M_DetailFilm dataDetail = new M_DetailFilm();
            int filmId = C_film.addDataFilm(dataFilm);
            dataDetail.film_id = filmId;
 

            if (cbTambahRuangan.SelectedItem != null)
            {
                string selectedValue = cbTambahRuangan.SelectedItem.ToString();
                int id_ruangan = 0;

                // Logika berdasarkan nilai ComboBox yang dipilih
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

                dataDetail.ruangan_id = id_ruangan;
            }
            else
            {
                MessageBox.Show("Silakan pilih ruangan terlebih dahulu.");
            }


            C_detailFilm.addDetailfilm(dataDetail);
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
            using (V_TambahSinopsis formSinopsis = new V_TambahSinopsis(sinopsisFilm)) // Kirim nilai sinopsisFilm ke FormSinopsis
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
