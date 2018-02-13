namespace Tarea02_programa02
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
            this.gbTamaño = new System.Windows.Forms.GroupBox();
            this.rbGran = new System.Windows.Forms.RadioButton();
            this.rbMed = new System.Windows.Forms.RadioButton();
            this.rbPeq = new System.Windows.Forms.RadioButton();
            this.gbIngredientes = new System.Windows.Forms.GroupBox();
            this.cbTomate = new System.Windows.Forms.CheckBox();
            this.cbComino = new System.Windows.Forms.CheckBox();
            this.cbCebolla = new System.Windows.Forms.CheckBox();
            this.cbClavo = new System.Windows.Forms.CheckBox();
            this.cbCham = new System.Windows.Forms.CheckBox();
            this.cbExtrQ = new System.Windows.Forms.CheckBox();
            this.gbCubierta = new System.Windows.Forms.GroupBox();
            this.rbCubiertaG = new System.Windows.Forms.RadioButton();
            this.rbCubiertaD = new System.Windows.Forms.RadioButton();
            this.rbAqui = new System.Windows.Forms.RadioButton();
            this.rbLLevar = new System.Windows.Forms.RadioButton();
            this.btnCocinar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gbTamaño.SuspendLayout();
            this.gbIngredientes.SuspendLayout();
            this.gbCubierta.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTamaño
            // 
            this.gbTamaño.BackColor = System.Drawing.Color.AliceBlue;
            this.gbTamaño.Controls.Add(this.rbGran);
            this.gbTamaño.Controls.Add(this.rbMed);
            this.gbTamaño.Controls.Add(this.rbPeq);
            this.gbTamaño.Location = new System.Drawing.Point(12, 12);
            this.gbTamaño.Name = "gbTamaño";
            this.gbTamaño.Size = new System.Drawing.Size(109, 100);
            this.gbTamaño.TabIndex = 0;
            this.gbTamaño.TabStop = false;
            this.gbTamaño.Text = "Tamaño";
            // 
            // rbGran
            // 
            this.rbGran.AutoSize = true;
            this.rbGran.Location = new System.Drawing.Point(7, 65);
            this.rbGran.Name = "rbGran";
            this.rbGran.Size = new System.Drawing.Size(60, 17);
            this.rbGran.TabIndex = 2;
            this.rbGran.Text = "Grande";
            this.rbGran.UseVisualStyleBackColor = true;
            // 
            // rbMed
            // 
            this.rbMed.AutoSize = true;
            this.rbMed.Location = new System.Drawing.Point(7, 42);
            this.rbMed.Name = "rbMed";
            this.rbMed.Size = new System.Drawing.Size(66, 17);
            this.rbMed.TabIndex = 1;
            this.rbMed.Text = "Mediana";
            this.rbMed.UseVisualStyleBackColor = true;
            // 
            // rbPeq
            // 
            this.rbPeq.AutoSize = true;
            this.rbPeq.Checked = true;
            this.rbPeq.Location = new System.Drawing.Point(7, 20);
            this.rbPeq.Name = "rbPeq";
            this.rbPeq.Size = new System.Drawing.Size(68, 17);
            this.rbPeq.TabIndex = 0;
            this.rbPeq.TabStop = true;
            this.rbPeq.Text = "Pequeña";
            this.rbPeq.UseVisualStyleBackColor = true;
            // 
            // gbIngredientes
            // 
            this.gbIngredientes.BackColor = System.Drawing.Color.AliceBlue;
            this.gbIngredientes.Controls.Add(this.cbTomate);
            this.gbIngredientes.Controls.Add(this.cbComino);
            this.gbIngredientes.Controls.Add(this.cbCebolla);
            this.gbIngredientes.Controls.Add(this.cbClavo);
            this.gbIngredientes.Controls.Add(this.cbCham);
            this.gbIngredientes.Controls.Add(this.cbExtrQ);
            this.gbIngredientes.Location = new System.Drawing.Point(137, 12);
            this.gbIngredientes.Name = "gbIngredientes";
            this.gbIngredientes.Size = new System.Drawing.Size(212, 100);
            this.gbIngredientes.TabIndex = 3;
            this.gbIngredientes.TabStop = false;
            this.gbIngredientes.Text = "Ingredientes";
            // 
            // cbTomate
            // 
            this.cbTomate.AutoSize = true;
            this.cbTomate.Location = new System.Drawing.Point(110, 65);
            this.cbTomate.Name = "cbTomate";
            this.cbTomate.Size = new System.Drawing.Size(67, 17);
            this.cbTomate.TabIndex = 5;
            this.cbTomate.Text = "Tomates";
            this.cbTomate.UseVisualStyleBackColor = true;
            // 
            // cbComino
            // 
            this.cbComino.AutoSize = true;
            this.cbComino.Location = new System.Drawing.Point(110, 44);
            this.cbComino.Name = "cbComino";
            this.cbComino.Size = new System.Drawing.Size(66, 17);
            this.cbComino.TabIndex = 4;
            this.cbComino.Text = "Cominos";
            this.cbComino.UseVisualStyleBackColor = true;
            // 
            // cbCebolla
            // 
            this.cbCebolla.AutoSize = true;
            this.cbCebolla.Location = new System.Drawing.Point(110, 21);
            this.cbCebolla.Name = "cbCebolla";
            this.cbCebolla.Size = new System.Drawing.Size(61, 17);
            this.cbCebolla.TabIndex = 3;
            this.cbCebolla.Text = "Cebolla";
            this.cbCebolla.UseVisualStyleBackColor = true;
            // 
            // cbClavo
            // 
            this.cbClavo.AutoSize = true;
            this.cbClavo.Location = new System.Drawing.Point(7, 66);
            this.cbClavo.Name = "cbClavo";
            this.cbClavo.Size = new System.Drawing.Size(58, 17);
            this.cbClavo.TabIndex = 2;
            this.cbClavo.Text = "Clavos";
            this.cbClavo.UseVisualStyleBackColor = true;
            // 
            // cbCham
            // 
            this.cbCham.AutoSize = true;
            this.cbCham.Location = new System.Drawing.Point(7, 43);
            this.cbCham.Name = "cbCham";
            this.cbCham.Size = new System.Drawing.Size(90, 17);
            this.cbCham.TabIndex = 1;
            this.cbCham.Text = "Champiñones";
            this.cbCham.UseVisualStyleBackColor = true;
            // 
            // cbExtrQ
            // 
            this.cbExtrQ.AutoSize = true;
            this.cbExtrQ.Location = new System.Drawing.Point(7, 20);
            this.cbExtrQ.Name = "cbExtrQ";
            this.cbExtrQ.Size = new System.Drawing.Size(84, 17);
            this.cbExtrQ.TabIndex = 0;
            this.cbExtrQ.Text = "Extra Queso";
            this.cbExtrQ.UseVisualStyleBackColor = true;
            // 
            // gbCubierta
            // 
            this.gbCubierta.BackColor = System.Drawing.Color.AliceBlue;
            this.gbCubierta.Controls.Add(this.rbCubiertaG);
            this.gbCubierta.Controls.Add(this.rbCubiertaD);
            this.gbCubierta.Location = new System.Drawing.Point(12, 129);
            this.gbCubierta.Name = "gbCubierta";
            this.gbCubierta.Size = new System.Drawing.Size(160, 75);
            this.gbCubierta.TabIndex = 3;
            this.gbCubierta.TabStop = false;
            this.gbCubierta.Text = "Tipo de Cubierta";
            // 
            // rbCubiertaG
            // 
            this.rbCubiertaG.AutoSize = true;
            this.rbCubiertaG.Location = new System.Drawing.Point(7, 42);
            this.rbCubiertaG.Name = "rbCubiertaG";
            this.rbCubiertaG.Size = new System.Drawing.Size(101, 17);
            this.rbCubiertaG.TabIndex = 1;
            this.rbCubiertaG.Text = "Cubierta Gruesa";
            this.rbCubiertaG.UseVisualStyleBackColor = true;
            // 
            // rbCubiertaD
            // 
            this.rbCubiertaD.AutoSize = true;
            this.rbCubiertaD.Checked = true;
            this.rbCubiertaD.Location = new System.Drawing.Point(7, 20);
            this.rbCubiertaD.Name = "rbCubiertaD";
            this.rbCubiertaD.Size = new System.Drawing.Size(107, 17);
            this.rbCubiertaD.TabIndex = 0;
            this.rbCubiertaD.TabStop = true;
            this.rbCubiertaD.Text = "Cubierta Delgada";
            this.rbCubiertaD.UseVisualStyleBackColor = true;
            // 
            // rbAqui
            // 
            this.rbAqui.AutoSize = true;
            this.rbAqui.Checked = true;
            this.rbAqui.Location = new System.Drawing.Point(212, 149);
            this.rbAqui.Name = "rbAqui";
            this.rbAqui.Size = new System.Drawing.Size(81, 17);
            this.rbAqui.TabIndex = 4;
            this.rbAqui.TabStop = true;
            this.rbAqui.Text = "Comer Aquí";
            this.rbAqui.UseVisualStyleBackColor = true;
            // 
            // rbLLevar
            // 
            this.rbLLevar.AutoSize = true;
            this.rbLLevar.Location = new System.Drawing.Point(212, 172);
            this.rbLLevar.Name = "rbLLevar";
            this.rbLLevar.Size = new System.Drawing.Size(75, 17);
            this.rbLLevar.TabIndex = 5;
            this.rbLLevar.Text = "Para llevar";
            this.rbLLevar.UseVisualStyleBackColor = true;
            // 
            // btnCocinar
            // 
            this.btnCocinar.Location = new System.Drawing.Point(19, 226);
            this.btnCocinar.Name = "btnCocinar";
            this.btnCocinar.Size = new System.Drawing.Size(153, 23);
            this.btnCocinar.TabIndex = 6;
            this.btnCocinar.Text = "Cocinar Pizza";
            this.btnCocinar.UseVisualStyleBackColor = true;
            this.btnCocinar.Click += new System.EventHandler(this.btnCocinar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(191, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCocinar);
            this.Controls.Add(this.rbLLevar);
            this.Controls.Add(this.rbAqui);
            this.Controls.Add(this.gbCubierta);
            this.Controls.Add(this.gbIngredientes);
            this.Controls.Add(this.gbTamaño);
            this.Name = "Form1";
            this.Text = "Pizzeria";
            this.gbTamaño.ResumeLayout(false);
            this.gbTamaño.PerformLayout();
            this.gbIngredientes.ResumeLayout(false);
            this.gbIngredientes.PerformLayout();
            this.gbCubierta.ResumeLayout(false);
            this.gbCubierta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbTamaño;
        private System.Windows.Forms.RadioButton rbGran;
        private System.Windows.Forms.RadioButton rbMed;
        private System.Windows.Forms.RadioButton rbPeq;
        private System.Windows.Forms.GroupBox gbIngredientes;
        private System.Windows.Forms.CheckBox cbTomate;
        private System.Windows.Forms.CheckBox cbComino;
        private System.Windows.Forms.CheckBox cbCebolla;
        private System.Windows.Forms.CheckBox cbClavo;
        private System.Windows.Forms.CheckBox cbCham;
        private System.Windows.Forms.CheckBox cbExtrQ;
        private System.Windows.Forms.GroupBox gbCubierta;
        private System.Windows.Forms.RadioButton rbCubiertaG;
        private System.Windows.Forms.RadioButton rbCubiertaD;
        private System.Windows.Forms.RadioButton rbAqui;
        private System.Windows.Forms.RadioButton rbLLevar;
        private System.Windows.Forms.Button btnCocinar;
        private System.Windows.Forms.Button button2;
    }
}

