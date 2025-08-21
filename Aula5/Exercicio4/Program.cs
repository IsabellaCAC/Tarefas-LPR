int num;
int soma;
int quadrado;

Console.WriteLine("Exercicio 4");

Console.WriteLine("Digite um numero: ");
num = Convert.ToInt32(Console.ReadLine());

quadrado = num * num;
soma = 0;

while (quadrado > 0)
{
    int digito = quadrado % 10;
    soma += digito;
    quadrado /= 10;
}

Console.WriteLine("A soma dos algarismos eh: " +soma);