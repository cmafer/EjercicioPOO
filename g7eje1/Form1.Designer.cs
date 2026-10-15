namespace g7eje1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPrecioFinal = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.BtnRopa = new System.Windows.Forms.Button();
            this.BtnElectronico = new System.Windows.Forms.Button();
            this.BtnAlimenticio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio base:";
            // 
            // LblPrecioFinal
            // 
            this.LblPrecioFinal.AutoSize = true;
            this.LblPrecioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecioFinal.Location = new System.Drawing.Point(110, 262);
            this.LblPrecioFinal.Name = "LblPrecioFinal";
            this.LblPrecioFinal.Size = new System.Drawing.Size(129, 18);
            this.LblPrecioFinal.TabIndex = 2;
            this.LblPrecioFinal.Text = "Precio final: $ --";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(308, 48);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(174, 20);
            this.TxtNombre.TabIndex = 3;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(308, 112);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(174, 20);
            this.TxtPrecio.TabIndex = 4;
            // 
            // BtnRopa
            // 
            this.BtnRopa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRopa.Location = new System.Drawing.Point(137, 197);
            this.BtnRopa.Name = "BtnRopa";
            this.BtnRopa.Size = new System.Drawing.Size(102, 34);
            this.BtnRopa.TabIndex = 5;
            this.BtnRopa.Text = "Ropa";
            this.BtnRopa.UseVisualStyleBackColor = true;
            this.BtnRopa.Click += new System.EventHandler(this.BtnRopa_Click);
            // 
            // BtnElectronico
            // 
            this.BtnElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnElectronico.Location = new System.Drawing.Point(308, 197);
            this.BtnElectronico.Name = "BtnElectronico";
            this.BtnElectronico.Size = new System.Drawing.Size(96, 34);
            this.BtnElectronico.TabIndex = 6;
            this.BtnElectronico.Text = "Electrónico";
            this.BtnElectronico.UseVisualStyleBackColor = true;
            this.BtnElectronico.Click += new System.EventHandler(this.BtnElectronico_Click);
            // 
            // BtnAlimenticio
            // 
            this.BtnAlimenticio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAlimenticio.Location = new System.Drawing.Point(452, 197);
            this.BtnAlimenticio.Name = "BtnAlimenticio";
            this.BtnAlimenticio.Size = new System.Drawing.Size(88, 34);
            this.BtnAlimenticio.TabIndex = 7;
            this.BtnAlimenticio.Text = "Alimenticio";
            this.BtnAlimenticio.UseVisualStyleBackColor = true;
            this.BtnAlimenticio.Click += new System.EventHandler(this.BtnAlimenticio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(684, 450);
            this.Controls.Add(this.BtnAlimenticio);
            this.Controls.Add(this.BtnElectronico);
            this.Controls.Add(this.BtnRopa);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblPrecioFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Catalogo de Productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPrecioFinal;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.Button BtnRopa;
        private System.Windows.Forms.Button BtnElectronico;
        private System.Windows.Forms.Button BtnAlimenticio;
    }
}

