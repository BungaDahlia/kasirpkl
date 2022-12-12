using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace kasir_pedagang_kaki_lima
{
    internal class Koneksi
    {
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;UID=root;PWD=;Database=dbkasirpkl");
    }
}
