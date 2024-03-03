namespace Veterinaria
{
    partial class Inicio
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
            btnEntrar = new Button();
            btnSalir = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            lblCrearUsuario = new LinkLabel();
            SuspendLayout();
            // 
            // btnEntrar
            // 
            btnEntrar.FlatStyle = FlatStyle.Popup;
            btnEntrar.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(287, 262);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 0;
            btnEntrar.Text = "ENTRAR";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.ActiveCaption;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(559, 316);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 1;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(216, -3);
            label1.Name = "label1";
            label1.Size = new Size(208, 38);
            label1.TabIndex = 2;
            label1.Text = "BIENVENIDO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(260, 89);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 3;
            label2.Text = "INGRESE SU USUARIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(244, 186);
            label3.Name = "label3";
            label3.Size = new Size(148, 15);
            label3.TabIndex = 4;
            label3.Text = "INGRESE SU CONTRASEÑA";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = SystemColors.Window;
            txtUsuario.Location = new Point(216, 107);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(208, 23);
            txtUsuario.TabIndex = 5;
            txtUsuario.TextAlign = HorizontalAlignment.Center;
            // 
            // txtContra
            // 
            txtContra.BackColor = SystemColors.Window;
            txtContra.ForeColor = SystemColors.WindowText;
            txtContra.Location = new Point(216, 204);
            txtContra.Name = "txtContra";
            txtContra.PasswordChar = '*';
            txtContra.Size = new Size(208, 23);
            txtContra.TabIndex = 6;
            txtContra.TextAlign = HorizontalAlignment.Center;
            // 
            // lblCrearUsuario
            // 
            lblCrearUsuario.AutoSize = true;
            lblCrearUsuario.Location = new Point(262, 300);
            lblCrearUsuario.Name = "lblCrearUsuario";
            lblCrearUsuario.Size = new Size(130, 15);
            lblCrearUsuario.TabIndex = 7;
            lblCrearUsuario.TabStop = true;
            lblCrearUsuario.Text = "Crear un nuevo usuario";
            lblCrearUsuario.LinkClicked += lblCrearUsuario_LinkClicked;
            // 
            // Inicio
            // 
            AcceptButton = btnEntrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 351);
            ControlBox = false;
            Controls.Add(lblCrearUsuario);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalir);
            Controls.Add(btnEntrar);
            Cursor = Cursors.Hand;
            Name = "Inicio";
            Text = "Veterinaria Ginger Yum";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntrar;
        private Button btnSalir;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private LinkLabel lblCrearUsuario;
    }
}