using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_publico_privado
{
    class Program
    {
        static void Main(string[] args)
        {
            int rInt = 0;
            double rDoub = 0.0;

            CCalculadora calcu = new CCalculadora();

            rInt = calcu.Suma(5, 3, 8);

            Console.WriteLine("El resultado es {0}", rInt);

            rDoub = calcu.Suma(3.9, 4.5);

            Console.WriteLine("El resultado es {0}", rDoub);

        }

    }
}
