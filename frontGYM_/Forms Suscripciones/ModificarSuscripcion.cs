using clasesGYM_;
using clasesGYM_.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontGYM_.Forms_Suscripciones
{
    public partial class ModificarSuscripcion : Form
    {
        public ModificarSuscripcion()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Id.Text = dataGridView1.CurrentRow?.Cells["Id"].Value?.ToString();
            Nombre.Text = dataGridView1.CurrentRow?.Cells["Nombre"].Value?.ToString();
            Precio.Text = dataGridView1.CurrentRow?.Cells["Precio"].Value?.ToString();
        }

        private void ModificarSuscripcion_Load(object sender, EventArgs e)
        {
            using (AplicationDbContext context = new AplicationDbContext())
            {
                var suscripciones = context.Suscripciones.ToList();
                dataGridView1.DataSource = suscripciones;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (AplicationDbContext context = new AplicationDbContext())
            {
                int suscripcionId = int.Parse(Id.Text);
                var suscripcion = context.Suscripciones.Find(suscripcionId);
                if (suscripcion != null)
                {
                    suscripcion.Nombre = Nombre.Text;
                    suscripcion.Precio = decimal.Parse(Precio.Text);
                    context.SaveChanges();
                    MessageBox.Show("Suscripción modificada con éxito.");
                    // Actualizar el DataGridView
                    var suscripciones = context.Suscripciones.ToList();
                    dataGridView1.DataSource = suscripciones;
                }
                else
                {
                    MessageBox.Show("Suscripción no encontrada.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SuscripcionRepository.EliminarSuscripcion(int.Parse(Id.Text));
            MessageBox.Show("Suscripción eliminada con éxito.");
            this.Close();
        }
    }
}
