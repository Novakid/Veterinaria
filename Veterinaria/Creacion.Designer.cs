namespace Veterinaria
{
    partial class Creacion
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
            btnCrearUsuario = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtCrearUsuario = new TextBox();
            txtCrearContra = new TextBox();
            txtCompararContra = new TextBox();
            lblResultado = new Label();
            button1 = new Button();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            SuspendLayout();
            // 
            // btnCrearUsuario
            // 
            btnCrearUsuario.FlatStyle = FlatStyle.Flat;
            btnCrearUsuario.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCrearUsuario.Location = new Point(199, 276);
            btnCrearUsuario.Name = "btnCrearUsuario";
            btnCrearUsuario.Size = new Size(75, 23);
            btnCrearUsuario.TabIndex = 0;
            btnCrearUsuario.Text = "INGRESAR";
            btnCrearUsuario.UseVisualStyleBackColor = true;
            btnCrearUsuario.Click += btnCrearUsuario_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(98, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 1;
            label1.Text = "CREACION DE USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 94);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(78, 134);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 172);
            label4.Name = "label4";
            label4.Size = new Size(116, 15);
            label4.TabIndex = 4;
            label4.Text = "Repita su contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 217);
            label5.Name = "label5";
            label5.Size = new Size(108, 15);
            label5.TabIndex = 5;
            label5.Text = "Seleccione su Nivel";
            // 
            // txtCrearUsuario
            // 
            txtCrearUsuario.Location = new Point(151, 91);
            txtCrearUsuario.Name = "txtCrearUsuario";
            txtCrearUsuario.Size = new Size(189, 23);
            txtCrearUsuario.TabIndex = 6;
            // 
            // txtCrearContra
            // 
            txtCrearContra.Location = new Point(151, 131);
            txtCrearContra.Name = "txtCrearContra";
            txtCrearContra.Size = new Size(189, 23);
            txtCrearContra.TabIndex = 7;
            // 
            // txtCompararContra
            // 
            txtCompararContra.Location = new Point(151, 169);
            txtCompararContra.Name = "txtCompararContra";
            txtCompararContra.Size = new Size(189, 23);
            txtCompararContra.TabIndex = 8;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(285, 280);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(419, 328);
            button1.Name = "button1";
            button1.Size = new Size(90, 23);
            button1.TabIndex = 11;
            button1.Text = "REGRESAR";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(166, 215);
            rb1.Name = "rb1";
            rb1.Size = new Size(61, 19);
            rb1.TabIndex = 12;
            rb1.TabStop = true;
            rb1.Text = "Nivel 1";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(258, 215);
            rb2.Name = "rb2";
            rb2.Size = new Size(61, 19);
            rb2.TabIndex = 13;
            rb2.TabStop = true;
            rb2.Text = "Nivel 2";
            rb2.UseVisualStyleBackColor = true;
            // 
            // Creacion
            // 
            AcceptButton = btnCrearUsuario;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 363);
            ControlBox = false;
            Controls.Add(rb2);
            Controls.Add(rb1);
            Controls.Add(button1);
            Controls.Add(lblResultado);
            Controls.Add(txtCompararContra);
            Controls.Add(txtCrearContra);
            Controls.Add(txtCrearUsuario);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCrearUsuario);
            Cursor = Cursors.Hand;
            Name = "Creacion";
            Text = "Creación de usuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCrearUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtCrearUsuario;
        private TextBox txtCrearContra;
        private TextBox txtCompararContra;
        private Label lblResultado;
        private Button button1;
        private RadioButton rb1;
        private RadioButton rb2;
    }
}