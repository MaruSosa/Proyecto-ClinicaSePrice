using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice
{
    public static class ContenedorSesion
    {
        // CAMBIO: Cambiamos string por int en Usuario
        public static int Usuario { get; set; }
        public static string Nombre { get; set; }
        public static string Rol { get; set; }

        public static void IniciarSesion(int id, string nombre, string rol)
        {
            Usuario = id; // Ahora sí: int es igual a int
            Nombre = nombre;
            Rol = rol;
        }

        public static void CerrarSesion()
        {
            Usuario = 0; // Ahora sí: int es igual a 0
            Nombre = null;
            Rol = null;
        }
    }
}
