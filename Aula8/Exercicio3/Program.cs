using System;

// struct para armazenar informacoes do heroi
struct Heroi
{
    public string nome;
    public string poder;
    public int pontuacao;
}

class Program
{
    // usando struct array para os herois
    static Heroi heroi1;
    static Heroi heroi2;
    static Heroi heroi3;
    static Heroi heroi4;
    static Heroi heroi5;
    
    static int quantiHeroisCadastrados = 0;
    
    // struct para a equipe
    static Heroi equipeHeroi1;
    static Heroi equipeHeroi2;
    static Heroi equipeHeroi3;
    
    static void Main()
    {
        MenuPrincipal();
    }
    
    static void MenuPrincipal()
    {
        while (true)
        {
            Console.WriteLine("------- MENU MARVEL -------");
            Console.WriteLine("1 - Cadastrar Heroi");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opcao: ");
            string opcao = Console.ReadLine();
            
            switch (opcao)
            {
                case "1":
                    CadastrarHeroi();
                    break;
                case "2":
                    SelecionarEquipe();
                    break;
                case "3":
                    ExibirEquipe();
                    break;
                case "4":
                    Console.WriteLine("Saindo...");
                    return;
                default:
                    Console.WriteLine("Opcao invalida!");
                    break;
            }
        }
    }
     
    static void CadastrarHeroi()
    {
        if (quantiHeroisCadastrados >= 5)
        {
            Console.WriteLine("Limite de cadastros atingidos!");
            return;
        }
     
        Console.Write("Nome do heroi(heroina): ");
        string nome = Console.ReadLine();

        Console.Write("Poder do heroi(heroina): ");
        string poder = Console.ReadLine();

        Console.Write("Pontuacao do heroi(heroina): ");
        int pontuacao = int.Parse(Console.ReadLine());

        quantiHeroisCadastrados++;
        
        // criar struct temporario
        Heroi novoHeroi;
        novoHeroi.nome = nome;
        novoHeroi.poder = poder;
        novoHeroi.pontuacao = pontuacao;
        
        switch (quantiHeroisCadastrados)
        {
            case 1:
                heroi1 = novoHeroi;
                break;
            case 2:
                heroi2 = novoHeroi;
                break;
            case 3:
                heroi3 = novoHeroi;
                break;
            case 4:
                heroi4 = novoHeroi;
                break;
            case 5:
                heroi5 = novoHeroi;
                break;
        }
        
        Console.WriteLine("Cadastro feito com sucesso!");
    }
    
    static void SelecionarEquipe()
    {
        if (quantiHeroisCadastrados < 3)
        {
            Console.WriteLine("Eh necessario no minimo 3 herois ou heroinas cadastrados");
            return;
        }
        
        Console.WriteLine("-------- Herois Cadastrados -----------");
        if (heroi1.nome != "") Console.WriteLine("1 - " + heroi1.nome + " (" + heroi1.poder + ")");
        if (heroi2.nome != "") Console.WriteLine("2 - " + heroi2.nome + " (" + heroi2.poder + ")");
        if (heroi3.nome != "") Console.WriteLine("3 - " + heroi3.nome + " (" + heroi3.poder + ")");
        if (heroi4.nome != "") Console.WriteLine("4 - " + heroi4.nome + " (" + heroi4.poder + ")");
        if (heroi5.nome != "") Console.WriteLine("5 - " + heroi5.nome + " (" + heroi5.poder + ")");

        Console.WriteLine("Selecione 3 herois ou heroinas pelo numero:");

        equipeHeroi1 = selecionarHeroi();
        equipeHeroi2 = selecionarHeroi();
        equipeHeroi3 = selecionarHeroi();
    }
    
    static Heroi selecionarHeroi()
    {
        Heroi heroiVazio;
        heroiVazio.nome = "";
        heroiVazio.poder = "";
        heroiVazio.pontuacao = 0;
        
        while (true)
        {
            Console.Write("numero do heroi ou heroina: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    if (heroi1.nome != "") return heroi1;
                    break;
                case "2":
                    if (heroi2.nome != "") return heroi2;
                    break;
                case "3":
                    if (heroi3.nome != "") return heroi3;
                    break;
                case "4":
                    if (heroi4.nome != "") return heroi4;
                    break;
                case "5":
                    if (heroi5.nome != "") return heroi5;
                    break;
            }
            Console.WriteLine("Escolha nula. Que tal tentar novamente?");
        }
    }

    static void ExibirEquipe()
    {
        if (equipeHeroi1.nome == "" || equipeHeroi2.nome == "" || equipeHeroi3.nome == "")
        {
            Console.WriteLine("Equipe nao montada ainda....");
            return;
        }

        Console.WriteLine("\n===== EQUIPE MARVEL =====");
        Console.WriteLine("1 - " + equipeHeroi1.nome + " | Poder: " + equipeHeroi1.poder + " | Pontuacao: " + equipeHeroi1.pontuacao);
        Console.WriteLine("2 - " + equipeHeroi2.nome + " | Poder: " + equipeHeroi2.poder + " | Pontuacao: " + equipeHeroi2.pontuacao);
        Console.WriteLine("3 - " + equipeHeroi3.nome + " | Poder: " + equipeHeroi3.poder + " | Pontuacao: " + equipeHeroi3.pontuacao);

        int total = CalcularPontuacaoTotal();
        Console.WriteLine("Pontuacao total da equipe: " + total);
    }

    static int CalcularPontuacaoTotal()
    {
        return equipeHeroi1.pontuacao + equipeHeroi2.pontuacao + equipeHeroi3.pontuacao;
    }
}