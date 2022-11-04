namespace PresentaciónAutolavado
{
    partial class FrmCobrar
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
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblCobro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPagado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(44, 23);
            this.lblFolio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(51, 20);
            this.lblFolio.TabIndex = 0;
            this.lblFolio.Text = "Folio: ";
            // 
            // lblCobro
            // 
            this.lblCobro.AutoSize = true;
            this.lblCobro.Location = new System.Drawing.Point(28, 61);
            this.lblCobro.Name = "lblCobro";
            this.lblCobro.Size = new System.Drawing.Size(83, 20);
            this.lblCobro.TabIndex = 1;
            this.lblCobro.Text = "Cobrando:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pagando:";
            // 
            // txtPagado
            // 
            this.txtPagado.Location = new System.Drawing.Point(120, 95);
            this.txtPagado.Name = "txtPagado";
            this.txtPagado.Size = new System.Drawing.Size(100, 26);
            this.txtPagado.TabIndex = 3;
            // 
            // FrmCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 692);
            this.Controls.Add(this.txtPagado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCobro);
            this.Controls.Add(this.lblFolio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCobrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblCobro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPagado;
    }
}