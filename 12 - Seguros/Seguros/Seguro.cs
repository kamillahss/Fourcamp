using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros
{
    public abstract class Seguro
    {
        public double Valor { get; set; }

        public DateTime DataContratacao { get; set; } 

        public TipoSeguro Tipo { get; set; }

        public Seguro(TipoSeguro tipo)
        {
            Tipo = tipo;
        }

        public abstract void ExibirInformacoes();
    }
}
