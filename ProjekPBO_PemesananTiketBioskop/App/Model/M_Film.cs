using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Model
{
    public class M_Film
    {
        [Key]
        public int film_id { get; set; }
        [Required]
        public string judul_film { get; set; }
        [Required]
        public string genre { get; set; }
        [Required]
        public string sutradara { get; set; }
        [Required]
        public string produksi { get; set; }
        [Required]
        public string aktor { get; set; }
        [Required]
        public int batas_umur { get; set; }
        [Required]
        public string durasi { get; set; }
        [Required]
        public string sinopsis { get; set; }
        [Required]
        public int harga { get; set; }
        [Required]
        public byte[] gambar { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public TimeSpan waktuTayang { get; set; }
        [Required]
        public DateTime tanggalTayang { get; set; }
    }
}
