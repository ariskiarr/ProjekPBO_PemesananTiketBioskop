using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using core;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_RiwayatPemesanan : DatabaseWrapper
    {
        public static DataTable getdataEtiket(int transaksi_id, int akunId)
        {
            try
            {
                string query = @"
            SELECT 
                akun.username,
                transaksi.transaksi_id,
                film.judul_film, 
                ruangan.nama_ruangan, 
                kursi.nomor_kursi, 
                transaksi.waktu_transaksi, 
                transaksi.tanggal_transaksi, 
                metode_pembayaran.nama_metode metode_pembayaran, 
                transaksi.jumlah_pembayaran,
                film.waktu_tayang, 
                film.tanggal_tayang
            FROM 
                transaksi
            JOIN 
                akun ON transaksi.akun_id = akun.akun_id 
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
            JOIN 
                metode_pembayaran ON transaksi.metode_id = metode_pembayaran.metode_id
            WHERE 
                transaksi.akun_id = @akun_id
                AND transaksi.transaksi_id = @transaksi_id;
";

                // Menyiapkan parameter
                var parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@transaksi_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = transaksi_id },
                    new NpgsqlParameter("@akun_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = akunId }
                };

                // Menjalankan query dan mengembalikan data
                return queryExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                // Tangani error dengan menampilkan pesan log
                Console.WriteLine($"Error saat mengambil data tiket: {ex.Message}");
                return null;
            }
        }

        public static DataTable getdataRiwayat(int akunId)
        {
            try
            {
                string query = @"
            SELECT 
                transaksi.transaksi_id,
                film.judul_film, 
                ruangan.nama_ruangan, 
                kursi.nomor_kursi,
                film.waktu_tayang,
                film.tanggal_tayang,
                transaksi.waktu_transaksi, 
                transaksi.tanggal_transaksi, 
                metode_pembayaran.nama_metode AS metode_pembayaran, 
                transaksi.jumlah_pembayaran
            FROM 
                transaksi
            JOIN 
                akun ON transaksi.akun_id = akun.akun_id
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
            JOIN 
                metode_pembayaran ON transaksi.metode_id = metode_pembayaran.metode_id
            WHERE 
                transaksi.akun_id = @akun_id;

            	  ";

                // Menyiapkan parameter
                var parameters = new NpgsqlParameter[]
                {
            new NpgsqlParameter("@akun_id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = akunId }
                };

                // Menjalankan query dan mengembalikan data
                return queryExecutor(query, parameters);
            }
            catch (Exception ex)
            {
                // Tangani error dengan menampilkan pesan log
                Console.WriteLine($"Error saat mengambil data tiket: {ex.Message}");
                return null;
            }
        }
    }
}
