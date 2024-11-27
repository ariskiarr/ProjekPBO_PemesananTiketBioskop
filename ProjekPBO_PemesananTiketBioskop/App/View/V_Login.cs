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
    public partial class V_Login : Form
    {
        public V_Login()
        {
            InitializeComponent();
        }

        private void btRegisterHalLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Register HalRegister = new V_Register();
            HalRegister.Show();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string usernameOrEmail = tbEmailUsernameLogin.Text;
            string password = tbPasswordLogin.Text;
            M_Akun data = new M_Akun();

            if (string.IsNullOrEmpty(usernameOrEmail) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username/Email dan Password mohon diisi!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            data = C_Login.Validate(usernameOrEmail, password);


            if (data == null)
            {
                MessageBox.Show("Username/Email atau Password salah!", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (data.role == "admin")
            {
                V_HalAdmin halAdmin = new V_HalAdmin();
                this.Hide();
                halAdmin.Show();
            }
            else if (data.role == "pelanggan")
            {
                V_HalPelanggan halPelanggan= new V_HalPelanggan();
                this.Hide();
                halPelanggan.ShowDialog();
            }
        }
    }
}