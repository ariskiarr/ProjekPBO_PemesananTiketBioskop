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
    public partial class V_DaftarFilm : UserControl
    {
        public V_DaftarFilm()
        {
            InitializeComponent();

        }

    

        private void btTambahFilm_Click(object sender, EventArgs e)
        {
            V_tambahFilm halTambahFilm = new V_tambahFilm();
            V_HalAdmin.loadUserControl(halTambahFilm);
        }
    }
}
