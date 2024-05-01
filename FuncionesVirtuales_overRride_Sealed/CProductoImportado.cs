using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_abstracta
{
    class CProductoImportado:CProducto
    {
        protected double impuesto;
        
        public CProductoImportado(string pDescripcion, double pPrecioCompra, double pImpuesto)
            : base(pDescripcion, pPrecioCompra)
        {
            impuesto = pImpuesto;
        }

        public override void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de importado");
            precioVenta = (precioCompra * (1 + impuesto)) * 1.30;
        }

        // Si no realizo la implementación de muestra venta que sigue abajo nos
        // mostrará un heero en la clase CProductoImportado
        public override void MuestraVenta()
        {
            Console.WriteLine("El gran producto {0} se vende en ${1}!!!!", descripcion, precioVenta);
        }
    }
}
