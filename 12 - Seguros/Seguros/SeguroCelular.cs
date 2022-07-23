using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros
{
    internal class SeguroCelular : Seguro
    {
       
        public string Modelo { get; set; }

        public string Marca { get; set; }

        public SeguroCelular(TipoSeguro tipo) : base(tipo)
        {
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("---- Seguro Celular ----");
            Console.WriteLine($"Data de contratação: {DataContratacao} ");
            Console.WriteLine($"Modelo do celular: {Modelo}");
            Console.WriteLine($"Marca do celular: {Marca}");
            Console.WriteLine("Valor do celular: " + (Valor).ToString("C"));
            Console.WriteLine("-------------------------");
        }

        public bool Validar()
        {
            if(Modelo == "" || Marca == "" || Valor == 0)
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
