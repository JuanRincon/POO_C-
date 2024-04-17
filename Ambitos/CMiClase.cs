using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambitos
{
    class CMiClase
    {
        // Estos datos s epueden ver en culaquier lugar de la clase
        // pero no fuera de ella, ambito objeto
        private int b = 10;

        public void Muestra()
            {
            // Creamos una variable local a Muestra
            // Ambito local
            int m = 5;
            int b = 3;

            // Podemos usar la variable local
            Console.WriteLine("m={0}", m);

            // Tratamos de mostrar la varible de main
            // No se puede
            // Console.WriteLine("a={0}", a);

            // Tratamos de mostrar el dato del método
            Console.WriteLine("Ambito local b={0}", b);
            // Tratamos de mostrar el dato del objeto
            Console.WriteLine("Ambito de objeto b={0}", this.b);

        }

        public void Multiplicador()
        {
            // Tratamos de usar el dato de la clase
            b = b * 5;

            // Tratamos de usar la variable local del otro método
            // No se puede
            //m = m * 100;
        }
    }
}
