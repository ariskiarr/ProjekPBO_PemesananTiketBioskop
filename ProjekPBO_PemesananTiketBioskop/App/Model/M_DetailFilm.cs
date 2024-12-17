using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Model
{
   public class M_DetailFilm
    {
        
        public int detailfilm_id { get; set; }
        
        public int ruangan_id { get; set; }
        
        public int film_id { get; set; }

    }
}
