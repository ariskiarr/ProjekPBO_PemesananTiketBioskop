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
        private int filmId;
        public V_PilihKursiPelanggan(int filmId)
        {
            InitializeComponent();
            this.filmId = filmId;

        }

        private void btKembaliPilihKursi_Click(object sender, EventArgs e)
        {
            V_PesanFilm halPesan = new V_PesanFilm(filmId);  // Mengirim filmId ke konstruktor V_PesanFilm
            halPesan.Show(); // Menampilkan form V_PesanFilm
            halPesan.LoadFilm();  // Memanggil LoadFilm untuk memuat ulang data film setelah form muncul
            this.Hide();  // Menyembunyikan form V_PilihKursiPelanggan



        }
    }
}
