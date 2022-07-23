using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPolimorfismo
{
    internal class Cliente : Pessoa
    {
        public string Titulo { get; set; }

        public Cliente(string titulo, string nome) : base(nome)
        {
            Titulo = titulo;
            Nome = nome;
        }

        public override void ExibirNomeFormatado()
        {
            Console.WriteLine($"{Titulo.ToUpper()} - {Nome.ToUpper()}");
        }
    }
}
