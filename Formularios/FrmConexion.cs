using System;
using System.Windows.Forms;
using System.Configuration;
using ClubDeportivo.Conexion;

namespace ClubDeportivo.Formularios
{
    // Permite configurar y probar la conexión a la base de datos
    public partial class FrmConexion : Form
    {
        private ConexionBD conexionActiva;

        public FrmConexion()
        {
            InitializeComponent();
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
            // Crea un objeto de conexión con los valores ingresados y prueba la conexión
            ConexionBD cn = new ConexionBD
            {
                servidor = txtServidor.Text,
                puerto = txtPuerto.Text,
                usuario = txtUsuario.Text,
                clave = txtClave.Text,
                baseDatos = txtBase.Text
            };

            cn.CrearConexion(); // Muestra mensaje de éxito o error
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validaciones mínimas antes de guardar
                if (string.IsNullOrWhiteSpace(txtServidor.Text) ||
                    string.IsNullOrWhiteSpace(txtPuerto.Text) ||
                    string.IsNullOrWhiteSpace(txtBase.Text) ||
                    string.IsNullOrWhiteSpace(txtUsuario.Text))
                {
                    MessageBox.Show("Complete Servidor, Puerto, Base y Usuario.",
                        "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Arma la cadena de conexión con formato MySQL
                string nuevaCadena =
                    $"server={txtServidor.Text};" +
                    $"port={txtPuerto.Text};" +
                    $"database={txtBase.Text};" +
                    $"user={txtUsuario.Text};" +
                    $"password={txtClave.Text};" +
                    "SslMode=none;AllowPublicKeyRetrieval=true;";

                // Actualiza el valor en App.config
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var connSection = config.ConnectionStrings.ConnectionStrings["cadenaConexion"];

                if (connSection == null)
                {
                    connSection = new ConnectionStringSettings(
                        "cadenaConexion",
                        nuevaCadena,
                        "MySql.Data.MySqlClient"
                    );
                    config.ConnectionStrings.ConnectionStrings.Add(connSection);
                }
                else
                {
                    connSection.ConnectionString = nuevaCadena;
                    connSection.ProviderName = "MySql.Data.MySqlClient";
                }

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("connectionStrings");

                // Guarda también en memoria (solo informativo)
                conexionActiva = new ConexionBD
                {
                    servidor = txtServidor.Text,
                    puerto = txtPuerto.Text,
                    usuario = txtUsuario.Text,
                    clave = txtClave.Text,
                    baseDatos = txtBase.Text
                };

                MessageBox.Show("Parámetros guardados correctamente.",
                    "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Vuelve al login una vez guardada la conexión
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar los parámetros:\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
