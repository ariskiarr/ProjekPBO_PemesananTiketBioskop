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
            [Key]
            public int akun_id { get; set; }
            [Required]
            public string role { get; set; }
            [Required]
            public string username { get; set; }
            [Required]
            public string nomor_telepon { get; set; }
            [Required]
            public string email { get; set; }
            [Required]
            public string password { get; set; }
        }
    }

