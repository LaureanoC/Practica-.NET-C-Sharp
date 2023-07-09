namespace Main
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
            btnAgregar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            inputNombre = new TextBox();
            inputApellido = new TextBox();
            inputLocalidad = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(110, 214);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 90);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 134);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 173);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 3;
            label3.Text = "Localidad";
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(110, 90);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(100, 23);
            inputNombre.TabIndex = 4;
            // 
            // inputApellido
            // 
            inputApellido.Location = new Point(110, 131);
            inputApellido.Name = "inputApellido";
            inputApellido.Size = new Size(100, 23);
            inputApellido.TabIndex = 5;
            // 
            // inputLocalidad
            // 
            inputLocalidad.Location = new Point(110, 170);
            inputLocalidad.Name = "inputLocalidad";
            inputLocalidad.Size = new Size(100, 23);
            inputLocalidad.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(82, 42);
            label4.Name = "label4";
            label4.Size = new Size(94, 15);
            label4.TabIndex = 7;
            label4.Text = "Agregar Persona";
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(271, 292);
            Controls.Add(label4);
            Controls.Add(inputLocalidad);
            Controls.Add(inputApellido);
            Controls.Add(inputNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnAgregar);
            Name = "FormAgregar";
            Text = "Academia Agregar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inputNombre;
        private TextBox inputApellido;
        private TextBox inputLocalidad;
        private Label label4;
    }
}