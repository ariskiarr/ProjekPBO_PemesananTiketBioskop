using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Model
{
        public class M_Akun
        {
            
            public int akun_id { get; set; }
            
            public string role { get; set; }
            
            public string username { get; set; }
            
            public string nomor_telepon { get; set; }
            
            public string email { get; set; }
            
            public string password { get; set; }
        }
    }

