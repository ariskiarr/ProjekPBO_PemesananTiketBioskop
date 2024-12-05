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

                DataTable dataFilm = C_film.getdataFilm();
                dgDaftarFilm.DataSource = dataFilm;
                dgDaftarFilm.AllowUserToAddRows = false;
                dgDaftarFilm.RowHeadersVisible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan saat memuat data: " + ex.Message);
            }

            if (!dgDaftarFilm.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.Name = "btnEdit";
                btnEdit.HeaderText = "Edit";
                btnEdit.Text = "Edit";
                btnEdit.UseColumnTextForButtonValue = true; // Menampilkan teks tombol di kolom
                dgDaftarFilm.Columns.Add(btnEdit);
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
                // Ambil film_id dari DataGridView
                int filmId = Convert.ToInt32(dgDaftarFilm.Rows[e.RowIndex].Cells["film_id"].Value);

                //Buat instance v_editFilm dengan parameter filmId
                V_EditFilm halEditFilm = new V_EditFilm(filmId);

                // Panggil metode loadUserControl di v_halAdmin
                V_HalAdmin.loadUserControl(halEditFilm);
            }
        }
    }
}
