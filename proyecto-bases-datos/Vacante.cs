using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_bases_datos
{
    class Vacante
    {
        private string nombre_empresa;
        private string nombre_puesto;
        private string descripcion;
        private string requisitos;        
        private float salario;
        private string idiomas;
        
        public string NombreEmpresa
        {
            get { return nombre_empresa; }
            set { nombre_empresa = value; }
        }

        public string NombrePuesto
        {
            get { return nombre_puesto; }
            set { nombre_puesto = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Requisitos
        {
            get { return requisitos; }
            set { requisitos = value; }
        }

        public float Salario
        {
            get { return salario; }
            set { salario = value; }
        }

        public string Idiomas
        {
            get { return idiomas; }
            set { idiomas = value; }
        }

        public Vacante(string nombre_empresa, string nombre_puesto, string descripcion, string requisitos, float salario, string idiomas)
        {            
            this.nombre_empresa = nombre_empresa;
            this.nombre_puesto = nombre_puesto;
            this.descripcion = descripcion;
            this.requisitos = requisitos;
            this.salario = salario;
            this.idiomas = idiomas;
        }

        public Vacante()
        {
            nombre_empresa = "";
            nombre_puesto = "";
            descripcion = "";
            requisitos = "";
            salario = 0;
            idiomas = "";
        }

    }
}
