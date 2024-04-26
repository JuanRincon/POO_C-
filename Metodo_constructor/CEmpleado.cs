using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    class CEmpleado:CPersona
    {
        private string puesto;
        private double salario;

        public string Puesto
        {
            get
            {
                return puesto;
            }

            set
            {
                puesto = value;
            }
        }

        public double Salario
        {
            get
            {
                return salario;
            }

            set
            {
                salario = value;
            }
        }

        public void ponerDatos(string pNombre, int pEdad, string pPuesto, double pSalario)
        {
            Nombre = pNombre;   // Ojo nos muestra la propiedad de la superclase no el atributo
            Edad = pEdad;

            puesto = pPuesto;
            salario = pSalario;
        }

        public void EmpleadoMuestra()
        {
            Muestra();
            Console.WriteLine("Trabajo de {0} con sueldo de ${1}", puesto, salario);
        }
    }
}
