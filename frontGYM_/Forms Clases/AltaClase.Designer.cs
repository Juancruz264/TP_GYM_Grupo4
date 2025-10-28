namespace frontGYM_.Forms_Clases
{
    partial class AltaClase
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
            Volver = new Button();
            HoraFin = new DateTimePicker();
            label5 = new Label();
            HoraInicio = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            Profesor = new TextBox();
            label2 = new Label();
            label1 = new Label();
            Nombre = new TextBox();
            label6 = new Label();
            Registro = new Button();
            listBoxDias = new ListBox();
            SuspendLayout();
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(656, 433);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 23;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // HoraFin
            // 
            HoraFin.Format = DateTimePickerFormat.Time;
            HoraFin.Location = new Point(274, 332);
            HoraFin.Name = "HoraFin";
            HoraFin.ShowUpDown = true;
            HoraFin.Size = new Size(298, 27);
            HoraFin.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(109, 339);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 28;
            label5.Text = "Hora de finalización";
            // 
            // HoraInicio
            // 
            HoraInicio.Format = DateTimePickerFormat.Time;
            HoraInicio.Location = new Point(276, 282);
            HoraInicio.Name = "HoraInicio";
            HoraInicio.ShowUpDown = true;
            HoraInicio.Size = new Size(297, 27);
            HoraInicio.TabIndex = 25;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 289);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 27;
            label4.Text = "Hora de inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(214, 185);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 17;
            label3.Text = "Días";
            // 
            // Profesor
            // 
            Profesor.Location = new Point(275, 128);
            Profesor.Name = "Profesor";
            Profesor.Size = new Size(298, 27);
            Profesor.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 131);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 16;
            label2.Text = "Profesor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 85);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(275, 82);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(298, 27);
            Nombre.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(339, 37);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 18;
            label6.Text = "ALTA CLASE";
            // 
            // Registro
            // 
            Registro.BackColor = SystemColors.ButtonShadow;
            Registro.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Registro.Location = new Point(326, 388);
            Registro.Name = "Registro";
            Registro.Size = new Size(152, 39);
            Registro.TabIndex = 29;
            Registro.Text = "Registrar!";
            Registro.UseVisualStyleBackColor = false;
            Registro.Click += Registro_Click_1;
            // 
            // listBoxDias
            // 
            listBoxDias.FormattingEnabled = true;
            listBoxDias.Location = new Point(276, 173);
            listBoxDias.Name = "listBoxDias";
            listBoxDias.SelectionMode = SelectionMode.MultiSimple;
            listBoxDias.Size = new Size(297, 84);
            listBoxDias.TabIndex = 30;
            // 
            // AltaClase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 495);
            Controls.Add(listBoxDias);
            Controls.Add(Registro);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(HoraFin);
            Controls.Add(HoraInicio);
            Controls.Add(Volver);
            Controls.Add(Profesor);
            Controls.Add(Nombre);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaClase";
            Text = "AltaClase";
            Load += AltaClase_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Horario;
        private Button Volver;
        private DateTimePicker HoraFin;
        private Label label5;
        private DateTimePicker HoraInicio;
        private Label label4;
        private Label label3;
        private TextBox Profesor;
        private Label label2;
        private Label label1;
        private TextBox Nombre;
        private Label label6;
        private Button Registro;
        private ListBox listBoxDias;
    }
}