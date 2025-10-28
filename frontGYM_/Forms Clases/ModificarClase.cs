using clasesGYM_;
using clasesGYM_.Repositorios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static clasesGYM_.Clase;

namespace frontGYM_.Forms_Clases
{
    public partial class ModificarClase : Form
    {
        public ModificarClase()
        {
            InitializeComponent();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            Id.Text = dataGridView1.CurrentRow?.Cells["Id"].Value?.ToString();
            Nombre.Text = dataGridView1.CurrentRow?.Cells["Nombre"].Value?.ToString();
            Profesor.Text = dataGridView1.CurrentRow?.Cells["Profesor"].Value?.ToString();
            if (dataGridView1.CurrentRow != null)
            {
                var horaInicioValue = dataGridView1.CurrentRow.Cells["HoraInicio"].Value;
                var horaFinValue = dataGridView1.CurrentRow.Cells["HoraFin"].Value;
                if (horaInicioValue != null && TimeOnly.TryParse(horaInicioValue.ToString(), out TimeOnly horaInicio))
                {
                    HoraInicio.Value = DateTime.Today.Add(horaInicio.ToTimeSpan());
                }
                if (horaFinValue != null && TimeOnly.TryParse(horaFinValue.ToString(), out TimeOnly horaFin))
                {
                    HoraFin.Value = DateTime.Today.Add(horaFin.ToTimeSpan());
                }
            }

        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModificarClase_Load(object sender, EventArgs e)
        {
            using (AplicationDbContext context = new AplicationDbContext())
            {
                var clases = context.Clases.ToList();
                dataGridView1.DataSource = clases;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona una fila primero.");
                return;
            }

            if (!int.TryParse(dataGridView1.CurrentRow.Cells["Id"].Value?.ToString(), out int id))
            {
                MessageBox.Show("Id inválido.");
                return;
            }

            try
            {
                using (var context = new AplicationDbContext())
                {
                    var clase = context.Clases.Find(id);
                    if (clase == null)
                    {
                        MessageBox.Show("Clase no encontrada.");
                        return;
                    }

                    clase.Nombre = Nombre.Text;
                    clase.Profesor = Profesor.Text;
                    // Usar FromDateTime en lugar de Parse del texto del control
                    clase.HoraInicio = TimeOnly.FromDateTime(HoraInicio.Value);
                    clase.HoraFin = TimeOnly.FromDateTime(HoraFin.Value);

                    context.SaveChanges();
                }

                MessageBox.Show("Clase actualizada correctamente.");

                // Refrescar grilla
                using (var ctx = new AplicationDbContext())
                {
                    dataGridView1.DataSource = ctx.Clases.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClaseRepository.EliminarClase(int.Parse(Id.Text));
            MessageBox.Show("Clase eliminada correctamente.");
            this.Close();
        }
    }
}

