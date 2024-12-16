using core;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
   
        public class C_KursiPelanggan
        {



        // Method untuk menandai kursi sebagai terpesan berdasarkan id_detail_film dan nomor kursi
        public static int PesanKursi(int idDetailFilm, string nomorKursi)
        {
            try
            {
                string query = @"
        INSERT INTO detail_kursi (kursi_id, detailfilm_id)
        SELECT k.kursi_id, @idDetailFilm
        FROM kursi k
        WHERE k.nomor_kursi = @nomorKursi
        RETURNING detailkursi_id"; // Mengembalikan id_detail_kursi

                var parameters = new NpgsqlParameter[]
                {
            new NpgsqlParameter("@idDetailFilm", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idDetailFilm },
            new NpgsqlParameter("@nomorKursi", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = nomorKursi }
                };

                // Eksekusi query dan ambil nilai yang dikembalikan
                DataTable result = DatabaseWrapper.queryExecutor(query, parameters);

                if (result.Rows.Count > 0)
                {
                    return Convert.ToInt32(result.Rows[0][0]); // Ambil nilai id_detail_kursi
                }
                else
                {
                    throw new Exception("Gagal mendapatkan id_detail_kursi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat menyimpan pemesanan kursi: {ex.Message}");
                throw; // Jangan lupa melempar ulang error jika diperlukan untuk debugging
            }
        }

        public static bool IsKursiTerpesan(int idDetailFilm, string nomorKursi)
        {
            try
            {
                // Pastikan query ini benar dan mengembalikan hasil yang sesuai
                string query = @"
            SELECT COUNT(*)
            FROM detail_kursi dk
            JOIN kursi k ON dk.kursi_id = k.kursi_id
            WHERE dk.detailfilm_id= @idDetailFilm AND k.nomor_kursi = @nomorKursi";

                var parameters = new NpgsqlParameter[]
                {
            new NpgsqlParameter("@idDetailFilm", NpgsqlTypes.NpgsqlDbType.Integer) { Value = idDetailFilm },
            new NpgsqlParameter("@nomorKursi", NpgsqlTypes.NpgsqlDbType.Varchar) { Value = nomorKursi }
                };

                // Cek hasil COUNT
                int count = Convert.ToInt32(DatabaseWrapper.queryExecutor(query, parameters).Rows[0][0]);
                return count > 0; // Jika lebih dari 0 berarti kursi sudah dipesan
            }
            catch (Exception ex)
            {
                // Debugging jika error
                MessageBox.Show($"Error: {ex.Message}");
                return false;
            }
        }


    }
}
 
