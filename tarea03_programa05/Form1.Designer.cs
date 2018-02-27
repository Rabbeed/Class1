namespace tarea03_programa05
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
            this.txtO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtI = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtO
            // 
            this.txtO.Location = new System.Drawing.Point(12, 25);
            this.txtO.Multiline = true;
            this.txtO.Name = "txtO";
            this.txtO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtO.Size = new System.Drawing.Size(331, 72);
            this.txtO.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vector original";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vector inverso";
            // 
            // txtI
            // 
            this.txtI.Location = new System.Drawing.Point(12, 131);
            this.txtI.Multiline = true;
            this.txtI.Name = "txtI";
            this.txtI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtI.Size = new System.Drawing.Size(331, 72);
            this.txtI.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 215);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtI);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtO);
            this.Name = "Form1";
            this.Text = "programa 5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtI;
    }
}

