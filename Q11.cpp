#include <iostream>
#include <stdio.h>

using namespace std;

int main()
{
    string nome[10];
    int idade[10], vezes = 1, i = 0, n = 0;
    for (i; i < sizeof nome / sizeof nome[0]; i ++, vezes ++)
    {
        printf("Digite o nome da %dª pessoa: ", vezes);
        cin.ignore();
        getline(cin, nome[i]);
        cout << "Digite a idade dela: ";
        cin >> idade[i];
    }
    i = 0;
    while (i <= sizeof idade / sizeof idade[0] - 1)
    {
        if (idade[i] <= idade[n])
        {
            if (n == sizeof idade / sizeof idade[0] - 1)
            {
                break;
            }
            else
            {
                n ++;
            }
        }
        else
        {
            n = 0;
            i ++;
        }
    }
    cout << "Dentre essas pessoas, a pessoa mais nova é " << nome[i] << "." << endl;
    return 0;
}