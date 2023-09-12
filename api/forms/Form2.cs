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
using DominioAlumno;

namespace forms
{
    public partial class Form2 : Form
    {

        private readonly HttpClient _httpClient = new()
        {
            BaseAddress = new Uri("http://localhost:5297")
        };

        public Form2()
        {
            InitializeComponent();
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            var alumnos = await _httpClient.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");
            this.dataAlumno.DataSource = alumnos;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAgregar form = new FormAgregar();
            form.Owner = this;
            form.ShowDialog();

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataAlumno.SelectedRows[0].Cells[0].Value);

            var alumno = await _httpClient.GetFromJsonAsync<Alumno>($"alumnos/{id}");

            MessageBox.Show("Hola " + alumno.Nombre);

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataAlumno.SelectedRows[0].Cells[0].Value);

            FormModificar formMod = new FormModificar(id);
            formMod.Owner = this;
            formMod.ShowDialog();

            var alumnos = await _httpClient.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");
            this.dataAlumno.DataSource = alumnos;

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.dataAlumno.SelectedRows[0].Cells[0].Value);


            var alumno = await _httpClient.DeleteAsync($"alumnos/{id}");

            var alumnos = await _httpClient.GetFromJsonAsync<IEnumerable<Alumno>>("alumnos");
            this.dataAlumno.DataSource = alumnos;


        }
    }
}
