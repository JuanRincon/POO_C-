using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambitos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Esta variable sólo se conoce en main
            int a = 5;

            a = a * 5;
            Console.WriteLine("a = {0}", a);

            // Tratamos de usar el directamente el dato de la clase
            // No se puede
            //b = 30;
            //Consolo.WriteLine("b={0}", b);

            // Instanciamos ahora
            CMiClase objeto = new CMiClase();

            objeto.Muestra();
            objeto.Multiplicador();
            objeto.Muestra();
        }
    }
}
