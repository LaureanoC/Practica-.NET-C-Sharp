namespace Login
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.input_pass.Text == "qwerty" && this.input_usuario.Text == "Laureano")
            {
                MessageBox.Show("Bienvenido al Sistema, Laureano");
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrectos", "Login"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void titulo_Click(object sender, EventArgs e)
        {

        }

        private void link_olvido_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Recuerdala");
        }
    }
}