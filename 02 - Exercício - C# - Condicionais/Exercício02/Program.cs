
void Ex1()
{
    // Faça um programa em C# que receba dois números inteiros e mostre na tela o maior número digitado
    int num1 = Int32.Parse(Console.ReadLine());
    int num2 = Int32.Parse(Console.ReadLine());

    if (num1 > num2)
    {
        Console.WriteLine(num1 + " é maior!");
    }
    else
    {
        Console.WriteLine(num2 + " é maior!");
    }
}

void Ex2()
{
    /*Escreva um programa em C# que receba 3 números reais e mostre-os na tela em ordem decrescente. 
      Considere que o usuário digitará 3 números diferentes.*/
    double num1 = Double.Parse(Console.ReadLine());
    double num2 = Double.Parse(Console.ReadLine());
    double num3 = Double.Parse(Console.ReadLine());


    if (num1 >= num2 && num1 >= num3 && num2 >= num3)
    {
        Console.WriteLine($"A ordem decrescente é: {num1}, {num2} e {num3}");
    }
    else if (num1 >= num2 && num1 >= num3 && num3 >= num2)
    {
        Console.WriteLine($"A ordem decrescente é: {num1}, {num3} e {num2}");
    }
    else if (num2 >= num1 && num2 >= num3 && num1 >= num3)
    {
        Console.WriteLine($"A ordem decrescente é: {num2}, {num1} e {num3}");
    }
    else if (num2 >= num1 && num2 >= num3 && num3 >= num1)
    {
        Console.WriteLine($"A ordem decrescente é: {num2}, {num3} e {num1}");
    }
    else if (num3 >= num1 && num3 >= num2 && num1 >= num2)
    {
        Console.WriteLine($"A ordem decrescente é: {num3}, {num1} e {num2}");
    }
    else if (num3 >= num1 && num3 >= num2 && num2 >= num1)
    {
        Console.WriteLine($"A ordem decrescente é: {num3}, {num2} e {num1}");
    }
}

void Ex3()
{
    /*Faça um programa em C# que receba do usuário três números inteiros e mostre-os na tela em ordem crescente. 
      Caso o usuário digite três números iguais, mostrar na tela a informação: OS TRÊS NÚMEROS DIGITADOS SÃO IGUAIS.*/

    int num1 = Int32.Parse(Console.ReadLine());
    int num2 = Int32.Parse(Console.ReadLine());
    int num3 = Int32.Parse(Console.ReadLine());

    if (num1 == num2 && num2 == num3)
    {
        Console.WriteLine("OS TRÊS NÚMEROS DIGITADOS SÃO IGUAIS!");
    }
    else if (num1 <= num2 && num1 <= num3 && num2 <= num3)
    {
        Console.WriteLine($"A ordem crescente é: {num1}, {num2} e {num3}");
    }
    else if (num1 <= num2 && num1 <= num3 && num3 <= num2)
    {
        Console.WriteLine($"A ordem crescente é: {num1}, {num3} e {num2}");
    }
    else if (num2 <= num1 && num2 <= num3 && num1 <= num3)
    {
        Console.WriteLine($"A ordem crescente é: {num2}, {num1} e {num3}");
    }
    else if (num2 <= num1 && num2 <= num3 && num3 <= num1)
    {
        Console.WriteLine($"A ordem crescente é: {num2}, {num3} e {num1}");
    }
    else if (num3 <= num1 && num3 <= num2 && num1 <= num2)
    {
        Console.WriteLine($"A ordem crescente é: {num3}, {num1} e {num2}");
    }
    else if (num3 <= num1 && num3 <= num2 && num2 <= num1)
    {
        Console.WriteLine($"A ordem crescente é: {num3}, {num2} e {num1}");
    }

}

void Ex4()
{
    int num1 = Int32.Parse(Console.ReadLine());
    int num2 = Int32.Parse(Console.ReadLine());
    int num3 = Int32.Parse(Console.ReadLine());

    if (num1 <= num2 && num1 <= num3 && num2 <= num3)
    {
        Console.WriteLine("Os números foram digitados em ordem crescente.");
    }
    else
    {
        Console.WriteLine("Os números não foram digitados em ordem crescente.");
    }
}

void Ex5()
{
    //Faça um programa em C# que solicite ao usuário um número inteiro e retorne se é par ou ímpar.

    int num = Int32.Parse(Console.ReadLine());

    if (num % 2 == 0)
    {
        Console.WriteLine("Esse número é par!");
    }
    else
    {
        Console.WriteLine("Esse número é ímpar!");
    }

}

void Ex6()
{
    //Faça um programa em C# que solicite ao usuário um número inteiro e retorne se é múltiplo de 5 e de 10 ao mesmo tempo.

    int num = Int32.Parse(Console.ReadLine());

    if (num % 10 == 0)
    {
        Console.WriteLine("Esse número não é multiplo de 5 e de 10.");
    }
    else
    {
        Console.WriteLine("Esse número não é multiplo de 5 e de 10.");
    }

}

