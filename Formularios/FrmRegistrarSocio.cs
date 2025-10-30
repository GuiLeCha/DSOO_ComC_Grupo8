using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ClubDeportivo.Formularios
{
    public partial class FrmRegistrarSocio : Form
    {
        public FrmRegistrarSocio()
        {
            InitializeComponent();
        }

        private void FrmRegistrarSocio_Load(object sender, EventArgs e)
        {
            dtpFechaIngreso.Value = DateTime.Today;
            cboTipoDocumento.Items.Clear();
            cboTipoDocumento.Items.Add("DNI");
            cboTipoDocumento.Items.Add("Pasaporte");
            cboTipoDocumento.Items.Add("LC/LE");

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Abrir conexión usando los datos del App.config
                string cadenaConexion = ConfigurationManager.ConnectionStrings["cadenaConexion"].ConnectionString;
                MySqlConnection conexion = new MySqlConnection(cadenaConexion);
                conexion.Open();

                // Insertar datos de la persona
                string sqlPersona = "INSERT INTO persona (nombre, apellido, tipoDocumento, numeroDocumento, direccion, telefono, email, fechaNacimiento) " +
                                    "VALUES ('" + txtNombre.Text + "', '" + txtApellido.Text + "', '" + cboTipoDocumento.Text + "', '" + txtNumeroDocumento.Text + "', '" +
                                    txtDireccion.Text + "', '" + txtTelefono.Text + "', '" + txtEmail.Text + "', '" + dtpFechaNacimiento.Value.ToString("yyyy-MM-dd") + "')";

                MySqlCommand cmdPersona = new MySqlCommand(sqlPersona, conexion);
                cmdPersona.ExecuteNonQuery();

                // Insertar los datos del socio (número carnet fijo)
                string sqlSocio = "INSERT INTO socios (idPersona, nroSocioCarnet, fechaIngreso, cuotaVigente) " +
                                  "VALUES (1, 1001, '" + dtpFechaIngreso.Value.ToString("yyyy-MM-dd") + "', " + chkCuotaVigente.Checked + ")";

                MySqlCommand cmdSocio = new MySqlCommand(sqlSocio, conexion);
                cmdSocio.ExecuteNonQuery();

                // Confirmar guardado
                MessageBox.Show("Registro guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                conexion.Close();

                // Limpiar campos
                txtNombre.Clear();
                txtApellido.Clear();
                cboTipoDocumento.SelectedIndex = -1;
                txtNumeroDocumento.Clear();
                txtDireccion.Clear();
                txtTelefono.Clear();
                txtEmail.Clear();
                chkCuotaVigente.Checked = false;
                dtpFechaNacimiento.Value = DateTime.Today;
                dtpFechaIngreso.Value = DateTime.Today;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // limpia todos los campos
            txtNombre.Clear();
            txtApellido.Clear();
            cboTipoDocumento.SelectedIndex = -1;
            txtNumeroDocumento.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            dtpFechaIngreso.Value = DateTime.Today;
            chkCuotaVigente.Checked = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            FrmMenu frm = new FrmMenu();
            frm.Show();
            this.Hide();
        }
    }
}
