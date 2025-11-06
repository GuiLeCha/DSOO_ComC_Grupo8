using System;
using System.Windows.Forms;
using ClubDeportivo.Conexion;
using ClubDeportivo.Formularios;
using MySql.Data.MySqlClient;

namespace ClubDeportivo
{
    // Punto de inicio del sistema Club Deportivo
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Verifica la conexión antes de iniciar el login
            try
            {
                ClubDeportivo.Conexion.Conexion conexion = new ClubDeportivo.Conexion.Conexion();
                using (MySqlConnection cn = conexion.AbrirConexion())
                {
                    // Si la conexión funciona, muestra la pantalla de login
                    Application.Run(new FrmLogin());
                }
            }
            catch
            {
                // Si la conexión falla, da opción a configurar los parámetros
                DialogResult respuesta = MessageBox.Show(
                    "No se pudo establecer conexión con el servidor.\n" +
                    "¿Desea configurar los parámetros de conexión ahora?",
                    "Error de conexión",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (respuesta == DialogResult.Yes)
                {
                    // Abre el formulario de configuración y luego el login
                    FrmConexion frm = new FrmConexion();
                    frm.ShowDialog();
                    Application.Run(new FrmLogin());
                }
                else
                {
                    // Si el usuario no configura la conexión, se cierra el programa
                    MessageBox.Show("El sistema no puede continuar sin una conexión válida.",
                        "Aplicación finalizada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
            }
        }
    }
}
