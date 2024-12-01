using core;
using Npgsql;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_film : DatabaseWrapper
    {
        private static string table = "film";

        public static DataTable All()
        {
            string query = @"
            SELECT *
            FROM film";


            DataTable datamahasiswa = queryExecutor(query);


            return datamahasiswa;
        }
        public static int addDataFilm(M_Film dataFilm)
        {
            string query = $"INSERT INTO {table}(judul_film, genre, sutradara, produksi, aktor, batas_umur, durasi, sinopsis, harga, gambar, status, waktu_tayang, tanggal_tayang) " +
                           "VALUES(@judul_film, @genre, @sutradara, @produksi, @aktor, @batas_umur, @durasi, @sinopsis, @harga, @gambar, @status, @waktuTayang, @tanggalTayang) " +
                           "RETURNING film_id;"; // Menambahkan RETURNING untuk mengambil ID film yang baru

            // Menyiapkan parameter untuk query
            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul_film", dataFilm.judul_film),
                new NpgsqlParameter("@genre", dataFilm.genre),
                new NpgsqlParameter("@sutradara", dataFilm.sutradara),
                new NpgsqlParameter("@produksi", dataFilm.produksi),
                new NpgsqlParameter("@aktor", dataFilm.aktor),
                new NpgsqlParameter("@batas_umur", dataFilm.batas_umur),
                new NpgsqlParameter("@durasi", dataFilm.durasi),
                new NpgsqlParameter("@sinopsis", string.IsNullOrWhiteSpace(dataFilm.sinopsis) ? (object)DBNull.Value : dataFilm.sinopsis),
                new NpgsqlParameter("@harga", dataFilm.harga),
                new NpgsqlParameter("@gambar", dataFilm.gambar),
                new NpgsqlParameter("@status", dataFilm.status),
                new NpgsqlParameter("@waktuTayang", dataFilm.waktuTayang),
                new NpgsqlParameter("@tanggalTayang", dataFilm.tanggalTayang)
    };

            // Menjalankan query dan mendapatkan ID film yang baru dimasukkan
            var result = ExecuteScalarCommand(query, parameters);

            // Memastikan bahwa hasil yang didapat bisa dikonversi menjadi int
            if (result != null && int.TryParse(result.ToString(), out int filmId))
            {
                return filmId;  // Mengembalikan ID film yang baru
            }

            // Jika tidak berhasil mendapatkan ID, kembalikan nilai default
            return 0;
        }
        public static void UpdateFilm(M_Film dataFilm)
        {

            string query = $"UPDATE {table} SET judul_film = @judul_film, genre= @genre, sutradara = @sutradara, produksi = @produksi,aktor=@aktor,batas_umur=@batas_umur, durasi=@durasi,sinopsis=@sinopsis,harga=@harga,gambar=@gambar,status=@status,film_id = @film_id WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@judul_film", dataFilm.judul_film),
                new NpgsqlParameter("@genre", dataFilm.genre),
                new NpgsqlParameter("@sutradara", dataFilm.sutradara),
                new NpgsqlParameter("@produksi", dataFilm.produksi),
                new NpgsqlParameter("@aktor", dataFilm.aktor),
                new NpgsqlParameter("@batas_umur", dataFilm.batas_umur),
                new NpgsqlParameter("@durasi", dataFilm.durasi),
                new NpgsqlParameter("@sinopsis", dataFilm.sinopsis),
                new NpgsqlParameter("@harga", dataFilm.harga),
                new NpgsqlParameter("@gambar", dataFilm.gambar),
                new NpgsqlParameter("@status", dataFilm.status),
                new NpgsqlParameter("@waktuTayang",dataFilm.waktuTayang),
                new NpgsqlParameter("@tanggalTayang",dataFilm.tanggalTayang)
            };

            commandExecutor(query, parameters);
        }
        public static DataTable getdataFilm(int film_id)
        {
            string query = @"
                SELECT  
                    film_id,judul_film, genre, sutradara, produksi, aktor, batas_umur, durasi, sinopsis, harga, gambar, status
                FROM 
                    film
                WHERE 
                    film_id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = film_id }
            };
            DataTable dataFilm = queryExecutor(query, parameters);
            return dataFilm;
        }

       
    }
}
