﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
     class Persona
    {
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string identificacion;
        private int edad;

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getApellido1()
        {
            return apellido1;
        }
        public void setApellido1(string apellido1)
        {
            this.apellido1 = apellido1;
        }
        public string getApellido2() 
        { 
            return apellido2;
        }
        public void setApellido2(string apellido2)
        {
            this.apellido2 = apellido2;
        }
        public string getIdentificacion() 
        { 
            return identificacion; 
        }
        public void setIdentificacion(string identificacion)
        {
            this.identificacion = identificacion;
        }
        public int getEdad()
        {
            return edad;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public Persona()
        {

        }
        public Persona(string nombre, string apellido1, string apellido2, string identificacion, int edad)
        {
            this.nombre = nombre;
            this.apellido1 = apellido1;
            this.apellido2 = apellido2;
            this.identificacion = identificacion;
            this.edad = edad;
        }
        //metodos
        public void Presentacion()
        {
            Console.WriteLine("Soy una Persona me llamo {0}",nombre);
        }
        //metodos para aplicar polimorfismo
        public void soy()
        {
            Console.WriteLine("Soy una Persona");
        }
    }

}
