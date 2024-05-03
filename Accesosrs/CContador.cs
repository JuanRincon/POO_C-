using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesosrs
{
    class CContador
    {
        double tasaImp = 0.0;
        string dato = "";
        public CContador()
        {
            
        }
        public double cImp()
        {
            Console.WriteLine("Ingrese la tasa de impuesto");
            dato = Console.ReadLine();
            tasaImp = double.Parse(dato);
            return tasaImp;
        }
    }
}
