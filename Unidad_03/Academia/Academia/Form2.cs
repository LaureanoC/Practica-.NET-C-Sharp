using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class FormAgregar : Form
    {
        public FormAgregar(bool agregar, int id)
        {
            InitializeComponent();
            this.ag = agregar;
            this.id = id;
        }

        private bool ag;
        private int id;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AcademiaABM formPrincipal = Owner as AcademiaABM;
            if (this.ag)
            {
                string nom = this.inputNombre.Text;
                string loc = this.inputLocalidad.Text;
                Persona p = new Persona(nom, loc);

                

                if (formPrincipal != null)
                {
                    formPrincipal.personas.Add(p);
                    this.Close();
                }
            }
            else
            {
                var p = formPrincipal.personas.FirstOrDefault(p => p.Id == this.id);

                p.Nombre = this.inputNombre.Text;
                p.Localidad = this.inputLocalidad.Text;
                this.Close();
            }

        }

        private void FormAgregar_Load(object sender, EventArgs e)
        {
            if (ag == false) 
            {
                this.titulo.Text = "Modificar Persona";
                this.btnAgregar.Text = "Modificar";
            }
        }
    }
}
