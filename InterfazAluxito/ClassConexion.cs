using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfazAluxito
{
    class ClassConexion
    {
        public MySqlConnection Conexion()
        {
            string servidor = "localhost";
            string db = "aluxito";
            string usuario = "root";
            string password = "123456";

            string CadenaConexion = "Database= " + db + "; Data Source=" + servidor + "; User Id="+usuario+"; Password="+password+"";

            try
            {
                MySqlConnection conexionDB = new MySqlConnection(CadenaConexion);
                return conexionDB;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error encontrado: "+ex.Message);
                return null;
            }
        }
    }
}
