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
    public partial class V_HalAdmin : Form
    {
        public V_HalAdmin()
        {
            V_Profil halProfil = new V_Profil();
            InitializeComponent();
            loadUserControl(halProfil);

        }

        public void loadUserControl(Control control)
        {
            panelMain.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            panelMain.Controls.Add(control);


        }

        private void btProfilAdmin_Click(object sender, EventArgs e)
        {
            V_Profil halProfil = new V_Profil();
            loadUserControl(halProfil);
        }

        private void btFilmAdmin_Click(object sender, EventArgs e)
        {
            V_tambahFilm halTambahFilm = new V_tambahFilm();
            loadUserControl(halTambahFilm);
        }

        private void btLaporanAdmin_Click(object sender, EventArgs e)
        {
            V_Laporan halLaporan = new V_Laporan();
            loadUserControl(halLaporan);
        }

        private void btLogoutAdmin_Click(object sender, EventArgs e)
        {
            DialogResult PopUp = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                 "Konfirmasi Logout",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (PopUp == DialogResult.Yes) 
            {
                Application.Exit(); 
            }
            else if (PopUp == DialogResult.No) 
            {
                return;
            }
        }
    }
    
}
