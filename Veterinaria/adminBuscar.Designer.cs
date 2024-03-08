namespace Veterinaria
{
    partial class adminBuscar
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
            BtnBuscar = new Button();
            rb1 = new RadioButton();
            rb2 = new RadioButton();
            btnEditar = new Button();
            btnEliminar = new Button();
            lb1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBuscar = new TextBox();
            txtUsuario = new TextBox();
            txtContra = new TextBox();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // BtnBuscar
            // 
            BtnBuscar.Location = new Point(412, 46);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(75, 23);
            BtnBuscar.TabIndex = 0;
            BtnBuscar.Text = "BUSCAR";
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(195, 203);
            rb1.Name = "rb1";
            rb1.Size = new Size(65, 19);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "NIVEL 1";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(278, 203);
            rb2.Name = "rb2";
            rb2.Size = new Size(65, 19);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "NIVEL 2";
            rb2.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(412, 107);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 3;
            btnEditar.Text = "EDITAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(412, 164);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 4;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // lb1
            // 
            lb1.FormattingEnabled = true;
            lb1.ItemHeight = 15;
            lb1.Location = new Point(519, 9);
            lb1.Name = "lb1";
            lb1.Size = new Size(269, 304);
            lb1.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(192, 9);
            label1.Name = "label1";
            label1.Size = new Size(295, 15);
            label1.TabIndex = 6;
            label1.Text = "BUSCADOR DE USUARIO MEDIANTE NOMBRE O NIVEL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(179, 15);
            label2.TabIndex = 7;
            label2.Text = "INGRESA EL USUARIO A BUSCAR";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(133, 111);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 8;
            label3.Text = "NOMBRE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(106, 164);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 9;
            label4.Text = "CONTRASEÑA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(151, 207);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 10;
            label5.Text = "NIVEL";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(195, 47);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(148, 23);
            txtBuscar.TabIndex = 11;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(195, 103);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(148, 23);
            txtUsuario.TabIndex = 12;
            // 
            // txtContra
            // 
            txtContra.Location = new Point(195, 156);
            txtContra.Name = "txtContra";
            txtContra.Size = new Size(148, 23);
            txtContra.TabIndex = 13;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(416, 211);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += BtnSalir_Click;
            // 
            // adminBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 344);
            ControlBox = false;
            Controls.Add(btnSalir);
            Controls.Add(txtContra);
            Controls.Add(txtUsuario);
            Controls.Add(txtBuscar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lb1);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(rb2);
            Controls.Add(rb1);
            Controls.Add(BtnBuscar);
            Name = "adminBuscar";
            Text = "adminBuscar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBuscar;
        private RadioButton rb1;
        private RadioButton rb2;
        private Button btnEditar;
        private Button btnEliminar;
        private ListBox lb1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBuscar;
        private TextBox txtUsuario;
        private TextBox txtContra;
        private Button btnSalir;
    }
}