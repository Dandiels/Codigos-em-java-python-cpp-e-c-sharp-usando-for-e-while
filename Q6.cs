using System;

namespace Q6
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            byte número_de_vezes, vezes = 1;
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite a quantidade de vezes que deseja que o seu nome apareça na tela: ");
            número_de_vezes = byte.Parse(Console.ReadLine());
            for (byte contador = 0; contador < número_de_vezes; contador ++, vezes ++)
            {
                Console.WriteLine("{0}ª Vez: {1}.", vezes, nome);
            }
        }
    }
}