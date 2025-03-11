Dictionary<string, List<int>> estoques = new Dictionary<string, List<int>>();
estoques.Add("Tenis", new List<int> { 750});
estoques.Add("Camisa", new List<int> { 500});
estoques.Add("Calca", new List<int> { 325});

void ExibirOpcoes()
{
    Console.Clear();
    Console.WriteLine(@"
███████╗░██████╗████████╗░█████╗░░██████╗░██╗░░░██╗███████╗░██████╗
██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗██║░░░██║██╔════╝██╔════╝
█████╗░░╚█████╗░░░░██║░░░██║░░██║██║██╗██║██║░░░██║█████╗░░╚█████╗░
██╔══╝░░░╚═══██╗░░░██║░░░██║░░██║╚██████╔╝██║░░░██║██╔══╝░░░╚═══██╗
███████╗██████╔╝░░░██║░░░╚█████╔╝░╚═██╔═╝░╚██████╔╝███████╗██████╔╝
╚══════╝╚═════╝░░░░╚═╝░░░░╚════╝░░░░╚═╝░░░░╚═════╝░╚══════╝╚═════╝░");

    Console.WriteLine("\nDigite as opçês do que você quer referente ao estoque");
    Console.WriteLine("Se quiser ver o estoque de tênis digite 1");
    Console.WriteLine("Se quiser ver o estoque de camisas digite 2");
    Console.WriteLine("Se quiser ver o estoque de calças digite 3");
    Console.WriteLine("Se quiser sair digite 4");

    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumero = int.Parse(opcaoEscolhida);
    switch(opcaoEscolhidaNumero)
    {
        case 1: EstoqueTenis(); break;
        case 2: EstoqueCamisa(); break;
        case 3: EstoqueCalca(); break;
        case 4:
            Console.Clear();
            Console.WriteLine("Fechando o site de estoque"); 
            break;
    }
}
void EstoqueTenis()
{
    Console.Clear();
    Console.WriteLine("Exibindo o estoque de tênis\n");

    if (estoques.ContainsKey("Tenis"))
    {
        foreach (var quantidade in estoques["Tenis"])
        {
            Console.WriteLine($"tênis: {quantidade}");
        }
        Console.Write("Clique em uma tecla para voltar ao menu ");
        Console.ReadKey();
        ExibirOpcoes();
    }
    else
    {
        Console.WriteLine("Não há estoque");
    }

}

void EstoqueCamisa()
{
    Console.Clear();
    Console.WriteLine("Exibindo estoque de Camisas\n");

    if (estoques.ContainsKey("Camisa"))
    {
        foreach (var quantidade in estoques["Camisa"])
        {
            Console.WriteLine($"Camisas: {quantidade}");
        }
        Console.Write("Clique em uma tecla para voltar ao menu ");
        Console.ReadKey();
        ExibirOpcoes();

    } else
    {
        Console.WriteLine("Não há estoque de camisas");
    }
}

void EstoqueCalca()
{
    Console.Clear();   
    Console.WriteLine("Exibindo estoque de camisas\n");

    if (estoques.ContainsKey("Calca"))
    {
        foreach (var quantidade in estoques["Calca"])
        {
            Console.Write($"calças: {quantidade}\n");
        }

        Console.Write("Clique em uma tecla para voltar ao menu ");
        Console.ReadKey();
        ExibirOpcoes();
    
    } else
    {
        Console.WriteLine("Não há estoque");
    }
}

ExibirOpcoes();