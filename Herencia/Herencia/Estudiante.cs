using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    //Herencia con : se refiere para indicar Herencia
     class Estudiante:Persona
    {
        private string carnet;

        //crear el constructor
        public Estudiante()
        {
        }
        //se utiliza la palabra reservada base para indicar  y poder pasar como parametro los otros atributos de la clase padre y solo se inidca en este caso un constructor para esta clase 
        // ya que el otro tiene uno y no hace falta
        public Estudiante(string nombre,string apellido1,string apellido2,string identificacion,int edad,string carnet):base(nombre,apellido1,apellido2,identificacion,edad)
        {
            
            this.carnet = carnet;
        }
        public string getCarnet()
        {
            return carnet;
        }
        public void setCarnet(string carnet)
        {
            this.carnet = carnet;
        }
        //Metodos
        //se utiliza el metodo new
        public new void soy()
        {
            Console.WriteLine("Soy una Persona Estudiante me llamo {0}",getNombre());
        }
    }

}
