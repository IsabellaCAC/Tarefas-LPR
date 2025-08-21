using System;

Console.WriteLine("Tarefa 1");

int num;

Console.WriteLine("Digite um numero inteiro: ");
num=Convert.ToInt32(Console.ReadLine());

if(num%2==0){
  Console.WriteLine("O numero eh par: " +num);
} 
else {
   Console.WriteLine("O numero eh impar: " +num);
}