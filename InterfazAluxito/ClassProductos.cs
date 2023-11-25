using System.Data;
using MySql.Data.MySqlClient;

namespace InterfazAluxito
{
    class ClassProductos
    {
        private int id;
        private string nombre;
        private int existencias;
        private string descripcion;
        private string unidad;
        private double precio;

        public int Id { get ; set; }
        public string Nombre { get ; set; }
        public int Existencias { get ; set; }
        public string Descripcion { get ; set; }
        public string Unidad { get ; set; }
        public double Precio { get; set; }
    }
}