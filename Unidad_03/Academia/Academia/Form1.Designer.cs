namespace Academia
{
    partial class AcademiaABM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grilla = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            localidadDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personaBindingSource = new BindingSource(components);
            btnActualizar = new Button();
            btnSalir = new Button();
            btnAgregar = new Button();
            btnBorrar = new Button();
            ((System.ComponentModel.ISupportInitialize)grilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).BeginInit();
            SuspendLayout();
            // 
            // grilla
            // 
            grilla.AutoGenerateColumns = false;
            grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grilla.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, localidadDataGridViewTextBoxColumn });
            grilla.DataSource = personaBindingSource;
            grilla.Location = new Point(12, 12);
            grilla.Name = "grilla";
            grilla.RowTemplate.Height = 25;
            grilla.Size = new Size(344, 363);
            grilla.TabIndex = 0;
            grilla.CellContentClick += grilla_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localidadDataGridViewTextBoxColumn
            // 
            localidadDataGridViewTextBoxColumn.DataPropertyName = "Localidad";
            localidadDataGridViewTextBoxColumn.HeaderText = "Localidad";
            localidadDataGridViewTextBoxColumn.Name = "localidadDataGridViewTextBoxColumn";
            localidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personaBindingSource
            // 
            personaBindingSource.DataSource = typeof(ClassLibrary1.Persona);
            personaBindingSource.CurrentChanged += personaBindingSource_CurrentChanged;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(93, 381);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(75, 23);
            btnActualizar.TabIndex = 1;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(281, 381);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 381);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(174, 381);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // AcademiaABM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 411);
            Controls.Add(btnBorrar);
            Controls.Add(btnAgregar);
            Controls.Add(btnSalir);
            Controls.Add(btnActualizar);
            Controls.Add(grilla);
            Name = "AcademiaABM";
            Text = "AcademiaABM";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)personaBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grilla;
        private Button btnActualizar;
        private Button btnSalir;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn localidadDataGridViewTextBoxColumn;
        private BindingSource personaBindingSource;
        private Button btnAgregar;
        private Button btnBorrar;
    }
}