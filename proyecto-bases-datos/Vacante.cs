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

        public Vacante(string nombre_empresa, string nombre_puesto, string descripcion, string requisitos, float salario)
        {            
            this.nombre_empresa = nombre_empresa;
            this.nombre_puesto = nombre_puesto;
            this.descripcion = descripcion;
            this.requisitos = requisitos;
            this.salario = salario;
        }

        public Vacante()
        {
            nombre_empresa = "";
            nombre_puesto = "";
            descripcion = "";
            requisitos = "";
            salario = 0;
        }

    }
}
