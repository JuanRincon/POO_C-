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

            CPersona p2 = new CPersona("Juan", 27);

            p1.muestra();
            p2.muestra();

        }
    }
}
