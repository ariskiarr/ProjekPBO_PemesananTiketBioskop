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
        
        public int film_id { get; set; }
        
        public string judul_film { get; set; }
        
        public string genre { get; set; }
        
        public string sutradara { get; set; }
        
        public string produksi { get; set; }
        
        public string aktor { get; set; }
        
        public int batas_umur { get; set; }
        
        public string durasi { get; set; }
        
        public string sinopsis { get; set; }
        
        public int harga { get; set; }
        
        public byte[] gambar { get; set; }
        
        public string status { get; set; }
        
        public TimeSpan waktuTayang { get; set; }
        
        public DateTime tanggalTayang { get; set; }
    }
}
