using ProjekPBO_PemesananTiketBioskop.App.Context;
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
    public partial class V_EditProfilPengguna : Form
    {
        V_ProfilPelanggan HalprofilPengguna = new V_ProfilPelanggan();
        M_Akun data = userSession.CurrentUser;
        C_Profil profil = new C_Profil();
        public V_EditProfilPengguna()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            tbEmailPengguna.Text = data.email;
            tbNomorTelpPengguna.Text = data.nomor_telepon;
            tbPasswordPengguna.Text = data.password;
            tbUsernamePengguna.Text = data.username;
        }

        private void btSimpanEditProfilPengguna_Click(object sender, EventArgs e)
        {
            // memastikan bahwa nomor telepon adalah angka
            if (!double.TryParse(tbNomorTelpPengguna.Text, out _))
            {
                MessageBox.Show("Nomor telepon harus berupa angka!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update data user session
            data.nomor_telepon = tbNomorTelpPengguna.Text;
            data.email = tbEmailPengguna.Text;
            data.password = tbPasswordPengguna.Text;
            data.username = tbUsernamePengguna.Text;
            profil.UpdateProfil();

            // Perbarui data di session setelah update
            userSession.CurrentUser = data;
            
            MessageBox.Show("Profil berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Panggil metode untuk memperbarui tampilan di form profil
            HalprofilPengguna.LoadUserData();
            HalprofilPengguna.Show();
            this.Close();
        }

        private void btKembaliEditProfilPengguna_Click(object sender, EventArgs e)
        {
            this.Close();
            HalprofilPengguna.Show();
        }
    }
}
