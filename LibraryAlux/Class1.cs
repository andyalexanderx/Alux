using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClassLibraryAlux
{
    public class Class1
    {
        public static DataSet Execute(string cmd)
        {
            SqlConnection conex = new SqlConnection("Data Source=LAPTOP-NIGM837B\\SQLEXPRESS;Initial Catalog=Aluxito;Integrated Security=True");
            conex.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter dp = new SqlDataAdapter(cmd, conex);

            dp.Fill(ds);
            conex.Close();
            return ds;
        }
    }
}
