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

namespace ProjekPBO_PemesananTiketBioskop.App.View.UC_V
{
    public partial class V_DaftarFilm : UserControl
    {
        public V_DaftarFilm()
        {
            InitializeComponent();
            LoadDataFilm();

        }


        private void LoadDataFilm()
        {
            try
            {

                if (!dgDaftarFilm.Columns.Contains("btnEdit"))
                {
                    DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                    btnEdit.Name = "btnEdit";
                    btnEdit.HeaderText = "Edit";
                    btnEdit.Text = "Edit";
                    btnEdit.UseColumnTextForButtonValue = true; // Menampilkan teks tombol di kolom
                    dgDaftarFilm.Columns.Add(btnEdit);
                }

                DataTable dataFilm = C_film.getdataFilm();
                dgDaftarFilm.DataSource = dataFilm;
                dgDaftarFilm.AllowUserToAddRows = false;
                dgDaftarFilm.RowHeadersVisible = false;
                dgDaftarFilm.Columns["film_id"].HeaderText = "ID Film";
                dgDaftarFilm.Columns["judul_film"].HeaderText = "Judul Film";
                dgDaftarFilm.Columns["genre"].HeaderText = "Genre";
                dgDaftarFilm.Columns["sutradara"].HeaderText = "Sutradara";
                dgDaftarFilm.Columns["produksi"].HeaderText = "Produksi";
                dgDaftarFilm.Columns["aktor"].HeaderText = "Aktor/Aktris";
                dgDaftarFilm.Columns["batas_umur"].HeaderText = "Batas Umur";
                dgDaftarFilm.Columns["durasi"].HeaderText = "Durasi (menit)";
                dgDaftarFilm.Columns["sinopsis"].HeaderText = "Sinopsis";
                dgDaftarFilm.Columns["waktu_tayang"].HeaderText = "Waktu Tayang";
                dgDaftarFilm.Columns["tanggal_tayang"].HeaderText = "Tanggal Tayang";
                dgDaftarFilm.Columns["harga"].HeaderText = "Harga";
                dgDaftarFilm.Columns["status"].HeaderText = "Status Film";
                dgDaftarFilm.Columns["nama_ruangan"].HeaderText = "Nama Ruangan";
                dgDaftarFilm.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 14, FontStyle.Bold); 
                dgDaftarFilm.ColumnHeadersHeight = 50; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data: " + ex.Message);
            }

            
        }

        private void btTambahFilm_Click(object sender, EventArgs e)
        {
            V_tambahFilm halTambahFilm = new V_tambahFilm();
            V_HalAdmin.loadUserControl(halTambahFilm);

        }


        private void dgDaftarFilm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgDaftarFilm.Columns[e.ColumnIndex].Name == "btnEdit")
            {
                int filmId = Convert.ToInt32(dgDaftarFilm.Rows[e.RowIndex].Cells["film_id"].Value);
                V_EditFilm halEditFilm = new V_EditFilm(filmId);
                V_HalAdmin.loadUserControl(halEditFilm);
            }
        }
    }
}
