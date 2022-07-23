//Projeto Mouse

using ProjetoMouse;

string Input(string msg)
{
    Console.WriteLine(msg);
    return Console.ReadLine();
}

double GetPercentual(double quant, double total)
{
    return (quant / total) * 100;
}

void ItemRelatorio(string titulo, List<int> listMouse)
{
    Console.WriteLine(titulo);
    if (listMouse.Count > 0)
    {
        string strMouses = "";
        foreach (int mouseId in listMouse)
        {
            strMouses += $"{mouseId},";
        }
        Console.WriteLine(strMouses);
    }
    else
    {
        Console.WriteLine("Nenhum!");
    }
    Console.WriteLine($"Total: {listMouse.Count}");
}

List<Mouse> mouses = new List<Mouse>();

bool encerrar = false;

Console.WriteLine("Identificador do mouse igual a 0 encerra o programa");

while (encerrar == false)
{
    try
    {
        int id = Int32.Parse(Input("Digite o indentificador do mouse: "));

        if (id != 0)
        {
            Mouse mouse = null;
            foreach (Mouse m in mouses)
            {
                if(m.Id == id)
                {
                    mouse = m;
                }
            }

            if(mouse != null)
            {
                throw new Exception("O mouse com este identificador já está cadastrado.");
            }

            List<Defeito> defeitos = new List<Defeito>();

            int quantDefeitos = Int32.Parse(Input("Quantos defeitos tem o mouse?"));

            if(quantDefeitos != 0)
            {
                for(int i = 0; i < quantDefeitos; i++)
                {
                    Console.WriteLine($"Defeito {i + 1}");

                    int defeito = Int32.Parse(Input("Qual o defeito?\n1 - Necessita de esfera \n2 - Necessita de limpeza \n3 - Necessita troca do capo ou conector \n4 - Quebrado ou inutilizado \n"));
                   
                    defeitos.Add((Defeito)(defeito--));
                }
            }

            mouse = new Mouse(id, defeitos);
            mouse.Id = id;
            mouse.Defeitos = defeitos;


            mouses.Add(mouse);
        }
        else
        {
            List<int> semDefeito = new List<int>();
            List<int> esfera = new List<int>();
            List<int> limpeza = new List<int>();
            List<int> troca = new List<int>();
            List<int> quebrados = new List<int>();

            List<int> umDefeito = new List<int>();

            foreach (Mouse mouse in mouses)
            {
                if(mouse.Defeitos.Count > 0)
                {
                    if (mouse.Defeitos.Count == 1)
                    {
                        umDefeito.Add(mouse.Id);
                    }

                    foreach (Defeito defeito in mouse.Defeitos)
                    {
                        switch (defeito)
                        {
                            case Defeito.NecessitaEsfera:
                                esfera.Add(mouse.Id);
                                break;
                            case Defeito.NecessitaLimpeza:
                                limpeza.Add(mouse.Id);
                                break;
                            case Defeito.NecessitaTrocaDoCaboOuConector:
                                troca.Add(mouse.Id);
                                break;
                            default:
                                quebrados.Add(mouse.Id);
                                break;
                        }
                    }
                }
                else
                    semDefeito.Add(mouse.Id);
            }

            ItemRelatorio("----Identificação dos mouses sem defeito ----", semDefeito);
            ItemRelatorio("----Identificação dos mouses que necessitam de esfera ----", esfera);
            ItemRelatorio("----Identificação dos mouses que necessitam de limpeza ----", limpeza);
            ItemRelatorio("----Identificação dos mouses que necessitam de troca de cabo ou conector ----", troca);
            ItemRelatorio("----Identificação dos mouses que estão quebrados ou inutilizados ----", quebrados);

            Console.WriteLine("Relatório - Resumo");
            Console.WriteLine($"Quantidade de mouses cadastrados: {mouses.Count}");
            Console.WriteLine($"% de mouses sem defeito: {GetPercentual(semDefeito.Count, mouses.Count)}%");
            Console.WriteLine($"% de mouses com um defeito: {GetPercentual(umDefeito.Count, mouses.Count)}%");

            encerrar = true;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}
