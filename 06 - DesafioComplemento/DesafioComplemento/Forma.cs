using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioComplemento
{
    public abstract class Forma
    {
        public string Nome { get; set; }

        public abstract double CalcularArea();
    }
}
