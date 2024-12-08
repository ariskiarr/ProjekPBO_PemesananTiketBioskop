using ProjekPBO_PemesananTiketBioskop.App.Core;
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
    public partial class V_ProfilPelanggan : Form
    {
        M_Akun data = userSession.CurrentUser;
        public V_ProfilPelanggan()
        {

            InitializeComponent();
            LoadUserData(); 

        }

        private void btEditProdilPengguna_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_EditProfilPengguna halEditProfilPelanggan = new V_EditProfilPengguna();
            halEditProfilPelanggan.Show();
        }

        public void LoadUserData()
        {
            lbEmailPengguna.Text = data.email;
            lbNomorTeleponPengguna.Text = data.nomor_telepon;
            lbPasswordPengguna.Text = data.password;
            lbUsernamePengguna.Text = data.username;
        }

        private void btKembaliProfilPengguna_Click(object sender, EventArgs e)
        {
            this.Close();
            V_HalPelanggan halPelanggan = new V_HalPelanggan();
            halPelanggan.Show();
        }
    }
}
