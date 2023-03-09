using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_bases_datos
{
    class Puesto
    {
        private string nombre;
        private string nombre_empresa;
        private float salario;

        public Puesto(string nombre, string nombre_empresa, float salario)
        {
            this.nombre = nombre;
            this.nombre_empresa = nombre_empresa;
            this.salario = salario;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Nombre_empresa
        {
            get { return nombre_empresa; }
            set { nombre = value; }
        }
    }
}
