using System;
using System.Windows.Forms;
using ClubDeportivo.Formularios;

namespace ClubDeportivo.Formularios
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Cierra el menú y vuelve al login
            this.Close();
            Application.OpenForms["FrmLogin"]?.Show();
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            FrmRegistrarPersona frm = new FrmRegistrarPersona();
            frm.Show();
            this.Hide();
        }

        private void btnPagos_Click(object sender, EventArgs e)
        {
            FrmPagos formPagos = new FrmPagos();
            formPagos.ShowDialog();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReporteCuotas frm = new FrmReporteCuotas();
            frm.ShowDialog();
        }
    }
}
