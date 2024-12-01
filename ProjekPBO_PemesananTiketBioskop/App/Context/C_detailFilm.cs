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

    }
}
    
