using DominioAlumno;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class FormModificar : Form
    {
        int id;
        public FormModificar(int id)
        {
            InitializeComponent();
            this.id = id;
        }

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        private async void buttonmodificar_Click(object sender, EventArgs e)
        {
            String nombre = inputNombre.Text;
            String apellio = inputApellido.Text;
            String direccion = inputDir.Text;
            String legajo = inputLegajo.Text;

            var alu = new Alumno()
            {
                Id = this.id,
                Nombre = nombre,
                Apellido = apellio,
                Direccion = direccion,
                Legajo = legajo
            };

            await _httpClient.PutAsJsonAsync($"alumnos/{id}", alu);
        }
    }
}
