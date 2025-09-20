namespace pryVargasSP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Declaración variables
        int Intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" && txtContraseña.Text == "adm135$") ||
                (txtUsuario.Text == "Operador" && txtContraseña.Text == "ope246$"))
            {
                frmBienvenido VentanaBienvenido = new frmBienvenido();
                VentanaBienvenido.ShowDialog();

                //Limpiamos controles
                txtContraseña.Text = "";
                txtUsuario.Text = "";
            }
            else
            {
                Intentos++;
                MessageBox.Show("Datos incorrectos. Acceso denegado", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContraseña.Text = "";
                txtUsuario.Text = "";
                if (Intentos == 3)
                {
                    this.Close();
                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                txtContraseña.Enabled = true;
            }
            else
            {
                txtContraseña.Enabled = false;
            }
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "")
            {
                btnAceptar.Enabled = true;
            }
            else
            {
                btnAceptar.Enabled = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Limpiamos controles
            txtContraseña.Text = "";
            txtUsuario.Text = "";

        }
    }
}
