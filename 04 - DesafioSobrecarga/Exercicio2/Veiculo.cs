using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Veiculo
    {
        public string Placa { get; set; }

        public string Marca { get; set; }

        public string Modelo { get; set; }

        public int Ano { get; set; }

        public Veiculo()
        {

        }

        public Veiculo(string placa, string marca, string modelo, int ano)
        {
            Placa = placa; Marca = marca; Modelo = modelo; Ano = ano; 
        }

        public bool Validacao()
        {
            if(Ano >= 1900 & Ano <= 2017)
                return false;
            
            return true;
        }
    }
}
