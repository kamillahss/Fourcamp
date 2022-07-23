// Leia 3 valores, no caso, variáveis “v1”, “v2” e “v3”, que são as três notas de um aluno.A seguir, calcule a média do aluno, sabendo que a nota “v1” tem peso 2, a nota “v2” tem peso 3 e a nota “v3” tem peso 5. Considere que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.

double v1, v2, v3, peso1 = 2.0, peso2 = 3.0, peso3 = 5.0, media;

v1 = Convert.ToDouble(Console.ReadLine());
v2 = Convert.ToDouble(Console.ReadLine());
v3 = Convert.ToDouble(Console.ReadLine());

media = (v1 * peso1 + v2 * peso2 + v3 * peso3) / 10;
Console.WriteLine("MÉDIA: " + media);