#include <iostream>

using namespace std;

int main()
{
    string nome;
    int numero_de_vezes, vezes = 1;
    cout << "Digite o seu nome: ";
    getline(cin, nome);
    cout << "Digite a quantidade de vezes que deseja que o seu nome apareça na tela: ";
    cin >> numero_de_vezes;
    for (int contador = 0; contador < numero_de_vezes; contador ++, vezes ++)
    {
        cout << vezes << "ª Vez: " << nome << "." << endl;
    }
    return 0;
}