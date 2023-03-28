using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
            MySqlConnection conexionBD = Conexion.conexion();
            
            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ("SELECT * FROM candidato");

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = comando;               

                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCandidatos.DataSource = table;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Mosstrar los Datos: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
