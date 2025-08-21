#include <iostream>
#include <string>

using namespace std;

int inverteNumero(int num){
    int reverso = 0;

    while (num != 0){
        int digito = num % 10;
        reverso = reverso * 10 + digito;
        num /= 10;
    }
}