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
    public partial class frmMostrarCandidatos : Form
    {
        public frmMostrarCandidatos()
        {
            InitializeComponent();
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPantalla = new frmPrincipal();
            frmPantalla.Show();
            this.Hide();
        }

        private void frmMostrarCandidatos_Load(object sender, EventArgs e)
        {

        }
    }
}
