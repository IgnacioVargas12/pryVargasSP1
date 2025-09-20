namespace pryVargasSP1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Declaraci�n variables
        int Intentos = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Administrador" && txtContrase�a.Text == "adm135$") ||
                (txtUsuario.Text == "Operador" && txtContrase�a.Text == "ope246$"))
            {
                frmBienvenido VentanaBienvenido = new frmBienvenido();
                VentanaBienvenido.ShowDialog();

                //Limpiamos controles
                txtContrase�a.Text = "";
                txtUsuario.Text = "";
            }
            else
            {
                Intentos++;
                MessageBox.Show("Datos incorrectos. Acceso denegado", "Datos Incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtContrase�a.Text = "";
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
                txtContrase�a.Enabled = true;
            }
            else
            {
                txtContrase�a.Enabled = false;
            }
        }

        private void txtContrase�a_TextChanged(object sender, EventArgs e)
        {
            if (txtContrase�a.Text != "")
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
            txtContrase�a.Text = "";
            txtUsuario.Text = "";

        }
    }
}
