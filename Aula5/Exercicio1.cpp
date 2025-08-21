#include <iostream>
using namespace std;
int main() {

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