void Ex7()
{
    /*Verifique se a soma dos números digitados é maior que 10 e mostre na tela:Se a soma for maior que 10, mostrar na tela: Número maior que 10.
     * Se a soma for menor ou igual a 10, mostrar na tela: Número menor ou igual a 10.*/

    double valor1 = Int32.Parse(Console.ReadLine());
    double valor2 = Int32.Parse(Console.ReadLine());
    double soma;

    soma = valor1 + valor2;

    if (soma > 10)
    {
        Console.WriteLine("Número maior que 10.");
    }
    else if (soma <= 10)
    {
        Console.WriteLine("Número menor ou igual a 10.");
    }
}

void Ex8()
{
    //A prefeitura de Recife criou um programa de empréstimo para seus funcionários com desconto em folha. O valor da prestação não pode ultrapassar 30% do salário bruto do funcionário.
    //Faça um programa em C# que solicite o valor do salário bruto, o valor da prestação e informe se o empréstimo pode ou não ser concedido

    double salarioBruto, valorPrest, porcento;

    Console.WriteLine("Digite o valor do salário bruto: ");
    salarioBruto = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor da prestação: ");
    valorPrest = Int32.Parse(Console.ReadLine());
    porcento = salarioBruto * 0.30;

    if (valorPrest == 0 || salarioBruto == 0)
    {
        Console.WriteLine("O valor do salário e do valor da prestação precisa ser maior que O!");
    }
    else
    {
        if (valorPrest >= porcento)
        {
            Console.WriteLine("Empréstimo pode ser concedido!");
        }
        else
        {
            Console.WriteLine("Empréstimo não pode ser concedido!");
        }
    }
}

void Ex9()
{
    /*Uma companhia aérea define os preços de suas passagens a partir da informação do destino bem como do número de passagens (se é apenas ida ou se inclui também a volta). 
     * Faça um programa em C# que solicite o destino bem como se o cliente deseja somente ida ou ida e volta. 
     * Informe o preço de acordo com a tabela abaixo (PS: a empresa não trabalha nos trechos sul e sudeste).*/
    Console.WriteLine("Informe o seu destino: ");
    string destino = Console.ReadLine();
    Console.WriteLine("Digite 0 se a passagem é só de IDA ou 1 para IDA e VOLTA: ");
    int idaVolta = Int32.Parse(Console.ReadLine());

    switch (destino)
    {
        case "norte":
            if (idaVolta == 0)
            {
                Console.WriteLine("Viagem de ida para região norte, custa R$ 280,00");
            }
            else if (idaVolta == 1)
            {
                Console.WriteLine("Viagem de ida e volta para região norte, custa R$ 400,00");
            }
            break;
        case "nordeste":
            if (idaVolta == 0)
            {
                Console.WriteLine("Viagem de ida para região norte, custa R$ 380,00");
            }
            else if (idaVolta == 1)
            {
                Console.WriteLine("Viagem de ida e volta para região norte, custa R$ 628,00");
            }
            break;
        case "centro-oeste":
            if (idaVolta == 0)
            {
                Console.WriteLine("Viagem de ida para região norte, custa R$ 620,00");
            }
            else if (idaVolta == 1)
            {
                Console.WriteLine("Viagem de ida e volta para região norte, custa R$ 1.100,00");
            }
            break;
    }

}

void Ex10()
{
    /*Uma instituição bancária utiliza um dígito verificador para validar o número da conta(com 3 dígitos) de seus clientes.
     * Faça um programa em C# que solicite o número da conta e calcule o dígito verificador. */

    Console.WriteLine("Insira o número da conta: ");
    string numConta = Console.ReadLine();

    string numInvertido = new string(numConta.Reverse().ToArray());
    string soma = (Int32.Parse(numConta) + Int32.Parse(numInvertido)).ToString();

    string resultado = soma.ToString();
    char digitoV = resultado[resultado.Length - 1];
    Console.WriteLine("O digito verificador é: " + digitoV);




}

void Ex11()
{

    int numero_1, numero_2, resultado;

    Console.WriteLine("Digite um número inteiro: ");
    numero_1 = Int32.Parse(Console.ReadLine());
    Console.WriteLine("Digite um número inteiro: ");
    numero_2 = Int32.Parse(Console.ReadLine());

    resultado = ((numero_1 % 2) * 3) + (13 - 2 * numero_2);

    if (resultado <= 0)
    {
        Console.WriteLine("Resultado menor ou igual a zero!");
    }
    else if (resultado > 0 && resultado <= 20)
    {
        Console.WriteLine("Resultado maior que zero e menor que vinte!");
    }
    else
    {
        Console.WriteLine("Resultado maior que vinte!");
    }
    Console.WriteLine("Resposta da letra A: " + resultado);

}

/*void Ex12()
        {
            Console.WriteLine("Menu de Opções /n Digite a opção desejada: ");
        }*/
Ex11();