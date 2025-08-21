Console.WriteLine("Tarefa 2");

string poderes;

Console.WriteLine("Escolha entre os personagens: Guerreira, Mago e Arqueira");
poderes = Console.ReadLine();

switch (poderes)
{

    case "Guerreira":
        Console.WriteLine("Uau, voce tem ataque pesado e defesa total!");
        break;

    case "Mago":
        Console.WriteLine("Uau, voce tem bola de fogo e escudo de gelo. Que medo!!!");
        break;

    case "Arqueira":
        Console.WriteLine("Uau, voce tem flecha precisa e disparo triplo. Esse eh poderoso, se ver saia correndo!!!");
        break;

    default:
        Console.WriteLine("Nao identificado");
        break;
}