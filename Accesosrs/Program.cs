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

            Juan.set_sueldo(7800);
            Juan.CalculaImpuesto();
            Juan.Muestra();
            Juan.MuestraLog();

            Console.WriteLine("----------------");

            CEmpleado Jose = new CEmpleado();

            Jose.set_sueldo(50000); // Se ingresen valores errados a proposito para revisar
            Jose.set_sueldo(25000); // la salida con estos valores
            Jose.set_sueldo(10000);

            Console.WriteLine("El sueldo de Jose {0}", Jose.get_sueldo(56)); // el 56 es
                                                                             // la password errada 
            Jose.Muestra();
            Jose.MuestraLog();
        }
    }

}
