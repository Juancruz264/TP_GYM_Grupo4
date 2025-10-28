namespace frontGYM_.Pago
{
    partial class CargarPago
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
            Pago = new Button();
            label5 = new Label();
            label4 = new Label();
            Fecha = new DateTimePicker();
            comboBox1 = new ComboBox();
            Volver = new Button();
            Monto = new TextBox();
            Nombre = new TextBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            Apellido = new TextBox();
            label7 = new Label();
            Id = new TextBox();
            Ide = new Label();
            Suscripcion = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Pago
            // 
            Pago.BackColor = SystemColors.ScrollBar;
            Pago.Location = new Point(526, 447);
            Pago.Name = "Pago";
            Pago.Size = new Size(165, 36);
            Pago.TabIndex = 42;
            Pago.Text = "Pagar!";
            Pago.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(353, 391);
            label5.Name = "label5";
            label5.Size = new Size(84, 20);
            label5.TabIndex = 41;
            label5.Text = "Suscripción";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(377, 343);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 40;
            label4.Text = "Fecha ";
            // 
            // Fecha
            // 
            Fecha.Location = new Point(458, 338);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(335, 27);
            Fecha.TabIndex = 38;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(458, 289);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(335, 28);
            comboBox1.TabIndex = 37;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(33, 433);
            Volver.Name = "Volver";
            Volver.Size = new Size(105, 36);
            Volver.TabIndex = 36;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            // 
            // Monto
            // 
            Monto.Location = new Point(457, 238);
            Monto.Name = "Monto";
            Monto.Size = new Size(336, 27);
            Monto.TabIndex = 35;
            // 
            // Nombre
            // 
            Nombre.Location = new Point(121, 124);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(192, 27);
            Nombre.TabIndex = 34;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(327, 23);
            label6.Name = "label6";
            label6.Size = new Size(164, 20);
            label6.TabIndex = 33;
            label6.Text = "REALIZAR PAGO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 292);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 32;
            label3.Text = "Método";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(377, 245);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 31;
            label2.Text = "Monto";
            label2.UseMnemonic = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 124);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 30;
            label1.Text = "Nombre";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(368, 62);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(425, 155);
            dataGridView1.TabIndex = 44;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // Apellido
            // 
            Apellido.Location = new Point(121, 170);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(192, 27);
            Apellido.TabIndex = 46;
            Apellido.TextChanged += Apellido_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(37, 170);
            label7.Name = "label7";
            label7.Size = new Size(66, 20);
            label7.TabIndex = 45;
            label7.Text = "Apellido";
            // 
            // Id
            // 
            Id.Location = new Point(121, 71);
            Id.Name = "Id";
            Id.Size = new Size(56, 27);
            Id.TabIndex = 50;
            // 
            // Ide
            // 
            Ide.AutoSize = true;
            Ide.Location = new Point(37, 71);
            Ide.Name = "Ide";
            Ide.Size = new Size(24, 20);
            Ide.TabIndex = 49;
            Ide.Text = "ID";
            // 
            // Suscripcion
            // 
            Suscripcion.FormattingEnabled = true;
            Suscripcion.Location = new Point(457, 386);
            Suscripcion.Name = "Suscripcion";
            Suscripcion.Size = new Size(336, 44);
            Suscripcion.TabIndex = 51;
            // 
            // CargarPago
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 495);
            Controls.Add(Suscripcion);
            Controls.Add(Id);
            Controls.Add(Ide);
            Controls.Add(Apellido);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(Pago);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(Fecha);
            Controls.Add(comboBox1);
            Controls.Add(Volver);
            Controls.Add(Monto);
            Controls.Add(Nombre);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CargarPago";
            Text = "CargarPago";
            Load += CargarPago_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Pago;
        private Label label5;
        private Label label4;
        private DateTimePicker Fecha;
        private ComboBox comboBox1;
        private Button Volver;
        private TextBox Monto;
        private TextBox Nombre;
        private Label label6;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox Apellido;
        private Label label7;
        private TextBox Id;
        private Label Ide;
        private ListBox Suscripcion;
    }
}