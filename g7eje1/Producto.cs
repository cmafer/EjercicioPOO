using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace g7eje1
{
    internal class Producto
    {
        protected string nombre;
        protected double precioBase;

        public Producto(string nombre, double precioBase)
        {
            this.nombre = nombre;
            this.precioBase = precioBase;
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public double PrecioBase
        {
            get { return precioBase; }
            set { precioBase = value; }
        }

    }
}
