void Ex1()
{
    //TABUADA
    Console.WriteLine("Digite o número que deseja a tabuada: ");
    int contador = Int32.Parse(Console.ReadLine());

    for (int contador1 = 0; contador1 < 11; contador1++)
    {
        Console.WriteLine($"{contador} * {contador1} = " + contador*contador1);
    }
}

void Ex2()
{

    Console.WriteLine("Digite um número: ");
    int num = Int32.Parse(Console.ReadLine());

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(num += 1);
    }
}

void Ex3()
{
    // Pares de 100 a 200
    for (int contador = 100; contador <= 200; contador++)
    {
        if(contador % 2 == 0)
        {
            Console.WriteLine(contador);
        }
        
    }
}

void Ex4()
{

    Console.WriteLine("Digite um número: ");
    int num1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Digite um número: ");
    int num2 = Int32.Parse(Console.ReadLine());

    int impares = 0;

    for (int contador = num1; contador < num2; contador++)
    {
        if (contador % 2 != 0)
        {
            impares++;
        }
    }
    Console.WriteLine("Números impares: " + impares);
}

void Ex5()
{
    Console.WriteLine("Digite o primeiro número: ");
    int num1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo número: ");
    int num2 = Int32.Parse(Console.ReadLine());

    int soma = 0;

    for (int n = num1; n <= num2 - 1; n++)
    {
        soma += num1; 
        Console.WriteLine($"O resultado é: " + soma);
    }
}


void Ex6()
{
    double soma = 0;
    int idade;
    for (int i = 1; i <= 50; i++)
    {
        Console.WriteLine("Informe a idade?");
        idade = int.Parse(Console.ReadLine());
       
        while(idade < 0)
        {
            Console.WriteLine("Idade inválida. Digite novamente: ");
            idade = Int32.Parse(Console.ReadLine());
        }
        soma += idade;
    }
        Console.WriteLine($"A média de idade é {soma / 50}");
}    

void Ex7()
    {
        Random randnum = new Random();
        int numeroAleatorio = randnum.Next(100, 110);
        
        
        Console.WriteLine("Escreva um número entre 100 e 110: ");
        int n1 = Int32.Parse(Console.ReadLine());
        
        int soma = 0;

        while(numeroAleatorio != n1)
        {
            numeroAleatorio = randnum.Next(100, 110);   
            Console.WriteLine($"Número aleatório: {numeroAleatorio}");
            soma += numeroAleatorio;
        }
        Console.WriteLine($"Soma dos números gerados é: {soma}");
    }

void Ex8()
{
    string nomeCidMaiorNumAci = "";
    string nomeCidMenorNumAci = "";
    int numCidMaiorNumAci = 0;
    int numCidMenorNumAci = 0;
    int totalVeiculos = 0;
    int totalCidadesMenor2000 = 0;
    int totalAcidentesMenor2000 = 0;

    for(int i = 0; i < 3; i++)
    {
        Console.WriteLine($"Digite o nome da cidade {i + i}:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite o numero de veiculos de passeio: ");
        int numVeiculos = Int32.Parse(Console.ReadLine());
        totalVeiculos += numVeiculos;

        Console.WriteLine("Digite o numero de acidentes de transito com vitimas:");
        int acidentes = Int32.Parse(Console.ReadLine());

        if(acidentes > numCidMaiorNumAci)
        {
            numCidMaiorNumAci = acidentes;
            nomeCidMaiorNumAci = nome;
        }

        if(acidentes < numCidMenorNumAci || i == 0)
        {
            numCidMenorNumAci = acidentes;
            nomeCidMenorNumAci = nome;
        }

        if(numVeiculos < 2000)
        {
            totalCidadesMenor2000++;
            totalAcidentesMenor2000 += acidentes;
        }
    }

    Console.WriteLine("A cidade que possui o maior número de acidentes de trânsito é: " + nomeCidMaiorNumAci);
    Console.WriteLine("A cidade que possui o menor número de acidentes de trânsito é: " + nomeCidMenorNumAci);
    Console.WriteLine("A média dos veículos das 15 cidades juntas é: " + (totalVeiculos / 3));
    Console.WriteLine("A média de acidentes de trânsito nas cidades com menos de 2000 veículos de passeio é: " + (totalAcidentesMenor2000/totalCidadesMenor2000));
}

void Ex9()
{
    bool sair = false;

    while (sair == false)
    {
        Console.WriteLine("Menu de Opções \nDigite a opção desejada: ");
        Console.WriteLine("1 - Somar dois números.\n2 - Raiz quadrada de um número.\n3 - Sair.");
        int opcao = Int32.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite um número: ");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número: ");
                int num2 = Int32.Parse(Console.ReadLine());

                int soma = num1 + num2;
                Console.WriteLine("O resultado é: " + soma);
                break;
            case 2:
                Console.WriteLine("Digite um número: ");
                int num = Int32.Parse(Console.ReadLine());
                double raiz = Math.Sqrt(Convert.ToDouble(num));
                Console.WriteLine($"A raiz quadrada de {num} é: {raiz}");
                break;
            case 3:
                Console.WriteLine("Saindoo...");
                sair = true;
                break;
            default:
                Console.WriteLine("Opção inválida. Digite novamente!");
                break;
        }
    }
}

Ex9();

