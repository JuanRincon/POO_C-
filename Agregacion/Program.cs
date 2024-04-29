using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de Composición

            // Creamos al propietario
            CPropietario Juan = new CPropietario("Juan");

           // Mostramos al propietario
            Juan.MostrarPropiedad();
            Console.WriteLine("--------");
        }
    }
}
