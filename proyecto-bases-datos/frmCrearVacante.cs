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
    public partial class frmCrearVacante : Form
    {
        public frmCrearVacante()
        {
            InitializeComponent();
        }

        private void frmNuevaVacante_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearVacante_Click(object sender, EventArgs e)
        {
            Vacante vacante = new Vacante();
            vacante.NombreEmpresa = txtNombreEmpresa.Text;
            vacante.NombrePuesto = txtPuesto.Text;
            vacante.Descripcion = txtDescripcion.Text;
            vacante.Requisitos = txtRequisitos.Text;
            vacante.Salario = float.Parse(txtSalario.Text);
    


            // Guardamos el candidato en la base de datos
            string sql = $"INSERT INTO vacante (nombre_empresa, nombre_puesto, descripcion, requisitos, salario) VALUES ('{vacante.NombreEmpresa}', '{vacante.NombrePuesto}', '{vacante.Descripcion}', '{vacante.Requisitos}', {vacante.Salario})";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                // Ejecutamos el comando.
                comando.ExecuteNonQuery();
                MessageBox.Show("La vacante se ha guardado con éxito!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Guardar: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
