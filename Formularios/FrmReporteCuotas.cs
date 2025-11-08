using ClubDeportivo.Conexion;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace ClubDeportivo.Formularios
{
    // Muestra un listado de socios con cuotas vencidas y permite imprimir el reporte
    public partial class FrmReporteCuotas : Form
    {
        private Conexion.Conexion con = new Conexion.Conexion();
        private PrintDocument printDocument = new PrintDocument();
        private DataTable datosCuotas;

        public FrmReporteCuotas()
        {
            InitializeComponent();
            // Asociamos el evento de impresión con el método que dibuja la página
            printDocument.PrintPage += new PrintPageEventHandler(ImprimirPagina);
        }

        private void FrmReporteCuotas_Load(object sender, EventArgs e)
        {
            // Carga los datos automáticamente al abrir el formulario
            CargarCuotasVencidas();
        }

        // Consulta las cuotas vencidas y las muestra en el DataGridView
        private void CargarCuotasVencidas()
        {
            try
            {
                using (MySqlConnection cn = con.AbrirConexion())
                {
                    string consulta = @"
                        SELECT 
                            p.numeroDocumento AS 'DNI',
                            p.nombre AS 'Nombre',
                            p.apellido AS 'Apellido',
                            p.email AS 'Email',
                            DATE_FORMAT(MAX(pa.fecha_pago), '%d/%m/%Y') AS 'Fecha de Último Pago',
                            DATE_FORMAT(DATE_ADD(MAX(pa.fecha_pago), INTERVAL 30 DAY), '%d/%m/%Y') AS 'Vencimiento'
                        FROM socios s
                        INNER JOIN persona p ON s.idPersona = p.idPersona
                        INNER JOIN pago pa ON pa.idPersona = p.idPersona
                        GROUP BY p.idPersona, p.numeroDocumento, p.nombre, p.apellido, p.email
                        HAVING DATE(DATE_ADD(MAX(pa.fecha_pago), INTERVAL 30 DAY)) = DATE(CURDATE())
                        ORDER BY p.apellido ASC;";

                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, cn);
                    datosCuotas = new DataTable();
                    adaptador.Fill(datosCuotas);
                    dgvCuotas.DataSource = datosCuotas;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Muestra una vista previa del reporte antes de imprimir
            if (datosCuotas == null || datosCuotas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Configuramos la orientación en horizontal
            printDocument.DefaultPageSettings.Landscape = true;

            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            vistaPrevia.Document = printDocument;
            vistaPrevia.WindowState = FormWindowState.Maximized;
            vistaPrevia.ShowDialog();
        }

        // Dibuja el contenido del reporte en la hoja de impresión
        // Dibuja el contenido del reporte en la hoja de impresión
        private void ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            // Configura la orientación horizontal de la hoja
            e.PageSettings.Landscape = true;

            // Márgenes y medidas base
            int margenIzq = 50;
            int margenSup = 80;
            int altoFila = 25;

            // Ajuste individual de columnas según el contenido
            int anchoDNI = 80;
            int anchoNombre = 100;
            int anchoApellido = 100;
            int anchoEmail = 200;
            int anchoUltimoPago = 130;
            int anchoVencimiento = 120;

            Font fuenteTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fuenteCabecera = new Font("Arial", 10, FontStyle.Bold);
            Font fuenteTexto = new Font("Arial", 10, FontStyle.Regular);

            // Encabezado principal
            e.Graphics.DrawString("CLUB DEPORTIVO - Sistema de Gestión", fuenteCabecera, Brushes.Black, margenIzq, 20);
            e.Graphics.DrawString($"Fecha de impresión: {DateTime.Now:dd/MM/yyyy}", fuenteTexto, Brushes.Black, margenIzq + 600, 20);
            e.Graphics.DrawString("Socios con Cuota Vencida al Día de Hoy", fuenteTitulo, Brushes.Black, margenIzq, 50);

            int x = margenIzq;
            int y = margenSup;

            // Encabezado de columnas
            e.Graphics.DrawString("DNI", fuenteCabecera, Brushes.Black, x, y);
            x += anchoDNI;
            e.Graphics.DrawString("Nombre", fuenteCabecera, Brushes.Black, x, y);
            x += anchoNombre;
            e.Graphics.DrawString("Apellido", fuenteCabecera, Brushes.Black, x, y);
            x += anchoApellido;
            e.Graphics.DrawString("Email", fuenteCabecera, Brushes.Black, x, y);
            x += anchoEmail;
            e.Graphics.DrawString("Fecha de Último Pago", fuenteCabecera, Brushes.Black, x, y);
            x += anchoUltimoPago;
            e.Graphics.DrawString("Vencimiento", fuenteCabecera, Brushes.Black, x, y);

            // Línea separadora bajo los encabezados
            e.Graphics.DrawLine(Pens.Black, margenIzq, y + altoFila - 5, margenIzq + anchoDNI + anchoNombre + anchoApellido + anchoEmail + anchoUltimoPago + anchoVencimiento, y + altoFila - 5);
            y += altoFila;

            // Filas del reporte
            foreach (DataRow fila in datosCuotas.Rows)
            {
                x = margenIzq;
                e.Graphics.DrawString(fila["DNI"].ToString(), fuenteTexto, Brushes.Black, x, y);
                x += anchoDNI;
                e.Graphics.DrawString(fila["Nombre"].ToString(), fuenteTexto, Brushes.Black, x, y);
                x += anchoNombre;
                e.Graphics.DrawString(fila["Apellido"].ToString(), fuenteTexto, Brushes.Black, x, y);
                x += anchoApellido;
                e.Graphics.DrawString(fila["Email"].ToString(), fuenteTexto, Brushes.Black, x, y);
                x += anchoEmail;
                e.Graphics.DrawString(fila["Fecha de Último Pago"].ToString(), fuenteTexto, Brushes.Black, x, y);
                x += anchoUltimoPago;
                e.Graphics.DrawString(fila["Vencimiento"].ToString(), fuenteTexto, Brushes.Black, x, y);

                y += altoFila;

                // Control de salto de página
                if (y > e.MarginBounds.Bottom - 50)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            e.HasMorePages = false;
        }

    }
}
