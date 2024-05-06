using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accesosrs
{
    class CContador
    {
        private double tasaImp = 0.0;
        private string dato = "";
        public CContador(double tImp, string dt)
        {
            tasaImp = tImp;
            dato = dt;
        }

        double TasaImp
            get { return tasaImp; }

        public double cImp()
        {
            Console.WriteLine("Ingrese la tasa de impuesto");
            dato = Console.ReadLine();
            tasaImp = double.Parse(dato);
            return tasaImp;
        }
    }
}
