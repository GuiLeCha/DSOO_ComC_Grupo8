using ClubDeportivo.Conexion;
using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Formularios
{
    // Formulario de inicio de sesión del sistema
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            // Permite iniciar sesión con la tecla Enter
            this.AcceptButton = btnIngresar;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            // Objeto de conexión a la base de datos
            Conexion.Conexion con = new Conexion.Conexion();

            try
            {
                using (MySqlConnection cn = con.AbrirConexion())
                {
                    string query = "SELECT * FROM usuarios WHERE usuario = @usuario AND clave = @clave";
                    MySqlCommand cmd = new MySqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                    cmd.Parameters.AddWithValue("@clave", txtClave.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        MessageBox.Show("Ingreso exitoso. \nBienvenido al Club Deportivo.",
                            "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Abre el menú principal y oculta el login
                        this.Hide();
                        FrmMenu menu = new FrmMenu();
                        menu.ShowDialog();

                        // Al cerrar el menú, termina la aplicación
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.",
                            "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    reader.Close();
                }

                // Limpia los campos después del intento
                txtUsuario.Clear();
                txtClave.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación desde la pantalla de login
            Application.Exit();
        }
    }
}
