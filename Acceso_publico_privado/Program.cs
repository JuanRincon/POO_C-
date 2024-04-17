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
            // Creamos intancia
            CCalculadora calcu1 = new CCalculadora();

            // Accedemos a los atributos para colocar información
            calcu1.a = 4;
            calcu1.b = 3;
            // Mostramos los datos
            calcu1.Muestra();

            // Intento acceder al dato privado
            // No se puede
            //calcu1.r = 8;
            //Console.WriteLine(calcu1.r);

            // Invocamos metodo
            calcu1.Suma();

            // Mostramos nuevamento los datos
            calcu1.Muestra();

            //-----------
            Console.WriteLine("---------------------");
            // Creamos otro objeto y asignamos valores
            CCalculadora miCalcu = new CCalculadora();
            miCalcu.a = 18;
            miCalcu.b = 53;
            miCalcu.Muestra();
            miCalcu.Suma();
            calcu1.Muestra();
            miCalcu.Muestra();
        }
    }
}
