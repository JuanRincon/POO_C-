using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos objeto de la clase persona
            CPersona uno = new CPersona("Maria", 27);

            uno.Muestra();
            Console.WriteLine("--------");

            // Creamos un objeto d la clase Empleado
            CEmpleado dos = new CEmpleado("Juan", 30, "Contador", 10500.00);

            // Usamos la muestra de empleado
            dos.EmpleadoMuestra();

            Console.WriteLine("--------");

            // Creamos otro empleado
            CEmpleado tres = new CEmpleado("Susana", 25, "Programadora", 150000.30);
            tres.EmpleadoMuestra();
            Console.WriteLine("--------");
            tres.ponerDatos("Susana", 15, "Programadora", 180000.70);
            tres.EmpleadoMuestra();

        }
    }
}
