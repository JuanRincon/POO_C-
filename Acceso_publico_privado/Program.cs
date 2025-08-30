using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_estaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0.0;

            // Clase normal

            CCalculadora miCalcu = new CCalculadora(5, 3);
            miCalcu.suma();
            Console.WriteLine("La suma es {0}", miCalcu.R);

            miCalcu.resta();
            Console.WriteLine("La resta es {0}", miCalcu.R);

            // Clase con metodos  estaticos

            r = CCalculadoraS.suma(6, 9);
            Console.WriteLine("La suma es {0}", r);

            r = CCalculadoraS.resta(45, 67);
            Console.WriteLine("La suma es {0}", r);

            // Si queremos implementar el objeto saludo de la clase CCalculadoraS
            // toca crear un objeto
            CCalculadoraS sCal = new CCalculadoraS();
            sCal.saludo();

            // Si invocamos a uno de los elementos estaticos como objeto no funciona
            // sCal.suma();
        }

    }
}
