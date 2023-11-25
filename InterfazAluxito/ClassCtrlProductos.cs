using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace InterfazAluxito
{
    class ClassCtrlProductos : ClassConexion
    {

        public List<Object> consulta(string dato)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;
            if (dato == null)
            {
                sql = "select idproducto, nombre, existencias, descripcion, unidad_medida, precio from productos order by nombre asc";
            }
            else
            {
                sql = "select idproducto, nombre, existencias, descripcion, unidad_medida," +
                    " precio from productos where nombre like '%" + dato + "%' or descripcion like '%" + dato + "%' or " +
                    "precio like '%" + dato + "%' or " +
                    "existencias like '%" + dato + "%' order by nombre asc";
            }
            try
            {
                MySqlConnection conexion = base.Conexion();
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(sql, conexion);
                reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    ClassProductos _producto = new ClassProductos();
                    _producto.Id = int.Parse(reader.GetString(0));
                    _producto.Nombre = reader.GetString("Nombre");
                    _producto.Descripcion = reader[3].ToString();
                    _producto.Precio = double.Parse(reader[5].ToString());
                    _producto.Unidad = reader[4].ToString();
                    _producto.Existencias = int.Parse(reader.GetString(2));
                    lista.Add(_producto);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return lista;
        }
        public List<Object> consultaIDProducto(string Code)
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;
            if (Code!=null)
            {
                sql = "select idproducto, nombre, existencias, descripcion, unidad_medida, precio from productos where idproducto= '"+Code+"'";
            }
            else
            {
                return null;
            }
            try
            {
                MySqlConnection conexion = base.Conexion();
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(sql, conexion);
                reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    ClassProductos _producto = new ClassProductos();
                    _producto.Id = int.Parse(reader.GetString(0));
                    _producto.Nombre = reader.GetString("Nombre");
                    _producto.Descripcion = reader[3].ToString();
                    _producto.Precio = double.Parse(reader[5].ToString());
                    _producto.Unidad = reader[4].ToString();
                    _producto.Existencias = int.Parse(reader.GetString(2));
                    lista.Add(_producto);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return lista;
        }

        public void insertar(int _id, string _nombre, int _existencia, string _descripcion, string _unidad, decimal _precio) 
        {

            try
            {
                MySqlConnection conexion = base.Conexion();
                conexion.Open();
                String vSQL = "INSERT INTO productos VALUES ('" + _id + "','" + _nombre + "','" + _descripcion +"','" + _existencia + "','" + _unidad + "','" + _precio + "');";
                MySqlCommand cmd = new MySqlCommand(vSQL, conexion);

                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha insertado el producto con exito");
            }
            catch(MySqlException){
                MessageBox.Show("Este producto ya existe");
            }
        }

        public void actualizar(int _id, string _nombre, int _existencia, string _descripcion, string _unidad, decimal _precio)
        {

            try
            {
                MySqlConnection conexion = base.Conexion();
                conexion.Open();
                String vSQL = "UPDATE productos set nombre='" + _nombre + "',existencias='" + _existencia + "',descripcion='" + _descripcion + "',unidad_medida='" + _unidad + "',precio='" + _precio + "' WHERE idproducto='" + _id + "';";
                MySqlCommand cmd = new MySqlCommand(vSQL, conexion);

                cmd.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Se ha actualizado la informacion del producto con exito");
            }
            catch (MySqlException)
            {
                MessageBox.Show("No se ha realizado la acutilizacion de la info. del producto");
            }
        }
        public List<Object> consultaProducto()
        {
            MySqlDataReader reader;
            List<Object> lista = new List<object>();
            string sql;

            sql = "select * from productos;";
            try
            {
                MySqlConnection conexion = base.Conexion();
                conexion.Open();
                MySqlCommand comand = new MySqlCommand(sql, conexion);
                reader = comand.ExecuteReader();
                while (reader.Read())
                {
                    ClassProductos _producto = new ClassProductos();
                    _producto.Id = int.Parse(reader.GetString(0));
                    _producto.Nombre = reader.GetString("Nombre");
                    _producto.Descripcion = reader[3].ToString();
                    _producto.Precio = double.Parse(reader[5].ToString());
                    _producto.Unidad = reader[4].ToString();
                    _producto.Existencias = int.Parse(reader.GetString(2));
                    lista.Add(_producto);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            return lista;
        }
    }
}
