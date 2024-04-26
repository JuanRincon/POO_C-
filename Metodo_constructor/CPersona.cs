using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class CPersona
    {
        private string nombre;
        private int edad;

        public string Nombre
        {
            set
            {
                nombre = value;
            }

            get
            {
                return nombre;
            }
        }  

        public int Edad
        {
            set
            {
                if (value >= 18)
                {
                    edad = value;
                }
                else
                {
                    edad = -1;
                    Console.WriteLine("Edad no permitida");
                }
            }

            get
            {
                return edad;
            }
        }

        public void Muestra()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}", nombre, edad);
        }
    }
}
