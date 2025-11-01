namespace ClubDeportivo
{
    partial class FrmComprobantePago
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Liberar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Form

        /// <summary>
        /// Método necesario para admitir el Diseñador.  
        /// No se puede modificar el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtComprobante
            // 
            this.txtComprobante.Location = new System.Drawing.Point(25, 25);
            this.txtComprobante.Multiline = true;
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.ReadOnly = true;
            this.txtComprobante.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComprobante.Size = new System.Drawing.Size(530, 320);
            this.txtComprobante.TabIndex = 0;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(230, 360);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 35);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir comprobante";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmComprobantePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 421);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtComprobante);
            this.Name = "FrmComprobantePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante de Pago";
            this.Load += new System.EventHandler(this.FrmComprobantePago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.Button btnImprimir;
    }
}
