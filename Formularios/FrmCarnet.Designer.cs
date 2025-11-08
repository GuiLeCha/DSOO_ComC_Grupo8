namespace ClubDeportivo
{
    partial class FrmCarnet
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblEmision = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlCarnet = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlCarnet.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(101, 7);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(157, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Carnet del Socio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(147, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(98, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Apellido";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(147, 103);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(81, 15);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Nro de Carnet";
            // 
            // lblEmision
            // 
            this.lblEmision.AutoSize = true;
            this.lblEmision.Location = new System.Drawing.Point(147, 139);
            this.lblEmision.Name = "lblEmision";
            this.lblEmision.Size = new System.Drawing.Size(83, 15);
            this.lblEmision.TabIndex = 3;
            this.lblEmision.Text = "Fecha Emisión";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(138, 221);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(120, 30);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimir carnet";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClubDeportivo.Properties.Resources.Logo_color;
            this.pictureBox1.Location = new System.Drawing.Point(12, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pnlCarnet
            // 
            this.pnlCarnet.Controls.Add(this.lblTitulo);
            this.pnlCarnet.Controls.Add(this.pictureBox1);
            this.pnlCarnet.Controls.Add(this.lblNombre);
            this.pnlCarnet.Controls.Add(this.lblEmision);
            this.pnlCarnet.Controls.Add(this.lblNumero);
            this.pnlCarnet.Location = new System.Drawing.Point(0, 12);
            this.pnlCarnet.Name = "pnlCarnet";
            this.pnlCarnet.Size = new System.Drawing.Size(360, 203);
            this.pnlCarnet.TabIndex = 6;
            // 
            // FrmCarnet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(372, 263);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.pnlCarnet);
            this.Name = "FrmCarnet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carnet del Socio";
            this.Load += new System.EventHandler(this.FrmCarnet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlCarnet.ResumeLayout(false);
            this.pnlCarnet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblEmision;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlCarnet;
    }
}
