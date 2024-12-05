using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    public partial class V_TambahSinopsis : Form
    {
        public string Sinopsis { get; private set; }
       
        public V_TambahSinopsis(string Sinopsis)
        {
            InitializeComponent();
            tbSinopsis.Text = Sinopsis;

        }

        private void btsimpanSinopsis_Click(object sender, EventArgs e)
        {
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
