using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4
{
    internal class Empregado
    {
        public string Nome { get; set; }

        public string Funcao { get; set; }

        public double Salario { get; set; }

        public Empregado(string nome, string funcao, double salario)
        {
            Nome = nome; Funcao = funcao; Salario = salario; 
        }

        public double AumentarSalario(double valorAumento)
        {
            Salario = valorAumento + Salario;
            return Salario;
            
        }
    }
}
