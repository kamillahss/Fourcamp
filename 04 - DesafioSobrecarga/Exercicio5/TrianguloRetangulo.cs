using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    public class TrianguloRetangulo
    {

        public double Cateto1 { get; set; }

        public double Cateto2 { get; set; }
        public TrianguloRetangulo()
        {
        }

        public TrianguloRetangulo(double cateto1, double cateto2)
        {
            Cateto1 = cateto1;
            Cateto2 = cateto2;
        }

        public double CalcularHipotenuza()
        {
            return Math.Sqrt(Math.Pow(Cateto1, 2) + Math.Pow(Cateto2, 2));
        }
    }
}
