using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;

namespace ClubDeportivo.Conexion
{
    public class Conexion
    {
        // Abre y devuelve una conexión a la base de datos
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
