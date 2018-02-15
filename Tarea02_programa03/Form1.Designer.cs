namespace Tarea02_programa03
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
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.txtIncr = new System.Windows.Forms.TextBox();
            this.txtResIncr = new System.Windows.Forms.TextBox();
            this.txtCont = new System.Windows.Forms.TextBox();
            this.txtResDec = new System.Windows.Forms.TextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnIncr = new System.Windows.Forms.Button();
            this.btnInterc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInicial
            // 
            this.txtInicial.Location = new System.Drawing.Point(131, 43);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(100, 20);
            this.txtInicial.TabIndex = 0;
            // 
            // txtIncr
            // 
            this.txtIncr.Location = new System.Drawing.Point(131, 113);
            this.txtIncr.Name = "txtIncr";
            this.txtIncr.Size = new System.Drawing.Size(100, 20);
            this.txtIncr.TabIndex = 1;
            // 
            // txtResIncr
            // 
            this.txtResIncr.Location = new System.Drawing.Point(12, 181);
            this.txtResIncr.Name = "txtResIncr";
            this.txtResIncr.ReadOnly = true;
            this.txtResIncr.Size = new System.Drawing.Size(100, 20);
            this.txtResIncr.TabIndex = 3;
            // 
            // txtCont
            // 
            this.txtCont.Location = new System.Drawing.Point(131, 181);
            this.txtCont.Name = "txtCont";
            this.txtCont.ReadOnly = true;
            this.txtCont.Size = new System.Drawing.Size(100, 20);
            this.txtCont.TabIndex = 2;
            // 
            // txtResDec
            // 
            this.txtResDec.Location = new System.Drawing.Point(249, 181);
            this.txtResDec.Name = "txtResDec";
            this.txtResDec.ReadOnly = true;
            this.txtResDec.Size = new System.Drawing.Size(100, 20);
            this.txtResDec.TabIndex = 4;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 233);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(100, 33);
            this.btnIniciar.TabIndex = 5;
            this.btnIniciar.Text = "Inicializar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnIncr
            // 
            this.btnIncr.Location = new System.Drawing.Point(131, 233);
            this.btnIncr.Name = "btnIncr";
            this.btnIncr.Size = new System.Drawing.Size(100, 33);
            this.btnIncr.TabIndex = 6;
            this.btnIncr.Text = "Incrementar";
            this.btnIncr.UseVisualStyleBackColor = true;
            this.btnIncr.Click += new System.EventHandler(this.btnIncr_Click);
            // 
            // btnInterc
            // 
            this.btnInterc.Location = new System.Drawing.Point(249, 233);
            this.btnInterc.Name = "btnInterc";
            this.btnInterc.Size = new System.Drawing.Size(100, 33);
            this.btnInterc.TabIndex = 7;
            this.btnInterc.Text = "Intercambiar";
            this.btnInterc.UseVisualStyleBackColor = true;
            this.btnInterc.Click += new System.EventHandler(this.btnInterc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "Valor Inicial";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Valor Inc / Dec";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado del\r\nincremento\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(145, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Contador";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(246, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 32);
            this.label5.TabIndex = 12;
            this.label5.Text = "Resultado del\r\nDecremento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 297);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInterc);
            this.Controls.Add(this.btnIncr);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.txtResDec);
            this.Controls.Add(this.txtResIncr);
            this.Controls.Add(this.txtCont);
            this.Controls.Add(this.txtIncr);
            this.Controls.Add(this.txtInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Conteo y Acumulación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.TextBox txtIncr;
        private System.Windows.Forms.TextBox txtResIncr;
        private System.Windows.Forms.TextBox txtCont;
        private System.Windows.Forms.TextBox txtResDec;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnIncr;
        private System.Windows.Forms.Button btnInterc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

