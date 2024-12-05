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

namespace ProjekPBO_PemesananTiketBioskop.App.View.UC_V
{
    public partial class V_editProfil : UserControl
    {
        V_Profil halProfil = new V_Profil();
        M_Akun data = userSession.CurrentUser;
        C_Profil profil = new C_Profil();
        public V_editProfil()
        {
            InitializeComponent();
            tbEmailAdmin.Text = data.email;
            tbNomorTeleponAdmin.Text = data.nomor_telepon;
            tbPasswordAmin.Text = data.password;
            tbUsernameAdmin.Text = data.username;


        }

        private void btSimpanProfilAdmin_Click(object sender, EventArgs e)
        {
            // memastikan bahwa nomor telepon adalah angka
            if (!double.TryParse(tbNomorTeleponAdmin.Text, out _))
            {
                MessageBox.Show("Nomor telepon harus berupa angka!", "Perhatian", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Update data user session
            data.nomor_telepon = tbNomorTeleponAdmin.Text;
            data.email = tbEmailAdmin.Text;
            data.password = tbPasswordAmin.Text;
            data.username = tbUsernameAdmin.Text;
            profil.UpdateProfil();

            // Perbarui data di session setelah update
            //userSession.CurrentUser = data;

            MessageBox.Show("Profil berhasil diupdate!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            V_Profil HalProfil = new V_Profil();
            V_HalAdmin.loadUserControl(HalProfil);


        }

        private void btBatalProfilAdmin_Click(object sender, EventArgs e)
        {
            V_Profil HalProfil = new V_Profil();
            V_HalAdmin.loadUserControl(HalProfil);
        }
    }

}
