using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class CEdificio
    {
        private string direccion;
        private int CantDepartamentos;
        private int DepRentados;

        public CEdificio(string pDireccon, int pCantidad, int pRentados)
        {
            direccion = pDireccon;
            CantDepartamentos = pCantidad;
            DepRentados = pRentados;
        }

        public void Muestra()
        {
            Console.WriteLine("Edificio en {0} con {1} departamentos, {2} rentados", direccion, CantDepartamentos, DepRentados);
        }
    }
}
