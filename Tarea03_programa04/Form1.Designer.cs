namespace Tarea03_programa04
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
            this.txtOrig = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNeg = new System.Windows.Forms.TextBox();
            this.txtCantNeg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantPos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCantCero = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblResNeg = new System.Windows.Forms.Label();
            this.lblResPos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtOrig
            // 
            this.txtOrig.Location = new System.Drawing.Point(12, 25);
            this.txtOrig.Multiline = true;
            this.txtOrig.Name = "txtOrig";
            this.txtOrig.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrig.Size = new System.Drawing.Size(404, 51);
            this.txtOrig.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Sumar Negativos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vector original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Positivos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(12, 211);
            this.txtPos.Multiline = true;
            this.txtPos.Name = "txtPos";
            this.txtPos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPos.Size = new System.Drawing.Size(256, 51);
            this.txtPos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Negativos";
            // 
            // txtNeg
            // 
            this.txtNeg.Location = new System.Drawing.Point(12, 101);
            this.txtNeg.Multiline = true;
            this.txtNeg.Name = "txtNeg";
            this.txtNeg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNeg.Size = new System.Drawing.Size(256, 51);
            this.txtNeg.TabIndex = 5;
            // 
            // txtCantNeg
            // 
            this.txtCantNeg.Location = new System.Drawing.Point(293, 120);
            this.txtCantNeg.Name = "txtCantNeg";
            this.txtCantNeg.Size = new System.Drawing.Size(100, 20);
            this.txtCantNeg.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de negativos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cantidad de positivos";
            // 
            // txtCantPos
            // 
            this.txtCantPos.Location = new System.Drawing.Point(293, 211);
            this.txtCantPos.Name = "txtCantPos";
            this.txtCantPos.Size = new System.Drawing.Size(100, 20);
            this.txtCantPos.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad de ceros";
            // 
            // txtCantCero
            // 
            this.txtCantCero.Location = new System.Drawing.Point(293, 164);
            this.txtCantCero.Name = "txtCantCero";
            this.txtCantCero.Size = new System.Drawing.Size(100, 20);
            this.txtCantCero.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Sumar Positivos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblResNeg
            // 
            this.lblResNeg.AutoSize = true;
            this.lblResNeg.Location = new System.Drawing.Point(125, 164);
            this.lblResNeg.Name = "lblResNeg";
            this.lblResNeg.Size = new System.Drawing.Size(0, 13);
            this.lblResNeg.TabIndex = 14;
            // 
            // lblResPos
            // 
            this.lblResPos.AutoSize = true;
            this.lblResPos.Location = new System.Drawing.Point(125, 273);
            this.lblResPos.Name = "lblResPos";
            this.lblResPos.Size = new System.Drawing.Size(0, 13);
            this.lblResPos.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 305);
            this.Controls.Add(this.lblResPos);
            this.Controls.Add(this.lblResNeg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCantCero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCantPos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantNeg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNeg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtOrig);
            this.Name = "Form1";
            this.Text = "programa 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOrig;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNeg;
        private System.Windows.Forms.TextBox txtCantNeg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantPos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCantCero;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblResNeg;
        private System.Windows.Forms.Label lblResPos;
    }
}

