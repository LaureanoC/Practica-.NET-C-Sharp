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
    public partial class FormGrilla : Form
    {
        public FormGrilla()
        {
            InitializeComponent();
            this.personas.Add(new Persona("Laureano", "Chaves", "Arrecifes"));


        }

        public List<Persona> personas = new List<Persona>();

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FormAgregar form = new FormAgregar();
            form.Owner = this;
            form.ShowDialog();
            grillaview.DataSource = null; // No me funcionaba el Refresh()
            grillaview.DataSource = this.personas;
        }

        private void grillaview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {

        }
    }
}
