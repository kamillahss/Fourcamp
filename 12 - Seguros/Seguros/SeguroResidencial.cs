using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seguros
{
    internal class SeguroResidencial : Seguro
    {
        
        public string Cidade { get; set; }

        public double Area { get; set; }

        public SeguroResidencial(TipoSeguro tipo) : base(tipo)
        {
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine("---- Seguro Residencial ----");
            Console.WriteLine($"Data de contratação: {DataContratacao} ");
            Console.WriteLine($"Modelo da residência: {Cidade}");
            Console.WriteLine($"Área de residência: {Area} m²");
            Console.WriteLine("Valor da residência: " + (Valor).ToString("C"));
            Console.WriteLine("-------------------------");
        }

        public bool Validar()
        {
            if (Cidade == "" || Area == 0 || Valor == 0)
            {
                Console.WriteLine("É obrigatório o preenchimento de todos os campos");
                return false;
            }
            else
            {
                Console.WriteLine("Seguro residencial adicionado com sucesso!");
                return true;
            }
        }
    }
}
