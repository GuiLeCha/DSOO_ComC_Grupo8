namespace ClubDeportivo.Formularios
{
    partial class FrmRegistrarPersona
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblNumeroDocumento = new System.Windows.Forms.Label();
            this.cboTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblTipoDocumento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.grpTipoApto = new System.Windows.Forms.GroupBox();
            this.txtObservacionesApto = new System.Windows.Forms.TextBox();
            this.lblObservacionesApto = new System.Windows.Forms.Label();
            this.chkAptoPresentado = new System.Windows.Forms.CheckBox();
            this.rdbNoSocio = new System.Windows.Forms.RadioButton();
            this.rdbSocio = new System.Windows.Forms.RadioButton();
            this.grpDatosSocio = new System.Windows.Forms.GroupBox();
            this.dtpFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.grpDatosPersonales.SuspendLayout();
            this.grpTipoApto.SuspendLayout();
            this.grpDatosSocio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(160, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(356, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Registro de Persona (Socio / No Socio)";
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpDatosPersonales.Controls.Add(this.dtpFechaNacimiento);
            this.grpDatosPersonales.Controls.Add(this.lblFechaNacimiento);
            this.grpDatosPersonales.Controls.Add(this.txtEmail);
            this.grpDatosPersonales.Controls.Add(this.lblEmail);
            this.grpDatosPersonales.Controls.Add(this.txtTelefono);
            this.grpDatosPersonales.Controls.Add(this.lblTelefono);
            this.grpDatosPersonales.Controls.Add(this.txtDireccion);
            this.grpDatosPersonales.Controls.Add(this.lblDireccion);
            this.grpDatosPersonales.Controls.Add(this.txtNumeroDocumento);
            this.grpDatosPersonales.Controls.Add(this.lblNumeroDocumento);
            this.grpDatosPersonales.Controls.Add(this.cboTipoDocumento);
            this.grpDatosPersonales.Controls.Add(this.lblTipoDocumento);
            this.grpDatosPersonales.Controls.Add(this.txtApellido);
            this.grpDatosPersonales.Controls.Add(this.lblApellido);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(20, 45);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(650, 190);
            this.grpDatosPersonales.TabIndex = 1;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(130, 161);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(101, 23);
            this.dtpFechaNacimiento.TabIndex = 15;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 165);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(106, 15);
            this.lblFechaNacimiento.TabIndex = 14;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(420, 132);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(180, 23);
            this.txtEmail.TabIndex = 13;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(340, 135);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(39, 15);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "Email:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(130, 132);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(180, 23);
            this.txtTelefono.TabIndex = 11;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(20, 135);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(55, 15);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(130, 97);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(470, 23);
            this.txtDireccion.TabIndex = 9;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(20, 100);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(60, 15);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(420, 61);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(180, 23);
            this.txtNumeroDocumento.TabIndex = 7;
            // 
            // lblNumeroDocumento
            // 
            this.lblNumeroDocumento.AutoSize = true;
            this.lblNumeroDocumento.Location = new System.Drawing.Point(340, 65);
            this.lblNumeroDocumento.Name = "lblNumeroDocumento";
            this.lblNumeroDocumento.Size = new System.Drawing.Size(69, 15);
            this.lblNumeroDocumento.TabIndex = 6;
            this.lblNumeroDocumento.Text = "N° Docum.:";
            // 
            // cboTipoDocumento
            // 
            this.cboTipoDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoDocumento.FormattingEnabled = true;
            this.cboTipoDocumento.Items.AddRange(new object[] {
            "DNI",
            "LC",
            "LE"});
            this.cboTipoDocumento.Location = new System.Drawing.Point(130, 61);
            this.cboTipoDocumento.Name = "cboTipoDocumento";
            this.cboTipoDocumento.Size = new System.Drawing.Size(180, 23);
            this.cboTipoDocumento.TabIndex = 5;
            // 
            // lblTipoDocumento
            // 
            this.lblTipoDocumento.AutoSize = true;
            this.lblTipoDocumento.Location = new System.Drawing.Point(20, 65);
            this.lblTipoDocumento.Name = "lblTipoDocumento";
            this.lblTipoDocumento.Size = new System.Drawing.Size(99, 15);
            this.lblTipoDocumento.TabIndex = 4;
            this.lblTipoDocumento.Text = "Tipo Documento:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(420, 27);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(180, 23);
            this.txtApellido.TabIndex = 3;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(340, 30);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 15);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(180, 23);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 30);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // grpTipoApto
            // 
            this.grpTipoApto.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpTipoApto.Controls.Add(this.txtObservacionesApto);
            this.grpTipoApto.Controls.Add(this.lblObservacionesApto);
            this.grpTipoApto.Controls.Add(this.chkAptoPresentado);
            this.grpTipoApto.Controls.Add(this.rdbNoSocio);
            this.grpTipoApto.Controls.Add(this.rdbSocio);
            this.grpTipoApto.Location = new System.Drawing.Point(20, 245);
            this.grpTipoApto.Name = "grpTipoApto";
            this.grpTipoApto.Size = new System.Drawing.Size(650, 100);
            this.grpTipoApto.TabIndex = 2;
            this.grpTipoApto.TabStop = false;
            this.grpTipoApto.Text = "Tipo de Persona y Apto Físico";
            // 
            // txtObservacionesApto
            // 
            this.txtObservacionesApto.Location = new System.Drawing.Point(350, 22);
            this.txtObservacionesApto.Multiline = true;
            this.txtObservacionesApto.Name = "txtObservacionesApto";
            this.txtObservacionesApto.Size = new System.Drawing.Size(260, 50);
            this.txtObservacionesApto.TabIndex = 12;
            // 
            // lblObservacionesApto
            // 
            this.lblObservacionesApto.AutoSize = true;
            this.lblObservacionesApto.Location = new System.Drawing.Point(250, 25);
            this.lblObservacionesApto.Name = "lblObservacionesApto";
            this.lblObservacionesApto.Size = new System.Drawing.Size(87, 15);
            this.lblObservacionesApto.TabIndex = 11;
            this.lblObservacionesApto.Text = "Observaciones:";
            // 
            // chkAptoPresentado
            // 
            this.chkAptoPresentado.AutoSize = true;
            this.chkAptoPresentado.Location = new System.Drawing.Point(30, 50);
            this.chkAptoPresentado.Name = "chkAptoPresentado";
            this.chkAptoPresentado.Size = new System.Drawing.Size(145, 19);
            this.chkAptoPresentado.TabIndex = 10;
            this.chkAptoPresentado.Text = "Apto físico presentado";
            this.chkAptoPresentado.UseVisualStyleBackColor = true;
            // 
            // rdbNoSocio
            // 
            this.rdbNoSocio.AutoSize = true;
            this.rdbNoSocio.Location = new System.Drawing.Point(120, 25);
            this.rdbNoSocio.Name = "rdbNoSocio";
            this.rdbNoSocio.Size = new System.Drawing.Size(73, 19);
            this.rdbNoSocio.TabIndex = 9;
            this.rdbNoSocio.TabStop = true;
            this.rdbNoSocio.Text = "No Socio";
            this.rdbNoSocio.UseVisualStyleBackColor = true;
            // 
            // rdbSocio
            // 
            this.rdbSocio.AutoSize = true;
            this.rdbSocio.Location = new System.Drawing.Point(30, 25);
            this.rdbSocio.Name = "rdbSocio";
            this.rdbSocio.Size = new System.Drawing.Size(54, 19);
            this.rdbSocio.TabIndex = 8;
            this.rdbSocio.TabStop = true;
            this.rdbSocio.Text = "Socio";
            this.rdbSocio.UseVisualStyleBackColor = true;
            //this.rdbSocio.CheckedChanged += new System.EventHandler(this.rdbSocio_CheckedChanged);
            // 
            // grpDatosSocio
            // 
            this.grpDatosSocio.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpDatosSocio.Controls.Add(this.dtpFechaIngreso);
            this.grpDatosSocio.Controls.Add(this.lblFechaIngreso);
            this.grpDatosSocio.Location = new System.Drawing.Point(20, 355);
            this.grpDatosSocio.Name = "grpDatosSocio";
            this.grpDatosSocio.Size = new System.Drawing.Size(650, 60);
            this.grpDatosSocio.TabIndex = 3;
            this.grpDatosSocio.TabStop = false;
            this.grpDatosSocio.Text = "Datos de Registro";
            // 
            // dtpFechaIngreso
            // 
            this.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaIngreso.Location = new System.Drawing.Point(130, 21);
            this.dtpFechaIngreso.Name = "dtpFechaIngreso";
            this.dtpFechaIngreso.Size = new System.Drawing.Size(101, 23);
            this.dtpFechaIngreso.TabIndex = 1;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(20, 25);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(83, 15);
            this.lblFechaIngreso.TabIndex = 0;
            this.lblFechaIngreso.Text = "Fecha Ingreso:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(160, 430);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(300, 430);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 30);
            this.btnLimpiar.TabIndex = 14;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(440, 430);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(120, 30);
            this.btnVolver.TabIndex = 15;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // FrmRegistrarPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(700, 480);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grpDatosSocio);
            this.Controls.Add(this.grpTipoApto);
            this.Controls.Add(this.grpDatosPersonales);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmRegistrarPersona";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Persona";
            this.Load += new System.EventHandler(this.FrmRegistrarPersona_Load);
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpTipoApto.ResumeLayout(false);
            this.grpTipoApto.PerformLayout();
            this.grpDatosSocio.ResumeLayout(false);
            this.grpDatosSocio.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cboTipoDocumento;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.GroupBox grpTipoApto;
        private System.Windows.Forms.RadioButton rdbSocio;
        private System.Windows.Forms.RadioButton rdbNoSocio;
        private System.Windows.Forms.CheckBox chkAptoPresentado;
        private System.Windows.Forms.TextBox txtObservacionesApto;
        private System.Windows.Forms.GroupBox grpDatosSocio;
        private System.Windows.Forms.DateTimePicker dtpFechaIngreso;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoDocumento;
        private System.Windows.Forms.Label lblNumeroDocumento;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.Label lblObservacionesApto;
    }
}
