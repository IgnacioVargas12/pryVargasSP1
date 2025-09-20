namespace pryVargasSP1
{
    partial class frmBienvenido
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
            lblBienvenido = new Label();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.BackColor = SystemColors.ActiveCaption;
            lblBienvenido.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenido.Font = new Font("Segoe UI", 50F);
            lblBienvenido.Location = new Point(50, 29);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(366, 106);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido";
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI", 16F);
            btnAceptar.Location = new Point(182, 158);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(110, 43);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmBienvenido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 213);
            Controls.Add(btnAceptar);
            Controls.Add(lblBienvenido);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmBienvenido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bienvenido";
            ResumeLayout(false);
        }

        #endregion

        private Label lblBienvenido;
        private Button btnAceptar;
    }
}