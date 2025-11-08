namespace ClubDeportivo.Formularios
{
    partial class FrmMenu
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
            this.btnRegistrarPersona = new System.Windows.Forms.Button();
            this.btnPagos = new System.Windows.Forms.Button();
            this.btnReportes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistrarPersona
            // 
            this.btnRegistrarPersona.Location = new System.Drawing.Point(208, 20);
            this.btnRegistrarPersona.Name = "btnRegistrarPersona";
            this.btnRegistrarPersona.Size = new System.Drawing.Size(234, 66);
            this.btnRegistrarPersona.TabIndex = 0;
            this.btnRegistrarPersona.Text = "Registrar Persona (Socio / No Socio)";
            this.btnRegistrarPersona.UseVisualStyleBackColor = true;
            this.btnRegistrarPersona.Click += new System.EventHandler(this.btnRegistrarSocio_Click);
            // 
            // btnPagos
            // 
            this.btnPagos.Location = new System.Drawing.Point(208, 101);
            this.btnPagos.Name = "btnPagos";
            this.btnPagos.Size = new System.Drawing.Size(234, 61);
            this.btnPagos.TabIndex = 1;
            this.btnPagos.Text = "Pagos";
            this.btnPagos.UseVisualStyleBackColor = true;
            this.btnPagos.Click += new System.EventHandler(this.btnPagos_Click);
            // 
            // btnReportes
            // 
            this.btnReportes.Location = new System.Drawing.Point(208, 188);
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(234, 61);
            this.btnReportes.TabIndex = 2;
            this.btnReportes.Text = "Reportes";
            this.btnReportes.UseVisualStyleBackColor = true;
            this.btnReportes.Click += new System.EventHandler(this.btnReportes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(208, 265);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(234, 46);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnReportes);
            this.Controls.Add(this.btnPagos);
            this.Controls.Add(this.btnRegistrarPersona);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Club Deportivo - Menú Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrarPersona;
        private System.Windows.Forms.Button btnPagos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnSalir;
    }
}
