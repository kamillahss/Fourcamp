
using Exercicio4;

Empregado empregado = new Empregado("João", "Analista de Sistemas", 5400);

empregado.AumentarSalario(600);

Console.WriteLine(empregado.Nome);
Console.WriteLine(empregado.Funcao);
Console.WriteLine(empregado.Salario.ToString("C"));
