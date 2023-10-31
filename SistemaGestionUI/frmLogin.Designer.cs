namespace SistemaGestionUI
{
    partial class frmLogin
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
            txtlabelUsuario = new TextBox();
            txtlabelContraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnEntrar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtlabelUsuario
            // 
            txtlabelUsuario.Location = new Point(114, 28);
            txtlabelUsuario.Name = "txtlabelUsuario";
            txtlabelUsuario.Size = new Size(168, 23);
            txtlabelUsuario.TabIndex = 0;
            txtlabelUsuario.TextChanged += txtlabelUsuario_TextChanged;
            // 
            // txtlabelContraseña
            // 
            txtlabelContraseña.Location = new Point(114, 65);
            txtlabelContraseña.Name = "txtlabelContraseña";
            txtlabelContraseña.Size = new Size(166, 23);
            txtlabelContraseña.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(114, 110);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(93, 44);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Login";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(114, 177);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(88, 42);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(329, 231);
            Controls.Add(btnSalir);
            Controls.Add(btnEntrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtlabelContraseña);
            Controls.Add(txtlabelUsuario);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtlabelUsuario;
        private TextBox txtlabelContraseña;
        private Label label1;
        private Label label2;
        private Button btnEntrar;
        private Button btnSalir;
    }
}