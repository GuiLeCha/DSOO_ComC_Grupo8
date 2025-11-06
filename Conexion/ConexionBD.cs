using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Conexion
{
    // Clase para configurar y probar la conexión con la base de datos
    public class ConexionBD
    {
        public string servidor { get; set; }
        public string puerto { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public string baseDatos { get; set; }

        private MySqlConnection conexion;

        public ConexionBD()
        {
            // Valores por defecto al iniciar
            servidor = "localhost";
            puerto = "3306";
            usuario = "root";
            clave = "";
            baseDatos = "clubdeportivo";
        }

        // Crea la conexión y muestra un mensaje según el resultado
        public MySqlConnection CrearConexion()
        {
            try
            {
                string cadenaConexion =
                    $"datasource={servidor};" +
                    $"port={puerto};" +
                    $"username={usuario};" +
                    $"password={clave};" +
                    $"Database={baseDatos}";

                conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

                MessageBox.Show("Conexión exitosa.", "Conexión BD",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con la base de datos:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        // Cierra la conexión si está abierta
        public void CerrarConexion()
        {
            if (conexion != null && conexion.State == System.Data.ConnectionState.Open)
                conexion.Close();
        }
    }
}
