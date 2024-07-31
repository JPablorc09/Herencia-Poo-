using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Profesor : Persona
    {
        protected string especialidad;
        protected string gradoAcademico;

        public Profesor()
        {
        }
        public Profesor(string nombre, string apellido1, string apellido2, string identificacion, int edad, string especialidad, string gradoAcademico) 
           : base(nombre, apellido1, apellido2,identificacion,edad)
        {
            this.especialidad = especialidad;
            this.gradoAcademico = gradoAcademico;
        }
        public string getEspecialidad()
        {
            return especialidad;
        }
        public void setEspecialidad(string especialidad)
        {
            this.especialidad=especialidad;
        }
        public string getGradoAcademico()
        {
            return gradoAcademico;
        }
        public void setGradoAcademico(string gradoAcademico)
        {
            this.gradoAcademico=gradoAcademico;
        }
        //metodo polimorfismo
        public new void soy()
        {
            Console.WriteLine("Soy un Profesor me llamo {0}", getNombre());

        }
    }
}
