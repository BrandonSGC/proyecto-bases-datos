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
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;
using MySql.Data.MySqlClient;

namespace proyecto_bases_datos
{
    public partial class frmIngresarCV : Form
    {
        public frmIngresarCV()
        {
            InitializeComponent();
        }

        private void btnLeerArchivo_Click(object sender, EventArgs e)
        {
            // Creamos la instancia del FileDialog para leer el archivo.
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.ShowDialog();

            // Asignamos la ruta a variable "filePath".
            string filePath = fileDialog.FileName.ToString();


            // Leer el archivo de Word.
            Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
            Document doc = app.Documents.Open(filePath);
            string data = doc.Content.Text;
            richTextBox1.Text = data;


            // Creamos el objeto candidato, el cual le asignaremos los datos de la plantilla de word.
            Candidato candidato = new Candidato();

            Experiencia experiencia = new Experiencia();

            Educacion educacion = new Educacion();

            List<Experiencia> ListaExperiencia = new List<Experiencia>();

            List<Educacion> ListaEducacion = new List<Educacion>();

            int cont = 0;
            string tipoDato = null;
            bool hayDatosEducacion = false;
            bool hayDatosExperiencia = false;

            /* Obtenemos los datos especificos del candidato del documento a 
            * partir de la lectura de cada linea, para con el metodo split() 
            * mas el parametro que le pasemos nos de los valores que vamos 
            * a necesitar. */
            foreach (Paragraph paragraph in doc.Content.Paragraphs)
            {
                string line = paragraph.Range.Text.Trim();
                string[] datos = line.Split(':');


                // Validamos que haya texto, sino salta de linea.
                if (line.Length > 0)
                {
                    if (datos[0].ToString().ToUpper() == "EXPERIENCIA")
                    {
                        cont = 7;
                        hayDatosExperiencia = true;
                    }
                    else if (datos[0].ToString().ToUpper() == "EDUCACIÓN")
                    {
                        cont = 12;
                        hayDatosEducacion = true;
                    }

                    switch (cont)
                    {
                        case 0:
                            candidato.Cedula = int.Parse(datos[1].ToString());
                            break;

                        case 1:
                            candidato.Nombre = datos[1].ToString();
                            break;

                        case 2:
                            candidato.Apellidos = datos[1].ToString();
                            break;

                        case 3:
                            candidato.Fecha_nacimiento = datos[1].ToString();
                            break;

                        case 4:
                            candidato.Fecha_aplicacion = datos[1].ToString();
                            break;

                        case 5:
                            candidato.Puesto = datos[1].ToString();
                            break;

                        case 6:
                            candidato.Idiomas = datos[1].ToString();
                            break;

                        case 7: // Experiencia
                            experiencia = new Experiencia();
                            break;

                        case 8:
                            experiencia.Empresa = datos[1].ToString();
                            break;

                        case 9:
                            experiencia.Fecha_inicio = datos[1].ToString();
                            break;

                        case 10:
                            experiencia.Fecha_finalizacion = datos[1].ToString();
                            break;

                        case 11:
                            experiencia.Descripcion = datos[1].ToString();
                            ListaExperiencia.Add(experiencia);
                            break;

                        case 12: // Educación
                            educacion = new Educacion();
                            break;

                        case 13:
                            educacion.Centro_educativo = datos[1].ToString();
                            break;

                        case 14:
                            educacion.Fecha_inicio = datos[1].ToString();
                            break;

                        case 15:
                            educacion.Fecha_finalizacion = datos[1].ToString();
                            break;

                        case 16:
                            educacion.Descripcion = datos[1].ToString();
                            ListaEducacion.Add(educacion);
                            break;
                    }

                }
                cont += 1;
            }

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            // Guardamos el candidato en la base de datos
            string sql = $"INSERT INTO candidato VALUES ({candidato.Cedula}, '{candidato.Nombre}', '{candidato.Apellidos}', '{candidato.Fecha_nacimiento}', '{candidato.Fecha_aplicacion}','{candidato.Puesto}','{candidato.Idiomas}') ON DUPLICATE KEY UPDATE nombre ='{candidato.Nombre}', apellidos= '{candidato.Apellidos}', fecha_nacimiento ='{candidato.Fecha_nacimiento}', fecha_aplicacion = '{candidato.Fecha_aplicacion}', puesto='{candidato.Puesto}', idiomas='{candidato.Idiomas}'";
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Guardar datos de candidato: {ex}");
            }

            foreach (Experiencia experiencia1 in ListaExperiencia)
            {
                sql = $"INSERT INTO candidato_experiencia(cedula_candidato, empresa, fecha_inicio, fecha_finalizacion, descripcion) VALUES ({candidato.Cedula}, '{experiencia1.Empresa}', '{experiencia1.Fecha_inicio}', '{experiencia1.Fecha_finalizacion}', '{experiencia1.Descripcion}')";
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al Guardar datos de experiencia: {ex}");
                }
            }

            foreach (Educacion educacion1 in ListaEducacion)
            {
                sql = $"INSERT INTO candidato_educacion(cedula_candidato, centro_educativo, fecha_inicio, fecha_finalizacion, descripcion) VALUES ({candidato.Cedula}, '{educacion1.Centro_educativo}', '{educacion1.Fecha_inicio}', '{educacion1.Fecha_finalizacion}', '{educacion1.Descripcion}')";
                try
                {
                    MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                    comando.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Error al Guardar datos de educación: {ex}");
                }
            }

            MessageBox.Show("El candidato ha sido guardado con éxito!");
            conexionBD.Close();

            app.Quit();
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPantalla = new frmPrincipal();
            frmPantalla.Show();
            this.Hide();
        }

        private void frmIngresarCV_Load(object sender, EventArgs e)
        {

        }
    }
}