namespace tarea03_programa06_Form
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
            this.cboA = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMult = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cboA
            // 
            this.cboA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboA.FormattingEnabled = true;
            this.cboA.Location = new System.Drawing.Point(12, 30);
            this.cboA.Name = "cboA";
            this.cboA.Size = new System.Drawing.Size(128, 306);
            this.cboA.TabIndex = 0;
            this.cboA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vector A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vector B";
            // 
            // cboB
            // 
            this.cboB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboB.FormattingEnabled = true;
            this.cboB.Location = new System.Drawing.Point(180, 30);
            this.cboB.Name = "cboB";
            this.cboB.Size = new System.Drawing.Size(128, 306);
            this.cboB.TabIndex = 2;
            this.cboB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboB_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Vector C";
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(207, 342);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(75, 23);
            this.btnMult.TabIndex = 6;
            this.btnMult.Text = "Multiplicar";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(350, 30);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(118, 299);
            this.txtC.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 373);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboA);
            this.Name = "Form1";
            this.Text = "Programa06";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.TextBox txtC;
    }
}

