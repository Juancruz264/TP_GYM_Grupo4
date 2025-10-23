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
            CrearClase = new Button();
            Profesor = new TextBox();
            Nombre = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(638, 388);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 23;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            // 
            // CrearClase
            // 
            CrearClase.Location = new Point(354, 290);
            CrearClase.Name = "CrearClase";
            CrearClase.Size = new Size(94, 29);
            CrearClase.TabIndex = 22;
            CrearClase.Text = "Crear!";
            CrearClase.UseVisualStyleBackColor = true;
            CrearClase.Click += CrearClase_Click;
            // 
            // Profesor
            // 
            Profesor.Location = new Point(267, 183);
            Profesor.Name = "Profesor";
            Profesor.Size = new Size(298, 27);
            Profesor.TabIndex = 20;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(267, 137);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(298, 27);
            Nombre.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(324, 89);
            label6.Name = "label6";
            label6.Size = new Size(153, 20);
            label6.TabIndex = 18;
            label6.Text = "CARGAR CLASE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(180, 231);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 17;
            label3.Text = "Horario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(172, 186);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 16;
            label2.Text = "Profesor";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 140);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 15;
            label1.Text = "Nombre";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(267, 231);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(297, 28);
            comboBox1.TabIndex = 24;
            // 
            // AltaClase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(Volver);
            Controls.Add(CrearClase);
            Controls.Add(Profesor);
            Controls.Add(Nombre);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AltaClase";
            Text = "AltaClase";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Volver;
        private Button CrearClase;
        private TextBox Horario;
        private TextBox Profesor;
        private TextBox Nombre;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
    }
}