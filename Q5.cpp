#include <iostream>

using namespace std;

int main()
{
    string nome;
    int vezes = 1;
    cout << "Digite o seu nome: ";
    getline(cin, nome);
    for (int contador = 0; contador < 10; contador ++, vezes ++)
    {
        cout << vezes << "ª Vez: " << nome << "." << endl;
    }
    return 0;
}