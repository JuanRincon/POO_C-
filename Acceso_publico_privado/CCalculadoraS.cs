﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos_estaticos
{
    class CCalculadoraS
    {
        public static double suma(double a, double b)
        {
            return a + b;
        }

        public static double resta(double a, double b)
        {
            return a - b;
        }

        public void saludo()
        {
            Console.WriteLine("Hola");
        }
    }
}
