using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using clasesGYM_;
using clasesGYM_.Repositorios;  

namespace frontGYM_
{
    public partial class AltaCliente : Form
    {
        public AltaCliente()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Registro_Click(object sender, EventArgs e)
        {
            using (AplicationDbContext context = new AplicationDbContext())
            {
                var tipoSuscripcion = comboBox1.SelectedItem as Suscripcion;
                if (tipoSuscripcion == null)
                {
                    MessageBox.Show("Por favor, seleccione un tipo de suscripción.");
                    return;
                }

                var nuevoCliente = new Cliente
                {
                    Dni = int.Parse(Dni.Text),
                    Direccion = Direccion.Text,
                    Nombre = Nombre.Text,
                    Apellido = Apellido.Text,
                    Telefono = int.Parse(Telefono.Text),
                    TipoSuscripcion = tipoSuscripcion,
                    FechaInicio = FechaInicio.Value,
                };
                ClienteRepository.AgregarCliente(nuevoCliente);
                MessageBox.Show("Cliente registrado con éxito.");
            }
        }

        private void AltaCliente_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = SuscripcionRepository.ObtenerSuscripciones();
            comboBox1.DisplayMember = "Nombre";
        }
    }
}
