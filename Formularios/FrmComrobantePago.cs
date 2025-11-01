using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class FrmComprobantePago : Form
    {
        private string textoComprobante;
        private PrintDocument printDoc = new PrintDocument();

        // Recibe el comprobante generado y lo muestra
        public FrmComprobantePago(string comprobante)
        {
            InitializeComponent();
            textoComprobante = comprobante;
            printDoc.PrintPage += PrintDoc_PrintPage;
        }

        private void FrmComprobantePago_Load(object sender, EventArgs e)
        {
            txtComprobante.Text = textoComprobante;
        }

        // Abre la vista previa de impresión
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            vistaPrevia.Document = printDoc;
            vistaPrevia.ShowDialog();
        }

        // Dibuja el texto del comprobante en la hoja de impresión
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font fuente = new Font("Consolas", 10);
            e.Graphics.DrawString(textoComprobante, fuente, Brushes.Black, 80, 100);
        }
    }
}
