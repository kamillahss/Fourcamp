using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioComplemento
{
    public abstract class FormaPlana : Forma
    {

        public int X { get; set; }

        public int Y { get; set; }

        public override double CalcularArea()
        {
            return 0;
        }
    }
}
