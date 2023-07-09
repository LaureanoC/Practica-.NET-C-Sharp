namespace Academia
{
    partial class FormAgregar
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
            inputNombre = new TextBox();
            inputLocalidad = new TextBox();
            label1 = new Label();
            label2 = new Label();
            titulo = new Label();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(123, 89);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(100, 23);
            inputNombre.TabIndex = 0;
            // 
            // inputLocalidad
            // 
            inputLocalidad.Location = new Point(123, 129);
            inputLocalidad.Name = "inputLocalidad";
            inputLocalidad.Size = new Size(100, 23);
            inputLocalidad.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 89);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 129);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 3;
            label2.Text = "Localidad";
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Location = new Point(123, 40);
            titulo.Name = "titulo";
            titulo.Size = new Size(94, 15);
            titulo.TabIndex = 4;
            titulo.Text = "Agregar Persona";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(123, 173);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 307);
            Controls.Add(btnAgregar);
            Controls.Add(titulo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputLocalidad);
            Controls.Add(inputNombre);
            Name = "FormAgregar";
            Text = "Form2";
            Load += FormAgregar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputNombre;
        private TextBox inputLocalidad;
        private Label label1;
        private Label label2;
        private Label titulo;
        private Button btnAgregar;
    }
}