using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using proyecto_bases_datos;

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

        private void btnCrearVacante_Click_1(object sender, EventArgs e)
        {
            Vacante vacante = new Vacante();
            vacante.NombreEmpresa = txtNombreEmpresa.Text;
            vacante.NombrePuesto = txtPuesto.Text;
            vacante.Descripcion = txtDescripcion.Text;
            vacante.Requisitos = txtRequisitos.Text;
            vacante.Salario = float.Parse(txtSalario.Text);
            vacante.Idiomas = txtIdiomas.Text;

            // Guardamos el candidato en la base de datos
            string sql = $"INSERT INTO vacante (nombre_empresa, nombre_puesto, descripcion, requisitos, salario,idiomas) VALUES ('{vacante.NombreEmpresa}', '{vacante.NombrePuesto}', '{vacante.Descripcion}', '{vacante.Requisitos}', '{vacante.Salario}','{vacante.Idiomas}')";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                // Ejecutamos el comando.
                comando.ExecuteNonQuery();
                MessageBox.Show("La vacante se ha guardado con éxito!");
                limpiar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Guardar vacante: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnBuscarVacante_Click(object sender, EventArgs e)
        {
            // Obtenemos el nombre del Puesto que vamos a buscar.
            Vacante vacante = new Vacante();
            vacante.NombrePuesto = txtPuesto.Text;

            // Creamos un reader
            MySqlDataReader reader = null;

            // Creamos la consulta.
            string sql = $"SELECT nombre_empresa, nombre_puesto, descripcion, requisitos, salario, idiomas FROM vacante WHERE nombre_puesto = '{vacante.NombrePuesto}' LIMIT 1";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                // Aqui tenemos ya el resultado de la consulta
                reader = comando.ExecuteReader();

                // Validamos que tengamos resultados (filas)
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        txtNombreEmpresa.Text = reader.GetString(0);
                        txtPuesto.Text = reader.GetString(1);
                        txtDescripcion.Text = reader.GetString(2);
                        txtRequisitos.Text = reader.GetString(3); 
                        txtSalario.Text = reader.GetString(4);
                        txtIdiomas.Text = reader.GetString(5);
                    }
                }
                else
                {
                    MessageBox.Show("No se encontraron registros.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Guardar vacante: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void limpiar()
        {
            txtNombreEmpresa.Text = "";
            txtPuesto.Text = "";
            txtDescripcion.Text = "";
            txtRequisitos.Text = "";
            txtSalario.Text = "";
            txtIdiomas.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnEliminarVacante_Click(object sender, EventArgs e)
        {
            // Obtenemos el nombre del Puesto que vamos a buscar.
            Vacante vacante = new Vacante();
            vacante.NombrePuesto = txtPuesto.Text;
            //Creamos la consulta
            string sql = $"DELETE FROM vacante WHERE nombre_puesto = '{vacante.NombrePuesto}'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {    //Comado para eliminar los datos de la base de datos
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.Parameters.AddWithValue("@nombre_puesto", vacante);
                int filasAfectadas = comando.ExecuteNonQuery();
                MessageBox.Show("La vacante se ha eliminado correctamente.");
                limpiar();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Guardar Vacante: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }

        }

        private void btnModificarVacante_Click(object sender, EventArgs e)
        {
            // Crear objeto Vacante con los valores del formulario
            Vacante vacante = new Vacante();
            vacante.NombreEmpresa = txtNombreEmpresa.Text;
            vacante.NombrePuesto = txtPuesto.Text;
            vacante.Descripcion = txtDescripcion.Text;
            vacante.Requisitos = txtRequisitos.Text;
            vacante.Salario = float.Parse(txtSalario.Text);
            vacante.Idiomas = txtIdiomas.Text;

            // Crear la consulta SQL para actualizar los campos de la vacante
            string sql = $"UPDATE vacante SET nombre_empresa = '{vacante.NombreEmpresa}', descripcion = '{vacante.Descripcion}', requisitos = '{vacante.Requisitos}', salario = '{vacante.Salario}', idiomas= '{vacante.Idiomas}' WHERE nombre_puesto = '{vacante.NombrePuesto}'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                // Ejecutar el comando
                comando.ExecuteNonQuery();

                MessageBox.Show("La vacante se ha modificado correctamente.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Modificar vacante: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPantalla = new frmPrincipal();
            frmPantalla.Show();
            this.Hide();
        }
    }
}