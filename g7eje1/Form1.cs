using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g7eje1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnRopa_Click(object sender, EventArgs e)
        {
            ProductoRopa producto = new ProductoRopa(TxtNombre.Text, double.Parse(TxtPrecio.Text));
            LblPrecioFinal.Text = "Precio final: $ " + producto.CalcularPrecioFInal().ToString("0.00");
         

        }

        private void BtnElectronico_Click(object sender, EventArgs e)
        {
            ProductoElectronico producto = new ProductoElectronico(TxtNombre.Text, double.Parse(TxtPrecio.Text), 10.00);
            LblPrecioFinal.Text = "Precio final $ " + producto.CalcularPrecioFinal().ToString("0.00");

        }

        private void BtnAlimenticio_Click(object sender, EventArgs e)
        {
            ProductoAlimenticio producto = new ProductoAlimenticio(TxtNombre.Text, double.Parse(TxtPrecio.Text));
            LblPrecioFinal.Text = "Precio final $ " + producto.CalcularPrecioFinal().ToString("0.00");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
