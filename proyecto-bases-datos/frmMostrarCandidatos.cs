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

        private void cargarPuestos()
        {
            MySqlConnection conexionBD = Conexion.conexion();

            try
            {
                conexionBD.Open();
                string sql = ("SELECT puesto_aplicar FROM candidato");
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);

                //MySqlDataAdapter adapter = new MySqlDataAdapter();
                //adapter.SelectCommand = comando;

                MySqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    // Agregar el valor de la columna correspondiente al ComboBox
                    cbPuestos.Items.Add(reader.GetString(0));
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
