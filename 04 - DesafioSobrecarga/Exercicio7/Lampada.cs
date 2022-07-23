using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio7
{
    internal class Lampada
    {
        public string Cor { get; set; }

        public bool Ligada { get; set; }

        public Lampada()
        {

        }

        public Lampada(string cor, bool ligada)
        {
            Cor = Cor; Ligada = ligada;
        }

        public Lampada(string cor)
        {
            Cor = Cor;
            Ligada = true;
        }
    }
}
