namespace Tarea03_programa01
{
    partial class programa01
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
            this.txtVector = new System.Windows.Forms.TextBox();
            this.btnPromedio = new System.Windows.Forms.Button();
            this.lblRes = new System.Windows.Forms.Label();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vector:";
            // 
            // txtVector
            // 
            this.txtVector.Location = new System.Drawing.Point(12, 24);
            this.txtVector.Multiline = true;
            this.txtVector.Name = "txtVector";
            this.txtVector.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtVector.Size = new System.Drawing.Size(369, 78);
            this.txtVector.TabIndex = 1;
            // 
            // btnPromedio
            // 
            this.btnPromedio.Location = new System.Drawing.Point(131, 108);
            this.btnPromedio.Name = "btnPromedio";
            this.btnPromedio.Size = new System.Drawing.Size(121, 23);
            this.btnPromedio.TabIndex = 2;
            this.btnPromedio.Text = "Calcular promedio";
            this.btnPromedio.UseVisualStyleBackColor = true;
            this.btnPromedio.Click += new System.EventHandler(this.btnPromedio_Click);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(205, 145);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(0, 13);
            this.lblRes.TabIndex = 3;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(15, 201);
            this.txtPromedio.Multiline = true;
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPromedio.Size = new System.Drawing.Size(366, 78);
            this.txtPromedio.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mayores que promedio:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Mostrar mayores que el promedio";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Promedio:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 311);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPromedio);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.btnPromedio);
            this.Controls.Add(this.txtVector);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Programa1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtVector;
        private System.Windows.Forms.Button btnPromedio;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}

