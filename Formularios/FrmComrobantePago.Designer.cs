namespace ClubDeportivo
{
    partial class FrmComprobantePago
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
            this.pnlComprobante = new System.Windows.Forms.Panel();
            this.lblTexto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlComprobante.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlComprobante
            // 
            this.pnlComprobante.BackColor = System.Drawing.Color.White;
            this.pnlComprobante.Controls.Add(this.lblTexto);
            this.pnlComprobante.Controls.Add(this.lblTitulo);
            this.pnlComprobante.Controls.Add(this.pictureBox1);
            this.pnlComprobante.Location = new System.Drawing.Point(12, 12);
            this.pnlComprobante.Name = "pnlComprobante";
            this.pnlComprobante.Size = new System.Drawing.Size(480, 323);
            this.pnlComprobante.TabIndex = 0;
            // 
            // lblTexto
            // 
            this.lblTexto.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTexto.Location = new System.Drawing.Point(20, 80);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(440, 227);
            this.lblTexto.TabIndex = 2;
            this.lblTexto.Text = "Texto del comprobante";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(140, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(214, 25);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Comprobante de Pago";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClubDeportivo.Properties.Resources.Logo_byn;
            this.pictureBox1.Location = new System.Drawing.Point(20, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(90, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(189, 351);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 30);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir comprobante";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // FrmComrobantePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(504, 393);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pnlComprobante);
            this.Name = "FrmComrobantePago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprobante de Pago";
            this.Load += new System.EventHandler(this.FrmComprobantePago_Load);
            this.pnlComprobante.ResumeLayout(false);
            this.pnlComprobante.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlComprobante;
        private System.Windows.Forms.Label lblTexto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnImprimir;
    }
}
