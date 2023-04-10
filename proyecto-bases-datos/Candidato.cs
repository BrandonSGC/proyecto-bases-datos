using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_bases_datos
{
    class Candidato
    {
        // Attributes
        private int cedula;
        private string nombre;
        private string apellidos;
        private string fecha_nacimiento;
        private string fecha_aplicacion;
        private string puesto;
        private string idiomas;


        // Constructors
        public Candidato(int cedula, string nombre, string apellidos, string fecha_nacimiento, string fecha_aplicacion, string puesto)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.fecha_nacimiento = fecha_nacimiento;
            this.fecha_aplicacion = fecha_aplicacion;
            this.puesto = puesto;
        }

        public Candidato()
        {
            this.cedula = 0;
            this.nombre = "";
            this.apellidos = "";
            this.fecha_nacimiento = "";
            this.fecha_aplicacion = "";
            this.puesto = "";
        }

        // Getters & Setters
        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public string Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }

        public string Fecha_aplicacion
        {
            get { return fecha_aplicacion; }
            set { fecha_aplicacion = value; }
        }

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }

        public string Idiomas
        {
            get { return idiomas; }
            set { idiomas = value; }
        }
    }
}
