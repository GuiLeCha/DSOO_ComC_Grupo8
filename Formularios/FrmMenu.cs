using System;
using System.Windows.Forms;

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
            FrmRegistrarSocio frm = new FrmRegistrarSocio();
            frm.Show();
            this.Hide();
        }

    }
}
