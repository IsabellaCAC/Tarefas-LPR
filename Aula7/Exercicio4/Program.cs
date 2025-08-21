using System;

class Program
{
    static void Main()
    {
        // valores corretos da imagem para teste
        int[,] matrizA = {
            { -1, 3, 0 },
            {  4, 2, 0 },
            {  0, 0, 1 }  // completando para 3x3
        };
        
        int[,] matrizB = {
            { 1, 2, 0 },
            { 3, 4, 0 },
            { 0, 0, 1 }   // completando para 3x3
        };
        
        int[,] resultado = new int[3, 3];
        
        Console.WriteLine("--- teste multiplicacao A * B ---");
        Console.WriteLine();
        
        // exibir matriz A
        Console.WriteLine("matriz A:");
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write($"{matrizA[i, j],4}");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
        
        // exibir matriz B
        Console.WriteLine("matriz B:");
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write($"{matrizB[i, j],4}");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine();
        
        // calculo da multiplicacao A * B com debug
        Console.WriteLine("calculando A * B:");
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                resultado[i, j] = 0;
                Console.Write($"posicao [{i}][{j}]: ");
                for(int k = 0; k < 3; k++)
                {
                    int produto = matrizA[i, k] * matrizB[k, j];
                    resultado[i, j] += produto;
                    Console.Write($"({matrizA[i, k]} * {matrizB[k, j]} = {produto}) ");
                    if(k < 2) Console.Write("+ ");
                }
                Console.WriteLine($" = {resultado[i, j]}");
            }
        }
        
        Console.WriteLine();
        
        // resultado final
        Console.WriteLine("resultado A * B:");
        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.Write($"{resultado[i, j],4}");
            }
            Console.WriteLine();
        }
        
        // conferindo com resultado esperado da imagem
        Console.WriteLine();
        Console.WriteLine("conferindo com a imagem:");
        Console.WriteLine($"posicao [0][0]: esperado = 8, calculado = {resultado[0, 0]} {(resultado[0, 0] == 8 ? "✓" : "✗")}");
        Console.WriteLine($"posicao [0][1]: esperado = 10, calculado = {resultado[0, 1]} {(resultado[0, 1] == 10 ? "✓" : "✗")}");
        Console.WriteLine($"posicao [1][0]: esperado = 10, calculado = {resultado[1, 0]} {(resultado[1, 0] == 10 ? "✓" : "✗")}");
        Console.WriteLine($"posicao [1][1]: esperado = 16, calculado = {resultado[1, 1]} {(resultado[1, 1] == 16 ? "✓" : "✗")}");
        
        Console.WriteLine();
        Console.WriteLine("pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}