using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_bases_datos
{
   
    public partial class frmPrincipal : Form
    {
       
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIngresarCV_Click(object sender, EventArgs e)
        {
            frmIngresarCV frmPantalla = new frmIngresarCV();
            frmPantalla.Show();
            this.Hide();
        }

        private void btnNuevaVacante_Click(object sender, EventArgs e)
        {
            frmCrearVacante frmPantalla = new frmCrearVacante();
            frmPantalla.Show(); 
            this.Hide();
        }

        private void btnMostrarCandidatos_Click(object sender, EventArgs e)
        {
            frmMostrarCandidatos frmPantalla = new frmMostrarCandidatos();
            frmPantalla.Show();
            this.Hide();
        }

        private void btnSeleccionCandidato_Click(object sender, EventArgs e)
        {

        frmSeleccionCandidato frmPantallaCandidato = new frmSeleccionCandidato();
            //frmMostrarCandidatos frmPantalla = new frmMostrarCandidatos();
            
            frmPantallaCandidato.Show();
            this.Hide();
        }
    }
}
