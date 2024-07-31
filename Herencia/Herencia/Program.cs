using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            //instancia estudiante
            Estudiante estudiante = new Estudiante();
            estudiante.setNombre("Fabian");
            estudiante.setApellido1("Mora");
            estudiante.setApellido2("alias");
            estudiante.setIdentificacion("4342423");
            estudiante.setEdad(32);
            estudiante.setCarnet("cat12");

            estudiante.Presentacion();
            estudiante.soy();
            //instancia el profesor
            Profesor profesor = new Profesor("Rogelio","sanabria","campos","324324",32,"base de datos","bachiller");
            profesor.Presentacion();
            profesor.soy();
            Console.ReadLine();
        }
    }
}
