using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    internal class Horario
    {
        public int Hora { get; set; }

        public int Minuto { get; set; }

        public int Segundo { get; set; }

        public Horario(int hora, int minuto, int segundo)
        {
            Hora = hora; int Minuto = minuto; Segundo = segundo;
        }

        public string ObterHora()
        {
            return $"{Hora}:{Minuto}:{Segundo}";
        }
    }
}
