using core;
using Npgsql;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_detailFilm : DatabaseWrapper
    {
        private static string table = "detail_film";
        public static void addDetailfilm(M_DetailFilm dataFilm)
        {

            string query = $"INSERT INTO {table}(ruangan_id, film_id)" +
                           "VALUES(@ruangan_id, @film_id);";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@ruangan_id", dataFilm.ruangan_id),
                new NpgsqlParameter("@film_id", dataFilm.film_id),
            };
            commandExecutor(query, parameters);

        }

        public static void updateDetailFilm(M_DetailFilm dataFilm)
        {
            string query = $"UPDATE {table} " +
                           "SET ruangan_id = @ruangan_id " +
                           "WHERE film_id = @film_id;";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@ruangan_id", dataFilm.ruangan_id),
                new NpgsqlParameter("@film_id", dataFilm.film_id),
            };
            commandExecutor(query, parameters);
        }

        // Method untuk mengambil detail film berdasarkan filmId
        public static M_Film GetFilmDetails(int filmId)
        {
            M_Film filmDetails = new M_Film();
            try
            {
                string query = @"
            SELECT genre, sutradara, aktor, durasi, produksi, gambar, sinopsis, judul_film 
            FROM film 
            WHERE film_id = @filmId";

                NpgsqlParameter[] parameters =
                {
            new NpgsqlParameter("@filmId", filmId)
        };

                using (var reader = DatabaseWrapper.ExecuteReaderCommand(query, parameters))
                {
                    if (reader.Read())
                    {
                        filmDetails.genre = reader["genre"].ToString();
                        filmDetails.sutradara = reader["sutradara"].ToString();
                        filmDetails.aktor = reader["aktor"].ToString();
                        filmDetails.durasi = reader["durasi"].ToString();
                        filmDetails.produksi = reader["produksi"].ToString();
                        filmDetails.sinopsis = reader["sinopsis"].ToString();
                        filmDetails.judul_film = reader["judul_film"].ToString();
                        filmDetails.gambar = reader["gambar"] as byte[]; // Jika gambar ada, simpan dalam byte array
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching film details: " + ex.Message);
            }

            return filmDetails;
        }


    }
}
    

    
