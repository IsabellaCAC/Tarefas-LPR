using System;

class Program
{
    static string nome1 = "";
    static string nome2 = "";
    static string nome3 = "";
    static string nome4 = "";
    static string nome5 = "";
    
    static string poder1 = "";
    static int pontuacao1 = 0;
    static string poder2 = "";
    static int pontuacao2 = 0;
    static string poder3 = "";
    static int pontuacao3 = 0;
    static string poder4 = "";
    static int pontuacao4 = 0;
    static string poder5 = "";
    static int pontuacao5 = 0;
    
    static int quantiHeroisCadastrados = 0;
    
    static string equipeNome1 = "";
    static string equipePoder1 = "";
    static int equipePontuacao1 = 0;

    static string equipeNome2 = "";
    static string equipePoder2 = "";
    static int equipePontuacao2 = 0;

    static string equipeNome3 = "";
    static string equipePoder3 = "";
    static int equipePontuacao3 = 0;
    
    void Main()
    {
        MenuPrincipal();
    }
    
    void MenuPrincipal()
    {
        while (true)
        {
            Console.WriteLine("------- MENU MARVEL ------=");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
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
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
     
     void CadastrarHeroi (){
          
        if (quantiHeroisCadastrados >= 5)
        {
            Console.WriteLine("Limite de cadrastos atingidos!");
            return;
        }
     
     Console.Write("Nome do heroi(heroina): ");
        string nome = Console.ReadLine();

        Console.Write("Poder do heroi(heroina): ");
        string poder = Console.ReadLine();

        Console.Write("Pontuacao do heroi(heroina): ");
        int pontuacao = int.Parse(Console.ReadLine());

        quantiHeroisCadastrados++;
        
         switch (quantiHeroisCadastrados)
        {
            case 1:
                nome1 = nome; poder1 = poder; pontuacao1 = pontuacao;
                break;
            case 2:
                nome2 = nome; poder2 = poder; pontuacao2 = pontuacao;
                break;
            case 3:
                nome3 = nome; poder3 = poder; pontuacao3 = pontuacao;
                break;
            case 4:
                nome4 = nome; poder4 = poder; pontuacao4 = pontuacao;
                break;
            case 5:
                nome5 = nome; poder5 = poder; pontuacao5 = pontuacao;
                break;
        }
        
        Console.WriteLine("Cadastro feito com sucesso 0ª0");
    }
    static void SelecionarEquipe()
    {
        if (quantiHeroisCadastrados < 3)
        {
            Console.WriteLine("Eh necessario no minimo 3 herois ou heroinas cadastrados");
            return;
        }
        Console.WriteLine("-------- Heróis Cadastrados -----------");
        if (nome1 != "") Console.WriteLine("1 - " + nome1 + " (" + poder1 + ")");
        if (nome2 != "") Console.WriteLine("2 - " + nome2 + " (" + poder2 + ")");
        if (nome3 != "") Console.WriteLine("3 - " + nome3 + " (" + poder3 + ")");
        if (nome4 != "") Console.WriteLine("4 - " + nome4 + " (" + poder4 + ")");
        if (nome5 != "") Console.WriteLine("5 - " + nome5 + " (" + poder5 + ")");

        Console.WriteLine("Selecione 3 herois ou heroinas pelo número:");

        equipeNome1 = selecionarHeroi(out equipePoder1, out equipePontuacao1);
        equipeNome2 = selecionarHeroi(out equipePoder2, out equipePontuacao2);
        equipeNome3 = selecionarHeroi(out equipePoder3, out equipePontuacao3);
    }
    static string selecionarHeroi(string poder, int pontuacao)
    {
        while (true)
        {
            Console.Write("umero do heroi ou heroina: ");
            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    poder = poder1; pontuacao = pontuacao1; return nome1;
                case "2":
                    poder = poder2; pontuacao = pontuacao2; return nome2;
                case "3":
                    poder = poder3; pontuacao = pontuacao3; return nome3;
                case "4":
                    if (nome4 != "")
                    {
                        poder = poder4; pontuacao = pontuacao4; return nome4;
                    }
                    break;
                case "5":
                    if (nome5 != "")
                    {
                        poder = poder5; pontuacao = pontuacao5; return nome5;
                    }
                    break;
            }
            Console.WriteLine("Escolha nula. Que tal tentar novamente?.");
        }
    }

    static void exibirEquipe()
    {
        if (equipeNome1 == "" || equipeNome2 == "" || equipeNome3 == "")
        {
            Console.WriteLine("Equipe nao montada ainda....");
            return;
        }

        Console.WriteLine("\n===== EQUIPE MARVEL =====");
        Console.WriteLine("1 - " + equipeNome1 + " | Poder: " + equipePoder1 + " | Pontuação: " + equipePontuacao1);
        Console.WriteLine("2 - " + equipeNome2 + " | Poder: " + equipePoder2 + " | Pontuação: " + equipePontuacao2);
        Console.WriteLine("3 - " + equipeNome3 + " | Poder: " + equipePoder3 + " | Pontuação: " + equipePontuacao3);

        int total = calcularPontuacaoTotal();
        Console.WriteLine("Pontuacao total da equipe: " + total);
    }

    static int calcularPontuacaoTotal()
    {
        return equipePontuacao1 + equipePontuacao2 + equipePontuacao3;
    }
}
          