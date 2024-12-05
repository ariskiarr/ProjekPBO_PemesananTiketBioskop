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
    public partial class V_EditSinopsis : Form
    {
        private M_Film film;
        public string Sinopsis { get; private set; }
        public V_EditSinopsis(M_Film film)
        {
            InitializeComponent();
            this.film = film;

            tbEditSinopsis.Text = film.sinopsis;
        }


        
        private void btsimpanSinopsis_Click(object sender, EventArgs e)
        {
            // Simpan teks sinopsis
            Sinopsis = tbEditSinopsis.Text;

            // Validasi input
            if (string.IsNullOrWhiteSpace(Sinopsis))
            {
                MessageBox.Show("Sinopsis tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tutup form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
