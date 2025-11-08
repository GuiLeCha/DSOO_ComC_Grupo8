namespace ClubDeportivo.Formularios
{
    partial class FrmConexion
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
            this.grpConexion = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.txtPuerto = new System.Windows.Forms.TextBox();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblBase = new System.Windows.Forms.Label();
            this.lblPuerto = new System.Windows.Forms.Label();
            this.lblServidor = new System.Windows.Forms.Label();
            this.btnProbar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.grpConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(85, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(295, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Configuración de Conexión MySQL";
            // 
            // grpConexion
            // 
            this.grpConexion.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpConexion.Controls.Add(this.txtClave);
            this.grpConexion.Controls.Add(this.txtUsuario);
            this.grpConexion.Controls.Add(this.txtBase);
            this.grpConexion.Controls.Add(this.txtPuerto);
            this.grpConexion.Controls.Add(this.txtServidor);
            this.grpConexion.Controls.Add(this.lblClave);
            this.grpConexion.Controls.Add(this.lblUsuario);
            this.grpConexion.Controls.Add(this.lblBase);
            this.grpConexion.Controls.Add(this.lblPuerto);
            this.grpConexion.Controls.Add(this.lblServidor);
            this.grpConexion.Location = new System.Drawing.Point(25, 55);
            this.grpConexion.Name = "grpConexion";
            this.grpConexion.Size = new System.Drawing.Size(400, 200);
            this.grpConexion.TabIndex = 1;
            this.grpConexion.TabStop = false;
            this.grpConexion.Text = "Parámetros de conexión";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(130, 152);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(240, 23);
            this.txtClave.TabIndex = 9;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(130, 122);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(240, 23);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(130, 92);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(240, 23);
            this.txtBase.TabIndex = 5;
            // 
            // txtPuerto
            // 
            this.txtPuerto.Location = new System.Drawing.Point(130, 62);
            this.txtPuerto.Name = "txtPuerto";
            this.txtPuerto.Size = new System.Drawing.Size(240, 23);
            this.txtPuerto.TabIndex = 3;
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(130, 32);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(240, 23);
            this.txtServidor.TabIndex = 1;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(25, 155);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(73, 15);
            this.lblClave.TabIndex = 8;
            this.lblClave.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(25, 125);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 15);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(25, 95);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(88, 15);
            this.lblBase.TabIndex = 4;
            this.lblBase.Text = "Base de datos:";
            // 
            // lblPuerto
            // 
            this.lblPuerto.AutoSize = true;
            this.lblPuerto.Location = new System.Drawing.Point(25, 65);
            this.lblPuerto.Name = "lblPuerto";
            this.lblPuerto.Size = new System.Drawing.Size(48, 15);
            this.lblPuerto.TabIndex = 2;
            this.lblPuerto.Text = "Puerto:";
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(25, 35);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(56, 15);
            this.lblServidor.TabIndex = 0;
            this.lblServidor.Text = "Servidor:";
            // 
            // btnProbar
            // 
            this.btnProbar.Location = new System.Drawing.Point(55, 270);
            this.btnProbar.Name = "btnProbar";
            this.btnProbar.Size = new System.Drawing.Size(120, 30);
            this.btnProbar.TabIndex = 10;
            this.btnProbar.Text = "Probar conexión";
            this.btnProbar.UseVisualStyleBackColor = true;
            this.btnProbar.Click += new System.EventHandler(this.btnProbar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(190, 270);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 30);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(325, 270);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 30);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(460, 320);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnProbar);
            this.Controls.Add(this.grpConexion);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmConexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conexión a la Base de Datos";
            this.grpConexion.ResumeLayout(false);
            this.grpConexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox grpConexion;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtPuerto;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.Label lblPuerto;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Button btnProbar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
