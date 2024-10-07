// ScreenSound
string mensagemDeBoasVindas = "Bem vindo(a) ao Screen Sound\n";
List<string> listaDasBandas = new List<string> { "Silvinho Blaublau", "Manoel Gomes", "Calypso" };

void ExibirMensagemDeBoasVindas()
{
    Console.Clear();
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine("\n" + mensagemDeBoasVindas);
}

void Titulo(string titulo)
{
    string asteriscos = string.Empty.PadRight(titulo.Length, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}

void MenuPrincipal()
{
    ExibirMensagemDeBoasVindas();
    Titulo("Menu Principal");
    Console.WriteLine("1. Registrar uma banda");
    Console.WriteLine("2. Listar bandas");
    Console.WriteLine("3. Avaliar banda");
    Console.WriteLine("4. Exibir média da banda");
    Console.WriteLine("-1. Sair\n");

    Console.Write("Escolha uma opção: ");
    string escolha = Console.ReadLine()!;
    int escolhaNumerica = int.Parse(escolha);
    switch (escolhaNumerica)
    {
        case 1:
            AdicionarUmaBanda();
            break;
        case 2:
            ExibirTodasAsBandas();
            break;
        case 3:
            Console.WriteLine($"Você escolheu {escolhaNumerica}");
            break;
        case 4:
            Console.WriteLine($"Você escolheu {escolhaNumerica}");
            break;
        case -1:
            Console.WriteLine($"Você escolheu {escolhaNumerica}");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void AdicionarUmaBanda()
{
    ExibirMensagemDeBoasVindas();
    Titulo("Registrar Banda");
    Console.Write("Banda que deseja registrar: ");
    string banda = Console.ReadLine()!;
    listaDasBandas.Add(banda);
    Console.WriteLine($"Banda {banda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    MenuPrincipal();
}

void ExibirTodasAsBandas()
{
    ExibirMensagemDeBoasVindas();
    Titulo("Bandas Registradas");
    foreach (string banda in listaDasBandas)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine();
    Console.Write("Aperte qualquer tecla para voltar ao Menu Principal: ");
    Console.ReadKey();
    MenuPrincipal();
}



MenuPrincipal();
