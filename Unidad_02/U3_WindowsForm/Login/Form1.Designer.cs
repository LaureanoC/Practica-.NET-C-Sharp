namespace Login
{
    partial class LoginForm
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
            titulo = new Label();
            nombre = new Label();
            contrasena = new Label();
            input_usuario = new TextBox();
            input_pass = new TextBox();
            button1 = new Button();
            link_olvido = new LinkLabel();
            SuspendLayout();
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.Location = new Point(149, 52);
            titulo.Name = "titulo";
            titulo.Size = new Size(37, 15);
            titulo.TabIndex = 0;
            titulo.Text = "Login";
            titulo.Click += titulo_Click;
            // 
            // nombre
            // 
            nombre.AutoSize = true;
            nombre.Location = new Point(50, 110);
            nombre.Name = "nombre";
            nombre.Size = new Size(47, 15);
            nombre.TabIndex = 1;
            nombre.Text = "Usuario";
            nombre.Click += label1_Click;
            // 
            // contrasena
            // 
            contrasena.AutoSize = true;
            contrasena.Location = new Point(50, 165);
            contrasena.Name = "contrasena";
            contrasena.Size = new Size(67, 15);
            contrasena.TabIndex = 2;
            contrasena.Text = "Contraseña";
            // 
            // input_usuario
            // 
            input_usuario.Location = new Point(123, 107);
            input_usuario.Name = "input_usuario";
            input_usuario.Size = new Size(157, 23);
            input_usuario.TabIndex = 3;
            // 
            // input_pass
            // 
            input_pass.Location = new Point(123, 162);
            input_pass.Name = "input_pass";
            input_pass.PasswordChar = '*';
            input_pass.Size = new Size(157, 23);
            input_pass.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(50, 205);
            button1.Name = "button1";
            button1.Size = new Size(230, 23);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // link_olvido
            // 
            link_olvido.AutoSize = true;
            link_olvido.Location = new Point(50, 271);
            link_olvido.Name = "link_olvido";
            link_olvido.Size = new Size(119, 15);
            link_olvido.TabIndex = 6;
            link_olvido.TabStop = true;
            link_olvido.Text = "Olvide mi contraseña";
            link_olvido.LinkClicked += link_olvido_LinkClicked;
            // 
            // LoginForm
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(357, 329);
            Controls.Add(link_olvido);
            Controls.Add(button1);
            Controls.Add(input_pass);
            Controls.Add(input_usuario);
            Controls.Add(contrasena);
            Controls.Add(nombre);
            Controls.Add(titulo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titulo;
        private Label nombre;
        private Label contrasena;
        private TextBox input_usuario;
        private TextBox input_pass;
        private Button button1;
        private LinkLabel link_olvido;
    }
}