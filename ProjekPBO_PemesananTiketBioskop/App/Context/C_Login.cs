using core;
using Npgsql;
using ProjekPBO_PemesananTiketBioskop.App.Model;
using ProjekPBO_PemesananTiketBioskop.App.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProjekPBO_PemesananTiketBioskop.App.Model.M_Akun;
using static System.Collections.Specialized.BitVector32;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_Login : DatabaseWrapper
    {
        public static M_Akun Validate(string usernameOremail, string password)
        {
            M_Akun loginAkun = null;
            string query = "SELECT * FROM akun WHERE (username =@UsernameOrEmail or email = @UsernameOrEmail) AND password = @password";

            // Parameter untuk query
            NpgsqlParameter[] parameters =
            {
            new NpgsqlParameter("@UsernameOrEmail", usernameOremail),
            new NpgsqlParameter("@password", password)
            };

            using (NpgsqlDataReader reader = ExecuteReaderCommand(query, parameters))

                if (reader.Read())
                {
                    loginAkun = new M_Akun()
                    {
                        akun_id = (int)reader["akun_id"],
                        role = (string)reader["role"],
                        username = (string)reader["username"],
                        password = (string)reader["password"],
                        email = (string)reader["email"],
                        nomor_telepon = (string)reader["nomor_telepon"] //== DBNull.Value ? null : (string)reader["nomor_telepon"],
                    };
                };
            userSession.CurrentUser = loginAkun;
            return loginAkun;
        }
    }
}
