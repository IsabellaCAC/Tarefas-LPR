#include <iostream>
#include <map>
#include <string>
#include <vector>
#include <iomanip>
using namespace std;

int main() {
    // map para armazenar nome da cidade e populacao
    map<string, long long> cidades;
    
    cout << "--- dicionario de cidades e populacao ---" << endl;
    cout << "quantas cidades voce quer cadastrar: ";
    int quantidade;
    cin >> quantidade;
    cin.ignore(); // limpar buffer
    
    // cadastrar as cidades
    cout << "\ndigite os dados das cidades:" << endl;
    for(int i = 0; i < quantidade; i++) {
        cout << "nome da cidade " << (i + 1) << ": ";
        string nome;
        getline(cin, nome);
        
        cout << "populacao de " << nome << ": ";
        long long populacao;
        cin >> populacao;
        cin.ignore(); // limpar buffer
        
        cidades[nome] = populacao;
        cout << "-------------------" << endl;
    }
    
    // exibir dicionario completo
    cout << "\ndicionario completo:" << endl;
    for(auto& cidade : cidades) {
        cout << cidade.first << ": " << cidade.second << " habitantes" << endl;
    }
    
    // calcular a populacao media
    long long somaPopulacao = 0;
    for(auto& cidade : cidades) {
        somaPopulacao += cidade.second;
    }
    double populacaoMedia = (double)somaPopulacao / cidades.size();
    
    cout << "\npopulacao media: " << fixed << setprecision(0) << populacaoMedia << " habitantes" << endl;
    
    // encontrar cidades acima da media
    cout << "\ncidades com populacao acima da media:" << endl;
    bool encontrouAcimaMedia = false;
    for(auto& cidade : cidades) {
        if(cidade.second > populacaoMedia) {
            cout << "- " << cidade.first << " (" << cidade.second << " habitantes)" << endl;
            encontrouAcimaMedia = true;
        }
    }
    if(!encontrouAcimaMedia) {
        cout << "nenhuma cidade encontrada acima da media." << endl;
    }
    
    // encontrar cidade mais populosa
    string cidadeMaisPopulosa = "";
    long long maiorPopulacao = -1;
    for(auto& cidade : cidades) {
        if(cidade.second > maiorPopulacao) {
            maiorPopulacao = cidade.second;
            cidadeMaisPopulosa = cidade.first;
        }
    }
    
    // encontrar cidade menos populosa
    string cidadeMenosPopulosa = "";
    long long menorPopulacao = LLONG_MAX;
    for(auto& cidade : cidades) {
        if(cidade.second < menorPopulacao) {
            menorPopulacao = cidade.second;
            cidadeMenosPopulosa = cidade.first;
        }
    }
    
    cout << "\ncidade mais populosa: " << cidadeMaisPopulosa << " (" << maiorPopulacao << " habitantes)" << endl;
    cout << "cidade menos populosa: " << cidadeMenosPopulosa << " (" << menorPopulacao << " habitantes)" << endl;
    
    // remover cidades com populacao especifica
    cout << "\ndigite uma populacao para remover todas as cidades com essa populacao: ";
    long long populacaoRemover;
    cin >> populacaoRemover;
    
    // encontrar cidades para remover
    vector<string> nomesRemover;
    for(auto& cidade : cidades) {
        if(cidade.second == populacaoRemover) {
            nomesRemover.push_back(cidade.first);
        }
    }
    
    // remover as cidades
    int removidos = 0;
    for(string& nome : nomesRemover) {
        cidades.erase(nome);
        removidos++;
    }
    
    cout << "\nforam removidas " << removidos << " cidade(s) com " << populacaoRemover << " habitantes." << endl;
    
    // exibir dicionario atualizado
    cout << "\ndicionario atualizado:" << endl;
    if(cidades.size() > 0) {
        for(auto& cidade : cidades) {
            cout << cidade.first << ": " << cidade.second << " habitantes" << endl;
        }
    }
    else {
        cout << "dicionario vazio - todas as cidades foram removidas." << endl;
    }
    
    cout << "\npressione enter para sair..." << endl;
    cin.ignore();
    cin.get();
    
    return 0;
}