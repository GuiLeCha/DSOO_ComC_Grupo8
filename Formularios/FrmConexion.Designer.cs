namespace ClubDeportivo.Formularios
{
    partial class FrmConexion : Form
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
            lblServidor = new Label();
            txtServidor = new TextBox();
            lblPuerto = new Label();
            lblBase = new Label();
            lblUsuario = new Label();
            lblClave = new Label();
            txtPuerto = new TextBox();
            txtBase = new TextBox();
            txtUsuario = new TextBox();
            txtClave = new TextBox();
            btnProbar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblServidor
            // 
            lblServidor.AutoSize = true;
            lblServidor.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblServidor.Location = new Point(35, 35);
            lblServidor.Name = "lblServidor";
            lblServidor.Size = new Size(53, 15);
            lblServidor.TabIndex = 0;
            lblServidor.Text = "Servidor:";
            // 
            // txtServidor
            // 
            txtServidor.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtServidor.Location = new Point(150, 32);
            txtServidor.Name = "txtServidor";
            txtServidor.Size = new Size(220, 25);
            txtServidor.TabIndex = 0;
            // 
            // lblPuerto
            // 
            lblPuerto.AutoSize = true;
            lblPuerto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lblPuerto.Location = new Point(35, 76);
            lblPuerto.Name = "lblPuerto";
            lblPuerto.Size = new Size(45, 15);
            lblPuerto.TabIndex = 2;
            lblPuerto.Text = "Puerto:";
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(35, 115);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(82, 15);
            lblBase.TabIndex = 3;
            lblBase.Text = "Base de datos:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(35, 155);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(50, 15);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            lblClave.AutoSize = true;
            lblClave.Location = new Point(35, 195);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(70, 15);
            lblClave.TabIndex = 5;
            lblClave.Text = "Contraseña:";
            // 
            // txtPuerto
            // 
            txtPuerto.Location = new Point(150, 72);
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(220, 23);
            txtPuerto.TabIndex = 1;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(150, 112);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(220, 23);
            txtBase.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(150, 152);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(220, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(150, 192);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(220, 23);
            txtClave.TabIndex = 4;
            // 
            // btnProbar
            // 
            btnProbar.BackColor = Color.LightSteelBlue;
            btnProbar.Location = new Point(38, 245);
            btnProbar.Name = "btnProbar";
            btnProbar.Size = new Size(105, 25);
            btnProbar.TabIndex = 5;
            btnProbar.Text = "Probar conexión";
            btnProbar.UseVisualStyleBackColor = false;
            btnProbar.Click += btnProbar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.PaleGreen;
            btnGuardar.Location = new Point(170, 245);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 25);
            btnGuardar.TabIndex = 6;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(280, 245);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(90, 25);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FrmConexion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(404, 281);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnProbar);
            Controls.Add(txtClave);
            Controls.Add(txtUsuario);
            Controls.Add(txtBase);
            Controls.Add(txtPuerto);
            Controls.Add(lblClave);
            Controls.Add(lblUsuario);
            Controls.Add(lblBase);
            Controls.Add(lblPuerto);
            Controls.Add(txtServidor);
            Controls.Add(lblServidor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FrmConexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conexión a la Base de Datos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblServidor;
        private TextBox txtServidor;
        private Label lblPuerto;
        private Label lblBase;
        private Label lblUsuario;
        private Label lblClave;
        private TextBox txtPuerto;
        private TextBox txtBase;
        private TextBox txtUsuario;
        private TextBox txtClave;
        private Button btnProbar;
        private Button btnGuardar;
        private Button btnCancelar;
    }
}