namespace PresentaciónAutolavado
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExpress = new System.Windows.Forms.Button();
            this.btnCera = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExpress
            // 
            this.btnExpress.Location = new System.Drawing.Point(43, 57);
            this.btnExpress.Name = "btnExpress";
            this.btnExpress.Size = new System.Drawing.Size(122, 43);
            this.btnExpress.TabIndex = 0;
            this.btnExpress.Text = "Express $30";
            this.btnExpress.UseVisualStyleBackColor = true;
            this.btnExpress.Click += new System.EventHandler(this.btnExpress_Click);
            // 
            // btnCera
            // 
            this.btnCera.Location = new System.Drawing.Point(210, 57);
            this.btnCera.Name = "btnCera";
            this.btnCera.Size = new System.Drawing.Size(122, 43);
            this.btnCera.TabIndex = 1;
            this.btnCera.Text = "Cera $40";
            this.btnCera.UseVisualStyleBackColor = true;
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(375, 57);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(122, 43);
            this.btnTotal.TabIndex = 2;
            this.btnTotal.Text = "Total $50";
            this.btnTotal.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 158);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnCera);
            this.Controls.Add(this.btnExpress);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autolavado";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExpress;
        private System.Windows.Forms.Button btnCera;
        private System.Windows.Forms.Button btnTotal;
    }
}

