using ClubDeportivo.Conexion;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Drawing.Printing;

namespace ClubDeportivo.Formularios
{
    public partial class FrmReporteCuotas : Form
    {
        private Conexion.Conexion con = new Conexion.Conexion();
        private PrintDocument printDocument = new PrintDocument();
        private DataTable datosCuotas;

        public FrmReporteCuotas()
        {
            InitializeComponent();
            printDocument.PrintPage += new PrintPageEventHandler(ImprimirPagina);
        }

        private void FrmReporteCuotas_Load(object sender, EventArgs e)
        {
            CargarCuotasVencidas();
        }

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
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (datosCuotas == null || datosCuotas.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para imprimir.", "Atención",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            PrintPreviewDialog vistaPrevia = new PrintPreviewDialog();
            vistaPrevia.Document = printDocument;
            vistaPrevia.WindowState = FormWindowState.Maximized;
            vistaPrevia.ShowDialog();
        }

        private void ImprimirPagina(object sender, PrintPageEventArgs e)
        {
            int margenIzq = 50;
            int margenSup = 80;
            int altoFila = 25;
            int anchoCol = 130;
            Font fuenteTitulo = new Font("Arial", 14, FontStyle.Bold);
            Font fuenteCabecera = new Font("Arial", 10, FontStyle.Bold);
            Font fuenteTexto = new Font("Arial", 10, FontStyle.Regular);

            e.Graphics.DrawString("CLUB DEPORTIVO - Sistema de Gestión", fuenteCabecera, Brushes.Black, margenIzq, 20);
            e.Graphics.DrawString($"Fecha de impresión: {DateTime.Now:dd/MM/yyyy}", fuenteTexto, Brushes.Black, margenIzq + 450, 20);
            e.Graphics.DrawString("Socios con Cuota Vencida al Día de Hoy", fuenteTitulo, Brushes.Black, margenIzq, 50);

            int x = margenIzq;
            int y = margenSup;

            foreach (DataColumn col in datosCuotas.Columns)
            {
                e.Graphics.DrawString(col.ColumnName, fuenteCabecera, Brushes.Black, x, y);
                x += anchoCol;
            }
            e.Graphics.DrawLine(Pens.Black, margenIzq, y + altoFila - 5, margenIzq + anchoCol * datosCuotas.Columns.Count, y + altoFila - 5);
            y += altoFila;

            foreach (DataRow fila in datosCuotas.Rows)
            {
                x = margenIzq;
                for (int i = 0; i < datosCuotas.Columns.Count; i++)
                {
                    e.Graphics.DrawString(fila[i]?.ToString(), fuenteTexto, Brushes.Black, x, y);
                    x += anchoCol;
                }
                y += altoFila;
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
