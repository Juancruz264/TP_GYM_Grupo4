using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frontGYM_.Pago
{
    public partial class CargarPago : Form
    {
        public CargarPago()
        {
            InitializeComponent();
        }

        private void CargarPago_Load(object sender, EventArgs e)
        {
            using (AplicationDbContext context = new AplicationDbContext())
            {
                var clientes = context.Clientes.ToList();
                dataGridView1.DataSource = clientes;
            }
        }

        private void Apellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //Id.Text = dataGridView1.CurrentRow?.Cells["Id"].Value?.ToString();
            //Nombre.Text = dataGridView1.CurrentRow?.Cells["Nombre"].Value?.ToString();
            //Apellido.Text = dataGridView1.CurrentRow?.Cells["Apellido"].Value?.ToString();
            //Suscripcion.Items.Add(dataGridView1.CurrentRow?.Cells["Suscripciones"].Value?.ToString());         
        }
    }
}
