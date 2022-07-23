//Leia quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto de A e B pelo produto de C e D segundo a fórmula:DIFERENCA = (A * B - C * D).

int a, b, c, d, diferenca;

a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
d = Convert.ToInt32(Console.ReadLine());

diferenca = (a * b - c * d);
Console.WriteLine("DIFERENÇA: " + diferenca);



