using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaDeClases;

namespace Main
{
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {

            InitializeComponent();
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = this.inputNombre.Text;
            string apellido = this.inputApellido.Text;
            string localidad = this.inputLocalidad.Text;

            Persona p = new Persona(nombre, apellido, localidad);

            // Obtener el formulario padre
            FormGrilla formPadre = this.Owner as FormGrilla;

            formPadre.personas.Add(p);
            

        }
    }
}
