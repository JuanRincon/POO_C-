using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_publico_privado
{
    class CCalculadora
    {
        // Declaromos los metodos
        public double Suma(double a, double b)
        {
            double r = 0.0;
   
            r = a + b;

            return r;
        }

        public int Suma(int a, int b)
        {
            int r = 0;

            r = a + b;

            return r;
        }

        public int Suma(int a, int b, int c)
        {
            int r = 0;

            r = a + b + c;

            return r;
        }

    }
}
