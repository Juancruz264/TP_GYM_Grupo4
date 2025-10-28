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
    public partial class AltaSuscripcion : Form
    {
        private void AltaSuscripcion_Load(object sender, EventArgs e)
        {

        }
        public AltaSuscripcion()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Registro_Click(object sender, EventArgs e)
        {
        }

        private void textbox_Click(object sender, EventArgs e)
        {

        }

        private void Registro_Click_1(object sender, EventArgs e)
        {
            using (AplicationDbContext context = new AplicationDbContext())
            {
                var nuevaSuscripcion = new Suscripcion
                {
                    Nombre = Nombre.Text,
                    Precio = decimal.Parse(Precio.Text)
                };
                SuscripcionRepository.AgregarSuscripcion(nuevaSuscripcion);
                MessageBox.Show("Suscripción registrada con éxito.");
            }
        }
    }
}