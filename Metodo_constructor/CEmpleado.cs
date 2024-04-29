using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    sealed class CEmpleado:CPersona   // Al colocar el sealed a la clase la sellamos
                                      // lo que significa que no se puede heredar de ella
    {
        private string puesto;
        private double salario;

        public CEmpleado(string pNombre, int pEdad, string pPuesto, double pSalario)
            : base(pNombre, pEdad)
        {
            Console.WriteLine("Constructor Empleado");
            puesto = pPuesto;
            salario = pSalario;
        }

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
            // Las dos propiedades siguientes ya no las necesito porque nombre y edad
            // ya son protected y no privados desde la clase base o padre
            //Nombre = pNombre;   // Ojo nos muestra la propiedad de la superclase no el atributo
            //Edad = pEdad;

            nombre = pNombre;
            edad = pEdad;

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
