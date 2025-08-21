#include <iostream>
using namespace std;
int main()
{
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
