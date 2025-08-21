#include <iostream>
#include <string>
#include <iomanip>
using namespace std;

// definicao da struct Livro
struct Livro {
    string titulo;
    string autor;
    int anoPublicacao;
    int numeroPaginas;
    double preco;
};

int main() {
    // array para armazenar os 3 livros
    Livro livros[3];
    double precoTotal = 0;
    int totalPaginas = 0;
    
    cout << "--- cadastro de livros ---" << endl;
    cout << "digite os dados de 3 livros:" << endl << endl;
    
    // entrada de dados dos livros
    for(int i = 0; i < 3; i++) {
        cout << "livro " << (i + 1) << ":" << endl;
        
        cout << "titulo: ";
        cin.ignore(); // limpa buffer antes de getline
        getline(cin, livros[i].titulo);
        
        cout << "autor: ";
        getline(cin, livros[i].autor);
        
        cout << "ano de publicacao: ";
        cin >> livros[i].anoPublicacao;
        
        cout << "numero de paginas: ";
        cin >> livros[i].numeroPaginas;
        
        cout << "preco: R$ ";
        cin >> livros[i].preco;
        
        cout << "-------------------" << endl;
    }
    
    cout << endl;
    cout << "--- relatorio dos livros ---" << endl << endl;
    
    // exibir dados dos livros e calcular totais
    for(int i = 0; i < 3; i++) {
        precoTotal += livros[i].preco;
        totalPaginas += livros[i].numeroPaginas;
        
        cout << "livro " << (i + 1) << ":" << endl;
        cout << "  titulo: " << livros[i].titulo << endl;
        cout << "  autor: " << livros[i].autor << endl;
        cout << "  ano: " << livros[i].anoPublicacao << endl;
        cout << "  paginas: " << livros[i].numeroPaginas << endl;
        cout << "  preco: R$ " << fixed << setprecision(2) << livros[i].preco << endl;
        cout << endl;
    }
    
    // calcular media de paginas
    double mediaPaginas = (double)totalPaginas / 3;
    
    // exibir resultados finais
    cout << "==============================" << endl;
    cout << "preco total dos livros: R$ " << fixed << setprecision(2) << precoTotal << endl;
    cout << "media de paginas: " << fixed << setprecision(1) << mediaPaginas << " paginas" << endl;
    cout << "==============================" << endl;
    
    cout << endl;
    cout << "pressione enter para sair..." << endl;
    cin.ignore();
    cin.get();
    
    return 0;
}