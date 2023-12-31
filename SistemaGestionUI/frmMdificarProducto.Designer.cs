﻿namespace SistemaGestionEntities
{
    partial class frmMdificarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            numStock = new NumericUpDown();
            label1 = new Label();
            txtUsuario = new TextBox();
            label6 = new Label();
            txtDescripcion = new TextBox();
            numPrecio = new NumericUpDown();
            numCosto = new NumericUpDown();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnModificar = new Button();
            ((System.ComponentModel.ISupportInitialize)numStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).BeginInit();
            SuspendLayout();
            // 
            // numStock
            // 
            numStock.DecimalPlaces = 2;
            numStock.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numStock.Location = new Point(32, 240);
            numStock.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numStock.Name = "numStock";
            numStock.Size = new Size(151, 29);
            numStock.TabIndex = 47;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(32, 212);
            label1.Name = "label1";
            label1.Size = new Size(129, 21);
            label1.TabIndex = 46;
            label1.Text = "Precio de Venta";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(33, 306);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(312, 29);
            txtUsuario.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(33, 278);
            label6.Name = "label6";
            label6.Size = new Size(88, 21);
            label6.TabIndex = 44;
            label6.Text = "Id Usuario";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDescripcion.Location = new Point(33, 38);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(312, 29);
            txtDescripcion.TabIndex = 43;
            // 
            // numPrecio
            // 
            numPrecio.DecimalPlaces = 2;
            numPrecio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numPrecio.Location = new Point(33, 180);
            numPrecio.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numPrecio.Name = "numPrecio";
            numPrecio.Size = new Size(151, 29);
            numPrecio.TabIndex = 42;
            // 
            // numCosto
            // 
            numCosto.DecimalPlaces = 2;
            numCosto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numCosto.Location = new Point(33, 109);
            numCosto.Maximum = new decimal(new int[] { 999999999, 0, 0, 0 });
            numCosto.Name = "numCosto";
            numCosto.Size = new Size(151, 29);
            numCosto.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(33, 152);
            label5.Name = "label5";
            label5.Size = new Size(129, 21);
            label5.TabIndex = 40;
            label5.Text = "Precio de Venta";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(33, 81);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 39;
            label3.Text = "Precio de Costo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(33, 10);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 38;
            label2.Text = "Descripción";
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.FlatStyle = FlatStyle.Popup;
            btnModificar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(402, 38);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(134, 40);
            btnModificar.TabIndex = 37;
            btnModificar.Text = "GUARDAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // frmMdificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(564, 395);
            Controls.Add(numStock);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(label6);
            Controls.Add(txtDescripcion);
            Controls.Add(numPrecio);
            Controls.Add(numCosto);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnModificar);
            Name = "frmMdificarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Modificar Producto";
            Load += frmMdificarProducto_Load;
            ((System.ComponentModel.ISupportInitialize)numStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCosto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown numStock;
        private Label label1;
        private TextBox txtUsuario;
        private Label label6;
        private TextBox txtDescripcion;
        private NumericUpDown numPrecio;
        private NumericUpDown numCosto;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button btnModificar;
    }
}