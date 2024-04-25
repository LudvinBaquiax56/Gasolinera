using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gasolinera
{
    internal class Bomba
    {
        public string Codigo { get; set; }
        public int LitrosDisponibles { get; set; }

        public Bomba(string codigo, int litrosDisponibles)
        {
            Codigo = codigo;
            LitrosDisponibles = litrosDisponibles;
        }

    }
}
