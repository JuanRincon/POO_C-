using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_abstracta
{
    class Program
    {
        static void Main(string[] args)
        {
            // Clases abstractas y metodos abstractos

            // No podemos intanciar clase abstracta directamente
            // CProducto miProducto = new CProducto("bicicleta", 3500);

            CProductoImportado miProdImp = new CProductoImportado("Motocicleta", 350000, 0.15);
            CProductoDetenido miProdDet = new CProductoDetenido("Televisor", 15000, 0.15, 0.30);

            miProdImp.CalculaPrecio();
            miProdDet.CalculaPrecio();

            miProdImp.MuestraVenta();
            miProdDet.MuestraVenta();
        }
    }
}
