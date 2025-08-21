using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Leitura dos dados da peça 1
        Console.Write("Digite o codigo da peça 1: ");
        int codigo1 = int.Parse(Console.ReadLine()); // Código da peça 1

        Console.Write("Digite o numero de peças 1: ");
        int quantidade1 = int.Parse(Console.ReadLine()); // Quantidade de peças 1

        Console.Write("Digite o valor unitario da peça 1: ");
        double valorUnitario1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Valor unitário da peça 1

        // Leitura dos dados da peça 2
        Console.Write("Digite o codigo da peça 2: ");
        int codigo2 = int.Parse(Console.ReadLine()); // Código da peça 2

        Console.Write("Digite o numero de peças 2: ");
        int quantidade2 = int.Parse(Console.ReadLine()); // Quantidade de peças 2

        Console.Write("Digite o valor unitario da peça 2: ");
        double valorUnitario2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // Valor unitário da peça 2

        // Cálculo do valor total a pagar
        double total = (quantidade1 * valorUnitario1) + (quantidade2 * valorUnitario2); // Soma do valor de cada peça

        // Exibição do resultado com duas casas decimais
        Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture)); // Mostra o total formatado
    }
}
