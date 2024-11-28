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
    public partial class V_Sinopsis : Form
    {
        public string Sinopsis { get; private set; }
        public V_Sinopsis(string existingSinopsis = "")
        {
            InitializeComponent();
            tbSinopsis.Text = existingSinopsis;
        }

        
        private void btsimpanSinopsis_Click(object sender, EventArgs e)
        {
            // Simpan teks sinopsis
            Sinopsis = tbSinopsis.Text.Trim();

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
