using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    public class Cor
    {
        public int Red { get; set; }

        public int Green { get; set; }

        public int Blue { get; set; }

        public Cor()
        {

        }

        public Cor(int red)
        {
            Red = red;
        }

        public Cor(int red, int green)
        {
            Red = red;
            Green = green;
        }

        public Cor(int red, int green, int blue)
        {
            Red = red;
            Green = green;
            Blue = blue;
        }

        public string ObterCor()
        {
            return $"({Red}, {Green}, {Blue})";
        }

    }
}
