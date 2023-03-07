using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Office.Interop.Word;

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
            app.Quit();
        }
    }
}