namespace Academia
{
    using ClassLibrary1;
    public partial class AcademiaABM : Form
    {

        public AcademiaABM()
        {
            InitializeComponent();
        }

        public List<Persona> personas = new List<Persona>();

        public void listar()
        {
            personas.Add(new Persona("Laureano", "Arrecifes"));
            personas.Add(new Persona("Esteban", "Rosario"));
            personas.Add(new Persona("Roberto", "Pehuajo"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listar();
            grilla.DataSource = personas;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void personaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.grilla.SelectedRows[0].Cells[0].Value);

                FormAgregar form = new FormAgregar(false, id);
                form.Owner = this; // Establece el formulario principal como propietario del formulario secundario
                form.ShowDialog();
                grilla.DataSource = null;
                grilla.DataSource = this.personas;
            }
            catch (Exception ex)
            {
                return;
            }



        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar form = new FormAgregar(true, 0);
            form.Owner = this; // Establece el formulario principal como propietario del formulario secundario
            form.ShowDialog();
            grilla.DataSource = null;
            grilla.DataSource = this.personas;
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.grilla.SelectedRows[0].Cells[0].Value);

                var p = personas.FirstOrDefault(p => p.Id == id);

                personas.Remove(p);

                grilla.DataSource = null;
                grilla.DataSource = this.personas;
            }
            catch (Exception ex)
            {
                return;
            }
        }
    }


}