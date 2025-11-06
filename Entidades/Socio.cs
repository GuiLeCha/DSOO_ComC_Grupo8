using System;
using MySql.Data.MySqlClient;
using ConexionDB = ClubDeportivo.Conexion.Conexion;

namespace ClubDeportivo
{
    // Representa a un socio del club, heredando los datos básicos de Persona
    public class Socio : Persona
    {
        private int idSocio;
        private int nroSocioCarnet;
        private DateTime fechaIngreso;
        private bool cuotaVigente;

        public int IdSocio { get => idSocio; set => idSocio = value; }
        public int NroSocioCarnet { get => nroSocioCarnet; set => nroSocioCarnet = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public bool CuotaVigente { get => cuotaVigente; set => cuotaVigente = value; }

        public Socio() { }

        public Socio(int idPersona, DateTime fechaAlta)
        {
            this.Id = idPersona;
            this.fechaIngreso = fechaAlta;
            this.cuotaVigente = false;
        }

        // Guarda el nuevo socio en la base de datos
        public void RegistrarEnBD()
        {
            ConexionDB conexion = new ConexionDB();

            try
            {
                using (MySqlConnection cn = conexion.AbrirConexion())
                {
                    string sql = "INSERT INTO socios (idPersona, fechaIngreso, cuotaVigente) " +
                                 "VALUES (@idPersona, @fechaIngreso, @cuotaVigente)";
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@idPersona", this.Id);
                    cmd.Parameters.AddWithValue("@fechaIngreso", this.fechaIngreso);
                    cmd.Parameters.AddWithValue("@cuotaVigente", this.cuotaVigente);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al registrar socio: " + ex.Message);
            }
        }

        // Cambia el estado de la cuota (vigente o no)
        public void ActualizarCuota(bool estado)
        {
            ConexionDB conexion = new ConexionDB();

            try
            {
                using (MySqlConnection cn = conexion.AbrirConexion())
                {
                    string sql = "UPDATE socios SET cuotaVigente = @estado WHERE idPersona = @idPersona";
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@estado", estado);
                    cmd.Parameters.AddWithValue("@idPersona", this.Id);
                    cmd.ExecuteNonQuery();
                }

                this.cuotaVigente = estado;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error al actualizar cuota: " + ex.Message);
            }
        }

        // Devuelve true si el socio tiene la cuota al día
        public bool EsSocioActivo()
        {
            return this.cuotaVigente;
        }
    }
}
