using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_bases_datos
{
    class Experiencia
    {
        private string empresa;
        private string fecha_inicio;
        private string fecha_finalizacion;
        private string descripcion;

        public Experiencia()
        {
            this.empresa = "";
            this.fecha_inicio = "";
            this.fecha_finalizacion = "";
            this.descripcion = "";
        }

        public string Empresa
        {
            get { return empresa; }
            set { empresa = value; }
        }

        public string Fecha_inicio
        {
            get { return fecha_inicio; }
            set { fecha_inicio = value; }
        }

        public string Fecha_finalizacion
        {
            get { return fecha_finalizacion; }
            set { fecha_finalizacion = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
    }
}
