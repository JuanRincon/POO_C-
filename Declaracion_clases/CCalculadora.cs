﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Declaracion_clases
{
    class CCalculadora
    {
        // Declaromos los atributos
        public double a;
        public double b;
        public double r;

        // Declaromos los metodos
        public void Suma()
        {
            // Se lleva a cabo una acción
            r = a + b;
        }

        public void Muestra()
        {
            Console.WriteLine("a={0}, b={1}, r={2}", a, b, r);
        }
    }
}
