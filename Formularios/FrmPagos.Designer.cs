namespace ClubDeportivo
{
    partial class FrmPagos
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblNombre = new Label();
            txtDni = new TextBox();
            txtMonto = new TextBox();
            txtDescripcion = new TextBox();
            btnBuscar = new Button();
            btnRegistrarPago = new Button();
            txtComprobante = new TextBox();
            cboFormaPago = new ComboBox();
            lblMedioPago = new Label();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 20);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(98, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre Apellido";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(24, 50);
            txtDni.Name = "txtDni";
            txtDni.PlaceholderText = "DNI";
            txtDni.Size = new Size(150, 23);
            txtDni.TabIndex = 1;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(24, 90);
            txtMonto.Name = "txtMonto";
            txtMonto.PlaceholderText = "Monto";
            txtMonto.Size = new Size(150, 23);
            txtMonto.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(24, 130);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.PlaceholderText = "Descripción";
            txtDescripcion.Size = new Size(300, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(190, 50);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(80, 23);
            btnBuscar.TabIndex = 4;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnRegistrarPago
            // 
            btnRegistrarPago.Location = new Point(24, 170);
            btnRegistrarPago.Name = "btnRegistrarPago";
            btnRegistrarPago.Size = new Size(120, 30);
            btnRegistrarPago.TabIndex = 5;
            btnRegistrarPago.Text = "Registrar pago";
            btnRegistrarPago.UseVisualStyleBackColor = true;
            btnRegistrarPago.Click += btnRegistrarPago_Click;
            // 
            // txtComprobante
            // 
            txtComprobante.Location = new Point(24, 220);
            txtComprobante.Multiline = true;
            txtComprobante.Name = "txtComprobante";
            txtComprobante.ReadOnly = true;
            txtComprobante.ScrollBars = ScrollBars.Vertical;
            txtComprobante.Size = new Size(500, 200);
            txtComprobante.TabIndex = 6;
            // 
            // cboFormaPago
            // 
            cboFormaPago.FormattingEnabled = true;
            cboFormaPago.Location = new Point(301, 90);
            cboFormaPago.Name = "cboFormaPago";
            cboFormaPago.Size = new Size(121, 23);
            cboFormaPago.TabIndex = 7;
            // 
            // lblMedioPago
            // 
            lblMedioPago.AutoSize = true;
            lblMedioPago.Location = new Point(205, 94);
            lblMedioPago.Name = "lblMedioPago";
            lblMedioPago.Size = new Size(90, 15);
            lblMedioPago.TabIndex = 8;
            lblMedioPago.Text = "Medio de pago:";
            // 
            // FrmPagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 450);
            Controls.Add(lblMedioPago);
            Controls.Add(cboFormaPago);
            Controls.Add(txtComprobante);
            Controls.Add(btnRegistrarPago);
            Controls.Add(btnBuscar);
            Controls.Add(txtDescripcion);
            Controls.Add(txtMonto);
            Controls.Add(txtDni);
            Controls.Add(lblNombre);
            Name = "FrmPagos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Pagos";
            Load += FrmPagos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.TextBox txtComprobante;
        private ComboBox cboFormaPago;
        private Label lblMedioPago;
    }
}
