using MySql.Data.MySqlClient;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace ClubDeportivo.Formularios
{
    public partial class FrmRegistrarPersona : Form
    {
        public FrmRegistrarPersona()
        {
            InitializeComponent();
        }

        private void FrmRegistrarPersona_Load(object sender, EventArgs e)
        {
            dtpFechaIngreso.Value = DateTime.Today;
            cboTipoDocumento.Items.Clear();
            cboTipoDocumento.Items.Add("DNI");
            cboTipoDocumento.Items.Add("Pasaporte");
            cboTipoDocumento.Items.Add("LC/LE");

            rdbSocio.Checked = true;
            chkAptoPresentado.Checked = true;

            chkCuotaVigente.Visible = false;
            txtNroSocio.Visible = false;
            lbltxtNroSocio.Visible = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones de campos obligatorios y formato
                if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                    string.IsNullOrWhiteSpace(txtApellido.Text) ||
                    cboTipoDocumento.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(txtNumeroDocumento.Text) ||
                    string.IsNullOrWhiteSpace(txtDireccion.Text) ||
                    string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    MessageBox.Show("Por favor complete todos los datos antes de continuar.",
                        "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(txtNumeroDocumento.Text, out _) || txtNumeroDocumento.Text.Length > 10)
                {
                    MessageBox.Show("El número de documento debe contener solo números y tener hasta 10 dígitos.",
                        "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!long.TryParse(txtTelefono.Text, out _) || txtTelefono.Text.Length > 15)
                {
                    MessageBox.Show("El teléfono debe contener solo números y tener hasta 15 dígitos.",
                        "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
                {
                    MessageBox.Show("El correo electrónico no es válido.",
                        "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtObservacionesApto.Text.Length > 100)
                {
                    MessageBox.Show("Las observaciones del apto físico no pueden superar los 100 caracteres.",
                        "Límite de texto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!chkAptoPresentado.Checked)
                {
                    MessageBox.Show("Debe presentar el Apto Físico para completar el registro.",
                        "Apto Físico obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
                using (MySqlConnection conexion = new MySqlConnection(cadenaConexion))
                {
                    conexion.Open();

                    string sqlCheck = "SELECT idPersona FROM persona WHERE tipoDocumento = @tipo AND numeroDocumento = @numero";
                    MySqlCommand cmdCheck = new MySqlCommand(sqlCheck, conexion);
                    cmdCheck.Parameters.AddWithValue("@tipo", cboTipoDocumento.Text);
                    cmdCheck.Parameters.AddWithValue("@numero", txtNumeroDocumento.Text);
                    object resultado = cmdCheck.ExecuteScalar();

                    long idPersona;

                    if (resultado != null)
                    {
                        idPersona = Convert.ToInt64(resultado);

                        string sqlSocioCheck = "SELECT COUNT(*) FROM socios WHERE idPersona = @id";
                        MySqlCommand cmdSocioCheck = new MySqlCommand(sqlSocioCheck, conexion);
                        cmdSocioCheck.Parameters.AddWithValue("@id", idPersona);
                        int esSocio = Convert.ToInt32(cmdSocioCheck.ExecuteScalar());

                        if (esSocio > 0)
                        {
                            MessageBox.Show("Esta persona ya está registrada como socio.",
                                "Registro duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }

                        if (rdbSocio.Checked)
                        {
                            DialogResult respuesta = MessageBox.Show("La persona ya está registrada como No Socio. ¿Desea convertirla en Socio?",
                                "Confirmar conversión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (respuesta == DialogResult.Yes)
                            {
                                string sqlSocio = "INSERT INTO socios (idPersona, nroSocioCarnet, fechaIngreso, cuotaVigente) " +
                                                  "VALUES (@id, 1001, @fecha, 0)";
                                MySqlCommand cmdSocio = new MySqlCommand(sqlSocio, conexion);
                                cmdSocio.Parameters.AddWithValue("@id", idPersona);
                                cmdSocio.Parameters.AddWithValue("@fecha", dtpFechaIngreso.Value.ToString("yyyy-MM-dd"));
                                cmdSocio.ExecuteNonQuery();

                                MessageBox.Show("La persona fue convertida en socio correctamente.",
                                    "Conversión exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                FrmPagos frmPagos = new FrmPagos((int)idPersona, "Socio");
                                frmPagos.ShowDialog();
                            }
                            return;
                        }
                        else
                        {
                            MessageBox.Show("La persona ya está registrada como No Socio.",
                                "Registro existente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                    else
                    {
                        // Inserta la nueva persona
                        string sqlPersona = "INSERT INTO persona (nombre, apellido, tipoDocumento, numeroDocumento, direccion, telefono, email, fechaNacimiento) " +
                                            "VALUES (@nombre, @apellido, @tipo, @numero, @direccion, @telefono, @correo, @fechaNac)";
                        MySqlCommand cmdPersona = new MySqlCommand(sqlPersona, conexion);
                        cmdPersona.Parameters.AddWithValue("@nombre", txtNombre.Text);
                        cmdPersona.Parameters.AddWithValue("@apellido", txtApellido.Text);
                        cmdPersona.Parameters.AddWithValue("@tipo", cboTipoDocumento.Text);
                        cmdPersona.Parameters.AddWithValue("@numero", txtNumeroDocumento.Text);
                        cmdPersona.Parameters.AddWithValue("@direccion", txtDireccion.Text);
                        cmdPersona.Parameters.AddWithValue("@telefono", txtTelefono.Text);
                        cmdPersona.Parameters.AddWithValue("@correo", txtEmail.Text);
                        cmdPersona.Parameters.AddWithValue("@fechaNac", dtpFechaNacimiento.Value.ToString("yyyy-MM-dd"));
                        cmdPersona.ExecuteNonQuery();

                        idPersona = cmdPersona.LastInsertedId;

                        // Inserta socio o no socio según corresponda
                        if (rdbSocio.Checked)
                        {
                            string sqlSocio = "INSERT INTO socios (idPersona, nroSocioCarnet, fechaIngreso, cuotaVigente) " +
                                              "VALUES (@id, 1001, @fecha, 0)";
                            MySqlCommand cmdSocio = new MySqlCommand(sqlSocio, conexion);
                            cmdSocio.Parameters.AddWithValue("@id", idPersona);
                            cmdSocio.Parameters.AddWithValue("@fecha", dtpFechaIngreso.Value.ToString("yyyy-MM-dd"));
                            cmdSocio.ExecuteNonQuery();

                            FrmPagos frmPagos = new FrmPagos((int)idPersona, "Socio");
                            frmPagos.ShowDialog();
                        }
                        else
                        {
                            string sqlNoSocio = "INSERT INTO nosocios (idPersona) VALUES (@id)";
                            MySqlCommand cmdNoSocio = new MySqlCommand(sqlNoSocio, conexion);
                            cmdNoSocio.Parameters.AddWithValue("@id", idPersona);
                            cmdNoSocio.ExecuteNonQuery();

                            FrmPagos frmPagos = new FrmPagos((int)idPersona, "NoSocio");
                            frmPagos.ShowDialog();
                        }

                        // Registra el apto físico obligatorio
                        string sqlApto = "INSERT INTO aptosfisicos (idPersona, fechaPresentacion, observaciones) " +
                                         "VALUES (@id, @fechaApto, @obs)";
                        MySqlCommand cmdApto = new MySqlCommand(sqlApto, conexion);
                        cmdApto.Parameters.AddWithValue("@id", idPersona);
                        cmdApto.Parameters.AddWithValue("@fechaApto", DateTime.Today.ToString("yyyy-MM-dd"));
                        cmdApto.Parameters.AddWithValue("@obs", txtObservacionesApto.Text);
                        cmdApto.ExecuteNonQuery();

                        MessageBox.Show("Registro guardado correctamente junto con el Apto Físico.",
                            "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpiarCampos();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            cboTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            dtpFechaIngreso.Value = DateTime.Today;
            chkAptoPresentado.Checked = true;
            txtObservacionesApto.Clear();
            rdbSocio.Checked = true;
        }
    }
}
