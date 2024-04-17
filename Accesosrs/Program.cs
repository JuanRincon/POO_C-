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
            double impuesto = 0.0;
            // Creamos objeto
            CEmpleado Juan = new CEmpleado();

            // No podemos hacer esto
            //Juan.sueldo = 10000;

            Juan.set_sueldo(10500.50);

            Juan.Muestra();
            Juan.CalculaImpuesto();

            impuesto = Juan.get_impuesto();

            Console.WriteLine("El impuesto es {0}", impuesto);

            Juan.Muestra();
        }
    }

}
