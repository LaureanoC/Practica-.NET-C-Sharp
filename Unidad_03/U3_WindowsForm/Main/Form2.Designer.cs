namespace Main
{
    partial class FormGrilla
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grillaview = new DataGridView();
            personaBindingSource = new BindingSource(components);
            buttonAgregar = new Button();
            buttonModificar = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)grillaview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // grillaview
            // 
            grillaview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grillaview.Location = new Point(127, 44);
            grillaview.Name = "grillaview";
            grillaview.RowTemplate.Height = 25;
            grillaview.Size = new Size(517, 276);
            grillaview.TabIndex = 0;
            grillaview.CellContentClick += grillaview_CellContentClick;
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(LibreriaDeClases.Persona);
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(127, 342);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(156, 23);
            buttonAgregar.TabIndex = 1;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            buttonAgregar.Click += buttonAgregar_Click;
            // 
            // buttonModificar
            // 
            buttonModificar.Location = new Point(310, 342);
            buttonModificar.Name = "buttonModificar";
            buttonModificar.Size = new Size(156, 23);
            buttonModificar.TabIndex = 2;
            buttonModificar.Text = "Modificar";
            buttonModificar.UseVisualStyleBackColor = true;
            buttonModificar.Click += buttonModificar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(488, 342);
            button2.Name = "button2";
            button2.Size = new Size(156, 23);
            button2.TabIndex = 3;
            button2.Text = "Borrar";
            button2.UseVisualStyleBackColor = true;
            // 
            // FormGrilla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonModificar);
            Controls.Add(buttonAgregar);
            Controls.Add(grillaview);
            Name = "FormGrilla";
            Text = "Academia Grilla";
            ((System.ComponentModel.ISupportInitialize)grillaview).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grillaview;
        private Button buttonAgregar;
        private Button buttonModificar;
        private Button button2;
        private BindingSource personaBindingSource;
    }
}