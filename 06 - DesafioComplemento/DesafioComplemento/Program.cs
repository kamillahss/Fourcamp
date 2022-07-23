using DesafioComplemento;

Quadrado quadrado = new Quadrado(0);
Triangulo triangulo = new Triangulo(0,0);
Circulo circulo = new Circulo(0);

Console.WriteLine("Informe qual forma deseja calcular a área: ");
string area = Console.ReadLine();

switch (area)
{
    case "quadrado":
        Console.WriteLine("Digite a medida do lado: ");
        quadrado.Lado = Double.Parse(Console.ReadLine());

        Console.WriteLine($"A área do quadrado é: {quadrado.CalcularArea()}");
        break;
    case "triângulo":
        Console.WriteLine("Digite a base do triângulo: ");
        triangulo.Base = Double.Parse(Console.ReadLine());
        Console.WriteLine("Digite a altura do triângulo: ");
        triangulo.Altura = Double.Parse(Console.ReadLine());

        Console.WriteLine($"A área do triângulo é: {triangulo.CalcularArea()}");
        break;
    case "circulo":
        Console.WriteLine("Digite o raio do círculo: ");
        circulo.Raio = Double.Parse(Console.ReadLine());

        Console.WriteLine($"A área do círculo é: {circulo.CalcularArea().ToString("F")}");
        break;
}
