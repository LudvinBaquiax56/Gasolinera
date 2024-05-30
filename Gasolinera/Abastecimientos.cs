using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera
{
    internal class Abastecimientos
    {
        public string Nombre {  get; set; }
        public string Tipo { get; set; }
        public int Precio { get; set; }
        public int LitrosVendidos {  get; set; }
        public int Total {  get; set; } 
        public DateTime Fecha { get; set; }

        public Abastecimientos()
        {
            Nombre = string.Empty;
            Tipo = string.Empty;
            Precio = 0;
            LitrosVendidos = 0;
            Total = 0;
            Fecha = DateTime.Now;
        }

        public void CalcularTotal()
        {
            Total = Precio * LitrosVendidos;
        }

    }
}
