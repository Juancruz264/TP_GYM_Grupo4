namespace frontGYM_
{
    partial class ModificarCliente
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Volver = new Button();
            Nombre = new TextBox();
            Apellido = new TextBox();
            Direccion = new TextBox();
            Telefono = new TextBox();
            label6 = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(416, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(542, 378);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 72);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 122);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 10;
            label3.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 165);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 11;
            label4.Text = "Dirección";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 208);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 12;
            label5.Text = "Teléfono";
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(874, 482);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 16;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(157, 65);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(203, 27);
            Nombre.TabIndex = 17;
            // 
            // Apellido
            // 
            Apellido.Location = new Point(157, 115);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(203, 27);
            Apellido.TabIndex = 18;
            // 
            // Direccion
            // 
            Direccion.Location = new Point(157, 158);
            Direccion.Name = "Direccion";
            Direccion.Size = new Size(203, 27);
            Direccion.TabIndex = 19;
            // 
            // Telefono
            // 
            Telefono.Location = new Point(157, 201);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(203, 27);
            Telefono.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(117, 30);
            label6.Name = "label6";
            label6.Size = new Size(331, 20);
            label6.TabIndex = 21;
            label6.Text = "MODIFICAR O ELIMINAR CLIENTE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 262);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 22;
            label1.Text = "Tipo Suscripcion";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(157, 255);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(203, 27);
            textBox1.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(157, 324);
            button1.Name = "button1";
            button1.Size = new Size(203, 36);
            button1.TabIndex = 31;
            button1.Text = "Modificar!";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(157, 393);
            button2.Name = "button2";
            button2.Size = new Size(203, 37);
            button2.TabIndex = 33;
            button2.Text = "Eliminar!";
            button2.UseVisualStyleBackColor = false;
            // 
            // ModificarCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 546);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(Telefono);
            Controls.Add(Direccion);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(Volver);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Name = "ModificarCliente";
            Text = "ModificarCliente";
            Load += ModificarCliente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button Volver;
        private TextBox Nombre;
        private TextBox Apellido;
        private TextBox Direccion;
        private TextBox Telefono;
        private Label label6;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}