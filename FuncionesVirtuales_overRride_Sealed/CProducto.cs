﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_abstracta
{
    abstract class CProducto
    {
        protected string descripcion;
        protected double precioCompra;
        protected double precioVenta;

        public CProducto(string pDescripcion, double pPrecioCompra)
        {
            descripcion = pDescripcion;
            precioCompra = pPrecioCompra;
            precioVenta = 0.0;
        }

        public virtual void CalculaPrecio()
        {
            Console.WriteLine("Calcula precio de producto");
            precioVenta = precioCompra * 1.3;
        }

        public abstract void MuestraVenta();
    }
}
