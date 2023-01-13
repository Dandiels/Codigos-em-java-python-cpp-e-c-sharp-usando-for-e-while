using System;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            short número;
            sbyte ordem;
            Console.Write("Digite um número maior do que 0: ");
            número = short.Parse(Console.ReadLine());
            if (número > 0)
            {
                Console.Write("Digite 1 para ordem crescente ou 2 para ordem decrescente: ");
                ordem = sbyte.Parse(Console.ReadLine());
                if (ordem == 1)
                {
                    número --;
                    Console.Write("A ordem crescente do zero até este número é ");
                    for (int listagem = 0; listagem < número; listagem ++)
                    {
                        Console.Write("{0}, ", listagem);
                    }
                    Console.WriteLine("{0} e {1}.", número, número + 1);
                }
                else if (ordem == 2)
                {
                    Console.Write("A ordem decrescente deste número até zero é ");
                    for (int listagem = número; listagem > 1; listagem --)
                    {
                        Console.Write("{0}, ", listagem);
                    }
                    Console.WriteLine("1 e 0.");
                }
                else
                {
                    Console.WriteLine("Você deve digitar um dos valores pedidos.");
                }
            }
            else
            {
                Console.WriteLine("Você deve digitar um número maior do que 0.");
            }
        }
    }
}