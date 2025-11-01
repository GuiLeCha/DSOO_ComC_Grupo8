namespace ClubDeportivo.Formularios
{
    partial class FrmMenu
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
            btnRegistrarPersona = new Button();
            btnPagos = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnRegistrarPersona
            // 
            btnRegistrarPersona.Location = new Point(238, 26);
            btnRegistrarPersona.Margin = new Padding(3, 4, 3, 4);
            btnRegistrarPersona.Name = "btnRegistrarPersona";
            btnRegistrarPersona.Size = new Size(268, 88);
            btnRegistrarPersona.TabIndex = 0;
            btnRegistrarPersona.Text = "Registrar Persona (Socio / No Socio)";
            btnRegistrarPersona.UseVisualStyleBackColor = true;
            btnRegistrarPersona.Click += btnRegistrarSocio_Click;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(238, 250);
            btnPagos.Margin = new Padding(3, 4, 3, 4);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(268, 81);
            btnPagos.TabIndex = 3;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(238, 142);
            btnReportes.Margin = new Padding(3, 4, 3, 4);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(268, 81);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(238, 353);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(268, 61);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(800, 451);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnPagos);
            Controls.Add(btnRegistrarPersona);
            Name = "FrmMenu";
            Text = "Club Deportivo - Menú Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarPersona;
        private Button btnPagos;
        private Button btnReportes;
        private Button btnSalir;
    }
}