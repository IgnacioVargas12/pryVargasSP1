namespace pryVargasSP1
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblUsuario = new Label();
            lblContraseña = new Label();
            btnAceptar = new Button();
            btnCancelar = new Button();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            SuspendLayout();
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 12F);
            lblUsuario.Location = new Point(22, 35);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(68, 21);
            lblUsuario.TabIndex = 0;
            lblUsuario.Text = "Usuario ";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 12F);
            lblContraseña.Location = new Point(22, 78);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(93, 21);
            lblContraseña.TabIndex = 1;
            lblContraseña.Text = "Contraseña ";
            // 
            // btnAceptar
            // 
            btnAceptar.Enabled = false;
            btnAceptar.Font = new Font("Segoe UI", 12F);
            btnAceptar.Location = new Point(250, 128);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(93, 34);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(151, 128);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(93, 34);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(117, 32);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(167, 29);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Font = new Font("Segoe UI", 12F);
            txtContraseña.Location = new Point(117, 75);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '#';
            txtContraseña.Size = new Size(167, 29);
            txtContraseña.TabIndex = 1;
            txtContraseña.TextChanged += txtContraseña_TextChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 174);
            Controls.Add(txtContraseña);
            Controls.Add(txtUsuario);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsuario;
        private Label lblContraseña;
        private Button btnAceptar;
        private Button btnCancelar;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
    }
}
