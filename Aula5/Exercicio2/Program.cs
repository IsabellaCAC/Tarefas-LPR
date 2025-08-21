﻿
int num;
int contador = 1;
int numAleatorio;

Console.WriteLine("Tarefa 2");

Random random = new Random();
numAleatorio = random.Next(1, 100);

do
{
    Console.WriteLine("Escreva um numero entre 1 a 100:");
    num = Convert.ToInt32(Console.ReadLine());

    if (num < numAleatorio)
    {
        Console.WriteLine("Chute baixo");
    }

    if (num > numAleatorio)
    {
        Console.WriteLine("chute alto");
    }
    contador++;
}
while (num != numAleatorio);
Console.WriteLine($"voce acertou em {contador} tentativas");