using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ConexionDB = ClubDeportivo.Conexion.Conexion;
using System.Drawing;

namespace ClubDeportivo
{
    // Permite registrar pagos de socios o no socios
    public partial class FrmPagos : Form
    {
        private int idPersonaSeleccionada = 0;
        private string tipoPersona = "";
        private ConexionDB conexion = new ConexionDB();

        public FrmPagos()
        {
            InitializeComponent();
        }

        // Se usa cuando el formulario se abre desde el registro de persona
        public FrmPagos(int idPersona, string tipo)
        {
            InitializeComponent();
            idPersonaSeleccionada = idPersona;
            tipoPersona = tipo;
        }

        private void FrmPagos_Load(object sender, EventArgs e)
        {
            // Estado inicial
            lblNombre.Text = "";
            lblTipo.Text = "";

            // Si se recibió una persona, se cargan sus datos
            if (idPersonaSeleccionada != 0)
                CargarDatosPersona(idPersonaSeleccionada);

            // Formas de pago disponibles
            cboFormaPago.Items.Clear();
            cboFormaPago.Items.Add("Efectivo");
            cboFormaPago.Items.Add("Tarjeta");
            cboFormaPago.Items.Add("3 cuotas");
            cboFormaPago.Items.Add("6 cuotas");
            cboFormaPago.SelectedIndex = 0;

            // Color general de fondo
            this.BackColor = Color.LightSteelBlue;
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

                        // Verifica si pertenece a socios o no socios
                        string sqlSocio = "SELECT COUNT(*) FROM socios WHERE idPersona = @id";
                        MySqlCommand cmdSocio = new MySqlCommand(sqlSocio, cn);
                        cmdSocio.Parameters.AddWithValue("@id", idPersonaSeleccionada);
                        int esSocio = Convert.ToInt32(cmdSocio.ExecuteScalar());

                        tipoPersona = (esSocio > 0) ? "Socio" : "No Socio";
                        lblTipo.Text = tipoPersona;
                    }
                    else
                    {
                        MessageBox.Show("No se encontró una persona con ese documento.");
                        lblNombre.Text = "";
                        lblTipo.Text = "";
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
            // Validaciones básicas
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
            string formaPago = cboFormaPago.SelectedItem.ToString();

            // Restricción para no socios
            if (tipoPersona != "Socio" && (formaPago == "3 cuotas" || formaPago == "6 cuotas"))
            {
                MessageBox.Show("Solo los socios pueden abonar en cuotas.",
                    "Forma de pago no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Guarda el pago en la base de datos
                using (MySqlConnection cn = conexion.AbrirConexion())
                {
                    string sql = "INSERT INTO pago (idPersona, fecha_pago, monto, tipo_pago, formaPago, descripcion) " +
                                 "VALUES (@idPersona, NOW(), @monto, @tipoPago, @formaPago, @descripcion)";
                    MySqlCommand cmd = new MySqlCommand(sql, cn);
                    cmd.Parameters.AddWithValue("@idPersona", idPersonaSeleccionada);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@tipoPago", tipoPago);
                    cmd.Parameters.AddWithValue("@formaPago", formaPago);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Pago registrado correctamente.", "Pago", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Si es socio y no tiene carnet, se genera automáticamente
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

                // Genera el texto del comprobante y abre el formulario de impresión
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

        // Carga nombre y tipo de persona al abrir el formulario con un ID ya conocido
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

                        tipoPersona = (esSocio > 0) ? "Socio" : "No Socio";
                        lblTipo.Text = tipoPersona;
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
