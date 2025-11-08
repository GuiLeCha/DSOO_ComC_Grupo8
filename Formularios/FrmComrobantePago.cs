using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ClubDeportivo
{
    // Muestra y permite imprimir el comprobante de pago
    public partial class FrmComprobantePago : Form
    {
        private string textoComprobante;

        public FrmComprobantePago(string comprobante)
        {
            InitializeComponent();
            textoComprobante = comprobante;
        }

        private void FrmComprobantePago_Load(object sender, EventArgs e)
        {
            // Texto del comprobante dentro del panel
            lblTexto.Text = textoComprobante;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Objeto de impresión
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirComprobante);

            // Ocultamos el botón mientras se imprime
            btnImprimir.Visible = false;

            // Vista previa
            PrintPreviewDialog vista = new PrintPreviewDialog();
            vista.Document = pd;
            vista.ShowDialog();

            // Volvemos a mostrar el botón
            btnImprimir.Visible = true;
        }

        private void ImprimirComprobante(object sender, PrintPageEventArgs e)
        {
            // Capturamos solo el panel del comprobante
            int ancho = pnlComprobante.Width;
            int alto = pnlComprobante.Height;

            Rectangle bounds = new Rectangle(0, 0, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            pnlComprobante.DrawToBitmap(img, bounds);

            // Dibujamos la imagen del panel en la hoja
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
