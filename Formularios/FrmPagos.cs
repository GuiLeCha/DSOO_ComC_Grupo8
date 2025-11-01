using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConexionDB = ClubDeportivo.Conexion.Conexion;

namespace ClubDeportivo
{
    public partial class FrmPagos : Form
    {
        private int idPersonaSeleccionada = 0;
        private string tipoPersona = "";
        private ConexionDB conexion = new ConexionDB();

        public FrmPagos()
        {
            InitializeComponent();
        }

        // Constructor usado cuando se abre desde el registro de persona
        public FrmPagos(int idPersona, string tipo)
        {
            InitializeComponent();
            idPersonaSeleccionada = idPersona;
            tipoPersona = tipo;
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            lblNombre.Text = "";

            if (idPersonaSeleccionada != 0)
                CargarDatosPersona(idPersonaSeleccionada);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text.Trim();

            if (dni == "")
            {
                MessageBox.Show("Debe ingresar un DNI para buscar.");
                return;
            }

            try
            {
                using (MySqlConnection cn = conexion.AbrirConexion())
                {
                    string sql = "SELECT idPersona, nombre, apellido FROM persona WHERE numeroDocumento = @dni";
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@dni", dni);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        idPersonaSeleccionada = dr.GetInt32("idPersona");
                        lblNombre.Text = dr.GetString("nombre") + " " + dr.GetString("apellido");
                        dr.Close();

                        // Verifica si la persona es socio o no socio
                        string sqlSocio = "SELECT COUNT(*) FROM socios WHERE idPersona = @id";
                        MySqlCommand cmdSocio = new MySqlCommand(sqlSocio, cn);
                        cmdSocio.Parameters.AddWithValue("@id", idPersonaSeleccionada);
                        int esSocio = Convert.ToInt32(cmdSocio.ExecuteScalar());

                        tipoPersona = (esSocio > 0) ? "Socio" : "NoSocio";
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una persona con ese documento.");
                        lblNombre.Text = "";
                        idPersonaSeleccionada = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar persona: " + ex.Message);
            }
        }

        private void btnRegistrarPago_Click(object sender, EventArgs e)
        {
            if (idPersonaSeleccionada == 0)
            {
                MessageBox.Show("Debe seleccionar una persona antes de registrar el pago.");
                return;
            }

            if (!double.TryParse(txtMonto.Text, out double monto))
            {
                MessageBox.Show("Debe ingresar un monto válido.");
                return;
            }

            string descripcion = txtDescripcion.Text.Trim();
            string tipoPago = (tipoPersona == "Socio") ? "Cuota" : "Actividad";

            try
            {
                // Inserta el pago en la base de datos
                using (MySqlConnection cn = conexion.AbrirConexion())
                {
                    string sql = "INSERT INTO pago (idPersona, fecha_pago, monto, tipo_pago, descripcion) " +
                                 "VALUES (@idPersona, NOW(), @monto, @tipoPago, @descripcion)";
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@idPersona", idPersonaSeleccionada);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@tipoPago", tipoPago);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Pago registrado correctamente.");

                // Si es socio y aún no tiene carnet, se genera automáticamente
                if (tipoPersona == "Socio")
                {
                    using (MySqlConnection cn = conexion.AbrirConexion())
                    {
                        string sqlCheck = "SELECT COUNT(*) FROM carnet WHERE idPersona = @id";
                        MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, cn);
                        cmdCheck.Parameters.AddWithValue("@id", idPersonaSeleccionada);
                        int tieneCarnet = Convert.ToInt32(cmdCheck.ExecuteScalar());

                        if (tieneCarnet == 0)
                        {
                            Carnet carnet = Carnet.GenerarCarnet(idPersonaSeleccionada);
                            carnet.GuardarEnBD();

                            FrmCarnet frmCarnet = new FrmCarnet(carnet, lblNombre.Text);
                            frmCarnet.ShowDialog();
                        }
                    }
                }

                // Genera el comprobante de pago y lo muestra en una ventana aparte
                Pago pago = new Pago(idPersonaSeleccionada, monto, tipoPago, descripcion);
                string comprobante = pago.GenerarComprobante(lblNombre.Text);

                FrmComprobantePago frmComprobante = new FrmComprobantePago(comprobante);
                frmComprobante.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar pago: " + ex.Message);
            }
        }

        private void CargarDatosPersona(int id)
        {
            try
            {
                using (MySqlConnection cn = conexion.AbrirConexion())
                {
                    string sql = "SELECT nombre, apellido FROM persona WHERE idPersona = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    MySqlDataReader dr = cmd.ExecuteReader();

                    if (dr.Read())
                    {
                        lblNombre.Text = dr.GetString("nombre") + " " + dr.GetString("apellido");
                        dr.Close();

                        string sqlSocio = "SELECT COUNT(*) FROM socios WHERE idPersona = @id";
                        MySqlCommand cmdSocio = new MySqlCommand(sqlSocio, cn);
                        cmdSocio.Parameters.AddWithValue("@id", idPersonaSeleccionada);
                        int esSocio = Convert.ToInt32(cmdSocio.ExecuteScalar());

                        tipoPersona = (esSocio > 0) ? "Socio" : "NoSocio";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
    }
}
