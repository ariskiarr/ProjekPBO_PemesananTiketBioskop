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
    internal class C_Register : DatabaseWrapper
    {
        public static bool IsDuplicate(string username, string email)
        {
            int hasil = 0;
            string query = @"
            SELECT COUNT(*)
            FROM akun
            WHERE username = @username OR email = @email";

            NpgsqlParameter[] parameters =
            {

            new NpgsqlParameter("@username", username),
            new NpgsqlParameter("@email", email)

            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))

                if (reader.Read())
                {
                    hasil = Convert.ToInt32(reader["count"]);
                };
            if (hasil > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void AddAkun(M_Akun akun)
        {

            string query = @"INSERT INTO akun (username, password, email, nomor_telepon, role) 
                         VALUES (@username, @password, @email, @nomor_telepon,@role)";

            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@username", akun.username),
            new NpgsqlParameter("@password", akun.password),
            new NpgsqlParameter("@email", akun.email),
            new NpgsqlParameter("@nomor_telepon", akun.nomor_telepon),
            new NpgsqlParameter("@role",akun.role = "pelanggan")
        };

            commandExecutor(query, parameters);
        }
    }
}
