﻿using System;
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

            int cont = 0;

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
                    if (cont == 0)
                    {
                        candidato.Cedula = int.Parse(datos[1].ToString());
                    }
                    if (cont == 1)
                    {
                        candidato.Nombre = datos[1].ToString();
                    }
                    if (cont == 2)
                    {
                        candidato.Apellidos = datos[1].ToString();
                    }
                    if (cont == 3)
                    {
                        candidato.Fecha_nacimiento = datos[1].ToString();
                    }
                    if (cont == 4)
                    {
                        candidato.Fecha_aplicacion = datos[1].ToString();
                    }
                    if (cont == 5)
                    {
                        candidato.Puesto_aplicar = datos[1].ToString();
                    }

                    // EMPIEZA LA EXPERIENCIA
                    if (cont == 8)
                    {
                        experiencia.Empresa = datos[1].ToString();
                    }
                    if (cont == 9)
                    {
                        experiencia.Fecha_inicio = datos[1].ToString();
                    }
                    if (cont == 10)
                    {
                        experiencia.Fecha_finalizacion = datos[1].ToString();
                    }
                    if (cont == 11)
                    {
                        experiencia.Descripcion = datos[1].ToString();
                    }

                    // EMPIEZA LA EDUCACION.
                    if (cont == 14)
                    {
                        educacion.Centro_educativo = datos[1].ToString();
                    }
                    if (cont == 15)
                    {
                        educacion.Fecha_inicio = datos[1].ToString();
                    }
                    if (cont == 16)
                    {
                        educacion.Fecha_finalizacion = datos[1].ToString();
                    }
                    if (cont == 17)
                    {
                        educacion.Descripcion = datos[1].ToString();
                    }
                }
                cont += 1;
            }                        

            // Guardamos el candidato en la base de datos
            string sql = $"INSERT INTO candidato VALUES ({candidato.Cedula}, '{candidato.Nombre}', '{candidato.Apellidos}', '{candidato.Fecha_nacimiento}', '{candidato.Fecha_aplicacion}', '{candidato.Puesto_aplicar}')";
            string sql2 = $"INSERT INTO candidato_experiencia(cedula_candidato, empresa, fecha_inicio, fecha_finalizacion, descripcion) VALUES ({candidato.Cedula}, '{experiencia.Empresa}', '{experiencia.Fecha_inicio}', '{experiencia.Fecha_finalizacion}', '{experiencia.Descripcion}')";
            string sql3 = $"INSERT INTO candidato_educacion(cedula_candidato, centro_educativo, fecha_inicio, fecha_finalizacion, descripcion) VALUES ({candidato.Cedula}, '{educacion.Centro_educativo}', '{educacion.Fecha_inicio}', '{educacion.Fecha_finalizacion}', '{educacion.Descripcion}')";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conexionBD);
                MySqlCommand comando2 = new MySqlCommand(sql2, conexionBD);
                MySqlCommand comando3 = new MySqlCommand(sql3, conexionBD);

                comando.ExecuteNonQuery();
                comando2.ExecuteNonQuery();
                comando3.ExecuteNonQuery();
                MessageBox.Show("El candidato ha sido guardado con éxito!");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error al Guardar: {ex}");
            }
            finally
            {
                conexionBD.Close();
            }
            app.Quit();
        }

        private void pbAtras_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPantalla = new frmPrincipal();
            frmPantalla.Show();
            this.Hide();
        }
    }
}