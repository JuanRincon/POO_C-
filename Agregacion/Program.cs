using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agregacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo de agregación

            // Creamos al propietario

            CPropietario Juan = new CPropietario("Juan");

            // Creamos la propiedad

            CEdificio edif1 = new CEdificio("Av. 1 num 56", 10, 3);

            // Vemos info del propietario

            Juan.MostrarPropiedad();

            // Le colocamos la propiedad

            Juan.AdicionaPropiedad(edif1);
            Juan.MostrarPropiedad();

            // Eliminamos a Juan
            Juan = null;         // Luego de eliminar el contenido de Juan
            GC.Collect();      // GC.Collect borra todos los datos nulos
            // Juan.MostrarPropiedad(); por lo que al ejecutar el objeto Juan sale un error

            Console.WriteLine("-----");

            // Verificamos que el edificio exista independiente de Juan
            edif1.Muestra();
        }
    }
}
