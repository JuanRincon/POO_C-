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
            CEmpleado uno = new CEmpleado("Susana", 25, "Programadora", 150000.30);
            uno.EmpleadoMuestra();
            Console.WriteLine("--------");
            uno.Edad = 15;

            uno.ponerDatos("Susana", 23, "Programadora", 180000.70);
            uno.EmpleadoMuestra();
        }
    }
}
