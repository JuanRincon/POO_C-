﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class CPez:CAnimal
    {
        public override void Moverse()
        {
            Console.WriteLine("El pez {0} nada", nombre);
        }
    }
}
