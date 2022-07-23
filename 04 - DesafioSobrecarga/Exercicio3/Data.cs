using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio3
{
    internal class Data
    {

        public int Dia { get; set; }

        public int Mes { get; set; }

        public int Ano { get; set; }

        public Data()
        {

        }
        public Data(int dia, int mes, int ano)
        {
            Dia = dia; Mes = mes; Ano = ano;
        }

        public void RetornarData(int dia, int mes, int ano)
        {
            Dia = dia; Mes = mes; Ano = ano;
            Console.WriteLine($"{dia}/{mes}/{ano}");
        }

        public bool ValidarDia()
        {
            if(Dia < 0 || Dia > 31)
                return false;

            return true;
        }

        public bool ValidarMes()
        {
            if (Mes < 1 || Mes > 12)
                return false;

            return true;
        }

        public bool ValidarAno()
        {
            if (Ano < 0)
                return false;


            return true;
        }

        public void NomeMes(int mes)
        {
            Mes = mes;

            if(mes == 1)
            {
                Console.WriteLine("Janeiro");
            }
            else if (mes == 2)
            {
                Console.WriteLine("Fevereiro");
            }
            else if (mes == 3)
            {
                Console.WriteLine("Março");
            }
            else if (mes == 4)
            {
                Console.WriteLine("Abril");
            }
            else if (mes == 5)
            {
                Console.WriteLine("Maio");
            }
            else if (mes == 6)
            {
                Console.WriteLine("Junho");
            }
            else if (mes == 7)
            {
                Console.WriteLine("Julho");
            }
            else if (mes == 8)
            {
                Console.WriteLine("Agosto");
            }
            else if (mes == 9)
            {
                Console.WriteLine("Setembro");
            }
            else if (mes == 10)
            {
                Console.WriteLine("Outubro");
            }
            else if (mes == 11)
            {
                Console.WriteLine("Novembro");
            }
            else if (mes == 12)
            {
                Console.WriteLine("Dezembro");
            }
        }
    }
}
