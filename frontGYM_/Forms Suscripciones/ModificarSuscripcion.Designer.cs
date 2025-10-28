namespace frontGYM_.Forms_Suscripciones
{
    partial class ModificarSuscripcion
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
            Precio = new TextBox();
            label2 = new Label();
            label3 = new Label();
            Nombre = new TextBox();
            Id = new TextBox();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            Volver = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(401, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(447, 349);
            dataGridView1.TabIndex = 10;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(183, 21);
            label6.Name = "label6";
            label6.Size = new Size(382, 20);
            label6.TabIndex = 11;
            label6.Text = "MODIFICAR O ELIMINAR SUSCRIPCIÓN";
            // 
            // Precio
            // 
            Precio.Location = new Point(99, 140);
            Precio.Name = "Precio";
            Precio.Size = new Size(277, 27);
            Precio.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 147);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 22;
            label2.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 21;
            label3.Text = "Nombre";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(99, 94);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(277, 27);
            Nombre.TabIndex = 24;
            // 
            // Id
            // 
            Id.Location = new Point(99, 190);
            Id.Name = "Id";
            Id.Size = new Size(94, 27);
            Id.TabIndex = 26;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 197);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 27;
            label1.Text = "Id";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(99, 282);
            button1.Name = "button1";
            button1.Size = new Size(219, 36);
            button1.TabIndex = 31;
            button1.Text = "Modificar!";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(99, 366);
            button2.Name = "button2";
            button2.Size = new Size(219, 38);
            button2.TabIndex = 33;
            button2.Text = "Eliminar!";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(797, 429);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 34;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // ModificarSuscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 486);
            Controls.Add(Volver);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Id);
            Controls.Add(Precio);
            Controls.Add(Nombre);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Name = "ModificarSuscripcion";
            Text = "ModificarSuscripcion";
            Load += ModificarSuscripcion_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label6;
        private TextBox Precio;
        private Label label2;
        private Label label3;
        private TextBox Nombre;
        private TextBox Id;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button Volver;
    }
}