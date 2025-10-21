namespace frontGYM_
{
    partial class MenuABMSuscripcion
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
            label1 = new Label();
            BajaCliente = new Button();
            ActualizarCliente = new Button();
            AltaCliente = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(304, 73);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 7;
            label1.Text = "ABM SUSCRIPCIÓN";
            // 
            // BajaCliente
            // 
            BajaCliente.Location = new Point(187, 283);
            BajaCliente.Name = "BajaCliente";
            BajaCliente.Size = new Size(407, 41);
            BajaCliente.TabIndex = 6;
            BajaCliente.Text = "Dar de baja cliente";
            BajaCliente.UseVisualStyleBackColor = true;
            // 
            // ActualizarCliente
            // 
            ActualizarCliente.Location = new Point(187, 210);
            ActualizarCliente.Name = "ActualizarCliente";
            ActualizarCliente.Size = new Size(407, 41);
            ActualizarCliente.TabIndex = 5;
            ActualizarCliente.Text = "Actualizar cliente";
            ActualizarCliente.UseVisualStyleBackColor = true;
            // 
            // AltaCliente
            // 
            AltaCliente.Location = new Point(187, 140);
            AltaCliente.Name = "AltaCliente";
            AltaCliente.Size = new Size(407, 41);
            AltaCliente.TabIndex = 4;
            AltaCliente.Text = "Dar de alta cliente";
            AltaCliente.UseVisualStyleBackColor = true;
            // 
            // MenuABMSuscripcion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(BajaCliente);
            Controls.Add(ActualizarCliente);
            Controls.Add(AltaCliente);
            Name = "MenuABMSuscripcion";
            Text = "MenuABMSuscripcion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BajaCliente;
        private Button ActualizarCliente;
        private Button AltaCliente;
    }
}