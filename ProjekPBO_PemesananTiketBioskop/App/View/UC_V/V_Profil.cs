using ProjekPBO_PemesananTiketBioskop.App.Core;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using ProjekPBO_PemesananTiketBioskop.App.View.UC_V;
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
    public partial class V_Profil : UserControl
    {
        public void loadUserControl(Control control)
        {
            this.Controls.Clear();
            control.Dock = DockStyle.Fill;
            this.Controls.Add(control);
            control.BringToFront();
            control.Focus();

        }
        public V_Profil()
        {
            InitializeComponent();
            M_Akun data = userSession.CurrentUser;
            lbEmailAdmin.Text = data.email;
            lbNomorTelp.Text = data.nomor_telepon;
            lbPasswordAdmin.Text = data.password;
            lbUsernameAdmin.Text = data.username;

        }

        private void btEditProfilAdmin_Click(object sender, EventArgs e)
        {
            V_editProfil halEditProfil = new V_editProfil();
            loadUserControl(halEditProfil );
        }
     
    }
}
