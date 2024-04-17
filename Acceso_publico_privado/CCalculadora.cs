using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_publico_privado
{
    class CCalculadora
    {
        // Declaramos los atributos
        public double a;
        public double b;

        // Declaramos el dato
        private double r;

        // Declaromos los metodos
        public void Suma()
        {
            // Se lleva a cabo una acción
            r = a + b;
            Muestra();
        }

        public void Muestra()
        {
            Console.WriteLine("a={0}, b={1}, r={2}", a, b, r);
        }
    }
}
