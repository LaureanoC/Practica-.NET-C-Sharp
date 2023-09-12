using DominioAlumno;
using System.Net.Http.Json;

namespace forms
{
    public partial class FormAgregar : Form
    {

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };


        public FormAgregar()
        {
            InitializeComponent();
        }

        private void inputNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private async void agregar_Click(object sender, EventArgs e)
        {
            String nombre = inputNombre.Text;
            String apellio = inputApellido.Text;
            String direccion = inputDir.Text;
            String legajo = inputLegajo.Text;

            var alu = new Alumno()
            {
                Nombre = nombre,
                Apellido = apellio,
                Direccion = direccion,
                Legajo = legajo
            };

            await _httpClient.PostAsJsonAsync("alumnos", alu);


        }
    }
}