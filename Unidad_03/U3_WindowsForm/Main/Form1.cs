namespace Main
{
    using Login;
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void menuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            LoginForm appLogin = new LoginForm();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }



        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void grillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGrilla grilla = new FormGrilla();
            grilla.ShowDialog();
        }
    }
}