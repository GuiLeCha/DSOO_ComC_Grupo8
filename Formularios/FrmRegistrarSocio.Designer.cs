namespace ClubDeportivo.Formularios
{
    partial class FrmRegistrarSocio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            cboTipoDocumento = new ComboBox();
            txtNumeroDocumento = new TextBox();
            txtDireccion = new TextBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            dtpFechaNacimiento = new DateTimePicker();
            txtNroSocio = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            chkCuotaVigente = new CheckBox();
            btnGuardar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            lblDatosPersonales = new Label();
            lblDatosDeSocio = new Label();
            lblNombre = new Label();
            lblApellido = new Label();
            lblTipoDocumento = new Label();
            lblNumeroDocumento = new Label();
            lblDireccion = new Label();
            lblTelefono = new Label();
            lblEmail = new Label();
            lblFechaNacimiento = new Label();
            lbltxtNroSocio = new Label();
            lblFechaIngreso = new Label();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(158, 63);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(212, 27);
            txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(510, 63);
            txtApellido.Margin = new Padding(3, 4, 3, 4);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(206, 27);
            txtApellido.TabIndex = 1;
            // 
            // cboTipoDocumento
            // 
            cboTipoDocumento.FormattingEnabled = true;
            cboTipoDocumento.Location = new Point(232, 106);
            cboTipoDocumento.Margin = new Padding(3, 4, 3, 4);
            cboTipoDocumento.Name = "cboTipoDocumento";
            cboTipoDocumento.Size = new Size(138, 28);
            cboTipoDocumento.TabIndex = 2;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(584, 101);
            txtNumeroDocumento.Margin = new Padding(3, 4, 3, 4);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(132, 27);
            txtNumeroDocumento.TabIndex = 3;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(165, 140);
            txtDireccion.Margin = new Padding(3, 4, 3, 4);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(551, 27);
            txtDireccion.TabIndex = 4;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(165, 176);
            txtTelefono.Margin = new Padding(3, 4, 3, 4);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(145, 27);
            txtTelefono.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(520, 179);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(196, 27);
            txtEmail.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(255, 211);
            dtpFechaNacimiento.Margin = new Padding(3, 4, 3, 4);
            dtpFechaNacimiento.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpFechaNacimiento.MinDate = new DateTime(1800, 1, 1, 0, 0, 0, 0);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(115, 27);
            dtpFechaNacimiento.TabIndex = 7;
            dtpFechaNacimiento.UseWaitCursor = true;
            // 
            // txtNroSocio
            // 
            txtNroSocio.Location = new Point(214, 376);
            txtNroSocio.Margin = new Padding(3, 4, 3, 4);
            txtNroSocio.Name = "txtNroSocio";
            txtNroSocio.ReadOnly = true;
            txtNroSocio.Size = new Size(114, 27);
            txtNroSocio.TabIndex = 8;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.Format = DateTimePickerFormat.Short;
            dtpFechaIngreso.Location = new Point(214, 341);
            dtpFechaIngreso.Margin = new Padding(3, 4, 3, 4);
            dtpFechaIngreso.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dtpFechaIngreso.MinDate = new DateTime(1800, 1, 1, 0, 0, 0, 0);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(115, 27);
            dtpFechaIngreso.TabIndex = 9;
            // 
            // chkCuotaVigente
            // 
            chkCuotaVigente.AutoSize = true;
            chkCuotaVigente.Location = new Point(377, 361);
            chkCuotaVigente.Margin = new Padding(3, 4, 3, 4);
            chkCuotaVigente.Name = "chkCuotaVigente";
            chkCuotaVigente.Size = new Size(123, 24);
            chkCuotaVigente.TabIndex = 10;
            chkCuotaVigente.Text = "Cuota vigente";
            chkCuotaVigente.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(175, 476);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 61);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(377, 476);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(90, 63);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(584, 476);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(87, 60);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "Volver al menú";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblDatosPersonales
            // 
            lblDatosPersonales.AutoSize = true;
            lblDatosPersonales.Location = new Point(153, 24);
            lblDatosPersonales.Name = "lblDatosPersonales";
            lblDatosPersonales.Size = new Size(121, 20);
            lblDatosPersonales.TabIndex = 14;
            lblDatosPersonales.Text = "Datos Personales";
            // 
            // lblDatosDeSocio
            // 
            lblDatosDeSocio.AutoSize = true;
            lblDatosDeSocio.Location = new Point(154, 304);
            lblDatosDeSocio.Name = "lblDatosDeSocio";
            lblDatosDeSocio.Size = new Size(110, 20);
            lblDatosDeSocio.TabIndex = 15;
            lblDatosDeSocio.Text = "Datos de Socio";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(84, 64);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 16;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(431, 66);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(69, 20);
            lblApellido.TabIndex = 17;
            lblApellido.Text = "Apellido:";
            // 
            // lblTipoDocumento
            // 
            lblTipoDocumento.AutoSize = true;
            lblTipoDocumento.Location = new Point(84, 109);
            lblTipoDocumento.Name = "lblTipoDocumento";
            lblTipoDocumento.Size = new Size(142, 20);
            lblTipoDocumento.TabIndex = 18;
            lblTipoDocumento.Text = "Tipo de Documento";
            // 
            // lblNumeroDocumento
            // 
            lblNumeroDocumento.AutoSize = true;
            lblNumeroDocumento.Location = new Point(431, 101);
            lblNumeroDocumento.Name = "lblNumeroDocumento";
            lblNumeroDocumento.Size = new Size(129, 20);
            lblNumeroDocumento.TabIndex = 19;
            lblNumeroDocumento.Text = "Num. Documento:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(84, 143);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(75, 20);
            lblDireccion.TabIndex = 20;
            lblDireccion.Text = "Direccion:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(84, 179);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 21;
            lblTelefono.Text = "Teléfono:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(465, 182);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(49, 20);
            lblEmail.TabIndex = 22;
            lblEmail.Text = "Email:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Location = new Point(84, 216);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(152, 20);
            lblFechaNacimiento.TabIndex = 23;
            lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lbltxtNroSocio
            // 
            lbltxtNroSocio.AutoSize = true;
            lbltxtNroSocio.Location = new Point(84, 376);
            lbltxtNroSocio.Name = "lbltxtNroSocio";
            lbltxtNroSocio.Size = new Size(78, 20);
            lbltxtNroSocio.TabIndex = 24;
            lbltxtNroSocio.Text = "Nro Socio:";
            // 
            // lblFechaIngreso
            // 
            lblFechaIngreso.AutoSize = true;
            lblFechaIngreso.Location = new Point(84, 339);
            lblFechaIngreso.Name = "lblFechaIngreso";
            lblFechaIngreso.Size = new Size(124, 20);
            lblFechaIngreso.TabIndex = 25;
            lblFechaIngreso.Text = "Fecha de Ingreso:";
            // 
            // FrmRegistrarSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(914, 600);
            Controls.Add(lblFechaIngreso);
            Controls.Add(lbltxtNroSocio);
            Controls.Add(lblFechaNacimiento);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefono);
            Controls.Add(lblDireccion);
            Controls.Add(lblNumeroDocumento);
            Controls.Add(lblTipoDocumento);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(lblDatosDeSocio);
            Controls.Add(lblDatosPersonales);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGuardar);
            Controls.Add(chkCuotaVigente);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(txtNroSocio);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(txtNumeroDocumento);
            Controls.Add(cboTipoDocumento);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmRegistrarSocio";
            Text = "Club Deportivo - Registrar Nuevo Socio";
            Load += FrmRegistrarSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtApellido;
        private ComboBox cboTipoDocumento;
        private TextBox txtNumeroDocumento;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private DateTimePicker dtpFechaNacimiento;
        private TextBox txtNroSocio;
        private DateTimePicker dtpFechaIngreso;
        private CheckBox chkCuotaVigente;
        private Button btnGuardar;
        private Button btnLimpiar;
        private Button btnVolver;
        private Label lblDatosPersonales;
        private Label lblDatosDeSocio;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblTipoDocumento;
        private Label lblNumeroDocumento;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblEmail;
        private Label lblFechaNacimiento;
        private Label lbltxtNroSocio;
        private Label lblFechaIngreso;
    }
}