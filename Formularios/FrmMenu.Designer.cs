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
            btnRegistrarPersona.Location = new Point(208, 20);
            btnRegistrarPersona.Name = "btnRegistrarPersona";
            btnRegistrarPersona.Size = new Size(234, 66);
            btnRegistrarPersona.TabIndex = 0;
            btnRegistrarPersona.Text = "Registrar Persona (Socio / No Socio)";
            btnRegistrarPersona.UseVisualStyleBackColor = true;
            btnRegistrarPersona.Click += btnRegistrarSocio_Click;
            // 
            // btnPagos
            // 
            btnPagos.Location = new Point(208, 101);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(234, 61);
            btnPagos.TabIndex = 3;
            btnPagos.Text = "Pagos";
            btnPagos.UseVisualStyleBackColor = true;
            btnPagos.Click += btnPagos_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(208, 188);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(234, 61);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(208, 265);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(234, 46);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnPagos);
            Controls.Add(btnRegistrarPersona);
            Margin = new Padding(3, 2, 3, 2);
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