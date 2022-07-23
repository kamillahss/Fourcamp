using Seguros;

var celular = new SeguroCelular(0);
var residencial = new SeguroResidencial(0);
var automovel = new SeguroAutomovel(0);
int opcao;
bool encerrar = false;

List<Seguro> seguros = new List<Seguro>();

List<TipoSeguro> tipos = new List<TipoSeguro>();


while (encerrar == false)
{
    try
    {
        Console.WriteLine("Escolha o tipo de seguro para avaliação: ");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("1 - Celular \n2 - Residencial \n3 - Automóvel \n4 - Meus Seguros \n5 - Sair");
        opcao = Int32.Parse(Console.ReadLine());
        opcao--;
        tipos.Add((TipoSeguro)opcao);

        if (opcao == (int)TipoSeguro.Celular)
        {
            Console.WriteLine("Insira o modelo do aparelho celular: ");
            celular.Modelo = Console.ReadLine();
            Console.WriteLine("Insira a marca do aparelho celular: ");
            celular.Marca = Console.ReadLine();
            Console.WriteLine("Insira o valor do aparelho celular: ");
            celular.Valor = Double.Parse(Console.ReadLine());
            celular.DataContratacao = DateTime.Now;

            celular.Validar();

            seguros.Add(celular);
        }

        else if (opcao == (int)TipoSeguro.Residencial)
        {
            Console.WriteLine("Insira a cidade da residencia: ");
            residencial.Cidade = Console.ReadLine();
            Console.WriteLine("Insira a área em metros quadrados da residencia: ");
            residencial.Area = Double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor da residencia: ");
            residencial.Valor = Double.Parse(Console.ReadLine());
            residencial.DataContratacao = DateTime.Now;

            residencial.Validar();

            seguros.Add(residencial);
        }
        else if (opcao == (int)TipoSeguro.Automovel)
        {
            Console.WriteLine("Insira a marca do automóvel: ");
            automovel.Marca = Console.ReadLine();
            Console.WriteLine("Insira o modelo do automóvel: ");
            automovel.Modelo = Console.ReadLine();
            Console.WriteLine("Insira o ano do automóvel: ");
            automovel.Ano = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira a quilometragem do automóvel: ");
            automovel.Quilometragem = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Insira o valor do automóvel: ");
            automovel.Valor = Double.Parse(Console.ReadLine());
            automovel.DataContratacao = DateTime.Now;

            automovel.Validar();
            seguros.Add(automovel);
        }

        else if (opcao == 4 - 1)
        {
            foreach (var meusSeguros in seguros)
            {
                meusSeguros.ExibirInformacoes();
            }
        }

        else if (opcao == 5 - 1)
        {
            encerrar = true;
            Console.WriteLine("Programa encerrado!");
        }
        else
        {
            Console.WriteLine("Opção inválida!");
        }
    }
    catch (Exception)
    {

        Console.WriteLine("Foi digitado um caracter não numérico, em um campo exclusivamente numérico. Tente novamente!");
        continue;
    }

}

