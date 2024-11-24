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
    }
}