using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Model
{
    public class M_Kursi
    {
        [Key]
        public int kursi_id { get; set; }

        [Required]
        public string nomor_kursi { get; set; }

        [Required]
        public string status { get; set; }

        [Required]
        public int detailfilm_id { get; set; }  
    }
}