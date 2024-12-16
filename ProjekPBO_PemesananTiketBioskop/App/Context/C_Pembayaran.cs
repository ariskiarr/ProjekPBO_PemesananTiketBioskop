using core;
using Npgsql;
using ProjekPBO_PemesananTiketBioskop.App.Core;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using ProjekPBO_PemesananTiketBioskop.App.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_Pembayaran : DatabaseWrapper
    {
        public static DataTable GetNomorKursi()
        {
            string query = @"SELECT kursi_id.idKursi, nomor_kursi.nomorkursi FROM kursi WHERE kursi_id = @kursi ";
            DataTable NomorKursi = queryExecutor(query);
            return NomorKursi;

        }

        public static DataTable getdataTransaksi()
        {
            if (userSession.CurrentUser == null)
            {
                throw new InvalidOperationException("User session is not available. The user must be logged in.");
            }

            string query = @"
        SELECT 
            akun.username,
            film.judul_film,
            ruangan.nama_ruangan,
            transaksi.waktu_transaksi,
            transaksi.tanggal_transaksi,
            kursi.nomor_kursi,
            transaksi.jumlah_pembayaran
        FROM 
            transaksi
        JOIN 
            detail_kursi ON transaksi.detailkursi_id = detail_kursi.detailkursi_id
        JOIN 
            kursi ON detail_kursi.kursi_id = kursi.kursi_id
        JOIN 
            detail_film ON detail_kursi.detailfilm_id = detail_film.detailfilm_id
        JOIN 
            film ON detail_film.film_id = film.film_id
        JOIN 
            ruangan ON detail_film.ruangan_id = ruangan.ruangan_id
        WHERE
            akun_id = @akun_id;
        "
            ;

            DataTable dataFilm = queryExecutor(query);
            return dataFilm;
        }

        public static int AddPembayaran(M_Pembayaran pembayaran)
        {
            try
            {
                string query = @"
                INSERT INTO transaksi 
                    (akun_id, waktu_transaksi, tanggal_transaksi, jumlah_pembayaran, detailkursi_id, metode_id)
                VALUES 
                    (@akun_id, @waktu_transaksi::time, @tanggal_transaksi, @jumlah_pembayaran, @detailkursi_id, @metode_id)
                RETURNING transaksi_id"; // Mengembalikan id_transaksi

                // Menyiapkan parameter untuk query
                var parameters = new NpgsqlParameter[]
                {
            new NpgsqlParameter("@akun_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = pembayaran.akun_id },
            new NpgsqlParameter("@waktu_transaksi", NpgsqlTypes.NpgsqlDbType.Time) { Value = pembayaran.waktu_transaksi.TimeOfDay },  // Menggunakan TimeOfDay untuk hanya mengambil waktu
            new NpgsqlParameter("@tanggal_transaksi", NpgsqlTypes.NpgsqlDbType.Date) { Value = pembayaran.tanggal_transaksi.Date },  // Menggunakan .Date untuk hanya mengambil tanggal
            new NpgsqlParameter("@jumlah_pembayaran", NpgsqlTypes.NpgsqlDbType.Numeric) { Value = pembayaran.JumlahUang },
            new NpgsqlParameter("@detailkursi_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = pembayaran.Kursi },
            new NpgsqlParameter("@metode_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = pembayaran.MetodeId }
                };

                // Eksekusi query dan ambil nilai yang dikembalikan
                DataTable result = queryExecutor(query, parameters);

                // Jika ada hasil, kembalikan transaksi_id
                if (result.Rows.Count > 0)
                {
                    return Convert.ToInt32(result.Rows[0]["transaksi_id"]); // Ambil nilai transaksi_id
                }
                else
                {
                    throw new Exception("Gagal mendapatkan transaksi_id.");
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan error jika terjadi masalah
                MessageBox.Show($"Error saat menyimpan pembayaran: {ex.Message}");
                throw; // Re-throw the exception to be handled at a higher level if needed
            }
        }

    }
}