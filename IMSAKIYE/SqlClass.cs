using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IMSAKIYE

{
    class SqlClass
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IMSAKIYEDB;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
