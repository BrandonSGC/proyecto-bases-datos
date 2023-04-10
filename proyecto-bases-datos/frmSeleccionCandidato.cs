using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proyecto_bases_datos
{
    public partial class frmSeleccionCandidato : Form
    {
        public frmSeleccionCandidato()
        {
            InitializeComponent();
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPantalla = new frmPrincipal();
            frmPantalla.Show();
            this.Hide();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void frmSeleccionCandidato_Load(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conexion();

            try
            {
                cargarPuestos();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Mostrar los Datos: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void cargarPuestos()
        {
            MySqlConnection conexionBD = Conexion.conexion();

            try
            {
                conexionBD.Open();
                string sql = ("SELECT id_vacante, concat('Empresa : ',nombre_empresa,' - Puesto : ', nombre_puesto) puesto FROM vacante");

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexionBD);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cbPuestos.DataSource = dataTable;
                cbPuestos.DisplayMember = "puesto";
                cbPuestos.ValueMember = "id_vacante";
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Mostrar los Datos de vacantes: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void cbPuestos_SelectedValueChanged(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conexion();

            int selectedIndex = cbPuestos.SelectedIndex;
            int valor_vacante = -1;

            if (selectedIndex >= 0)
            {
                DataRowView selectedRow = (DataRowView)cbPuestos.SelectedItem;
                valor_vacante = (int)selectedRow["id_vacante"];
            }


            try
            {
                conexionBD.Open();
                string sql = $"SELECT nombre_empresa, nombre_puesto,descripcion, requisitos, idiomas FROM vacante WHERE id_vacante='{valor_vacante}'";

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conexionBD);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                foreach (DataRow fila in dataTable.Rows)
                {
                    txtEmpresa.Text = fila["nombre_empresa"].ToString();
                    txtPuesto.Text = fila["nombre_puesto"].ToString();
                    txtDescripcion.Text = fila["descripcion"].ToString();
                    txtRequisitos.Text = fila["requisitos"].ToString();
                    txtIdiomas.Text = fila["idiomas"].ToString();
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Mostrar los Datos de vacantes: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnCandidatos_Click(object sender, EventArgs e)
        {
            VariablesGlobales.nombre_empresa = txtEmpresa.Text;
            VariablesGlobales.nombre_puesto = txtPuesto.Text;
            VariablesGlobales.idiomas = txtIdiomas.Text;
            VariablesGlobales.descripcion = txtDescripcion.Text;
            VariablesGlobales.requisitos = txtRequisitos.Text;

            frmMostrarCandidatos frmCandidato = new frmMostrarCandidatos();
            frmCandidato.ShowDialog();

        }
    }
}

