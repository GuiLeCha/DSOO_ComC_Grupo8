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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(103, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre Apellido";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(24, 50);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "DNI";
            this.txtDni.Size = new System.Drawing.Size(150, 23);
            this.txtDni.TabIndex = 1;
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(24, 90);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PlaceholderText = "Monto";
            this.txtMonto.Size = new System.Drawing.Size(150, 23);
            this.txtMonto.TabIndex = 2;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(24, 130);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PlaceholderText = "Descripción";
            this.txtDescripcion.Size = new System.Drawing.Size(300, 23);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(190, 50);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(24, 170);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(120, 30);
            this.btnRegistrarPago.TabIndex = 5;
            this.btnRegistrarPago.Text = "Registrar pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // txtComprobante
            // 
            this.txtComprobante.Location = new System.Drawing.Point(24, 220);
            this.txtComprobante.Multiline = true;
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.ReadOnly = true;
            this.txtComprobante.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComprobante.Size = new System.Drawing.Size(500, 200);
            this.txtComprobante.TabIndex = 6;
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.txtComprobante);
            this.Controls.Add(this.btnRegistrarPago);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblNombre);
            this.Name = "FrmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Pagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegistrarPago;
        private System.Windows.Forms.TextBox txtComprobante;
    }
}
