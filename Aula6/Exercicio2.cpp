#include <iostream>
using namespace std;

void exercicio1() {
	int quanti;
	int par;
	double media =0;
	int num;
	int num_pares = 0;

	cout << "Digite a quantidade de numero que voce quer digitar: "<< endl;

	cin >> quanti;

	while (quanti!=0)
	{
		cout << "Digite um numero:" <<endl;
		cin>> par;
		if (par%2==0)
		{
			media+= par;
			num_pares++;
		}
		quanti--;
	}
	double vai =  media/num_pares;
	cout << "a media eh: "<< vai <<endl;


}
void exercicio3() {

	int soma;

	for (int i = 50; i <= 500; i++)
	{
		if (i % 3 == 0 && i % 2 == 1)
		{
			soma += i;
		}
	}
	cout << "a soma dos numero eh: " << soma << endl;
}


void exercicio4() {

	int horasPorDia;
	int totalHoras = 0;
	int dias = 0;

	cout << "Insira o numero de horas de treinamento por dia: ";
	cin >> horasPorDia;


	while (totalHoras < 1000) {
		totalHoras += horasPorDia;
		dias++;
	}


	int semanas = dias / 5; 
	int meses = semanas / 4.5;

	cout << "Total de horas de treinamento: " << totalHoras << endl;
	cout << "Dias necessarios: " << dias << endl;
	cout << "Semanas necessarias: " << semanas << endl;
	cout << "Meses necessarios: " << meses << endl;

}
int main() {
    int opcao;

    do {
        cout << "---------- MENU DE EXERCÍCIOS -------";
        cout << "1 - Exercício 1: Média dos números pares";
        cout << "2 - Exercício 3: Soma dos ímpares múltiplos de 3 (50 a 500)";
        cout << "3 - Exercício 4: Soma dos dígitos do quadrado de um número";
        cout << "0 - Sair";
        cout << "Escolha uma opção: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                exercicio1();
                break;
            case 2:
                exercicio3();
                break;
            case 3:
                exercicio4();
                break;
            case 0:
                cout << "Saindo do programa. Bye, bye!";
                break;
            default:
                cout << "Nao reconheco essa opcao... Tente novamente.\n";
        }

    } while (opcao != 0);

    return 0;
}