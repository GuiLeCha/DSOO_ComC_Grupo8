using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace ClubDeportivo.Conexion
{
    // Maneja la conexión general a la base de datos del sistema
    public class Conexion
    {
        // Abre y devuelve una conexión activa
        public MySqlConnection AbrirConexion()
        {
            string cadena = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
            MySqlConnection cn = new MySqlConnection(cadena);
            cn.Open();
            return cn;
        }

        // Cierra la conexión si está abierta
        public void CerrarConexion(MySqlConnection cn)
        {
            if (cn != null && cn.State == ConnectionState.Open)
                cn.Close();
        }
    }
}
