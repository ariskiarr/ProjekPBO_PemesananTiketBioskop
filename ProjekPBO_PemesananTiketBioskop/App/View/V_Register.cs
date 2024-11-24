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
    public partial class V_Register : Form
    {
        public V_Register()
        {
            InitializeComponent();
        }

        private void btLoginHalRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_Login HalLogin = new V_Login();
            HalLogin.Show();
        }
    }
}
