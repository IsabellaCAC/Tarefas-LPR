using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- organizador de nomes por tamanho ---");
        Console.Write("quantos nomes voce quer digitar: ");
        int quantidade = int.Parse(Console.ReadLine());
        
        // array para armazenar os nomes
        string[] nomes = new string[quantidade];
        
        Console.WriteLine("digite os nomes:");
        for (int i = 0; i < quantidade; i++)
        {
            nomes[i] = Console.ReadLine();
        }
        
        Console.WriteLine("\nsaida:");
        
        // encontrar o menor tamanho para comecar
        int menorTamanho = int.MaxValue;
        for (int i = 0; i < quantidade; i++)
        {
            if (nomes[i].Length < menorTamanho)
            {
                menorTamanho = nomes[i].Length;
            }
        }
        
        // array para marcar nomes ja usados
        bool[] usado = new bool[quantidade];
        
        // processar linha por linha
        while (true)
        {
            string linha = "";
            bool encontrouNome = false;
            
            // para cada tamanho possivel (do menor ao maior)
            for (int tamanho = menorTamanho; tamanho <= 20; tamanho++) // assumindo max 20 chars
            {
                // procurar o primeiro nome nao usado com esse tamanho
                for (int i = 0; i < quantidade; i++)
                {
                    if (!usado[i] && nomes[i].Length == tamanho)
                    {
                        if (linha != "")
                            linha += ", ";
                        linha += nomes[i];
                        usado[i] = true;
                        encontrouNome = true;
                        break; // so pega um nome de cada tamanho por linha
                    }
                }
            }
            
            if (!encontrouNome)
                break;
                
            Console.WriteLine(linha);
        }
        
        Console.WriteLine("\npressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}