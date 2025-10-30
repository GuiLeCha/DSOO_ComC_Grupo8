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
            btnRegistrarSocio = new Button();
            btnActividades = new Button();
            btnReportes = new Button();
            btnSalir = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnRegistrarSocio
            // 
            btnRegistrarSocio.Location = new Point(136, 41);
            btnRegistrarSocio.Name = "btnRegistrarSocio";
            btnRegistrarSocio.Size = new Size(84, 66);
            btnRegistrarSocio.TabIndex = 0;
            btnRegistrarSocio.Text = "Registrar nuevo Socio";
            btnRegistrarSocio.UseVisualStyleBackColor = true;
            btnRegistrarSocio.Click += btnRegistrarSocio_Click;
            // 
            // btnActividades
            // 
            btnActividades.Location = new Point(399, 128);
            btnActividades.Name = "btnActividades";
            btnActividades.Size = new Size(84, 61);
            btnActividades.TabIndex = 3;
            btnActividades.Text = "Actividades";
            btnActividades.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(136, 128);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(84, 61);
            btnReportes.TabIndex = 2;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(271, 207);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(84, 46);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // button1
            // 
            button1.Location = new Point(399, 41);
            button1.Name = "button1";
            button1.Size = new Size(84, 66);
            button1.TabIndex = 1;
            button1.Text = "Registrar nuevo NoSocio";
            button1.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(700, 338);
            Controls.Add(button1);
            Controls.Add(btnSalir);
            Controls.Add(btnReportes);
            Controls.Add(btnActividades);
            Controls.Add(btnRegistrarSocio);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmMenu";
            Text = "Club Deportivo - Menú Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegistrarSocio;
        private Button btnActividades;
        private Button btnReportes;
        private Button btnSalir;
        private Button button1;
    }
}