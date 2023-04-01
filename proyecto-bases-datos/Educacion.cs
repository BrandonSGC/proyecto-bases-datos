using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_bases_datos
{
    class Educacion
    {
        private string centro_educativo;
        private string fecha_inicio;
        private string fecha_finalizacion;
        private string descripcion;

        public Educacion()
        {
            this.centro_educativo = "";
            this.fecha_inicio = "";
            this.fecha_finalizacion = "";
            this.descripcion = "";
        }

        public string Centro_educativo
        {
            get { return centro_educativo; }
            set { centro_educativo = value; }
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
