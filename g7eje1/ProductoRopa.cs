using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace g7eje1
{
    internal class ProductoRopa : Producto
    {

        public ProductoRopa(string nombre, double precioBase) : base(nombre, precioBase)
        {
        }

        public double CalcularPrecioFInal()
        { return precioBase * 1.13; }


    }
}
