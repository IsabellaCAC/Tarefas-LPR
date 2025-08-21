#include <iostream>
#include <vector>
using namespace std;

int main() {
    // Declaração do vetor para armazenar os 10 números
    int vetor[10];
    int numeroPesquisar;
    vector<int> posicoes; // Para armazenar as posições onde o número foi encontrado
    int ocorrencias = 0;
    
    cout << "--- programa de busca em vetor ---" << endl;
    cout << "digite 10 numeros inteiros:" << endl;
    
    // Leitura dos 10 números
    for (int i = 0; i < 10; i++) {
        cout << "numero " << (i + 1) << ": ";
        cin >> vetor[i];
    }
    
    // exibir o vetor digitado
    cout << "\n vetor digitado: ";
    for (int i = 0; i < 10; i++) {
        cout << vetor[i] << " ";
    }
    cout << endl;
    
    // solicitar o numero a ser pesquisado
    cout << "\n digite o numero que voce quer pesquisar no vetor: ";
    cin >> numeroPesquisar;
    
    // buscar o numero no vetor
    for (int i = 0; i < 10; i++) {
        if (vetor[i] == numeroPesquisar) {
            posicoes.push_back(i); // armazena a posicao (indice)
            ocorrencias++;
        }
    }
    
    // exibir os resultados
    if (ocorrencias > 0) {
        cout << "\n numero " << numeroPesquisar << " foi encontrado!" << endl;
        cout << "apareceu " << ocorrencias << " vezes" << endl;
        
        cout << "posicoes: ";
        for (int i = 0; i < posicoes.size(); i++) {
            cout << posicoes[i];
            if (i < posicoes.size() - 1) {
                cout << ", ";
            }
        }
        cout << endl;
        
        cout << "\n obs: as posicoes comecam do 0 (primeira posicao = 0)" << endl;
    } else {
        cout << "\n numero " << numeroPesquisar << " nao foi encontrado no vetor." << endl;
    }
    
    return 0;
}