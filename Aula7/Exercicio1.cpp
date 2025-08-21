#include <iostream>
#include <vector>

using namespace std;

int main (){
     
    cout <<  "---------------------------------------" << endl;
    cout <<  "------ Bem-vindo ao exercicio 1 -------" << endl;
    cout <<  "---------------------------------------" << endl;

    int numeros [10];
    
    cout << "Digite 10 numeros inteiros!"<< endl; 

    for (int i =0 ; i<10; i++) {
        cout << "Numero "<< i +1 << ": ";
        cin >> numeros[i];
    }

     vector<int> pares;
     vector <int> impar;

     for (int i = 0; i<10; i++) {
        if (numeros [i]%2 ==0){
        pares.push_back(numeros[i]);
    } 
     else {
        impar.push_back(numeros[i]);
    }
}

    cout << "\nOs numeros pares sao: "<< endl;
    for (int num : pares){
        cout << num << " ";
    }
    
    cout << "\n Os numeros impar sao: "<< endl;
    for (int num : impar){
        cout << num << " ";
    }

     cout <<  "\n---------------------------------------" << endl;
    cout <<   "--------- Fim do exercicio 1 ----------" << endl;
    cout <<   "---------------------------------------" << endl;

    cout << endl;
    return 0;

}