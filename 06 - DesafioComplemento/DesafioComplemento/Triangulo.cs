using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioComplemento
{
    internal class Triangulo : FormaPlana
    {
        public double Altura { get; set; }

        public double Base { get; set; }

        public Triangulo(double altura, double base1)
        {
            Altura = altura;
            Base = base1;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }
}
