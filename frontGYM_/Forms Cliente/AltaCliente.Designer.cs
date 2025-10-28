namespace frontGYM_
{
    partial class AltaCliente
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Dni = new TextBox();
            Direccion = new TextBox();
            Nombre = new TextBox();
            Apellido = new TextBox();
            Telefono = new TextBox();
            Registro = new Button();
            label7 = new Label();
            comboBox1 = new ComboBox();
            Volver = new Button();
            errorProvider1 = new ErrorProvider(components);
            FechaInicio = new DateTimePicker();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 63);
            label1.Name = "label1";
            label1.Size = new Size(27, 15);
            label1.TabIndex = 0;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(157, 98);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Dirección";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 131);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 169);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(164, 201);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 4;
            label5.Text = "Teléfono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(276, 29);
            label6.Name = "label6";
            label6.Size = new Size(146, 17);
            label6.TabIndex = 5;
            label6.Text = "CARGAR CLIENTE";
            // 
            // Dni
            // 
            Dni.Location = new Point(240, 61);
            Dni.Margin = new Padding(3, 2, 3, 2);
            Dni.Name = "Dni";
            Dni.Size = new Size(261, 23);
            Dni.TabIndex = 6;
            // 
            // Direccion
            // 
            Direccion.Location = new Point(240, 98);
            Direccion.Margin = new Padding(3, 2, 3, 2);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(261, 23);
            Direccion.TabIndex = 7;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(240, 131);
            Nombre.Margin = new Padding(3, 2, 3, 2);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(261, 23);
            Nombre.TabIndex = 8;
            // 
            // Apellido
            // 
            Apellido.Location = new Point(240, 169);
            Apellido.Margin = new Padding(3, 2, 3, 2);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(261, 23);
            Apellido.TabIndex = 9;
            // 
            // Telefono
            // 
            Telefono.Location = new Point(240, 201);
            Telefono.Margin = new Padding(3, 2, 3, 2);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(261, 23);
            Telefono.TabIndex = 10;
            // 
            // Registro
            // 
            Registro.Location = new Point(313, 270);
            Registro.Margin = new Padding(3, 2, 3, 2);
            Registro.Name = "Registro";
            Registro.Size = new Size(82, 22);
            Registro.TabIndex = 11;
            Registro.Text = "Registrar!";
            Registro.UseVisualStyleBackColor = true;
            Registro.Click += Registro_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(121, 236);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 12;
            label7.Text = "Tipo suscripción";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(240, 236);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(261, 23);
            comboBox1.TabIndex = 13;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(581, 290);
            Volver.Margin = new Padding(3, 2, 3, 2);
            Volver.Name = "Volver";
            Volver.Size = new Size(92, 27);
            Volver.TabIndex = 14;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FechaInicio
            // 
            FechaInicio.Location = new Point(626, 59);
            FechaInicio.Margin = new Padding(3, 2, 3, 2);
            FechaInicio.Name = "FechaInicio";
            FechaInicio.Size = new Size(239, 23);
            FechaInicio.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(515, 63);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 16;
            label8.Text = "Fecha Inicio";
            // 
            // AltaCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 331);
            Controls.Add(label8);
            Controls.Add(FechaInicio);
            Controls.Add(Volver);
            Controls.Add(comboBox1);
            Controls.Add(label7);
            Controls.Add(Registro);
            Controls.Add(Telefono);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(Direccion);
            Controls.Add(Dni);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AltaCliente";
            Text = "AltaCliente";
            Load += AltaCliente_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox Dni;
        private TextBox Direccion;
        private TextBox Nombre;
        private TextBox Apellido;
        private TextBox Telefono;
        private Button Registro;
        private Label label7;
        private ComboBox comboBox1;
        private Button Volver;
        private ErrorProvider errorProvider1;
        private Label label8;
        private DateTimePicker FechaInicio;
    }
}