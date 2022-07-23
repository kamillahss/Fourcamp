﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioComplemento
{
    internal class Circulo : FormaPlana
    {
       
        public const double PI = 3.1416;
        public double Raio { get; set; }

        public Circulo(double raio)
        {
            Raio = raio;
        }
        public override double CalcularArea()
        {
            return PI * (Raio * Raio);
        }
    }
}
