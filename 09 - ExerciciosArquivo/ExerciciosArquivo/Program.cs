

void Exercicio01()
{
   
    using(var escritor = new StreamWriter("../../../Exercicio01.txt"))
    {
        for(int i = 65; i <= 90; i++)
        {
            escritor.WriteLine(Convert.ToChar(i));
        }
    }
}

void Exercicio02()
{
    

    using (var escritor = new StreamWriter("../../../Exercicio02.txt"))
    {
        Random random = new Random();

        Console.WriteLine("Digite a quantidade de linhas: ");
        int quantLinhas = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Digite a quantidade de colunas: ");
        int quantColunas = Int32.Parse(Console.ReadLine());


        for(int i = 0; i < quantLinhas; i++)
        {
            string linha = "";

            for(int j= 0; j < quantColunas; j++)
            {
                linha += $"{random.Next(1000)}\t\t";
            }

            escritor.WriteLine(linha);
        }

    }
    
}

void Exercicio03()
{
    using(var leitor = new StreamReader("../../../Exercicio03.txt"))
    {
        float maiorValor = 0;
        int linhaMaiorValor = 0;

        string[] linhas = leitor.ReadToEnd().Split("\n");

        for(int i = 0; i < linhas.Length; i++)
        {
            float num = float.Parse(linhas[i]);

            if(num > maiorValor)
            {
                maiorValor = num;
                linhaMaiorValor = i + 1;
            }
        }

        Console.WriteLine($"A linha de maior valor é a: linha {linhaMaiorValor}");
    }
}

void Exercicio04()
{
    string[] linhas;

    using (var leitor = new StreamReader("../../../Exercicio04.txt"))
    {
        linhas = leitor.ReadToEnd().Split("\n");
    }

    using(var escritor = new StreamWriter("../../../Exercicio04Resultado.txt"))
    {
        for(int i = 0; i < linhas.Length; i++)
        {
            string[] strNumeros = linhas[i].Split(",");
            int n1 = int.Parse(strNumeros[0]);
            int n2 = int.Parse(strNumeros[1]);

            escritor.WriteLine($"{n1}, {n2}, {n1 + n2}");
        }
    }
}

void Exercicio05()
{
    using(var leitor = new StreamReader("../../../Exercicio05.txt"))
    {
        string[] linhas = leitor.ReadToEnd().Split("\n");

        int soma = 0;

        for(int i = 1; i < linhas.Length; i++)
        {
            string[] linhaSeparada = linhas[i].Split(",");

            soma += Int32.Parse(linhaSeparada[1]);
        }

        Console.WriteLine($"O resultado da soma do segundo campo é: {soma}");
    }
}

Exercicio05();