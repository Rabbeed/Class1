namespace LanzarDados
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
            this.txtDespliega = new System.Windows.Forms.TextBox();
            this.btnLanzar = new System.Windows.Forms.Button();
            this.lblDado1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDespliega
            // 
            this.txtDespliega.Location = new System.Drawing.Point(12, 233);
            this.txtDespliega.Multiline = true;
            this.txtDespliega.Name = "txtDespliega";
            this.txtDespliega.ReadOnly = true;
            this.txtDespliega.Size = new System.Drawing.Size(519, 141);
            this.txtDespliega.TabIndex = 0;
            // 
            // btnLanzar
            // 
            this.btnLanzar.Location = new System.Drawing.Point(179, 204);
            this.btnLanzar.Name = "btnLanzar";
            this.btnLanzar.Size = new System.Drawing.Size(181, 23);
            this.btnLanzar.TabIndex = 1;
            this.btnLanzar.Text = "Lanzar";
            this.btnLanzar.UseVisualStyleBackColor = true;
            // 
            // lblDado1
            // 
            this.lblDado1.Location = new System.Drawing.Point(13, 13);
            this.lblDado1.Name = "lblDado1";
            this.lblDado1.Size = new System.Drawing.Size(86, 74);
            this.lblDado1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(126, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 74);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 386);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDado1);
            this.Controls.Add(this.btnLanzar);
            this.Controls.Add(this.txtDespliega);
            this.Name = "Form1";
            this.Text = "Lanzar Dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDespliega;
        private System.Windows.Forms.Button btnLanzar;
        private System.Windows.Forms.Label lblDado1;
        private System.Windows.Forms.Label label1;
    }
}

