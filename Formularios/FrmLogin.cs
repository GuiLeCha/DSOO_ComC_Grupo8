using ClubDeportivo.Conexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ClubDeportivo.Formularios
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Conexion.Conexion con = new Conexion.Conexion();

            try
            {
                con.AbrirConexion();

                string query = "SELECT * FROM usuarios WHERE usuario = @usuario AND clave = @clave";

                MySqlCommand cmd = new MySqlCommand(query, con.AbrirConexion());
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@clave", txtClave.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Ingreso exitoso. Bienvenido al Club Deportivo.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmMenu menu = new FrmMenu();
                    menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                reader.Close();
                con.CerrarConexion();

                // Limpiar datos
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
            Application.Exit();
        }
    }
}
