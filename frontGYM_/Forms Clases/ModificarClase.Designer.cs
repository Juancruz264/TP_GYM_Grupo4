namespace frontGYM_.Forms_Clases
{
    partial class ModificarClase
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
            dataGridView1 = new DataGridView();
            label6 = new Label();
            label1 = new Label();
            label2 = new Label();
            Nombre = new TextBox();
            Profesor = new TextBox();
            HoraInicio = new DateTimePicker();
            HoraFin = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            Volver = new Button();
            button2 = new Button();
            Id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(456, 50);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(447, 349);
            dataGridView1.TabIndex = 9;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(186, 9);
            label6.Name = "label6";
            label6.Size = new Size(309, 20);
            label6.TabIndex = 8;
            label6.Text = "MODIFICAR O ELIMINAR CLASE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 57);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 110);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 11;
            label2.Text = "Profesor";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(186, 54);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(219, 27);
            Nombre.TabIndex = 14;
            // 
            // Profesor
            // 
            Profesor.Location = new Point(186, 107);
            Profesor.Name = "Profesor";
            Profesor.Size = new Size(219, 27);
            Profesor.TabIndex = 15;
            // 
            // HoraInicio
            // 
            HoraInicio.Format = DateTimePickerFormat.Time;
            HoraInicio.Location = new Point(186, 158);
            HoraInicio.Name = "HoraInicio";
            HoraInicio.ShowUpDown = true;
            HoraInicio.Size = new Size(219, 27);
            HoraInicio.TabIndex = 16;
            // 
            // HoraFin
            // 
            HoraFin.Format = DateTimePickerFormat.Time;
            HoraFin.Location = new Point(186, 217);
            HoraFin.Name = "HoraFin";
            HoraFin.ShowUpDown = true;
            HoraFin.Size = new Size(219, 27);
            HoraFin.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 158);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 18;
            label4.Text = "Hora de inicio";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 217);
            label5.Name = "label5";
            label5.Size = new Size(143, 20);
            label5.TabIndex = 19;
            label5.Text = "Hora de finalización";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(186, 285);
            button1.Name = "button1";
            button1.Size = new Size(219, 36);
            button1.TabIndex = 30;
            button1.Text = "Modificar!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(871, 423);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 31;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(186, 361);
            button2.Name = "button2";
            button2.Size = new Size(219, 38);
            button2.TabIndex = 32;
            button2.Text = "Eliminar!";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Id
            // 
            Id.Location = new Point(36, 272);
            Id.Name = "Id";
            Id.Size = new Size(70, 27);
            Id.TabIndex = 33;
            // 
            // ModificarClase
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 501);
            Controls.Add(Id);
            Controls.Add(button2);
            Controls.Add(Volver);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(HoraFin);
            Controls.Add(HoraInicio);
            Controls.Add(Profesor);
            Controls.Add(Nombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(label6);
            Name = "ModificarClase";
            Text = "ModificarClase";
            Load += ModificarClase_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label6;
        private Label label1;
        private Label label2;
        private TextBox Nombre;
        private TextBox Profesor;
        private DateTimePicker HoraInicio;
        private DateTimePicker HoraFin;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button Volver;
        private Button button2;
        private TextBox Id;
    }
}