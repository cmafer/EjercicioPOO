using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g7eje1
{
    internal class ProductoAlimenticio : Producto
    {

        public ProductoAlimenticio(string nombre, double precioBase) : base(nombre, precioBase)
        {

        }

        public double CalcularPrecioFinal()
        {
            return precioBase;
        }

    }
}
