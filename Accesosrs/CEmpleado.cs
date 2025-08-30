using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesosrs
{
    class CEmpleado  // En esta parte se redujo el código para simplificar el problema
    {
        private double sueldo;
        private double impuesto;
        string dato = "";
        int elec = 0;

        CContador c1 = new CContador(25, "50");

        public void Muestra()
        {
            Console.WriteLine("Sueldo={0}, impuesto={1}", sueldo, impuesto);
        }

        public double Sueldo  // Para este caso tenemos propiedad de lectura y escritura
        {                      // pero se puede usar sólo una de estas dependiendo de la necesidad
            get
            {
                return sueldo;   // Propiedad de lectura
            }

            set
            {
                sueldo = value;  // Propiedad de escritura
            }
        }

        public double Impuesto
        {
            get
            {
                return impuesto;
            }
        }

        // Mutator
        public void CalculaImpuesto()
        {
            Console.WriteLine("seleccione 1. Si añade tasa de impuesto manual ");
            Console.WriteLine("seleccione 2. Si deja tasa por defecto ");
            dato = Console.ReadLine();
            elec = Convert.ToInt32(dato);
            if (elec == 2)
            {
                impuesto = sueldo * 0.16;
            }
            else
            {
                tImp = c1.cImp();
                impuesto = sueldo * tImp;
            }
        }

    }
}
