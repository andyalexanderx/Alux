using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazAluxito
{
    public sealed class ClaseSingleton //no se puede heredar la clase
    {
        public string Usuario {  get; set; }
        public DateTime fechaInicio { get; set; }
        private ClaseSingleton() //constructor privado
        {

        }
        private static ClaseSingleton session; //crear variable privada referenciada la instancia
        private static object _lock = new object();

        public static ClaseSingleton ObtienerInstancia() //obtener el estado de la instancia, para saber si esta creada o no
        {
            if (session == null) throw new Exception("Sesión no iniciada");
            return session;
        }
        public static void Login(string usuario) //crear la sesion (instancia)
        {
            lock (_lock)
            {
                if (session == null)
                {
                    session = new ClaseSingleton();
                    session.Usuario = usuario;
                    session.fechaInicio = DateTime.Now; //Tiempo de creacion
                }
                else
                {
                    throw new Exception("Sesión iniciada");
                }
            }
        }
        public static void Logout() //liberar la sesion
        {
            lock (_lock)
            {
                if (session != null)
                {
                    session = null;
                }
                else
                {
                    throw new Exception("Sesion no iniciada");
                }
            }
        }
    }
}
