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
            CPersona uno = new CPersona();
            uno.Nombre = "Maria";
            uno.Edad = 27;

            uno.Muestra();
            Console.WriteLine("--------");

            // Creamos un objeto d la clase Empleado
            CEmpleado dos = new CEmpleado();

            // Colocamos la información usando las propiedades de su clase base
            dos.Nombre = "Juan";
            dos.Edad = 30;

            dos.Puesto = "Contador";
            dos.Salario = 10500.50;

            // Usamos la muestra de empleado
            dos.EmpleadoMuestra();

            // Verificamos que podemos usar la muestra de la clase base
            dos.Muestra();

            Console.WriteLine("--------");

            // Creamos otro empleado
            CEmpleado tres = new CEmpleado();

            tres.ponerDatos("Susana", 15, "Programadora", 150000.30);

            tres.EmpleadoMuestra();
        }
    }
}
