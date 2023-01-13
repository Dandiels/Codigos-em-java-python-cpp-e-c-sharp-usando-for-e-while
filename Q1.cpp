#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    int numero, ordem;
    cout << "Digite um número maior do que 0: ";
    cin >> numero;
    if (numero > 0)
    {
        cout << "Digite 1 para ordem crescente ou 2 para ordem decrescente: ";
        cin >> ordem;
        if (ordem == 1)
        {
            numero --;
            cout << "A ordem crescente do zero até este número é ";
            for (int listagem = 0; listagem < numero; listagem ++)
            {
                printf("%d, ", listagem);
            }
            printf("%d e %d.\n", numero, numero + 1);
        }
        else if (ordem == 2)
        {
            cout << "A ordem decrescente deste número até zero é ";
            for (int listagem = numero; listagem > 1; listagem --)
            {
                printf("%d, ", listagem);
            }
            cout << "1 e 0." << endl;
        }
        else
        {
            cout << "Você deve digitar um dos valores pedidos." << endl;
        }
    }
    else
    {
        cout << "Você deve digitar um número maior do que 0." << endl;
    }
    return 0;
}