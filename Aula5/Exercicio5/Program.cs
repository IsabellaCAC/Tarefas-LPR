Console.WriteLine("Execicio 5!");

double horasDia;
double horaSemana;
double horaMes;


Console.WriteLine("Digite quantas horas de treinamento por dia: ");

horasDia = Convert.ToInt32(Console.ReadLine());
horaSemana = horasDia * 5;
horaMes = horaSemana * 4.5;

Console.WriteLine($"o treinamento teve {horaSemana} horas semanais");

int mes = (int)(1000 / horaMes);
int mesResto = (int)(1000 % horaMes);

int semanas = (int)(mesResto / horaSemana);
int semanaResto = (int)(mesResto % horaSemana);

double dias = semanaResto / horasDia;

Console.WriteLine($"Faltam {dias} dias, {semanas} semanas e {mes} meses para alcancar 1000 horas de treinamento!!!");