using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
namespace DoAn
{
    class clsDatabase
    {

        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLKS;Integrated Security=True");
        
        public khachhang GetDataTable(string NameTable)
        {
            string sql = "select * from " + NameTable;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            khachhang dt = new khachhang();
            
            return dt;

        }

    }
}
