using System;
using MySql.Data.MySqlClient;
using ConexionDB = ClubDeportivo.Conexion.Conexion;

namespace ClubDeportivo
{
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

        // Inserta un nuevo socio en la base de datos
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

        // Actualiza el estado de la cuota del socio
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

        public bool EsSocioActivo()
        {
            return this.cuotaVigente;
        }
    }
}
