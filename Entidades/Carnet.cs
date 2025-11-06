using System;
using MySql.Data.MySqlClient;
using ConexionDB = ClubDeportivo.Conexion.Conexion;

namespace ClubDeportivo
{
    // Representa el carnet que se emite al socio
    public class Carnet
    {
        private int idSocio;
        private string numeroCarnet;
        private DateTime fechaEmision;

        public int IdSocio { get => idSocio; set => idSocio = value; }
        public string NumeroCarnet { get => numeroCarnet; set => numeroCarnet = value; }
        public DateTime FechaEmision { get => fechaEmision; set => fechaEmision = value; }

        public Carnet() { }

        public Carnet(int idSocio)
        {
            this.idSocio = idSocio;
            this.fechaEmision = DateTime.Now;
            this.numeroCarnet = "SOC-" + idSocio + "-" + fechaEmision.Year;
        }

        // Crea un carnet nuevo para el socio recibido
        public static Carnet GenerarCarnet(int idSocio)
        {
            return new Carnet(idSocio);
        }

        // Guarda el carnet generado en la base de datos
        public void GuardarEnBD()
        {
            ConexionDB conexion = new ConexionDB();

            try
            {
                using (MySqlConnection cn = conexion.AbrirConexion())
                {
                    string sql = "INSERT INTO carnet (idPersona, numeroCarnet, fecha_emision) " +
                                 "VALUES (@idPersona, @numeroCarnet, @fechaEmision)";

                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@idPersona", idSocio);
                    cmd.Parameters.AddWithValue("@numeroCarnet", numeroCarnet);
                    cmd.Parameters.AddWithValue("@fechaEmision", fechaEmision);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al guardar carnet: " + ex.Message);
            }
        }

        public override string ToString()
        {
            return $"Nro Carnet: {numeroCarnet}\nEmitido: {fechaEmision.ToShortDateString()}";
        }
    }
}
