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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxTipoGasolina = new System.Windows.Forms.ComboBox();
            this.dataGridViewReporte = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonVerReporte = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLlenarTanque1 = new System.Windows.Forms.Button();
            this.buttonLlenarTanque2 = new System.Windows.Forms.Button();
            this.textBoxLitrosDespachados = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBomba1
            // 
            this.buttonBomba1.Location = new System.Drawing.Point(306, 39);
            this.buttonBomba1.Name = "buttonBomba1";
            this.buttonBomba1.Size = new System.Drawing.Size(75, 23);
            this.buttonBomba1.TabIndex = 1;
            this.buttonBomba1.Text = "Bomba 1";
            this.buttonBomba1.UseVisualStyleBackColor = true;
            this.buttonBomba1.Click += new System.EventHandler(this.buttonBomba1_Click);
            // 
            // buttonBomba2
            // 
            this.buttonBomba2.Location = new System.Drawing.Point(306, 80);
            this.buttonBomba2.Name = "buttonBomba2";
            this.buttonBomba2.Size = new System.Drawing.Size(75, 23);
            this.buttonBomba2.TabIndex = 2;
            this.buttonBomba2.Text = "Bomba 2";
            this.buttonBomba2.UseVisualStyleBackColor = true;
            this.buttonBomba2.Click += new System.EventHandler(this.buttonBomba2_Click);
            // 
            // textBoxLitros
            // 
            this.textBoxLitros.Location = new System.Drawing.Point(137, 151);
            this.textBoxLitros.Name = "textBoxLitros";
            this.textBoxLitros.Size = new System.Drawing.Size(121, 20);
            this.textBoxLitros.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Litros a Despachar ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre Del Cliente ";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(137, 44);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(121, 20);
            this.textBoxNombreCliente.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de gasolina";
            // 
            // comboBoxTipoGasolina
            // 
            this.comboBoxTipoGasolina.FormattingEnabled = true;
            this.comboBoxTipoGasolina.Items.AddRange(new object[] {
            "Regular",
            "Super",
            "Diesel"});
            this.comboBoxTipoGasolina.Location = new System.Drawing.Point(137, 80);
            this.comboBoxTipoGasolina.Name = "comboBoxTipoGasolina";
            this.comboBoxTipoGasolina.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTipoGasolina.TabIndex = 8;
            // 
            // dataGridViewReporte
            // 
            this.dataGridViewReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReporte.Location = new System.Drawing.Point(38, 242);
            this.dataGridViewReporte.Name = "dataGridViewReporte";
            this.dataGridViewReporte.Size = new System.Drawing.Size(382, 150);
            this.dataGridViewReporte.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // buttonVerReporte
            // 
            this.buttonVerReporte.Location = new System.Drawing.Point(39, 196);
            this.buttonVerReporte.Name = "buttonVerReporte";
            this.buttonVerReporte.Size = new System.Drawing.Size(140, 23);
            this.buttonVerReporte.TabIndex = 11;
            this.buttonVerReporte.Text = "Ver Reportes";
            this.buttonVerReporte.UseVisualStyleBackColor = true;
            this.buttonVerReporte.Click += new System.EventHandler(this.buttonVerReporte_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(530, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Litros Despachados";
            // 
            // buttonLlenarTanque1
            // 
            this.buttonLlenarTanque1.Location = new System.Drawing.Point(533, 124);
            this.buttonLlenarTanque1.Name = "buttonLlenarTanque1";
            this.buttonLlenarTanque1.Size = new System.Drawing.Size(138, 23);
            this.buttonLlenarTanque1.TabIndex = 13;
            this.buttonLlenarTanque1.Text = "Llenar Tanque1";
            this.buttonLlenarTanque1.UseVisualStyleBackColor = true;
            this.buttonLlenarTanque1.Click += new System.EventHandler(this.buttonLlenarTanque1_Click);
            // 
            // buttonLlenarTanque2
            // 
            this.buttonLlenarTanque2.Location = new System.Drawing.Point(533, 161);
            this.buttonLlenarTanque2.Name = "buttonLlenarTanque2";
            this.buttonLlenarTanque2.Size = new System.Drawing.Size(138, 23);
            this.buttonLlenarTanque2.TabIndex = 14;
            this.buttonLlenarTanque2.Text = "Llenar Tanque 2";
            this.buttonLlenarTanque2.UseVisualStyleBackColor = true;
            this.buttonLlenarTanque2.Click += new System.EventHandler(this.buttonLlenarTanque2_Click);
            // 
            // textBoxLitrosDespachados
            // 
            this.textBoxLitrosDespachados.Enabled = false;
            this.textBoxLitrosDespachados.Location = new System.Drawing.Point(667, 80);
            this.textBoxLitrosDespachados.Name = "textBoxLitrosDespachados";
            this.textBoxLitrosDespachados.Size = new System.Drawing.Size(100, 20);
            this.textBoxLitrosDespachados.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Precio";
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(137, 109);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrecio.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPrecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxLitrosDespachados);
            this.Controls.Add(this.buttonLlenarTanque2);
            this.Controls.Add(this.buttonLlenarTanque1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonVerReporte);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridViewReporte);
            this.Controls.Add(this.comboBoxTipoGasolina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLitros);
            this.Controls.Add(this.buttonBomba2);
            this.Controls.Add(this.buttonBomba1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBomba1;
        private System.Windows.Forms.Button buttonBomba2;
        private System.Windows.Forms.TextBox textBoxLitros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxTipoGasolina;
        private System.Windows.Forms.DataGridView dataGridViewReporte;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonVerReporte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLlenarTanque1;
        private System.Windows.Forms.Button buttonLlenarTanque2;
        private System.Windows.Forms.TextBox textBoxLitrosDespachados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPrecio;
    }
}

