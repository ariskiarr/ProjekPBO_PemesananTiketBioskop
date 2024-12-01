using core;
using Npgsql;
using ProjekPBO_PemesananTiketBioskop.App.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Context
{
    internal class C_Profil : DatabaseWrapper
    {

        public void UpdateProfil()
        {
            string query = "UPDATE akun SET username = @username, " +
               "password = @password, " +
               "nomor_telepon = @nomor_telepon, " +
               "email = @email " +
               "WHERE akun_id = @akun_id";


            // Pastikan akun_id ada
            if (userSession.CurrentUser != null)
            {
                NpgsqlParameter[] parameters = new NpgsqlParameter[]
                {
                    new NpgsqlParameter("@akun_id", userSession.CurrentUser.akun_id),
                    new NpgsqlParameter("@username", userSession.CurrentUser.username),
                    new NpgsqlParameter("@nomor_telepon", userSession.CurrentUser.nomor_telepon),
                    new NpgsqlParameter("@email", userSession.CurrentUser.email),
                    new NpgsqlParameter("@password",userSession.CurrentUser.password)
                    
                };

                // Eksekusi query dengan parameters
                commandExecutor(query, parameters);
            }
            else
            {
                MessageBox.Show("User session tidak ditemukan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
