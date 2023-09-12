namespace forms
{
    partial class FormAgregar
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
            inputNombre = new TextBox();
            inputApellido = new TextBox();
            inputLegajo = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            inputDir = new TextBox();
            label4 = new Label();
            agregar = new Button();
            SuspendLayout();
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(121, 100);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(100, 23);
            inputNombre.TabIndex = 0;
            inputNombre.TextChanged += inputNombre_TextChanged;
            // 
            // inputApellido
            // 
            inputApellido.Location = new Point(121, 143);
            inputApellido.Name = "inputApellido";
            inputApellido.Size = new Size(100, 23);
            inputApellido.TabIndex = 1;
            // 
            // inputLegajo
            // 
            inputLegajo.Location = new Point(121, 189);
            inputLegajo.Name = "inputLegajo";
            inputLegajo.Size = new Size(100, 23);
            inputLegajo.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(62, 100);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 143);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 192);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 5;
            label3.Text = "Legajo";
            // 
            // inputDir
            // 
            inputDir.Location = new Point(121, 235);
            inputDir.Name = "inputDir";
            inputDir.Size = new Size(100, 23);
            inputDir.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 243);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 7;
            label4.Text = "Dirección";
            // 
            // agregar
            // 
            agregar.Location = new Point(121, 282);
            agregar.Name = "agregar";
            agregar.Size = new Size(100, 23);
            agregar.TabIndex = 8;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += agregar_Click;
            // 
            // FormAgregar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 450);
            Controls.Add(agregar);
            Controls.Add(label4);
            Controls.Add(inputDir);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputLegajo);
            Controls.Add(inputApellido);
            Controls.Add(inputNombre);
            Name = "FormAgregar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox inputNombre;
        private TextBox inputApellido;
        private TextBox inputLegajo;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox inputDir;
        private Label label4;
        private Button agregar;
    }
}