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
using static ProjekPBO_PemesananTiketBioskop.App.Model.M_Akun;

namespace ProjekPBO_PemesananTiketBioskop.App.View
{
    public partial class V_Register : Form
    {
        public V_Register()
        {
            InitializeComponent();
        }
        private bool ValidateInput()
        {
            return !(
                     string.IsNullOrWhiteSpace(tbEmailRegister.Text) ||
                     string.IsNullOrWhiteSpace(tbNotelpRegister.Text) ||
                     string.IsNullOrWhiteSpace(tbPasswordRegister.Text) ||
                     string.IsNullOrWhiteSpace(tbUsernameRegister.Text));

        }

        private void ClearFields()
        {
            tbEmailRegister.Clear();
            tbNotelpRegister.Clear();
            tbPasswordRegister.Clear();
            tbUsernameRegister.Clear();
        }
        private void btLoginHalRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Login HalLogin = new V_Login();
            HalLogin.Show();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                MessageBox.Show("Isilah seluruh kolom!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            string username = tbUsernameRegister.Text;
            string email = tbEmailRegister.Text;
            string password = tbPasswordRegister.Text;
            string nomor_telepon = tbNotelpRegister.Text;

            if (C_Register.IsDuplicate(username, email))
            {
                MessageBox.Show("Username atau Email sudah digunakan!", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            try
            {
                M_Akun akun = new M_Akun
               {
                    username = username,
                    email = email,
                    password = password,
                    nomor_telepon = nomor_telepon
                };
                

                C_Register.AddAkun(akun);
                MessageBox.Show("Berhasil membuat akun!", "Registrasi berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearFields();
            this.DialogResult = DialogResult.OK;
            V_Login halLogin = new V_Login();
            this.Hide();
            halLogin.Show();
        }
    }
}
