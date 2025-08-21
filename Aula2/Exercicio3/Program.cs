using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Leitura dos dados
        Console.Write("Digite o numero do funcionario: ");
        int numeroFuncionario = int.Parse(Console.ReadLine());

        Console.Write("Digite o numero de horas trabalhadas: ");
        double horasTrabalhadas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        Console.Write("Digite o valor recebido por hora: ");
        double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        // Calculo do salario
        double salario = horasTrabalhadas * valorPorHora;

        // Saida formatada
        Console.WriteLine("Funcionario: " + numeroFuncionario);
        Console.WriteLine("Salario: R$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
    }
}
