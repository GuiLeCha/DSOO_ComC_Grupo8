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
        private PrintDocument printDoc = new PrintDocument();

        // Recibe el texto del comprobante ya generado
        public FrmComprobantePago(string comprobante)
        {
            InitializeComponent();
            textoComprobante = comprobante;
            printDoc.PrintPage += PrintDoc_PrintPage;
        }

        private void FrmComprobantePago_Load(object sender, EventArgs e)
        {
            // Muestra el comprobante en el cuadro de texto
            txtComprobante.Text = textoComprobante;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Abre la vista previa antes de imprimir
            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            vistaPrevia.Document = printDoc;
            vistaPrevia.ShowDialog();
        }

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Dibuja el texto del comprobante en la hoja
            Font fuente = new Font("Consolas", 10);
            e.Graphics.DrawString(textoComprobante, fuente, Brushes.Black, 80, 100);
        }
    }
}
