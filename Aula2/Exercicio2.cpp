#include <iostream>
#include <string>
using namespace std;

int main()
{
    int a, b;

    cout << "Digite dois numeros inteiros ";
    cin >> a;
    cin >> b;

    if (a % b == 0 || b % a == 0)
    {
        cout << " O numero sao multiplos";
    }
    else
    {
        cout << "O numero nao sao multiplos";
    }
}