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
        private PrintDocument printDoc = new PrintDocument();

        // Muestra los datos del carnet emitido
        public FrmCarnet(Carnet carnet, string nombreCompleto)
        {
            InitializeComponent();
            carnetActual = carnet;
            nombreSocio = nombreCompleto;

            // Se asocia el evento de impresión al método que dibuja el carnet
            printDoc.PrintPage += PrintDoc_PrintPage;
        }

        private void FrmCarnet_Load(object sender, EventArgs e)
        {
            lblNombre.Text = nombreSocio;
            lblNumero.Text = carnetActual.NumeroCarnet;
            lblEmision.Text = carnetActual.FechaEmision.ToShortDateString();
        }

        // Abre la vista previa antes de imprimir
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            vistaPrevia.Document = printDoc;
            vistaPrevia.ShowDialog();
        }

        // Dibuja el contenido del carnet en la hoja de impresión
        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            float y = 100;
            Font fuenteTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fuenteTexto = new Font("Arial", 12);

            e.Graphics.DrawString("CLUB DEPORTIVO - CARNET DE SOCIO", fuenteTitulo, Brushes.Black, 100, y);
            y += 50;
            e.Graphics.DrawString("Nombre: " + nombreSocio, fuenteTexto, Brushes.Black, 100, y);
            y += 30;
            e.Graphics.DrawString("Número de Carnet: " + carnetActual.NumeroCarnet, fuenteTexto, Brushes.Black, 100, y);
            y += 30;
            e.Graphics.DrawString("Fecha de Emisión: " + carnetActual.FechaEmision.ToShortDateString(), fuenteTexto, Brushes.Black, 100, y);
        }
    }
}
