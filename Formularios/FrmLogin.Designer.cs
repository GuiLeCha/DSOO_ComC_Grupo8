namespace ClubDeportivo.Formularios
{
    partial class FrmLogin
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.pnlLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlLogin.Controls.Add(this.lblTitulo);
            this.pnlLogin.Controls.Add(this.btnSalir);
            this.pnlLogin.Controls.Add(this.btnIngresar);
            this.pnlLogin.Controls.Add(this.txtClave);
            this.pnlLogin.Controls.Add(this.txtUsuario);
            this.pnlLogin.Controls.Add(this.lblClave);
            this.pnlLogin.Controls.Add(this.lblUsuario);
            this.pnlLogin.Location = new System.Drawing.Point(280, 30);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(310, 220);
            this.pnlLogin.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(50, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(205, 21);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Ingreso al Club Deportivo";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(165, 160);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 30);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(30, 160);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(120, 30);
            this.btnIngresar.TabIndex = 5;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(115, 110);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(170, 23);
            this.txtClave.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(115, 70);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(170, 23);
            this.txtUsuario.TabIndex = 3;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(30, 113);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(70, 15);
            this.lblClave.TabIndex = 2;
            this.lblClave.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(30, 73);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuario:";
            // 
            // logo
            // 
            this.logo.Image = global::ClubDeportivo.Properties.Resources.Logo_color;
            this.logo.Location = new System.Drawing.Point(12, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(250, 250);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(610, 280);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Deportivo - Inicio de sesión";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox logo;
    }
}
