namespace forms
{
    partial class FormModificar
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
            buttonmodificar = new Button();
            inputNombre = new TextBox();
            inputApellido = new TextBox();
            inputLegajo = new TextBox();
            inputDir = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // buttonmodificar
            // 
            buttonmodificar.Location = new Point(120, 310);
            buttonmodificar.Name = "buttonmodificar";
            buttonmodificar.Size = new Size(75, 23);
            buttonmodificar.TabIndex = 0;
            buttonmodificar.Text = "Modificar";
            buttonmodificar.UseVisualStyleBackColor = true;
            buttonmodificar.Click += buttonmodificar_Click;
            // 
            // inputNombre
            // 
            inputNombre.Location = new Point(120, 112);
            inputNombre.Name = "inputNombre";
            inputNombre.Size = new Size(100, 23);
            inputNombre.TabIndex = 1;
            // 
            // inputApellido
            // 
            inputApellido.Location = new Point(120, 161);
            inputApellido.Name = "inputApellido";
            inputApellido.Size = new Size(100, 23);
            inputApellido.TabIndex = 2;
            // 
            // inputLegajo
            // 
            inputLegajo.Location = new Point(120, 209);
            inputLegajo.Name = "inputLegajo";
            inputLegajo.Size = new Size(100, 23);
            inputLegajo.TabIndex = 3;
            // 
            // inputDir
            // 
            inputDir.Location = new Point(120, 257);
            inputDir.Name = "inputDir";
            inputDir.Size = new Size(100, 23);
            inputDir.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 115);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 164);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 212);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 7;
            label3.Text = "Legajo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 260);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 8;
            label4.Text = "Direcci'ón";
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(inputDir);
            Controls.Add(inputLegajo);
            Controls.Add(inputApellido);
            Controls.Add(inputNombre);
            Controls.Add(buttonmodificar);
            Name = "FormModificar";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonmodificar;
        private TextBox inputNombre;
        private TextBox inputApellido;
        private TextBox inputLegajo;
        private TextBox inputDir;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}