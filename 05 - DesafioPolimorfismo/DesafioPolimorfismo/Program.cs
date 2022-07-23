

using DesafioPolimorfismo;

Console.WriteLine("Cadastrar cliente: ");

Cliente cliente = new Cliente("", "");

Console.WriteLine("Insira o título: ");
cliente.Titulo = Console.ReadLine();
Console.WriteLine("Insira o nome: ");
cliente.Nome = Console.ReadLine();

cliente.ExibirNomeFormatado();
