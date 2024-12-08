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
    public partial class V_HalPelanggan : Form
    {
        private FlowLayoutPanel panelFilm;
        private ComboBox filterComboBox;
        public V_HalPelanggan()
        {
            InitializeComponent();
            InitializePanelFilm();
            InitializeFilterComboBox();
            LoadFilmItems(); // Memuat semua film secara default
            this.Resize += (s, e) => panelFilm.Invalidate(); // Refresh layout saat form di-resize
        }

        private void InitializePanelFilm()
        {
            panelFilm = new FlowLayoutPanel
            {
                AutoScroll = true,
                Location = new Point(137, 333),
                Size = new Size(1672, 708),
                BorderStyle = BorderStyle.None,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                Padding = new Padding(10),
                BackColor = Color.Transparent,
            };
            this.Controls.Add(panelFilm);
        }

        private void InitializeFilterComboBox()
        {
            filterComboBox = new ComboBox
            {

                Location = new Point(1569, 95),
                Height = 40,
                Width = 220,
                Font = new Font("Segoe UI", 14),
                BackColor = Color.MidnightBlue,
                ForeColor = Color.White,
                DropDownStyle = ComboBoxStyle.DropDownList,


            };

            filterComboBox.Items.AddRange(new string[] { "Semua Usia", "Usia 13+", "Usia 17+" });
            filterComboBox.SelectedIndex = 0; // Default ke "Semua Usia"
            filterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;

            this.Controls.Add(filterComboBox);
        }

        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = filterComboBox.SelectedItem.ToString();
            if (selectedFilter == "Usia 13+")
                LoadFilmItems("13+");
            else if (selectedFilter == "Usia 17+")
                LoadFilmItems("17+");
            else
                LoadFilmItems();
        }

        private void LoadFilmItems(string filterUsia = "all")
        {
            panelFilm.Controls.Clear(); // Bersihkan panel sebelum menambahkan film

            // Panggil metode statis dari C_Film
            List<M_Film> filmList = C_film.GetFilmsByFilter(filterUsia);

            foreach (var film in filmList)
            {
                Panel filmItem = new Panel
                {
                    Size = new Size(312, 550),
                    BackColor = Color.White,
                    BorderStyle = BorderStyle.None,
                    Margin = new Padding(20),
                };

                // Gambar film
                PictureBox pictureBox = new PictureBox
                {
                    Image = film.gambar != null ? Image.FromStream(new MemoryStream(film.gambar)) : Properties.Resources.imgapp,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Dock = DockStyle.Fill,
                    Height = 400,


                };

                // Label judul film
                Label lblJudulFilm = new Label
                {
                    Text = film.judul_film,
                    Dock = DockStyle.Top,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    BackColor = Color.MintCream,
                    Height = 40

                };

                // Tombol pilih
                Button btnPilih = new Button
                {
                    Text = "Pilih",
                    Dock = DockStyle.Bottom,
                    BackColor = ColorTranslator.FromHtml("#4CAF50"),
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat,
                    Height = 40,
                };

                btnPilih.Click += (s, e) =>
                {
                    V_DetailFilm formDetailFilm = new V_DetailFilm(film.film_id);
                    formDetailFilm.Show();
                    this.Hide();
                };

                // Tambahkan kontrol ke panel item film
                filmItem.Controls.Add(pictureBox);
                filmItem.Controls.Add(lblJudulFilm);
                filmItem.Controls.Add(btnPilih);

                // Tambahkan item film ke panel utama
                panelFilm.Controls.Add(filmItem);
            }
        }

        private void btRiwayatPelanggan_Click(object sender, EventArgs e)
        {

        }

        private void btLogoutPelanggan_Click(object sender, EventArgs e)
        {
            DialogResult PopUp = MessageBox.Show("Apakah Anda yakin ingin logout?",
                                                 "Konfirmasi Logout",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

            if (PopUp == DialogResult.Yes)
            {
                this.Close();
                V_Login halLogin = new V_Login();
                halLogin.Show();
            }
            else if (PopUp == DialogResult.No)
            {
                return;
            }


        }

        private void btProfilPelanggan_Click(object sender, EventArgs e)
        {
            this.Hide();
            V_ProfilPelanggan halProfil = new V_ProfilPelanggan();
            halProfil.Show();
        }
    }
}
