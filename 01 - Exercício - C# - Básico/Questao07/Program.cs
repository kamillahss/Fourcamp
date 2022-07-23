// Leia 2 valores de ponto flutuante de dupla precisão “v1” e “v2”, que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno,sabendo que a nota “v1” tem peso 3.5 e a nota “v2” tem peso 7.5 (A soma dos pesos portanto é 11). Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal

double v1, v2, media, peso1 = 3.5, peso2 = 7.5;

v1 = Convert.ToDouble(Console.ReadLine());
v2 = Convert.ToDouble(Console.ReadLine());

media = (v1*peso1 + v2*peso2) / 11;
Console.WriteLine("MÉDIA: " + media);