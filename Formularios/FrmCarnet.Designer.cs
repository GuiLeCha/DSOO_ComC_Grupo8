namespace ClubDeportivo
{
    partial class FrmCarnet
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEmision = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(60, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(175, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Carnet del Socio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(60, 70);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Apellido";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(60, 100);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(90, 15);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Nro de Carnet";
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Location = new System.Drawing.Point(60, 130);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(83, 15);
            this.lblEmision.TabIndex = 3;
            this.lblEmision.Text = "Fecha Emisión";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(90, 165);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 30);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir carnet";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 220);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.lblEmision);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmCarnet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carnet del Socio";
            this.Load += new System.EventHandler(this.FrmCarnet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.Button btnImprimir;
    }
}
