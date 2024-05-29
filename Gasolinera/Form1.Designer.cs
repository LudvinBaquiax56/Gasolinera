namespace Gasolinera
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
            this.buttonBomba1 = new System.Windows.Forms.Button();
            this.buttonBomba2 = new System.Windows.Forms.Button();
            this.textBoxLitros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonBomba1
            // 
            this.buttonBomba1.Location = new System.Drawing.Point(377, 170);
            this.buttonBomba1.Name = "buttonBomba1";
            this.buttonBomba1.Size = new System.Drawing.Size(75, 23);
            this.buttonBomba1.TabIndex = 1;
            this.buttonBomba1.Text = "Bomba 1";
            this.buttonBomba1.UseVisualStyleBackColor = true;
            this.buttonBomba1.Click += new System.EventHandler(this.buttonBomba1_Click);
            // 
            // buttonBomba2
            // 
            this.buttonBomba2.Location = new System.Drawing.Point(468, 169);
            this.buttonBomba2.Name = "buttonBomba2";
            this.buttonBomba2.Size = new System.Drawing.Size(75, 23);
            this.buttonBomba2.TabIndex = 2;
            this.buttonBomba2.Text = "Bomba 2";
            this.buttonBomba2.UseVisualStyleBackColor = true;
            this.buttonBomba2.Click += new System.EventHandler(this.buttonBomba2_Click);
            // 
            // textBoxLitros
            // 
            this.textBoxLitros.Location = new System.Drawing.Point(136, 57);
            this.textBoxLitros.Name = "textBoxLitros";
            this.textBoxLitros.Size = new System.Drawing.Size(100, 20);
            this.textBoxLitros.TabIndex = 3;
            this.textBoxLitros.TextChanged += new System.EventHandler(this.textBoxLitros_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "litros a Despachar ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLitros);
            this.Controls.Add(this.buttonBomba2);
            this.Controls.Add(this.buttonBomba1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBomba1;
        private System.Windows.Forms.Button buttonBomba2;
        private System.Windows.Forms.TextBox textBoxLitros;
        private System.Windows.Forms.Label label1;
    }
}

