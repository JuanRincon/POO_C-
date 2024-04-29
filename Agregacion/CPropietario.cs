﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class CPropietario
    {
        private string nombre;
        private CEdificio propiedad = null;
        
        public CPropietario(string pNombre)
        {
            nombre = pNombre;
            propiedad = new CEdificio("Av 2 numero 32", 7, 4);
        }

        public void MostrarPropiedad()
        {
            if (propiedad != null)
            {
                Console.Write("{0} tiene ", nombre);
                propiedad.Muestra();
            }

            else
                Console.WriteLine("{0} aun no tiene propiedades", nombre);
        }
    }
}
 