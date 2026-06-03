using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaSePrice
{
    internal class Conexion
    {
        string cadenaConexion =
            "server=localhost;database=clinica_seprice;user=root;password=root;";

        public MySqlConnection conectar()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            return conexion;
        }
    }
}