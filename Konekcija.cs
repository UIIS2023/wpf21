using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran
{
    public class Konekcija
    {
        public SqlConnection KreirajKonekciju()
        {
            SqlConnectionStringBuilder ccnb = new SqlConnectionStringBuilder
            {
                DataSource = @"LAPTOP-S8BLMRE6\\SQLEXPRESS",
                InitialCatalog = "Restoran",
                IntegratedSecurity = true
            };

            string con = ccnb.ToString();
            SqlConnection konekcija = new SqlConnection(con);
            return konekcija;

        }
    }
}
