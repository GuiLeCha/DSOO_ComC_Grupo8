using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace ClubDeportivo.Conexion
{
    public class Conexion
    {
        private MySqlConnection conectar;

        public Conexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
            conectar = new MySqlConnection(cadena);
        }

        public MySqlConnection AbrirConexion()
        {
            if (conectar.State == ConnectionState.Closed)
                conectar.Open();
            return conectar;
        }

        public MySqlConnection CerrarConexion()
        {
            if (conectar.State == ConnectionState.Open)
                conectar.Close();
            return conectar;
        }
    }
}
