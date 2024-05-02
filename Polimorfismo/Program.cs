﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            string valor;
            int opcion;

            // Sin polimorfismo, queda concreto a la clase

            //Console.WriteLine("¿Qué mascota quieres? 1-Gato, 2-Reptil");
            //valor = Console.ReadLine();
            //opcion = Convert.ToInt32(valor);

            //if (opcion == 1)
            //{
            //    CGato migato = new CGato();
            //    migato.Nombre = "Fuzzy";
            //    migato.Moverse();
            //}
            //if (opcion == 2)
            //{
            //    CReptil mireptil = new CReptil();
            //    mireptil.Nombre = "Lizardo";
            //    mireptil.Moverse();
            //}

            Console.WriteLine("-------------");

            // Con polimorfismo, el código se concentra en el concepto no en la clase
            Console.WriteLine("Qué mascota quieres? 1-Perro, 2-Pez, 3-Ave");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);

            // Creamos la variable que tendrá polimorfismo
            CAnimal miMascota = new CAnimal();

            // Basado en la seleccion le damos el comportamiento seleccionado
            if (opcion == 1)
                miMascota = new CPerro();
            if (opcion == 2)
                miMascota = new CPez();
            if (opcion == 3)
                miMascota = new CAnimal();

            // Ahora trabajamos en términos del concepto Animal y no en términos de clases específicas
            Console.WriteLine("Dame el nombre");
            miMascota.Nombre = Console.ReadLine();

            miMascota.Moverse();
        }
    }
}
