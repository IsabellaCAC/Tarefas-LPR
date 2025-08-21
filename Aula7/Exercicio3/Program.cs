using System;

class Program
{
    static void Main()
    {
        // matriz com as distancias entre as cidades
        int[,] distancias = {
            {  0, 524, 521, 882 },  // vitoria
            {524,   0, 434, 586 },  // belo horizonte  
            {521, 434,   0, 429 },  // rio de janeiro
            {882, 586, 429,   0 }   // sao paulo
        };
        
        // nomes das cidades
        string[] cidades = {"vitoria", "belo horizonte", "rio de janeiro", "sao paulo"};
        
        int opcao1, opcao2;
        
        Console.WriteLine("--- consulta de distancias entre cidades ---");
        Console.WriteLine("para sair, escolha a mesma cidade como origem e destino");
        Console.WriteLine();
        
        // loop principal do programa
        do
        {
            // mostra o menu das cidades
            Console.WriteLine("cidades disponiveis:");
            for(int i = 0; i < cidades.Length; i++)
            {
                Console.WriteLine($"{i + 1} - {cidades[i]}");
            }
            
            Console.WriteLine();
            
            // escolha da primeira cidade
            Console.Write("escolha a cidade de origem (1-4): ");
            opcao1 = int.Parse(Console.ReadLine()) - 1;
            
            // escolha da segunda cidade  
            Console.Write("escolha a cidade de destino (1-4): ");
            opcao2 = int.Parse(Console.ReadLine()) - 1;
            
            // verifica se as opcoes sao validas
            if(opcao1 >= 0 && opcao1 < 4 && opcao2 >= 0 && opcao2 < 4)
            {
                if(opcao1 == opcao2)
                {
                    Console.WriteLine("\nvocê escolheu a mesma cidade! encerrando programa...");
                    break;
                }
                else
                {
                    int distancia = distancias[opcao1, opcao2];
                    Console.WriteLine($"\ndistancia entre {cidades[opcao1]} e {cidades[opcao2]}: {distancia} km");
                    Console.WriteLine("--------------------");
                }
            }
            else
            {
                Console.WriteLine("\nopcao invalida! escolha numeros de 1 a 4.");
                Console.WriteLine("--------------------");
            }
            
        } while(opcao1 != opcao2 || opcao1 < 0 || opcao1 >= 4 || opcao2 < 0 || opcao2 >= 4);
        
        Console.WriteLine("\nobrigado por usar o programa!");
        Console.WriteLine("pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}