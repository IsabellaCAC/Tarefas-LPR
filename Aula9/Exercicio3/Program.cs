using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // dicionario para armazenar nome e idade
        Dictionary<string, int> pessoas = new Dictionary<string, int>();
        
        Console.WriteLine("--- dicionario de pessoas e idades ---");
        Console.Write("quantas pessoas voce quer cadastrar: ");
        int quantidade = int.Parse(Console.ReadLine());
        
        // cadastrar as pessoas
        Console.WriteLine("\ndigite os dados das pessoas:");
        for(int i = 0; i < quantidade; i++)
        {
            Console.Write($"nome da pessoa {i + 1}: ");
            string nome = Console.ReadLine();
            
            Console.Write($"idade de {nome}: ");
            int idade = int.Parse(Console.ReadLine());
            
            pessoas[nome] = idade;
            Console.WriteLine("-------------------");
        }
        
        // exibir dicionario completo
        Console.WriteLine("\ndicionario completo:");
        foreach(var pessoa in pessoas)
        {
            Console.WriteLine($"{pessoa.Key}: {pessoa.Value} anos");
        }
        
        // calcular a idade media
        double somaIdades = 0;
        foreach(var pessoa in pessoas)
        {
            somaIdades += pessoa.Value;
        }
        double idadeMedia = somaIdades / pessoas.Count;
        
        Console.WriteLine($"\nidade media: {idadeMedia:F1} anos");
        
        // encontrar pessoas acima da media
        Console.WriteLine("\npessoas com idade acima da media:");
        bool encontrouAcimaMedia = false;
        foreach(var pessoa in pessoas)
        {
            if(pessoa.Value > idadeMedia)
            {
                Console.WriteLine($"- {pessoa.Key} ({pessoa.Value} anos)");
                encontrouAcimaMedia = true;
            }
        }
        if(!encontrouAcimaMedia)
        {
            Console.WriteLine("nenhuma pessoa encontrada acima da media.");
        }
        
        // encontrar pessoa mais velha
        string pessoaMaisVelha = "";
        int maiorIdade = -1;
        foreach(var pessoa in pessoas)
        {
            if(pessoa.Value > maiorIdade)
            {
                maiorIdade = pessoa.Value;
                pessoaMaisVelha = pessoa.Key;
            }
        }
        
        // encontrar pessoa mais nova
        string pessoaMaisNova = "";
        int menorIdade = int.MaxValue;
        foreach(var pessoa in pessoas)
        {
            if(pessoa.Value < menorIdade)
            {
                menorIdade = pessoa.Value;
                pessoaMaisNova = pessoa.Key;
            }
        }
        
        Console.WriteLine($"\npessoa mais velha: {pessoaMaisVelha} ({maiorIdade} anos)");
        Console.WriteLine($"pessoa mais nova: {pessoaMaisNova} ({menorIdade} anos)");
        
        // remover pessoas com idade especifica
        Console.WriteLine();
        Console.Write("digite uma idade para remover todas as pessoas com essa idade: ");
        int idadeRemover = int.Parse(Console.ReadLine());
        
        // criar lista de nomes para remover (nao pode modificar durante iteracao)
        List<string> nomesRemover = new List<string>();
        foreach(var pessoa in pessoas)
        {
            if(pessoa.Value == idadeRemover)
            {
                nomesRemover.Add(pessoa.Key);
            }
        }
        
        // remover as pessoas
        int removidos = 0;
        foreach(string nome in nomesRemover)
        {
            pessoas.Remove(nome);
            removidos++;
        }
        
        Console.WriteLine($"\nforam removidas {removidos} pessoa(s) com {idadeRemover} anos.");
        
        // exibir dicionario atualizado
        Console.WriteLine("\ndicionario atualizado:");
        if(pessoas.Count > 0)
        {
            foreach(var pessoa in pessoas)
            {
                Console.WriteLine($"{pessoa.Key}: {pessoa.Value} anos");
            }
        }
        else
        {
            Console.WriteLine("dicionario vazio - todas as pessoas foram removidas.");
        }
        
        Console.WriteLine("\npressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}