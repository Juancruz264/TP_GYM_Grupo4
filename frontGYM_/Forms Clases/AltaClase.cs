using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using clasesGYM_.Repositorios;
using clasesGYM_;

namespace frontGYM_.Forms_Clases
{
    public partial class AltaClase : Form
    {
        public AltaClase()
        {
            InitializeComponent();
        }
        private void AltaClase_Load(object sender, EventArgs e)
        {
            listBoxDias.SelectionMode = SelectionMode.MultiSimple;
            listBoxDias.Items.AddRange(Enum.GetNames(typeof(Dias)));


        }

        private void Registro_Click(object sender, EventArgs e)
        {
            Dias diasSeleccionados = Dias.Ninguno;

            foreach (var item in listBoxDias.SelectedItems)
            {
                Dias dia = (Dias)Enum.Parse(typeof(Dias), item.ToString());
                diasSeleccionados |= dia;
            }
            using (AplicationDbContext context = new AplicationDbContext())
            {
                var nuevaClase = new Clase
                {
                    Nombre = Nombre.Text,
                    Profesor = Profesor.Text,
                    Dias = diasSeleccionados
                };
                ClaseRepository.AgregarClase(nuevaClase);
                MessageBox.Show("Clase creada con éxito.");
            }
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();           
        }
    }
}
