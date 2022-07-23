using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros
{
    internal class SeguroAutomovel : Seguro
    {
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public int Ano { get; set; }

        public int Quilometragem { get; set; }

        public SeguroAutomovel(TipoSeguro tipo) : base(tipo)
        {
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("---- Seguro Automóvel ----");
            Console.WriteLine($"Data de contratação: {DataContratacao}");
            Console.WriteLine($"Marca do automóvel: {Marca}");
            Console.WriteLine($"Marca do automóvel: {Modelo}");
            Console.WriteLine($"Ano do automóvel:{Ano}");
            Console.WriteLine($"Quilometragem do automóvel: {Quilometragem} km");
            Console.WriteLine("Valor do automóvel: " + (Valor).ToString("C"));
            Console.WriteLine("-------------------------");
        }

        public bool Validar()
        {
            if (Modelo == "" || Marca == "" || Valor == 0)
            {
                Console.WriteLine("É obrigatório o preenchimento de todos os campos");
                return false;
            }
            else if(Ano == 0 || Quilometragem == 0)
            {
                Console.WriteLine("É obrigatório o preenchimento de todos os campos");
                return false;
            }
            else
            {
                Console.WriteLine("Seguro de celular adicionado com sucesso!");
                return true;
            }
        }
    }
}
