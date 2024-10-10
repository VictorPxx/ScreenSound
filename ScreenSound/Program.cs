// ScreenSound
using System.Xml;

string mensagemDeBoasVindas = "Bem vindo(a) ao Screen Sound\n";
Dictionary <string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("King of pisadinha", new List<int> { 9, 6, 6, 8, 7, 5});
bandasRegistradas.Add("Rosa Floyd", new List<int> ());
//List<string> listaDasBandas = new List<string> { "Silvinho Blaublau", "Manoel Gomes", "Calypso" };

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
            AvaliandoBandas();
            break;
        case 4:
            ExibirMediaDaBanda();
            break;
        case -1:
            Console.WriteLine($"Tchau :)");
            break;
        default:
            Console.WriteLine("Opção inválida");
            break;
    }
}

void AdicionarUmaBanda()
{
    Console.Clear();
    Titulo("Registrar Banda");
    Console.Write("Banda que deseja registrar: ");
    string banda = Console.ReadLine()!;
    bandasRegistradas.Add(banda, new List<int>());
    Console.WriteLine($"Banda {banda} foi registrada com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    MenuPrincipal();
}

void ExibirTodasAsBandas()
{
    Console.Clear();
    Titulo("Bandas Registradas");
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }
    Console.WriteLine();
    Console.Write("Aperte qualquer tecla para voltar ao Menu Principal: ");
    Console.ReadKey();
    MenuPrincipal();
}
void AvaliandoBandas()
{
    //Pedir o nome da banda a ser avaliada
    //Saber se a banda está na lista
    //Pedir a nota do usuário
    //
    Console.Clear();
    Titulo("Avaliação de banda");
    Console.WriteLine("Qual banda você deseja avaliar:");
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.WriteLine($"\nQual nota a banda {nomeDaBanda} merece: ");
        int notaDaBanda = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDaBanda].Add(notaDaBanda);
        Console.Write($"\nVocê avaliou a banda {nomeDaBanda}. Obrigado!");
        Thread.Sleep(4500);
        MenuPrincipal();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não está registrada nos nosso Bancos de Dados");
        Console.WriteLine("Veja as bandas registradas");
        Thread.Sleep(4000);
        ExibirTodasAsBandas();
    }
}

void ExibirMediaDaBanda()
{
    Console.Clear();
    Titulo("Exibir média da banda");
    Console.Write("Bande que deseja ver a Média: ");
    string nomeDaBanda = Console.ReadLine()!;
    Console.WriteLine();
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"\nMédia da banda {nomeDaBanda}: {notasDaBanda.Average():F1}");
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não está registrada nos nosso Bancos de Dados");
        Console.WriteLine("Veja as bandas registradas");
        Thread.Sleep(4000);
        ExibirTodasAsBandas();
    }
}

MenuPrincipal();