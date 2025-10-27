namespace frontGYM_
{
    partial class AltaSuscripcion
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
            label2 = new Label();
            label = new Label();
            Nombre = new TextBox();
            Precio = new TextBox();
            label1 = new Label();
            Registro = new Button();
            Volver = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 81);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(186, 121);
            label.Name = "label";
            label.Size = new Size(40, 15);
            label.TabIndex = 1;
            label.Text = "Precio";
            // 
            // Nombre
            // 
            Nombre.Location = new Point(252, 76);
            Nombre.Margin = new Padding(3, 2, 3, 2);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(148, 23);
            Nombre.TabIndex = 3;
            // 
            // Precio
            // 
            Precio.Location = new Point(252, 116);
            Precio.Margin = new Padding(3, 2, 3, 2);
            Precio.Name = "Precio";
            Precio.Size = new Size(148, 23);
            Precio.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(242, 23);
            label1.Name = "label1";
            label1.Size = new Size(165, 17);
            label1.TabIndex = 6;
            label1.Text = "ALTA SUSCRIPCIÓN";
            // 
            // Registro
            // 
            Registro.BackColor = SystemColors.GradientInactiveCaption;
            Registro.ForeColor = SystemColors.Desktop;
            Registro.Location = new Point(277, 227);
            Registro.Margin = new Padding(3, 2, 3, 2);
            Registro.Name = "Registro";
            Registro.Size = new Size(82, 22);
            Registro.TabIndex = 7;
            Registro.Text = "Registrar";
            Registro.UseVisualStyleBackColor = false;
            Registro.Click += Registro_Click;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.Font = new Font("Tahoma", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = SystemColors.ControlLightLight;
            Volver.Location = new Point(578, 286);
            Volver.Margin = new Padding(3, 2, 3, 2);
            Volver.Name = "Volver";
            Volver.Size = new Size(92, 27);
            Volver.TabIndex = 8;
            Volver.Text = "volver!";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // AltaSuscripcion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(Volver);
            Controls.Add(Registro);
            Controls.Add(label1);
            Controls.Add(Precio);
            Controls.Add(Nombre);
            Controls.Add(label);
            Controls.Add(label2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "AltaSuscripcion";
            Text = "AltaSuscripcion";
            Load += AltaSuscripcion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label;
        private TextBox Nombre;
        private TextBox Precio;
        private Label label1;
        private Button Registro;
        private Button Volver;
    }
}