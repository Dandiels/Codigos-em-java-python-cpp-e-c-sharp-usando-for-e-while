#include <iostream>

using namespace std;

int main()
{
    float numero, soma = 0;
    int i = 0;
    cout << "Digite uma sequência de números:" << endl;
    while (i >= 0)
    {
        cin >> numero;
        soma = soma + numero;
        if (numero < 0)
        {
            break;
        }
    }
    cout << "A soma dos números que você digitou, até o número negativo, é " << soma << "." << endl;
    return 0;
}