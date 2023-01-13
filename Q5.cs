using System;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            byte vezes = 1;
            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            for (byte contador = 0; contador < 10; contador ++, vezes ++)
            {
                Console.WriteLine("{0}ª Vez: {1}.", vezes, nome);
            }
        }
    }
}