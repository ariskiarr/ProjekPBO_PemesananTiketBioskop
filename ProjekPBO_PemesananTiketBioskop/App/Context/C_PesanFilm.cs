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
    public class C_PesanFilm
    {
        public static M_Film GetdataFilm(int filmId)
        {
            M_Film dataFilm = new M_Film();
            try
            {
                string query = @"
            SELECT harga, gambar
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
                        dataFilm.harga = (int)Convert.ToDecimal(reader["harga"]);
                        dataFilm.gambar = reader["gambar"] as byte[]; 
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching film details: " + ex.Message);
            }

            return dataFilm;
        }
    }
}
