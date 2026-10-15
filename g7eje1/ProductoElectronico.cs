using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g7eje1
{
    internal class ProductoElectronico : Producto
    {
        private double costoGarantia;

        public ProductoElectronico(string nombre, double precioBase, double costoGarantia) : base(nombre,precioBase)
        {
            this.costoGarantia = costoGarantia;

        }

        //aplicando IVA del 13% + costo de garantia

        public double CalcularPrecioFinal()
        {
            return (precioBase * 1.13) + costoGarantia;
        }


    }
}
