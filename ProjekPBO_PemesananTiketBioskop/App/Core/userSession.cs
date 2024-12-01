using ProjekPBO_PemesananTiketBioskop.App.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjekPBO_PemesananTiketBioskop.App.Core
{
    internal class userSession
    {
        public static M_Akun CurrentUser { get; set; }
    }
}
