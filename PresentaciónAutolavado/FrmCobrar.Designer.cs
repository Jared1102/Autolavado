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
            this.lblPagando = new System.Windows.Forms.Label();
            this.txtCobrando = new System.Windows.Forms.TextBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.lbl20 = new System.Windows.Forms.Label();
            this.lbl50 = new System.Windows.Forms.Label();
            this.btn20 = new System.Windows.Forms.Button();
            this.btn50 = new System.Windows.Forms.Button();
            this.btnr1 = new PresentaciónAutolavado.ButtonRound();
            this.btnr2 = new PresentaciónAutolavado.ButtonRound();
            this.btnr5 = new PresentaciónAutolavado.ButtonRound();
            this.btnr10 = new PresentaciónAutolavado.ButtonRound();
            this.SuspendLayout();
            // 
            // lblFolio
            // 
            this.lblFolio.AutoSize = true;
            this.lblFolio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolio.Location = new System.Drawing.Point(153, 23);
            this.lblFolio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(51, 20);
            this.lblFolio.TabIndex = 0;
            this.lblFolio.Text = "Folio: ";
            // 
            // lblCobro
            // 
            this.lblCobro.AutoSize = true;
            this.lblCobro.Location = new System.Drawing.Point(120, 61);
            this.lblCobro.Name = "lblCobro";
            this.lblCobro.Size = new System.Drawing.Size(83, 20);
            this.lblCobro.TabIndex = 1;
            this.lblCobro.Text = "Cobrando:";
            // 
            // lblPagando
            // 
            this.lblPagando.AutoSize = true;
            this.lblPagando.Location = new System.Drawing.Point(127, 100);
            this.lblPagando.Name = "lblPagando";
            this.lblPagando.Size = new System.Drawing.Size(99, 20);
            this.lblPagando.TabIndex = 2;
            this.lblPagando.Text = "Pagando: $0";
            // 
            // txtCobrando
            // 
            this.txtCobrando.Enabled = false;
            this.txtCobrando.Location = new System.Drawing.Point(212, 58);
            this.txtCobrando.Name = "txtCobrando";
            this.txtCobrando.ReadOnly = true;
            this.txtCobrando.Size = new System.Drawing.Size(100, 26);
            this.txtCobrando.TabIndex = 4;
            // 
            // txtFolio
            // 
            this.txtFolio.Enabled = false;
            this.txtFolio.Location = new System.Drawing.Point(212, 17);
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.ReadOnly = true;
            this.txtFolio.Size = new System.Drawing.Size(100, 26);
            this.txtFolio.TabIndex = 5;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(106, 446);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(110, 48);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "Cobrar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 446);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 48);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(242, 358);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(29, 20);
            this.lbl1.TabIndex = 49;
            this.lbl1.Text = "0 x";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(90, 356);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(29, 20);
            this.lbl2.TabIndex = 48;
            this.lbl2.Text = "0 x";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(239, 260);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(29, 20);
            this.lbl5.TabIndex = 46;
            this.lbl5.Text = "0 x";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Location = new System.Drawing.Point(90, 260);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(29, 20);
            this.lbl10.TabIndex = 44;
            this.lbl10.Text = "0 x";
            // 
            // lbl20
            // 
            this.lbl20.AutoSize = true;
            this.lbl20.Location = new System.Drawing.Point(235, 163);
            this.lbl20.Name = "lbl20";
            this.lbl20.Size = new System.Drawing.Size(29, 20);
            this.lbl20.TabIndex = 41;
            this.lbl20.Text = "0 x";
            // 
            // lbl50
            // 
            this.lbl50.AutoSize = true;
            this.lbl50.Location = new System.Drawing.Point(29, 163);
            this.lbl50.Name = "lbl50";
            this.lbl50.Size = new System.Drawing.Size(29, 20);
            this.lbl50.TabIndex = 39;
            this.lbl50.Text = "0 x";
            // 
            // btn20
            // 
            this.btn20.BackgroundImage = global::PresentaciónAutolavado.Properties.Resources.billete_20;
            this.btn20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn20.Location = new System.Drawing.Point(270, 133);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(159, 80);
            this.btn20.TabIndex = 42;
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // btn50
            // 
            this.btn50.BackgroundImage = global::PresentaciónAutolavado.Properties.Resources.billete_50;
            this.btn50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn50.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn50.Location = new System.Drawing.Point(64, 133);
            this.btn50.Name = "btn50";
            this.btn50.Size = new System.Drawing.Size(159, 80);
            this.btn50.TabIndex = 40;
            this.btn50.UseVisualStyleBackColor = true;
            this.btn50.Click += new System.EventHandler(this.btn50_Click);
            // 
            // btnr1
            // 
            this.btnr1.BackgroundImage = global::PresentaciónAutolavado.Properties.Resources.moneda_1;
            this.btnr1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnr1.FlatAppearance.BorderSize = 0;
            this.btnr1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnr1.Location = new System.Drawing.Point(277, 331);
            this.btnr1.Name = "btnr1";
            this.btnr1.Size = new System.Drawing.Size(75, 75);
            this.btnr1.TabIndex = 50;
            this.btnr1.UseVisualStyleBackColor = true;
            this.btnr1.Click += new System.EventHandler(this.btnr1_Click);
            // 
            // btnr2
            // 
            this.btnr2.BackgroundImage = global::PresentaciónAutolavado.Properties.Resources.moneda_2;
            this.btnr2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnr2.FlatAppearance.BorderSize = 0;
            this.btnr2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnr2.Location = new System.Drawing.Point(125, 331);
            this.btnr2.Name = "btnr2";
            this.btnr2.Size = new System.Drawing.Size(75, 75);
            this.btnr2.TabIndex = 47;
            this.btnr2.UseVisualStyleBackColor = true;
            this.btnr2.Click += new System.EventHandler(this.btnr2_Click);
            // 
            // btnr5
            // 
            this.btnr5.BackgroundImage = global::PresentaciónAutolavado.Properties.Resources.moneda_5;
            this.btnr5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnr5.FlatAppearance.BorderSize = 0;
            this.btnr5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnr5.Location = new System.Drawing.Point(274, 231);
            this.btnr5.Name = "btnr5";
            this.btnr5.Size = new System.Drawing.Size(75, 75);
            this.btnr5.TabIndex = 45;
            this.btnr5.UseVisualStyleBackColor = true;
            this.btnr5.Click += new System.EventHandler(this.btnr5_Click);
            // 
            // btnr10
            // 
            this.btnr10.BackgroundImage = global::PresentaciónAutolavado.Properties.Resources.moneda_10;
            this.btnr10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnr10.FlatAppearance.BorderSize = 0;
            this.btnr10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnr10.Location = new System.Drawing.Point(125, 231);
            this.btnr10.Name = "btnr10";
            this.btnr10.Size = new System.Drawing.Size(75, 75);
            this.btnr10.TabIndex = 43;
            this.btnr10.UseVisualStyleBackColor = true;
            this.btnr10.Click += new System.EventHandler(this.btnr10_Click);
            // 
            // FrmCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 503);
            this.Controls.Add(this.btnr1);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.btnr2);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.btnr5);
            this.Controls.Add(this.lbl10);
            this.Controls.Add(this.btnr10);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.lbl20);
            this.Controls.Add(this.btn50);
            this.Controls.Add(this.lbl50);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.txtFolio);
            this.Controls.Add(this.txtCobrando);
            this.Controls.Add(this.lblPagando);
            this.Controls.Add(this.lblCobro);
            this.Controls.Add(this.lblFolio);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCobrar_FormClosed);
            this.Load += new System.EventHandler(this.FrmCobrar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblCobro;
        private System.Windows.Forms.Label lblPagando;
        private System.Windows.Forms.TextBox txtCobrando;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnCancelar;
        private ButtonRound btnr1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private ButtonRound btnr2;
        private System.Windows.Forms.Label lbl5;
        private ButtonRound btnr5;
        private System.Windows.Forms.Label lbl10;
        private ButtonRound btnr10;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Label lbl20;
        private System.Windows.Forms.Button btn50;
        private System.Windows.Forms.Label lbl50;
    }
}