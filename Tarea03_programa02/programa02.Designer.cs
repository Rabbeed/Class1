namespace Tarea03_programa02
{
    partial class programa02
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuma = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(87, 10);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtA.Size = new System.Drawing.Size(309, 49);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(87, 75);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtB.Size = new System.Drawing.Size(309, 49);
            this.txtB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vector A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vector B";
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(163, 203);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(131, 23);
            this.btnSuma.TabIndex = 4;
            this.btnSuma.Text = "Sumar vectores";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(87, 148);
            this.txtRes.Multiline = true;
            this.txtRes.Name = "txtRes";
            this.txtRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRes.Size = new System.Drawing.Size(309, 49);
            this.txtRes.TabIndex = 5;
            this.txtRes.TextChanged += new System.EventHandler(this.txtRes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado";
            // 
            // programa02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 253);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "programa02";
            this.Text = "Suma vectores";
            this.Load += new System.EventHandler(this.programa02_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuma;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.Label label3;
    }
}

