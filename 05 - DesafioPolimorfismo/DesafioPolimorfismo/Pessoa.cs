using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPolimorfismo
{
    internal class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public virtual void ExibirNomeFormatado()
        {
            Console.WriteLine(Nome.ToUpper());
        }
    }
}
