using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesosrs
{
    class CEmpleado
    {
        private double sueldo;
        private double impuesto;

        public void Muestra()
        {
            Console.WriteLine("Sueldo={0}, impuesto={1}", sueldo, impuesto);
        }

        // Accesor, get, y set
        public void set_sueldo(double pSueldo)
        {
            sueldo = pSueldo;
        }

        public double get_sueldo()
        {
            return sueldo;
        }

        public double get_impuesto()
        {
            return impuesto;
        }

        // Mutator
        public void CalculaImpuesto()
        {
            impuesto = sueldo * 0.16;
        }
    }
}
