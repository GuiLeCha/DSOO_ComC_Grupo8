using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FrmCarnet : Form
    {
        private Carnet carnetActual;
        private string nombreSocio;

        public FrmCarnet(Carnet carnet, string nombreCompleto)
        {
            InitializeComponent();
            carnetActual = carnet;
            nombreSocio = nombreCompleto;
        }

        private void FrmCarnet_Load(object sender, EventArgs e)
        {
            // Asignamos los datos a las etiquetas del carnet
            lblNombre.Text = nombreSocio;
            lblNumero.Text = carnetActual.NumeroCarnet;
            lblEmision.Text = carnetActual.FechaEmision.ToShortDateString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Creamos el documento de impresión
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirCarnet);

            // Ocultamos el botón mientras se imprime
            btnImprimir.Visible = false;

            // Mostramos la vista previa de impresión
            PrintPreviewDialog vista = new PrintPreviewDialog();
            vista.Document = pd;
            vista.ShowDialog();

            // Volvemos a mostrar el botón
            btnImprimir.Visible = true;
        }
        private void ImprimirCarnet(object sender, PrintPageEventArgs e)
        {
            int ancho = pnlCarnet.Width;
            int alto = pnlCarnet.Height;

            Rectangle bounds = new Rectangle(0, 0, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            pnlCarnet.DrawToBitmap(img, bounds);

            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
