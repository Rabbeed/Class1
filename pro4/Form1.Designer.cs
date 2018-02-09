namespace pro4
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
            this.Calcular = new System.Windows.Forms.Button();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textHorasT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPagoxHr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxImpuesto = new System.Windows.Forms.TextBox();
            this.labelRes = new System.Windows.Forms.Label();
            this.buttonsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calcular
            // 
            this.Calcular.Location = new System.Drawing.Point(16, 259);
            this.Calcular.Name = "Calcular";
            this.Calcular.Size = new System.Drawing.Size(75, 23);
            this.Calcular.TabIndex = 0;
            this.Calcular.Text = "Calcular";
            this.Calcular.UseVisualStyleBackColor = true;
            this.Calcular.Click += new System.EventHandler(this.Calcular_Click);
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.Location = new System.Drawing.Point(63, 15);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(198, 20);
            this.textBoxnombre.TabIndex = 1;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(13, 18);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(47, 13);
            this.Nombre.TabIndex = 2;
            this.Nombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Horas Trabajadas:";
            // 
            // textHorasT
            // 
            this.textHorasT.Location = new System.Drawing.Point(118, 51);
            this.textHorasT.Name = "textHorasT";
            this.textHorasT.Size = new System.Drawing.Size(143, 20);
            this.textHorasT.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Paga x Hora:";
            // 
            // textBoxPagoxHr
            // 
            this.textBoxPagoxHr.Location = new System.Drawing.Point(88, 88);
            this.textBoxPagoxHr.Name = "textBoxPagoxHr";
            this.textBoxPagoxHr.Size = new System.Drawing.Size(173, 20);
            this.textBoxPagoxHr.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tasa de Impuesto:";
            // 
            // textBoxImpuesto
            // 
            this.textBoxImpuesto.Location = new System.Drawing.Point(114, 125);
            this.textBoxImpuesto.Name = "textBoxImpuesto";
            this.textBoxImpuesto.Size = new System.Drawing.Size(147, 20);
            this.textBoxImpuesto.TabIndex = 7;
            // 
            // labelRes
            // 
            this.labelRes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelRes.Location = new System.Drawing.Point(12, 163);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(269, 93);
            this.labelRes.TabIndex = 10;
            // 
            // buttonsalir
            // 
            this.buttonsalir.Location = new System.Drawing.Point(206, 259);
            this.buttonsalir.Name = "buttonsalir";
            this.buttonsalir.Size = new System.Drawing.Size(75, 23);
            this.buttonsalir.TabIndex = 11;
            this.buttonsalir.Text = "Salir";
            this.buttonsalir.UseVisualStyleBackColor = true;
            this.buttonsalir.Click += new System.EventHandler(this.buttonsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 294);
            this.Controls.Add(this.buttonsalir);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxImpuesto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPagoxHr);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textHorasT);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.textBoxnombre);
            this.Controls.Add(this.Calcular);
            this.Name = "Form1";
            this.Text = "Salario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcular;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textHorasT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPagoxHr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxImpuesto;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Button buttonsalir;
    }
}

