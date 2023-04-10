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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            cargarPuestos();
            MySqlConnection conexionBD = Conexion.conexion();

            try
            {
                txtEmpresa.Text = VariablesGlobales.nombre_empresa;
                txtPuesto.Text = VariablesGlobales.nombre_puesto;
                txtDescripcion.Text = VariablesGlobales.descripcion;
                txtRequisitos.Text = VariablesGlobales.requisitos;
                txtIdiomas.Text = VariablesGlobales.idiomas;
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = $"SELECT * FROM candidato WHERE UPPER(puesto) like UPPER('%{VariablesGlobales.nombre_puesto}%') AND UPPER(idiomas) like UPPER('%{VariablesGlobales.idiomas}%') ";

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = comando;               

                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvCandidatos.DataSource = table;

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

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexionBD = Conexion.conexion();

            try
            {
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand();
                comando.Connection = conexionBD;
                comando.CommandText = ($"SELECT * FROM candidato WHERE puesto_aplicar = '{cbPuestos.SelectedItem.ToString()}'");

                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = comando;

                DataTable tablaCandidatos = new DataTable();
                adapter.Fill(tablaCandidatos);
                dgvCandidatos.DataSource = tablaCandidatos;

                if (tablaCandidatos.Rows.Count <= 0)
                {
                    MessageBox.Show("No hay candidatos que cumplan con lo requerido para el puesto");

                }
                else
                {

                    DataGridViewTextBoxColumn colExperiencia = new DataGridViewTextBoxColumn();
                    colExperiencia.HeaderText = "Experiencia";
                    colExperiencia.Name = "txtExperiencia";
                    dgvCandidatos.Columns.Add(colExperiencia);

                    DataGridViewTextBoxColumn colEducacion = new DataGridViewTextBoxColumn();
                    colEducacion.HeaderText = "Educación";
                    colEducacion.Name = "txtEducacion";
                    dgvCandidatos.Columns.Add(colEducacion);

                    // se recorre el datagridview para determinar quienes tienen experiencia y educacion para el puesto
                    bool experiencia = false;
                    bool educacion = false;
                    foreach (DataGridViewRow fila in dgvCandidatos.Rows)
                    {
                        int cedula = Convert.ToInt32(fila.Cells[0].Value.ToString());

                        // experiencia
                        comando.CommandText = $"SELECT * FROM candidato_experiencia  WHERE cedula_candidato = {cedula} AND  descripcion LIKE UPPER('%{VariablesGlobales.descripcion}%')";

                        adapter.SelectCommand = comando;

                        DataTable tablaExperiencia = new DataTable();
                        adapter.Fill(tablaExperiencia);

                        DataGridViewCell cell = fila.Cells[dgvCandidatos.Columns["txtExperiencia"].Index];

                        if (tablaExperiencia.Rows.Count > 0)
                        {
                            cell.Value = "SI Tiene";
                            experiencia = true;
                        }
                        else
                        {
                            cell.Value = "NO Tiene";
                            experiencia = false;
                        }

                        // educacion
                        comando.CommandText = $"SELECT * FROM candidato_educacion  WHERE cedula_candidato = {cedula} AND  descripcion LIKE UPPER('%{VariablesGlobales.requisitos}%')";

                        adapter.SelectCommand = comando;

                        DataTable tablaEducacion = new DataTable();
                        adapter.Fill(tablaEducacion);

                        cell = fila.Cells[dgvCandidatos.Columns["txtEducacion"].Index];

                        if (tablaEducacion.Rows.Count > 0)
                        {
                            cell.Value = "SI Tiene";
                            educacion = true;
                        }
                        else
                        {
                            cell.Value = "NO Tiene";
                            educacion = false;
                        }

                        if (educacion == true && experiencia == true)
                        {
                            fila.DefaultCellStyle.BackColor = Color.GreenYellow;
                        }

                    }

                }
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

    }
}
