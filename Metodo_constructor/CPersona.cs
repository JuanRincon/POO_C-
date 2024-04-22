using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_constructor
{
    class CPersona
    {
        private string nombre;
        private int edad;

        public CPersona()
        {
            string tempEdad = "";

            Console.WriteLine("Estamos en el cosntructor");
            Console.WriteLine("Dame el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Dame la edad");
            tempEdad = Console.ReadLine();
            edad = Convert.ToInt32(tempEdad);
        }

        // Sobrecarga
        public CPersona(string pNombre, int pEdad)
        {
            Console.WriteLine("Estamso en el constructor sobrecargado");

            nombre = pNombre;
            edad = pEdad;
        }

        public string Nombre
        {
            set
            {
                nombre = value;
            }
        }

        public int Edad
        {
            set
            {
                edad = value;
            }
        }

        public void muestra()
        {
            Console.WriteLine("Nombre: {0}, Edad: {1}", nombre, edad);
        }
      
    }
}
