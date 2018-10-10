using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjemploListaEnlazada2;

namespace MantenimientoJugadores
{
    public partial class frmEstudiante : Form
    {
        controladoraEstudiante controlador = new controladoraEstudiante();
        public frmEstudiante()
        {
            InitializeComponent();
            controlador.cargarEstudiante();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            List<object> lsEstudiante = new List<object>();
            if(controlador.existeEstudiante(txtNombre.Text.Trim()))
            {
                var estudiante  = controlador.filtraEstudiante(txtNombre.Text.Trim());
                txtDatos.Text = estudiante;
                MessageBox.Show("Econtrado");
            }else
            {
                MessageBox.Show("No existe estudiante");
                txtDatos.Clear();
            }

        }
        
    }
}
