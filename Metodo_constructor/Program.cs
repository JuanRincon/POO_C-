using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            CPersona p1 = new CPersona();

            p1.Nombre = "Juan";
            p1.Edad = 27;

            p1.muestra();
        }
    }
}
