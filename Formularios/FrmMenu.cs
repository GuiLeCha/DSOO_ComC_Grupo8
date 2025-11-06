using System;
using System.Windows.Forms;
using ClubDeportivo.Formularios;

namespace ClubDeportivo.Formularios
{
    // Menú principal del sistema. Desde acá accedemos a los distintos módulos.
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra el menú y vuelve al formulario de login
            this.Close();
            Application.OpenForms["FrmLogin"]?.Show();
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            // Abre el formulario para registrar socios o no socios
            FrmRegistrarPersona frm = new FrmRegistrarPersona();
            frm.ShowDialog();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            // Abre la ventana de pagos
            FrmPagos formPagos = new FrmPagos();
            formPagos.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            // Muestra el reporte de cuotas
            FrmReporteCuotas frm = new FrmReporteCuotas();
            frm.ShowDialog();
        }
    }
}
