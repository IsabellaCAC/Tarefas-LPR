#include <iostream>
#include <cstdlib>
#include <ctime>
using namespace std;

int main() {
    // array para os 100 numeros aleatorios
    int numeros[100];
    int listaImpar[100]; // para numeros impares
    int tamanhoImpar = 0;
    
    cout << "--- gerador de numeros aleatorios ---" << endl;
    
    // inicializar gerador de numeros aleatorios
    srand(time(0));
    
    // gerar 100 numeros aleatorios entre 1 e 100
    cout << "gerando 100 numeros aleatorios..." << endl;
    for(int i = 0; i < 100; i++) {
        numeros[i] = rand() % 100 + 1; // numeros de 1 a 100
    }
    
    // exibir lista original (opcional)
    cout << "\nlista original:" << endl;
    for(int i = 0; i < 100; i++) {
        cout << numeros[i] << " ";
        if((i + 1) % 10 == 0) cout << endl; // quebrar linha a cada 10 numeros
    }
    
    // ordenar em ordem crescente usando bubble sort
    cout << "\nordenando em ordem crescente..." << endl;
    for(int i = 0; i < 99; i++) {
        for(int j = 0; j < 99 - i; j++) {
            if(numeros[j] > numeros[j + 1]) {
                // trocar posicoes
                int temp = numeros[j];
                numeros[j] = numeros[j + 1];
                numeros[j + 1] = temp;
            }
        }
    }
    
    // exibir lista ordenada
    cout << "\nlista ordenada:" << endl;
    for(int i = 0; i < 100; i++) {
        cout << numeros[i] << " ";
        if((i + 1) % 10 == 0) cout << endl;
    }
    
    // remover numeros pares e criar lista so com impares
    cout << "\nremovendo numeros pares..." << endl;
    for(int i = 0; i < 100; i++) {
        if(numeros[i] % 2 != 0) { // se for impar
            listaImpar[tamanhoImpar] = numeros[i];
            tamanhoImpar++;
        }
    }
    
    // exibir lista apenas com impares
    cout << "\nlista apenas com numeros impares:" << endl;
    for(int i = 0; i < tamanhoImpar; i++) {
        cout << listaImpar[i] << " ";
        if((i + 1) % 10 == 0) cout << endl;
    }
    cout << endl;
    
    // verificar numeros repetidos na lista original ordenada
    cout << "\nnumeros repetidos na lista original:" << endl;
    bool encontrouRepetidos = false;
    
    for(int i = 0; i < 99; i++) {
        if(numeros[i] == numeros[i + 1]) {
            // contar quantas vezes o numero se repete
            int contador = 1;
            int numeroAtual = numeros[i];
            int j = i;
            
            while(j < 99 && numeros[j] == numeros[j + 1]) {
                contador++;
                j++;
            }
            
            cout << "numero " << numeroAtual << " aparece " << contador << " vezes" << endl;
            encontrouRepetidos = true;
            
            // pular os numeros ja contados
            i = j;
        }
    }
    
    if(!encontrouRepetidos) {
        cout << "nao foram encontrados numeros repetidos." << endl;
    }
    
    cout << "\npressione enter para sair..." << endl;
    cin.get();
    
    return 0;
}