using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using ClassLibraryAlux;
namespace InterfazAluxito
{
    class connection
    {
        //public MySqlConnection Connection()
        //{
        //    //MySqlConnection Conectar = new MySqlConnection(
        //    //    "datasource=localhost; port=3006; username=root; password=123456; database=aluxito; ");
        //    //Conectar.Open();
        //    //return Conectar;
        //    // La siguiente linea es la que provee la conexión entre C# y MySQL.
        //    // Debes cambiar el nombre de usuario, contrasenia y nombre de base de datos
        //    // de acuerdo a tus datos
        //    // Puedes ignorar la opción de base de datos (database) si quieres acceder a todas
        //    // 127.0.0.1 es de localhost y el puerto predeterminado para conectar
        //    /*Alonso@10*/
        //    string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=123456;database=aluxito;";
        //    // Tu consulta en SQL
        //    string query = "SELECT * FROM users";

        //    // Prepara la conexión
        //    MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        //    MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        //    commandDatabase.CommandTimeout = 60;
        //    MySqlDataReader reader;

        //    // A consultar !
        //    try
        //    {
        //        // Abre la base de datos
        //        databaseConnection.Open();

        //        // Ejecuta la consultas
        //        reader = commandDatabase.ExecuteReader();

        //        // Hasta el momento todo bien, es decir datos obtenidos

        //        // IMPORTANTE :#
        //        // Si tu consulta retorna un resultado, usa el siguiente proceso para obtener datos
        //        if (reader.HasRows)
        //        {
        //            while (reader.Read())
        //            {
        //                // En nuestra base de datos, el array contiene:  ID 0, FIRST_NAME 1,LAST_NAME 2
        //                // Hacer algo con cada fila obtenida
        //                string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2)};
        //            }
        //        }
        //        else
        //        {
        //            MessageBox.Show("No se encontraron datos.");
        //        }

        //        // Cerrar la conexión
        //        databaseConnection.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        // Mostrar cualquier excepción
        //        MessageBox.Show(ex.Message);
        //    }
        //    return databaseConnection;
        //}
        /*public void conect()
        {
            Class1.Execute("select * from productos");
        }*/
    }
}