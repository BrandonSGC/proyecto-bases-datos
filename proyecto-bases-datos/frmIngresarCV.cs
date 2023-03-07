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

            int cont = 0;

            /* Obtenemos los datos especificos del candidato del documento a 
            * partir de la lectura de cada linea, para con el metodo split() 
            * mas el parametro que le pasemos nos de los valores que vamos 
            * a necesitar. */
            foreach (Paragraph paragraph in doc.Content.Paragraphs)
            {
                string line = paragraph.Range.Text.Trim();
                string[] datos = line.Split(':');

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
                cont += 1;
            }

            //MessageBox.Show($"Candidato:\nNombre: {candidato.Nombre}\nApellidos: {candidato.Apellidos}\nCedula: {candidato.Cedula}\nFecha Nacimiento: {candidato.Fecha_nacimiento}\nFecha Aplicacion: {candidato.Fecha_aplicacion}\n");

            app.Quit();
        }
    }
}