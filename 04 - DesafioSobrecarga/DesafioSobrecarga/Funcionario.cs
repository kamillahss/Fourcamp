using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1
{
    internal class Funcionario
    {
        public string Nome { get; set; }

        public int Matricula { get; set; }

        public Profissao Profissao { get; set; }

        public double Salario { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int matricula)
        {

        }

        public Funcionario(int matricula, string nome)
        {

        }

        public Funcionario(int matricula, string nome, Profissao profissao)
        {

        }

        public void ExibirDadosFuncionario()
        {

        }
    }
}
