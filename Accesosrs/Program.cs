using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesosrs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creamos objeto
            CEmpleado Juan = new CEmpleado();

            Juan.Sueldo = 15000;   // Aquí se están utilizando las propiedades de C# para Accesors
            Juan.CalculaImpuesto();

            Console.WriteLine("El sueldo de Juan {0}", Juan.Impuesto);

            Juan.Muestra();
        }
    }

}
