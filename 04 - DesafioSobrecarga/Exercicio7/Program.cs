
using Exercicio7;

Lampada lampada = new Lampada();

Console.WriteLine("Cor da lampada: " + lampada.Cor);
Console.WriteLine("Está ligada?" + lampada.Ligada);

Lampada lampada2 = new Lampada("Branca");

Console.WriteLine("Cor da lampada: " + lampada2.Cor);
Console.WriteLine("Está ligada?" + lampada2.Ligada);

Lampada lampada1 = new Lampada("Amarela", false);

Console.WriteLine("Cor da lampada 1: " + lampada1.Cor);
Console.WriteLine("Está ligada?" + lampada1.Ligada);




