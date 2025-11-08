namespace ClubDeportivo
{
    partial class FrmPagos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpBusqueda = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTipoTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreTitulo = new System.Windows.Forms.Label();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.lblMedioPago = new System.Windows.Forms.Label();
            this.cboFormaPago = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.lblMonto = new System.Windows.Forms.Label();
            this.btnRegistrarPago = new System.Windows.Forms.Button();
            this.grpBusqueda.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.grpPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBusqueda
            // 
            this.grpBusqueda.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpBusqueda.Controls.Add(this.btnBuscar);
            this.grpBusqueda.Controls.Add(this.txtDni);
            this.grpBusqueda.Controls.Add(this.lblDni);
            this.grpBusqueda.Location = new System.Drawing.Point(12, 12);
            this.grpBusqueda.Name = "grpBusqueda";
            this.grpBusqueda.Size = new System.Drawing.Size(536, 64);
            this.grpBusqueda.TabIndex = 0;
            this.grpBusqueda.TabStop = false;
            this.grpBusqueda.Text = "Búsqueda por DNI";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(370, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(120, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(74, 24);
            this.txtDni.Name = "txtDni";
            this.txtDni.PlaceholderText = "DNI";
            this.txtDni.Size = new System.Drawing.Size(280, 23);
            this.txtDni.TabIndex = 1;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(22, 28);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(30, 15);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpDatos.Controls.Add(this.lblTipo);
            this.grpDatos.Controls.Add(this.lblTipoTitulo);
            this.grpDatos.Controls.Add(this.lblNombre);
            this.grpDatos.Controls.Add(this.lblNombreTitulo);
            this.grpDatos.Location = new System.Drawing.Point(12, 82);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(536, 70);
            this.grpDatos.TabIndex = 1;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos de la persona";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(321, 31);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(0, 15);
            this.lblTipo.TabIndex = 3;
            // 
            // lblTipoTitulo
            // 
            this.lblTipoTitulo.AutoSize = true;
            this.lblTipoTitulo.Location = new System.Drawing.Point(275, 31);
            this.lblTipoTitulo.Name = "lblTipoTitulo";
            this.lblTipoTitulo.Size = new System.Drawing.Size(33, 15);
            this.lblTipoTitulo.TabIndex = 2;
            this.lblTipoTitulo.Text = "Tipo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(78, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 15);
            this.lblNombre.TabIndex = 1;
            // 
            // lblNombreTitulo
            // 
            this.lblNombreTitulo.AutoSize = true;
            this.lblNombreTitulo.Location = new System.Drawing.Point(22, 31);
            this.lblNombreTitulo.Name = "lblNombreTitulo";
            this.lblNombreTitulo.Size = new System.Drawing.Size(54, 15);
            this.lblNombreTitulo.TabIndex = 0;
            this.lblNombreTitulo.Text = "Nombre:";
            // 
            // grpPago
            // 
            this.grpPago.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpPago.Controls.Add(this.lblMedioPago);
            this.grpPago.Controls.Add(this.cboFormaPago);
            this.grpPago.Controls.Add(this.txtDescripcion);
            this.grpPago.Controls.Add(this.lblDescripcion);
            this.grpPago.Controls.Add(this.txtMonto);
            this.grpPago.Controls.Add(this.lblMonto);
            this.grpPago.Controls.Add(this.btnRegistrarPago);
            this.grpPago.Location = new System.Drawing.Point(12, 158);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(536, 126);
            this.grpPago.TabIndex = 2;
            this.grpPago.TabStop = false;
            this.grpPago.Text = "Datos del pago";
            // 
            // lblMedioPago
            // 
            this.lblMedioPago.AutoSize = true;
            this.lblMedioPago.Location = new System.Drawing.Point(202, 28);
            this.lblMedioPago.Name = "lblMedioPago";
            this.lblMedioPago.Size = new System.Drawing.Size(90, 15);
            this.lblMedioPago.TabIndex = 3;
            this.lblMedioPago.Text = "Medio de pago:";
            // 
            // cboFormaPago
            // 
            this.cboFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFormaPago.FormattingEnabled = true;
            this.cboFormaPago.Location = new System.Drawing.Point(298, 24);
            this.cboFormaPago.Name = "cboFormaPago";
            this.cboFormaPago.Size = new System.Drawing.Size(192, 23);
            this.cboFormaPago.TabIndex = 4;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(98, 57);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PlaceholderText = "Detalle del pago";
            this.txtDescripcion.Size = new System.Drawing.Size(392, 23);
            this.txtDescripcion.TabIndex = 6;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(22, 61);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(72, 15);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(73, 24);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.PlaceholderText = "Monto";
            this.txtMonto.Size = new System.Drawing.Size(112, 23);
            this.txtMonto.TabIndex = 2;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(22, 28);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(46, 15);
            this.lblMonto.TabIndex = 1;
            this.lblMonto.Text = "Monto:";
            // 
            // btnRegistrarPago
            // 
            this.btnRegistrarPago.Location = new System.Drawing.Point(370, 90);
            this.btnRegistrarPago.Name = "btnRegistrarPago";
            this.btnRegistrarPago.Size = new System.Drawing.Size(120, 25);
            this.btnRegistrarPago.TabIndex = 7;
            this.btnRegistrarPago.Text = "Registrar pago";
            this.btnRegistrarPago.UseVisualStyleBackColor = true;
            this.btnRegistrarPago.Click += new System.EventHandler(this.btnRegistrarPago_Click);
            // 
            // FrmPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(560, 300);
            this.Controls.Add(this.grpPago);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.grpBusqueda);
            this.Name = "FrmPagos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión de Pagos";
            this.Load += new System.EventHandler(this.FrmPagos_Load);
            this.grpBusqueda.ResumeLayout(false);
            this.grpBusqueda.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpPago.ResumeLayout(false);
            this.grpPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBusqueda;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTipoTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreTitulo;
        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.Label lblMedioPago;
        private System.Windows.Forms.ComboBox cboFormaPago;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Button btnRegistrarPago;
    }
}
